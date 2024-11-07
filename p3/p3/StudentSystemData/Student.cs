using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemData
{
	public class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public Career Career { get; set; }


		public override string ToString()
		{
			return $"Nombre: {FirstName} {LastName}, Carrera: {Career.Name}";
		}
	}
}
