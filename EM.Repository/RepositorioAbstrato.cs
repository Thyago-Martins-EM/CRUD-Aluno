using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using EM.Domain;
using FirebirdSql.Data.FirebirdClient;

namespace EM.Repository
{

    public abstract class RepositorioAbstrato<T> where T : IEntidade
    {

        public FbConnection GetConexao()
        {
            string strCon = //ConfigurationManager.ConnectionStrings["Connection"].ToString();
                @"DataSource=localhost; Database=CRUD_EM.FDB; username= SYSDBA; password = masterkey";            
            return new FbConnection(strCon);
        }
        public void Add(T objeto)
        {
            using(FbConnection conexaFB = GetConexao())
            {
                try
                {
                    conexaFB.Open();
                    Console.WriteLine("Conexão efetuada");
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }
                finally
                {
                    conexaFB.Close();
                }
            }
        }
        public void Remove(T objeto)
        {

        }
        public void Update(T objeto)
        {

        }

        public IEnumerable<T> GeAll()
        {
            return null;
        }

        public IEnumerable<T> Get(Expression<Func<T, bool> > predicate)
        {   

            return null;

        }
        
    }
}
