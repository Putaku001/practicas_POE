using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_POE.Forms
{
	public partial class EventoDeMouse : Form
	{
		public EventoDeMouse()
		{
			InitializeComponent();
		}

		private void EventoDeMouse_Load(object sender, EventArgs e)
		{

		}

		private void CambioColorPictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			CambioColorPictureBox.BackColor = Color.Black;
		}

		private void CambioColorPictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			CambioColorPictureBox.BackColor = Color.Transparent;
		}

		private void EventoDeMouse_MouseMove(object sender, MouseEventArgs e)
		{
			EjeYlabel.Text = e.Y.ToString();
			EjeXlabel.Text = e.X.ToString();
		}

		private void EventoDeMouse_MouseClick(object sender, MouseEventArgs e)
		{
			string buttonClicked = "";

			switch (e.Button)
			{
				case MouseButtons.Left:
					buttonClicked = "Izquierdo";
					break;
				case MouseButtons.Right:
					buttonClicked = "Derecho";
					break;
				case MouseButtons.Middle:
					buttonClicked = "Central";
					break;
			}

			NombreClickLabel.Text = buttonClicked;
		}
	}
}
