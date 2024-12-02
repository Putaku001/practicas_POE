using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class StudentService
    {

        private StudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public DataTable GetAllStudent(string search)
        {
            return _studentRepository.GetStudents(search);
        }
        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.EditStudent(student);
        }

        public void DeleteStudente(int id)
        {
            _studentRepository.DeleteStudent(id);
        }
    }
}
