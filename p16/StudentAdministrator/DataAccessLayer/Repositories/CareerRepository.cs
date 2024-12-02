using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class CareerRepository
	{
		private SqlDataAccess _dbConnection;

        public CareerRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetCareers(string searchCareer)
        {
			DataTable careersTable = new DataTable();

			using (var connection = _dbConnection.GetConnection())
			{
                // Nombre del procedimiento almacenado
                string storedProcedureName = "sp_SelectCareer";

                SqlCommand command = new SqlCommand(storedProcedureName, connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@SearchCareer", '%' + searchCareer + '%');
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();
				careersTable.Load(reader);
			}

			return careersTable;
		}

		public void AddCareer(Career career)
		{
			using (var connection = _dbConnection.GetConnection())
			{
                // Nombre del procedimiento almacenado
                string storedProcedureName = "sp_InsertCareer";

                SqlCommand command = new SqlCommand(storedProcedureName, connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nameCareer", career.nameCareer);
                command.Parameters.AddWithValue("@descriptionCareer", career.descriptionCareer);
                connection.Open();

                command.ExecuteNonQuery();
            }
		}
		public void EditCareer(Career career)
		{
			using (var connection = _dbConnection.GetConnection())
			{
                // Nombre del procedimiento almacenado
                string storedProcedureName = "sp_UpdateCareer";

                SqlCommand command = new SqlCommand(storedProcedureName, connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nameCareer", career.nameCareer);
				command.Parameters.AddWithValue("@descriptionCareer", career.descriptionCareer);
				command.Parameters.AddWithValue("@idCareer", career.idCareer);
				connection.Open();

				command.ExecuteNonQuery();
			}
		}

		public void DeleteCareer(int id)
		{
			using (var connection = _dbConnection.GetConnection())
			{
                // Nombre del procedimiento almacenado
                string storedProcedureName = "sp_DeleteCareer";

                SqlCommand command = new SqlCommand(storedProcedureName, connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@idCareer", id);
				connection.Open();

				command.ExecuteNonQuery();
			}
		}

	}
}
