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

namespace EM.WindowsForms
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //EnumeradorSexo sexo = new EnumeradorSexo();
            comboGenero.Items.Add(EnumeradorSexo.Masculino);
            comboGenero.Items.Add(EnumeradorSexo.Feminino);
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

        private void botaoLimpar_Click(object sender, EventArgs e)
        {

        }

        private void botaoPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {

        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
