namespace Practica_1_POE.Forms
{
	partial class EventosTeclado
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			MayusculasTextBox = new TextBox();
			PreviewTextBox = new TextBox();
			SuspendLayout();
			// 
			// MayusculasTextBox
			// 
			MayusculasTextBox.Location = new Point(76, 39);
			MayusculasTextBox.Name = "MayusculasTextBox";
			MayusculasTextBox.Size = new Size(100, 23);
			MayusculasTextBox.TabIndex = 0;
			MayusculasTextBox.KeyPress += MayusculasTextBox_KeyPress;
			// 
			// PreviewTextBox
			// 
			PreviewTextBox.Location = new Point(76, 112);
			PreviewTextBox.Name = "PreviewTextBox";
			PreviewTextBox.Size = new Size(100, 23);
			PreviewTextBox.TabIndex = 1;
			PreviewTextBox.PreviewKeyDown += PreviewTextBox_PreviewKeyDown;
			// 
			// EventosTeclado
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(263, 219);
			Controls.Add(PreviewTextBox);
			Controls.Add(MayusculasTextBox);
			Name = "EventosTeclado";
			Text = "EventosTeclado";
			KeyDown += EventosTeclado_KeyDown;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox MayusculasTextBox;
		private TextBox PreviewTextBox;
	}
}