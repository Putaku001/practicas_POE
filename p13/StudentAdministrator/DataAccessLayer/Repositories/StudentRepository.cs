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

        public DataTable GetStudents()
        {
            DataTable studentTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT st.idStudent, st.nameStudent, st.lastnameStudent, st.idCareerStudent, ca.nameCareer 
                                 FROM student st
                                 INNER JOIN career ca ON st.idCareerStudent = ca.idCareer";

                SqlCommand command = new SqlCommand(query, connection);
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
                string query = "INSERT INTO student VALUES(@NameStudent, @LastnameStudent, @IdCareerStudent)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NameStudent", student.nameStudent);
                command.Parameters.AddWithValue("@LastnameStudent", student.lastnameStudent);
                command.Parameters.AddWithValue("@IdCareerStudent", student.idCareerStudent);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public void EditStudent(Student student)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE student 
								 SET nameStudent = @NameStudent,
									 lastnameStudent = @LastnameStudent,
                                     idCareerStudent = @IdCareerStudent
								 WHERE idStudent = @IdStudent";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NameStudent", student.nameStudent);
                command.Parameters.AddWithValue("@LastnameStudent", student.lastnameStudent);
                command.Parameters.AddWithValue("@IdCareerStudent", student.idCareerStudent);
                command.Parameters.AddWithValue("@IdStudent", student.idStudent);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM student WHERE idStudent = @IdStudent";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdStudent", id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }


    }
}
