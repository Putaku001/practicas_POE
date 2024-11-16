namespace Practica_1_POE.Forms
{
	partial class EventoDeMouse
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
			groupBox1 = new GroupBox();
			CambioColorPictureBox = new PictureBox();
			groupBox2 = new GroupBox();
			EjeYlabel = new Label();
			EjeXlabel = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox3 = new GroupBox();
			NombreClickLabel = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)CambioColorPictureBox).BeginInit();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(CambioColorPictureBox);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(252, 111);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "MouseDown y MouseUp";
			// 
			// CambioColorPictureBox
			// 
			CambioColorPictureBox.BorderStyle = BorderStyle.FixedSingle;
			CambioColorPictureBox.Location = new Point(57, 22);
			CambioColorPictureBox.Name = "CambioColorPictureBox";
			CambioColorPictureBox.Size = new Size(113, 78);
			CambioColorPictureBox.TabIndex = 0;
			CambioColorPictureBox.TabStop = false;
			CambioColorPictureBox.MouseDown += CambioColorPictureBox_MouseDown;
			CambioColorPictureBox.MouseUp += CambioColorPictureBox_MouseUp;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(EjeYlabel);
			groupBox2.Controls.Add(EjeXlabel);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label1);
			groupBox2.Location = new Point(287, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(252, 111);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "MouseMove";
			// 
			// EjeYlabel
			// 
			EjeYlabel.AutoSize = true;
			EjeYlabel.Location = new Point(134, 67);
			EjeYlabel.Name = "EjeYlabel";
			EjeYlabel.Size = new Size(38, 15);
			EjeYlabel.TabIndex = 3;
			EjeYlabel.Text = "label4";
			// 
			// EjeXlabel
			// 
			EjeXlabel.AutoSize = true;
			EjeXlabel.Location = new Point(134, 42);
			EjeXlabel.Name = "EjeXlabel";
			EjeXlabel.Size = new Size(38, 15);
			EjeXlabel.TabIndex = 2;
			EjeXlabel.Text = "label3";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(63, 67);
			label2.Name = "label2";
			label2.Size = new Size(35, 15);
			label2.TabIndex = 1;
			label2.Text = "Eje Y:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(63, 42);
			label1.Name = "label1";
			label1.Size = new Size(35, 15);
			label1.TabIndex = 0;
			label1.Text = "Eje X:";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(NombreClickLabel);
			groupBox3.Location = new Point(185, 155);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(200, 133);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "MouseWheel";
			// 
			// NombreClickLabel
			// 
			NombreClickLabel.AutoSize = true;
			NombreClickLabel.Location = new Point(46, 63);
			NombreClickLabel.Name = "NombreClickLabel";
			NombreClickLabel.Size = new Size(35, 15);
			NombreClickLabel.TabIndex = 0;
			NombreClickLabel.Text = "Nada";
			// 
			// EventoDeMouse
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(551, 320);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "EventoDeMouse";
			Text = "Eventos de Mouse";
			Load += EventoDeMouse_Load;
			MouseClick += EventoDeMouse_MouseClick;
			MouseMove += EventoDeMouse_MouseMove;
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)CambioColorPictureBox).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private PictureBox CambioColorPictureBox;
		private Label EjeYlabel;
		private Label EjeXlabel;
		private Label label2;
		private Label label1;
		private Label NombreClickLabel;
	}
}