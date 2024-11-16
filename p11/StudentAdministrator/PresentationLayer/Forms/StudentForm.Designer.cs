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
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(462, 76);
            dgvStudent.Margin = new Padding(3, 4, 3, 4);
            dgvStudent.MultiSelect = false;
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudent.Size = new Size(437, 399);
            dgvStudent.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(317, 444);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(172, 444);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(37, 444);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 14;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtNameStudent
            // 
            txtNameStudent.Location = new Point(37, 125);
            txtNameStudent.Margin = new Padding(3, 4, 3, 4);
            txtNameStudent.Name = "txtNameStudent";
            txtNameStudent.Size = new Size(365, 27);
            txtNameStudent.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 76);
            label2.Name = "label2";
            label2.Size = new Size(235, 28);
            label2.TabIndex = 10;
            label2.Text = "Nombre del Estudiante:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 32);
            label1.TabIndex = 9;
            label1.Text = "Administrador de Estudiantes";
            // 
            // txtLastnameStudent
            // 
            txtLastnameStudent.Location = new Point(37, 242);
            txtLastnameStudent.Margin = new Padding(3, 4, 3, 4);
            txtLastnameStudent.Name = "txtLastnameStudent";
            txtLastnameStudent.Size = new Size(365, 27);
            txtLastnameStudent.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 193);
            label3.Name = "label3";
            label3.Size = new Size(246, 28);
            label3.TabIndex = 18;
            label3.Text = "Apellidos del Estudiante:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 312);
            label4.Name = "label4";
            label4.Size = new Size(227, 28);
            label4.TabIndex = 20;
            label4.Text = "Carrera del Estudiante:";
            // 
            // cbxCareerStudent
            // 
            cbxCareerStudent.FormattingEnabled = true;
            cbxCareerStudent.Location = new Point(37, 359);
            cbxCareerStudent.Name = "cbxCareerStudent";
            cbxCareerStudent.Size = new Size(365, 28);
            cbxCareerStudent.TabIndex = 21;
            // 
            // btnShowCareer
            // 
            btnShowCareer.Location = new Point(267, 514);
            btnShowCareer.Name = "btnShowCareer";
            btnShowCareer.Size = new Size(358, 29);
            btnShowCareer.TabIndex = 22;
            btnShowCareer.Text = "Ver Carreras";
            btnShowCareer.UseVisualStyleBackColor = true;
            btnShowCareer.Click += btnShowCareer_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 555);
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
            Name = "StudentForm";
            Text = "StudentForm";
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
    }
}