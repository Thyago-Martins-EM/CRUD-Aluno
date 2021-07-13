using System;
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

            if (edicao && ValidaCampos())
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

                LimparDados();
                CarregaDadosGridView();
                AlteraBotoesCampos(edicao = false);
            }

            else if(!edicao && ValidaCampos())
            {                    
                Aluno aluno = new Aluno()
                {
                    Matricula = Convert.ToInt32(textoMatricula.Text),
                    Nome = textoNome.Text.Replace("'", "''"),
                    Sexo = (EnumeradorSexo)comboGenero.SelectedIndex,
                    Nascimento = Convert.ToDateTime(maskedTextBox1.Text),
                    CPF = textoCPF.Text,
                };

                new RepositorioAluno().Add(aluno);

                LimparDados();
                CarregaDadosGridView();
                AlteraBotoesCampos(edicao = false);
            }            
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            AlteraBotoesCampos(edicao = false);
            LimparDados();
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

        private bool ValidaCampos()
        {

            bool matricula = Int32.TryParse(textoMatricula.Text, out int matriculaAluno);
            bool nascimento = DateTime.TryParse(maskedTextBox1.Text, out DateTime data);

            //Valida Campo Matricula
            if (!matricula || matriculaAluno == 0)
            {
                MessageBox.Show("O campo Matricula não pode está em branco ou ser 0");
                textoMatricula.Focus();
                return false;
            }
            //Verifica se Matricula ja existe
            else if (new RepositorioAluno().GetByMatricula(matriculaAluno) != null)
            {
                MessageBox.Show("Já existe um aluno registrado com essa matricula!");
                textoMatricula.Focus();
                return false;
            }
            //Valida Campo Nome
            else if (textoNome.Text == "" || textoNome.Text.Length < 3)
            {
                MessageBox.Show("O campo Nome não pode está em branco e deve ter mais de 3 letras");
                textoNome.Focus();
                return false;
            }
            //Valida Campo Sexo
            else if (comboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Com sexo não selecionado, informe um genero!");
                comboGenero.Focus();
                return false;
            }
            //Valida Campo Nascimento
            else if (!nascimento && data < DateTime.Now)
            {
                MessageBox.Show("Data invalida");
                maskedTextBox1.Focus();
                return false;
            }
            //Valida Campo CPF
            else if (!DomainUtilitarios.ValidaCPF(textoCPF.Text))
            {
                MessageBox.Show("Informe um CPF valido!");                
                textoCPF.Focus();
                return false;
            }            

            return true;
        }
    }
}
