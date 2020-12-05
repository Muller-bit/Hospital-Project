namespace HospitalExam
{
	partial class Login
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
			this.components = new System.ComponentModel.Container();
			this.loginLabel = new MaterialSkin.Controls.MaterialLabel();
			this.loginInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.buttonLogin = new MaterialSkin.Controls.MaterialRaisedButton();
			this.passwordInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Depth = 0;
			this.loginLabel.Font = new System.Drawing.Font("Roboto", 11F);
			this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.loginLabel.Location = new System.Drawing.Point(61, 97);
			this.loginLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(46, 19);
			this.loginLabel.TabIndex = 99;
			this.loginLabel.Text = "Login";
			// 
			// loginInput
			// 
			this.loginInput.Depth = 0;
			this.loginInput.Hint = "";
			this.loginInput.Location = new System.Drawing.Point(64, 127);
			this.loginInput.MouseState = MaterialSkin.MouseState.HOVER;
			this.loginInput.Name = "loginInput";
			this.loginInput.PasswordChar = '\0';
			this.loginInput.SelectedText = "";
			this.loginInput.SelectionLength = 0;
			this.loginInput.SelectionStart = 0;
			this.loginInput.Size = new System.Drawing.Size(261, 23);
			this.loginInput.TabIndex = 0;
			this.loginInput.Tag = "Login";
			this.loginInput.Text = "dnldcode";
			this.loginInput.UseSystemPasswordChar = false;
			this.loginInput.Validating += new System.ComponentModel.CancelEventHandler(this.loginInput_Validating);
			// 
			// buttonLogin
			// 
			this.buttonLogin.Depth = 0;
			this.buttonLogin.Location = new System.Drawing.Point(96, 238);
			this.buttonLogin.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Primary = true;
			this.buttonLogin.Size = new System.Drawing.Size(185, 58);
			this.buttonLogin.TabIndex = 99;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// passwordInput
			// 
			this.passwordInput.Depth = 0;
			this.passwordInput.Hint = "";
			this.passwordInput.Location = new System.Drawing.Point(63, 194);
			this.passwordInput.MouseState = MaterialSkin.MouseState.HOVER;
			this.passwordInput.Name = "passwordInput";
			this.passwordInput.PasswordChar = '\0';
			this.passwordInput.SelectedText = "";
			this.passwordInput.SelectionLength = 0;
			this.passwordInput.SelectionStart = 0;
			this.passwordInput.Size = new System.Drawing.Size(261, 23);
			this.passwordInput.TabIndex = 1;
			this.passwordInput.Tag = "Password";
			this.passwordInput.Text = "password";
			this.passwordInput.UseSystemPasswordChar = true;
			this.passwordInput.Validating += new System.ComponentModel.CancelEventHandler(this.passwordInput_Validating);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Depth = 0;
			this.passwordLabel.Font = new System.Drawing.Font("Roboto", 11F);
			this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.passwordLabel.Location = new System.Drawing.Point(60, 164);
			this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(75, 19);
			this.passwordLabel.TabIndex = 99;
			this.passwordLabel.Text = "Password";
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider1.ContainerControl = this;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(377, 314);
			this.Controls.Add(this.passwordInput);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.loginInput);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.loginLabel);
			this.MaximizeBox = false;
			this.Name = "Login";
			this.ShowIcon = false;
			this.Sizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hospital Login";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialLabel loginLabel;
		private MaterialSkin.Controls.MaterialSingleLineTextField loginInput;
		private MaterialSkin.Controls.MaterialRaisedButton buttonLogin;
		private MaterialSkin.Controls.MaterialSingleLineTextField passwordInput;
		private MaterialSkin.Controls.MaterialLabel passwordLabel;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}