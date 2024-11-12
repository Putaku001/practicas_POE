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
	public partial class EventosTeclado : Form
	{
		public EventosTeclado()
		{
			InitializeComponent();
		}

		private void EventosTeclado_KeyDown(object sender, KeyEventArgs e)
		{
			// Verifica si Ctrl está presionado junto con otra tecla
			if (e.Control)
			{
				switch (e.KeyCode)
				{
					case Keys.S:
						MessageBox.Show("Guardar acción realizada", "Información");
						break;
					case Keys.O:
						MessageBox.Show("Abrir acción realizada", "Información");
						break;
				}
			}
		}

		private void MayusculasTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Verifica si el carácter es una letra
			if (char.IsLetter(e.KeyChar))
			{
				// Convierte el carácter a mayúscula
				e.KeyChar = char.ToUpper(e.KeyChar);
			}
			else if (!char.IsControl(e.KeyChar))
			{
				// Si no es una letra ni una tecla de control, cancelar el evento
				e.Handled = true;
			}
		}

		private void PreviewTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Tab)
			{
				MessageBox.Show("Se ha presionado Tab, mostrando la ayuda personalizada.");
				e.IsInputKey = true; // Prevenir el comportamiento predeterminado
			}
		}
	}
}
