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
        private static readonly Conexao instanciaFireBird = new Conexao();
        private Conexao() { }

        public static Conexao getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            return new FbConnection(conn);
        }
    }
}
