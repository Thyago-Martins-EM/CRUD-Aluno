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
            if (edicao)
            {
                Aluno aluno = new Aluno()
                {
                    Matricula = Convert.ToInt32(textoMatricula.Text),
                    Nome = textoNome.Text,
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
                    Nome = textoNome.Text,
                    Sexo = (EnumeradorSexo)comboGenero.SelectedIndex,
                    Nascimento = Convert.ToDateTime(maskedTextBox1.Text),
                    CPF = textoCPF.Text,
                };
                new RepositorioAluno().Add(aluno);                
            }
            LimparDados();
            CarregaDadosGridView();
            edicao = false;
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void botaoPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            edicao = true;
            AlteraBotoesCampos(edicao);
            PreencheFormulario(this.aluno);
        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            this.aluno = new RepositorioAluno().GetByMatricula(setMatricula);
            RemoverAluno form = new RemoverAluno(this.aluno);
            form.ShowDialog();
            CarregaDadosGridView();
        }

        public void CarregaDadosGridView()
        {
            IEnumerable<Aluno> enumerable = new RepositorioAluno().GetAll();

            alunoBindingSource.DataSource = enumerable;
            gridViewAluno.DataSource = alunoBindingSource;
        }

        private void GridViewAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setMatricula = Convert.ToInt32(gridViewAluno.Rows[e.RowIndex].Cells[0].Value);
            this.aluno = new RepositorioAluno().GetByMatricula(setMatricula);
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

        private bool ValidaDadosAluno(Aluno aluno)
        {
            return false;
        }

        private void validaCPF(string cpf)
        {

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
