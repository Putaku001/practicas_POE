namespace PresentationLayer.Forms
{
    partial class StudentForm
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
			dgvStudent = new DataGridView();
			btnDelete = new Button();
			btnEdit = new Button();
			btnSave = new Button();
			txtNameStudent = new TextBox();
			label2 = new Label();
			label1 = new Label();
			txtLastnameStudent = new TextBox();
			label3 = new Label();
			label4 = new Label();
			cbxCareerStudent = new ComboBox();
			btnShowCareer = new Button();
			btnGeneratePDF = new Button();
			((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
			SuspendLayout();
			// 
			// dgvStudent
			// 
			dgvStudent.AllowUserToAddRows = false;
			dgvStudent.AllowUserToDeleteRows = false;
			dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvStudent.Location = new Point(404, 57);
			dgvStudent.MultiSelect = false;
			dgvStudent.Name = "dgvStudent";
			dgvStudent.ReadOnly = true;
			dgvStudent.RowHeadersWidth = 51;
			dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvStudent.Size = new Size(382, 299);
			dgvStudent.TabIndex = 17;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(277, 333);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(75, 23);
			btnDelete.TabIndex = 16;
			btnDelete.Text = "Eliminar";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(150, 333);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(75, 23);
			btnEdit.TabIndex = 15;
			btnEdit.Text = "Editar";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(32, 333);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 14;
			btnSave.Text = "Guardar";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// txtNameStudent
			// 
			txtNameStudent.Location = new Point(32, 94);
			txtNameStudent.Name = "txtNameStudent";
			txtNameStudent.Size = new Size(320, 23);
			txtNameStudent.TabIndex = 12;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(32, 57);
			label2.Name = "label2";
			label2.Size = new Size(190, 21);
			label2.TabIndex = 10;
			label2.Text = "Nombre del Estudiante:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(252, 7);
			label1.Name = "label1";
			label1.Size = new Size(274, 25);
			label1.TabIndex = 9;
			label1.Text = "Administrador de Estudiantes";
			// 
			// txtLastnameStudent
			// 
			txtLastnameStudent.Location = new Point(32, 182);
			txtLastnameStudent.Name = "txtLastnameStudent";
			txtLastnameStudent.Size = new Size(320, 23);
			txtLastnameStudent.TabIndex = 19;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(32, 145);
			label3.Name = "label3";
			label3.Size = new Size(199, 21);
			label3.TabIndex = 18;
			label3.Text = "Apellidos del Estudiante:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(32, 234);
			label4.Name = "label4";
			label4.Size = new Size(182, 21);
			label4.TabIndex = 20;
			label4.Text = "Carrera del Estudiante:";
			// 
			// cbxCareerStudent
			// 
			cbxCareerStudent.FormattingEnabled = true;
			cbxCareerStudent.Location = new Point(32, 269);
			cbxCareerStudent.Margin = new Padding(3, 2, 3, 2);
			cbxCareerStudent.Name = "cbxCareerStudent";
			cbxCareerStudent.Size = new Size(320, 23);
			cbxCareerStudent.TabIndex = 21;
			// 
			// btnShowCareer
			// 
			btnShowCareer.Location = new Point(32, 383);
			btnShowCareer.Margin = new Padding(3, 2, 3, 2);
			btnShowCareer.Name = "btnShowCareer";
			btnShowCareer.Size = new Size(320, 22);
			btnShowCareer.TabIndex = 22;
			btnShowCareer.Text = "Ver Carreras";
			btnShowCareer.UseVisualStyleBackColor = true;
			btnShowCareer.Click += btnShowCareer_Click;
			// 
			// btnGeneratePDF
			// 
			btnGeneratePDF.Location = new Point(451, 383);
			btnGeneratePDF.Name = "btnGeneratePDF";
			btnGeneratePDF.Size = new Size(293, 23);
			btnGeneratePDF.TabIndex = 23;
			btnGeneratePDF.Text = "Generar Reporte PDF";
			btnGeneratePDF.UseVisualStyleBackColor = true;
			btnGeneratePDF.Click += btnGeneratePDF_Click;
			// 
			// StudentForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(807, 416);
			Controls.Add(btnGeneratePDF);
			Controls.Add(btnShowCareer);
			Controls.Add(cbxCareerStudent);
			Controls.Add(label4);
			Controls.Add(txtLastnameStudent);
			Controls.Add(label3);
			Controls.Add(dgvStudent);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(btnSave);
			Controls.Add(txtNameStudent);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "StudentForm";
			Text = "StudentForm";
			FormClosed += StudentForm_FormClosed;
			((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvStudent;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private TextBox txtNameStudent;
        private Label label2;
        private Label label1;
        private TextBox txtLastnameStudent;
        private Label label3;
        private Label label4;
        private ComboBox cbxCareerStudent;
        private Button btnShowCareer;
		private Button btnGeneratePDF;
	}
}