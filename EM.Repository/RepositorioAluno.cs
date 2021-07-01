using System;
using System.Collections.Generic;
using System.Linq;
using EM.Domain;
using FirebirdSql.Data.FirebirdClient;
namespace EM.Repository
{
    public class RepositorioAluno : RepositorioAbstrato<Aluno>
    {

        private Conexao conexao = new Conexao();
        public override void Add(Aluno aluno)
        {
            int sexo = aluno.Sexo == EnumeradorSexo.Masculino ? 0 : 1;
            string dtNascimento = aluno.Nascimento.ToString("yyyy/MM/dd");

            using (FbConnection conexaFB = conexao.GetConexao())
            {
                try
                {
                    conexaFB.Open();
                    string fSQL = $"INSERT INTO ALUNO VALUES ({aluno.Matricula}, '{aluno.Nome}', {sexo}, '{aluno.CPF}', '{dtNascimento}');";
                    FbCommand cmd = new FbCommand(fSQL, conexaFB);
                    cmd.ExecuteNonQuery();
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

        public override void Update(Aluno objeto)
        {
            base.Update(objeto);
        }

        public override void Remove(Aluno objeto)
        {
            base.Remove(objeto);
        }

        public override IEnumerable<Aluno> GetAll()
        {

            using (FbConnection conexaFB = conexao.GetConexao())
            {
                try
                {
                    conexaFB.Open();
                    string fSQL = $"SELECT * FROM ALUNO;";
                    FbCommand cmd = new FbCommand(fSQL, conexaFB);
                    cmd.ExecuteNonQuery();
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

            return base.GetAll();
        }

        public Aluno GetByMatricula(int matricula)
        {
            return null;
        }

        public IEnumerable<Aluno> GetByContendoNoNome(string parteDoNome)
        {
            return null;
        }
    }
}
