using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class UserRepository
	{
		private SqlDataAccess _dbConnection;

        public UserRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public User? GetRegisteredUser(string username, string password)
        {
			using (var connection = _dbConnection.GetConnection())
			{
				string query = @"SELECT * FROM users 
								 WHERE usernameUser = @UsernameUser AND passwordUser = @PasswordUser";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@UsernameUser", username);
				command.Parameters.AddWithValue("@PasswordUser", password);
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					return new User
					{
						idUser = reader.GetInt32(0),
						nameUser = reader.GetString(1),
						usernameUser = reader.GetString(2),
						passwordUser = reader.GetString(3),
						idRolUser = reader.GetInt32(4),
					};
				}
				else
				{
					return null;
				}
			}
		}
    }
}
