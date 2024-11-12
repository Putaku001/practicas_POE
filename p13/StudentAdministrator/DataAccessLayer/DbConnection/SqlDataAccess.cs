using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbConnection
{
	public class SqlDataAccess
	{
		private readonly string _connectionString;

		public SqlDataAccess()
		{
			_connectionString = "Data Source=U20210444\\U20210444;Initial Catalog=StudentAdministratorDB;Integrated Security=True;Encrypt=False";
		}

		public SqlConnection GetConnection()
		{
			return new SqlConnection(_connectionString);
		}
	}
}
