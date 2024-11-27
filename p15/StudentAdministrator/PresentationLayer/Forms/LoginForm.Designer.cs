namespace PresentationLayer.Forms
{
	partial class LoginForm
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
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			label3 = new Label();
			btnLogin = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(40, 58);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 0;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(40, 119);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(40, 76);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(262, 23);
			txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(40, 137);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(259, 23);
			txtPassword.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(100, 22);
			label3.Name = "label3";
			label3.Size = new Size(162, 15);
			label3.TabIndex = 4;
			label3.Text = "Administrador de Estudiantes";
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(131, 184);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(75, 23);
			btnLogin.TabIndex = 5;
			btnLogin.Text = "Iniciar Sesion";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(344, 236);
			Controls.Add(btnLogin);
			Controls.Add(label3);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Label label3;
		private Button btnLogin;
	}
}