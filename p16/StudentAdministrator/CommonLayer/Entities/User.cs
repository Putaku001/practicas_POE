using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
	public class User
	{
		public int idUser { get; set; }
		public string nameUser { get; set; }
		public string usernameUser { get; set; }
		public string passwordUser { get; set; }
		public int idRolUser { get; set; }
	}
}
