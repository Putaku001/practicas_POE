using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Student
    {
        public int idStudent { get; set; }
        public string nameStudent { get; set; }
        public string lastnameStudent { get; set; }
        public int idCareerStudent { get; set; }
        public string? nameCareerStudent { get; set; }
    }
}
