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
            string strConn = @"DataSource=localhost; Port=3050; Database=D:\Bancos\CRUD_EM.FDB; username= SYSDBA; password = masterkey";
            return new FbConnection(strConn);
        }        
    }
}
