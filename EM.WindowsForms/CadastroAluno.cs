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
        BindingSource bs = new BindingSource();
        Conexao conexao = new Conexao();
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //EnumeradorSexo sexo = new EnumeradorSexo();
            comboGenero.Items.Add(EnumeradorSexo.Masculino);
            comboGenero.Items.Add(EnumeradorSexo.Feminino);

            

            using (FbConnection conexaFB = conexao.GetConexao())
            {
                try
                {
                    conexaFB.Open();
                    string fSQL = $"SELECT * FROM ALUNO;";
                    FbCommand cmd = new FbCommand(fSQL, conexaFB);
                    FbDataAdapter fbData = new FbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    fbData.Fill(dt);
                    /*IEnumerable<Aluno> alunos;
                    foreach(DataRow dataRow in dt.Rows)
                    {
                        alunos = dt.AsEnumerable();
                    }*/
                    //return dt; //alunos;
                    bs.DataSource = dt;
                    bs.DataMember = dt.TableName;
                    gridViewAluno.DataSource = bs;
                }
                catch (FbException fbErr)
                {
                    throw fbErr;
                }
                finally
                {
                    conexaFB.Close();
                }
            }
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
