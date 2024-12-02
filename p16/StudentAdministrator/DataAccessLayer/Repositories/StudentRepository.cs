using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class StudentRepository
    {
        private SqlDataAccess _dbConnection;

        public StudentRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetStudents(string search)
        {
            DataTable studentTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                // Nombre del procedimiento almacenado
                string storedProcedureName = "sp_SelectStudent";

                SqlCommand command = new SqlCommand(storedProcedureName, connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Search", '%' + search + '%');
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                studentTable.Load(reader);
            }

            return studentTable;
        }

        public void AddStudent(Student student)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                // Nombre del procedimiento almacenado
                string storedProcedureName = "sp_InsertStudent";

                SqlCommand command = new SqlCommand(storedProcedureName, connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nameStudent", student.nameStudent);
                command.Parameters.AddWithValue("@lastnameStudent", student.lastnameStudent);
                command.Parameters.AddWithValue("@idCareerStudent", student.idCareerStudent);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public void EditStudent(Student student)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                // Nombre del procedimiento almacenado
                string storedProcedureName = "sp_UpdateStudent";

                SqlCommand command = new SqlCommand(storedProcedureName, connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nameStudent", student.nameStudent);
                command.Parameters.AddWithValue("@lastnameStudent", student.lastnameStudent);
                command.Parameters.AddWithValue("@idCareerStudent", student.idCareerStudent);
                command.Parameters.AddWithValue("@idStudent", student.idStudent);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                // Nombre del procedimiento almacenado
                string storedProcedureName = "sp_DeleteStudent";

                SqlCommand command = new SqlCommand(storedProcedureName, connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@idStudent", id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }


    }
}
