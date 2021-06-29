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
        private Aluno objeto;

        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboGenero.Items.Add("Masculino");
            comboGenero.Items.Add("Feminino");
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
            new RepositorioAluno().Add(objeto);
        }
    }
}
