using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.DbConnection
{
    public class SqlDataAcesscs
    {
        private readonly string _connectionString;
        public SqlDataAcesscs()
        {
            _connectionString = "Data Source=ALEJANDRO\\SQLEXPRESS;Initial Catalog=StudentAdministratorDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection( _connectionString );
        }
    }
}
