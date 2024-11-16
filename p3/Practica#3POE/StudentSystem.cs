using StudentSystemData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3POE
{
	public partial class StudentSystem : Form
	{

		public StudentSystem()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			Career career = new Career();
			Student student = new Student();

			career.Name = txtCarreraAlumno.Text;
			student.FirstName = txtNombreAlumno.Text;
			student.LastName = txtApellidoAlumno.Text;
			student.PhoneNumber = txtNumeroTelefono.Text;
			student.Career = career;

			lstbRegistroAlumno.Items.Add(student);
			MessageBox.Show("Estudiante Registrado con Exito");
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (lstbRegistroAlumno.SelectedItem is Student selectedStudent)
			{
				lstbRegistroAlumno.Items.Remove(selectedStudent);
				MessageBox.Show("Estudiante Eliminado con Exito");
			}
			else
			{
				MessageBox.Show("No ha seleccionado estudiante");
			}
		}
	}
}
