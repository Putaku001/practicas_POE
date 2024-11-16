namespace PresentationLayer.Forms
{
	partial class CareerForm
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtNameCareer = new TextBox();
			txtDescriptionCareer = new TextBox();
			btnSave = new Button();
			btnEdit = new Button();
			btnDelete = new Button();
			dgvCareers = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvCareers).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(282, 9);
			label1.Name = "label1";
			label1.Size = new Size(247, 25);
			label1.TabIndex = 0;
			label1.Text = "Administrador de Carreras";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(31, 60);
			label2.Name = "label2";
			label2.Size = new Size(177, 21);
			label2.TabIndex = 1;
			label2.Text = "Nombre de la Carrera:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(31, 151);
			label3.Name = "label3";
			label3.Size = new Size(204, 21);
			label3.TabIndex = 2;
			label3.Text = "Descripcion de la Carrera:";
			// 
			// txtNameCareer
			// 
			txtNameCareer.Location = new Point(31, 97);
			txtNameCareer.Name = "txtNameCareer";
			txtNameCareer.Size = new Size(320, 23);
			txtNameCareer.TabIndex = 3;
			// 
			// txtDescriptionCareer
			// 
			txtDescriptionCareer.Location = new Point(31, 189);
			txtDescriptionCareer.Multiline = true;
			txtDescriptionCareer.Name = "txtDescriptionCareer";
			txtDescriptionCareer.Size = new Size(320, 116);
			txtDescriptionCareer.TabIndex = 4;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(31, 336);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 5;
			btnSave.Text = "Guardar";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(159, 336);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(75, 23);
			btnEdit.TabIndex = 6;
			btnEdit.Text = "Editar";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(276, 336);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(75, 23);
			btnDelete.TabIndex = 7;
			btnDelete.Text = "Eliminar";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// dgvCareers
			// 
			dgvCareers.AllowUserToAddRows = false;
			dgvCareers.AllowUserToDeleteRows = false;
			dgvCareers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvCareers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCareers.Location = new Point(406, 60);
			dgvCareers.MultiSelect = false;
			dgvCareers.Name = "dgvCareers";
			dgvCareers.ReadOnly = true;
			dgvCareers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCareers.Size = new Size(382, 299);
			dgvCareers.TabIndex = 8;
			// 
			// CareerForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 383);
			Controls.Add(dgvCareers);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(btnSave);
			Controls.Add(txtDescriptionCareer);
			Controls.Add(txtNameCareer);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "CareerForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CareerForm";
			((System.ComponentModel.ISupportInitialize)dgvCareers).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtNameCareer;
		private TextBox txtDescriptionCareer;
		private Button btnSave;
		private Button btnEdit;
		private Button btnDelete;
		private DataGridView dgvCareers;
	}
}