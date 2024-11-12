using BusinessLayer.Services;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
	public partial class LoginForm : Form
	{
		private readonly UserService _userService;

		public LoginForm()
		{
			InitializeComponent();
			_userService = new UserService();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var user = _userService.GetRegisterdUser(txtUsername.Text, txtPassword.Text);

			if ( user != null)
			{
				AuthUser.UserName = user.nameUser;
				AuthUser.idRol = user.idRolUser;

				StudentForm studentForm = new StudentForm();
				studentForm.ShowDialog();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Usuario o Contraseña Incorrecta, vuelve a intentarlo");
			}
		}
	}
}
