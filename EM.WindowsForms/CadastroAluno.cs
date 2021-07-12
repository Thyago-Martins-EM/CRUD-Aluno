﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EM.Domain;
using EM.Repository;
using FirebirdSql.Data.FirebirdClient;

namespace EM.WindowsForms
{
    public partial class CadastroAluno : Form
    {

        private bool edicao = false;
        private int setMatricula = 0;
        private Aluno aluno = new Aluno();

        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            comboGenero.Items.Add(EnumeradorSexo.Masculino);
            comboGenero.Items.Add(EnumeradorSexo.Feminino);
            CarregaDadosGridView();
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
        }

        private void textoSoComNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (edicao)
                {
                    Aluno aluno = new Aluno()
                    {
                        Matricula = Convert.ToInt32(textoMatricula.Text),
                        Nome = textoNome.Text.Replace("'", "''"),
                        Sexo = (EnumeradorSexo)comboGenero.SelectedIndex,
                        Nascimento = Convert.ToDateTime(maskedTextBox1.Text),
                        CPF = textoCPF.Text,
                    };
                    new RepositorioAluno().Update(aluno);
                }

                if (!edicao)
                {
                    Aluno aluno = new Aluno()
                    {
                        Matricula = Convert.ToInt32(textoMatricula.Text),
                        Nome = textoNome.Text.Replace("'", "''"),
                        Sexo = (EnumeradorSexo)comboGenero.SelectedIndex,
                        Nascimento = Convert.ToDateTime(maskedTextBox1.Text),
                        CPF = textoCPF.Text,
                    };
                    if(new RepositorioAluno().GetByMatricula(aluno.Matricula) == null)
                    {
                        new RepositorioAluno().Add(aluno);
                        MessageBox.Show(aluno.GetHashCode().ToString());
                    }
                    else
                    {
                        MessageBox.Show("Matricula já cadastrada no sistema. \nInforme uma matricula diferente.");
                    }
                    
                }

                LimparDados();
                CarregaDadosGridView();
                AlteraBotoesCampos(edicao = false);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            AlteraBotoesCampos(edicao = false);
            LimparDados();
            throw new System.InvalidOperationException("Deu Pau...");
        }

        private void botaoPesquisa_Click(object sender, EventArgs e)
        {

            bool sucesso = Int32.TryParse(textoPesquisa.Text, out setMatricula);

            if (sucesso)
            {
                alunoBindingSource.DataSource = new RepositorioAluno().GetByMatricula(setMatricula);
                gridViewAluno.DataSource = alunoBindingSource;
                setMatricula = 0;
            }
            else
            {
                alunoBindingSource.DataSource = new RepositorioAluno().GetByContendoNoNome(textoPesquisa.Text);
                gridViewAluno.DataSource = alunoBindingSource;
            }

            
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {

            if(setMatricula != 0)
            {
                edicao = true;
                AlteraBotoesCampos(edicao);
                PreencheFormulario(this.aluno);
            }
            else
            {
                MessageBox.Show("Clique em algum registro para que possa editalo!");
            }
            
        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            if(setMatricula != 0)
            {
                this.aluno = new RepositorioAluno().GetByMatricula(setMatricula);
                RemoverAluno form = new RemoverAluno(this.aluno);
                form.ShowDialog();
                LimparDados();
                CarregaDadosGridView();
                setMatricula = 0;
                if (edicao)
                {
                    edicao = false;
                    AlteraBotoesCampos(edicao);
                }
            }
            else
            {
                MessageBox.Show("Clique em algum registro para que possa excluílo!");
            }
        }

        public void CarregaDadosGridView()
        {
            IEnumerable<Aluno> enumerable = new RepositorioAluno().GetAll();

            alunoBindingSource.DataSource = enumerable;
            gridViewAluno.DataSource = alunoBindingSource;
        }

        private void GridViewAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
            
            }
            else
            {
                setMatricula = Convert.ToInt32(gridViewAluno.Rows[e.RowIndex].Cells[0].Value);
                aluno = new RepositorioAluno().GetByMatricula(setMatricula);
            }
        }

        private void LimparDados()
        {
            foreach (Control myControl in groupBox1.Controls)
            {
                if (myControl as TextBox == null)
                { }
                else
                {
                    ((TextBox)myControl).Text = "";
                }
            }
            comboGenero.SelectedIndex = -1;
            maskedTextBox1.Text = "";
            textoMatricula.Focus();            
        }

        private void AlteraBotoesCampos(bool edicao)
        {
            if (edicao)
            {
                label1.Text = "Editando Aluno";
                botaoAdicionar.Text = "Modificar";
                botaoLimpar.Text = "Cancelar";
                textoMatricula.Enabled = false;
                textoNome.Focus();
            }
            else 
            {
                label1.Text = "Novo Aluno";
                botaoAdicionar.Text = "Adicionar";
                botaoLimpar.Text = "Limpar";
                textoMatricula.Enabled = true;
                textoNome.Focus();
                setMatricula = 0;
            }
        }

        private void PreencheFormulario(Aluno aluno)
        {
            textoMatricula.Text = Convert.ToString(aluno.Matricula);
            textoNome.Text = aluno.Nome;
            comboGenero.SelectedIndex = Convert.ToInt32(aluno.Sexo);
            maskedTextBox1.Text = Convert.ToString(aluno.Nascimento);
            textoCPF.Text = aluno.CPF;
        }
    
    }
}
