using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Repository
{
    public class Conexao
    {
        public FbConnection GetConexao()
        {
            string strConn = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            return new FbConnection(strConn);
        }

        public void Conectar()
        {
            try
            {
                GetConexao().Open();
                Console.WriteLine("Conexão efetuada");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {
                GetConexao().Close();
            }
        }
    }
}
