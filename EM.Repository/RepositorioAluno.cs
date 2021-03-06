using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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
            using (FbConnection conexaFB = conexao.GetConexao())
            {
                conexaFB.Open();
                string fSQL = $@"INSERT INTO ALUNO VALUES ({aluno.Matricula}, '{aluno.Nome}', {sexo}, '{aluno.CPF}', '{aluno.Nascimento.ToShortDateString()}');";
                FbCommand cmd = new FbCommand(fSQL, conexaFB);
                cmd.ExecuteNonQuery();
                conexaFB.Close();
            }
        }          

        public override void Update(Aluno aluno)
        {
            int sexo = aluno.Sexo == EnumeradorSexo.Masculino ? 0 : 1;

            using (FbConnection conexaFB = conexao.GetConexao())
            {
                conexaFB.Open();
                string fSQL = $"UPDATE ALUNO SET NOME = '{aluno.Nome}', SEXO = {sexo}, CPF = '{aluno.CPF}', NASCIMENTO = '{aluno.Nascimento:yyyy/MM/dd}'" +
                                $"WHERE MATRICULA = {aluno.Matricula};";
                FbCommand cmd = new FbCommand(fSQL, conexaFB);
                cmd.ExecuteNonQuery();

                conexaFB.Close();
            }
        }

        public override void Remove(Aluno aluno)
        {

            using (FbConnection conexaFB = conexao.GetConexao())
            {
                conexaFB.Open();
                string fSQL = $"DELETE FROM ALUNO WHERE MATRICULA = {aluno.Matricula};";
                FbCommand cmd = new FbCommand(fSQL, conexaFB);
                cmd.ExecuteNonQuery();

                conexaFB.Close();
            }
        }

        public override IEnumerable<Aluno> GetAll()
        {
            using (FbConnection conexaFB = conexao.GetConexao())
            {
                conexaFB.Open();
                string fSQL = $"SELECT * FROM ALUNO ORDER BY MATRICULA;";
                FbCommand cmd = new FbCommand(fSQL, conexaFB);
                FbDataReader fbData = cmd.ExecuteReader();
                
                List<Aluno> alunos = new List<Aluno>();

                while (fbData.Read())
                {
                    Aluno aluno = new Aluno()
                    {
                        Matricula = Convert.ToInt32(fbData[0]),
                        Nome = fbData[1].ToString(),
                        CPF = fbData[3].ToString(),
                        Nascimento = Convert.ToDateTime(fbData[4]),
                        Sexo = (EnumeradorSexo)Convert.ToInt32(fbData[2])
                    };

                     alunos.Add(aluno);
                }
                conexaFB.Close();
                return alunos;                    
            }
        }

        public override IEnumerable<Aluno> Get(Expression<Func<Aluno, bool>> predicate)
        {
            //IEnumerable<Aluno> listaAlunos = GetAll().Where(predicate.Compile());
            
            return GetAll().Where(predicate.Compile());
        }

        public Aluno GetByMatricula(int matricula)
        {
            return Get(aluno => aluno.Matricula == matricula).FirstOrDefault();
        }

        public IEnumerable<Aluno> GetByContendoNoNome(string parteDoNome)
        {            
            return Get(aluno => aluno.Nome.ToUpper().Contains(parteDoNome.ToUpper()));
        }
    }
}
