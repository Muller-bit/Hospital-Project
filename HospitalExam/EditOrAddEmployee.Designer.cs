namespace HospitalExam
{
	partial class EditOrAddEmployee
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonExit = new MaterialSkin.Controls.MaterialRaisedButton();
			this.buttonMain = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.materialLabelId = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
			this.idInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.nameInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.surnameInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.loginInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.passwordInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.gmcInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.comboBoxPosition = new System.Windows.Forms.ComboBox();
			this.comboBoxSpeciality = new System.Windows.Forms.ComboBox();
			this.mainLabel = new MaterialSkin.Controls.MaterialLabel();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 70);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.74699F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.25301F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 417);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.buttonExit, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.buttonMain, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 364);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(387, 50);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// buttonExit
			// 
			this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExit.Depth = 0;
			this.buttonExit.Location = new System.Drawing.Point(213, 3);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
			this.buttonExit.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Primary = true;
			this.buttonExit.Size = new System.Drawing.Size(154, 44);
			this.buttonExit.TabIndex = 102;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonMain
			// 
			this.buttonMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMain.Depth = 0;
			this.buttonMain.Location = new System.Drawing.Point(20, 3);
			this.buttonMain.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
			this.buttonMain.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonMain.Name = "buttonMain";
			this.buttonMain.Primary = true;
			this.buttonMain.Size = new System.Drawing.Size(153, 44);
			this.buttonMain.TabIndex = 101;
			this.buttonMain.Text = "Save";
			this.buttonMain.UseVisualStyleBackColor = true;
			this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.mainLabel, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.93333F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.06667F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(387, 355);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.37313F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.62687F));
			this.tableLayoutPanel4.Controls.Add(this.materialLabelId, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.materialLabel1, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.materialLabel2, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.materialLabel3, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.materialLabel4, 0, 4);
			this.tableLayoutPanel4.Controls.Add(this.materialLabel5, 0, 5);
			this.tableLayoutPanel4.Controls.Add(this.materialLabel6, 0, 6);
			this.tableLayoutPanel4.Controls.Add(this.materialLabel7, 0, 7);
			this.tableLayoutPanel4.Controls.Add(this.idInput, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.nameInput, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this.surnameInput, 1, 2);
			this.tableLayoutPanel4.Controls.Add(this.loginInput, 1, 3);
			this.tableLayoutPanel4.Controls.Add(this.passwordInput, 1, 4);
			this.tableLayoutPanel4.Controls.Add(this.gmcInput, 1, 7);
			this.tableLayoutPanel4.Controls.Add(this.comboBoxPosition, 1, 5);
			this.tableLayoutPanel4.Controls.Add(this.comboBoxSpeciality, 1, 6);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 41);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 8;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(381, 311);
			this.tableLayoutPanel4.TabIndex = 2;
			// 
			// materialLabelId
			// 
			this.materialLabelId.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.materialLabelId.AutoSize = true;
			this.materialLabelId.Depth = 0;
			this.materialLabelId.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabelId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabelId.Location = new System.Drawing.Point(65, 9);
			this.materialLabelId.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.materialLabelId.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabelId.Name = "materialLabelId";
			this.materialLabelId.Size = new System.Drawing.Size(21, 19);
			this.materialLabelId.TabIndex = 0;
			this.materialLabelId.Text = "Id";
			// 
			// materialLabel1
			// 
			this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(37, 47);
			this.materialLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(49, 19);
			this.materialLabel1.TabIndex = 1;
			this.materialLabel1.Text = "Name";
			// 
			// materialLabel2
			// 
			this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(18, 85);
			this.materialLabel2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(68, 19);
			this.materialLabel2.TabIndex = 2;
			this.materialLabel2.Text = "Surname";
			// 
			// materialLabel3
			// 
			this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(40, 123);
			this.materialLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(46, 19);
			this.materialLabel3.TabIndex = 3;
			this.materialLabel3.Text = "Login";
			// 
			// materialLabel4
			// 
			this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.materialLabel4.AutoSize = true;
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel4.Location = new System.Drawing.Point(11, 161);
			this.materialLabel4.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(75, 19);
			this.materialLabel4.TabIndex = 4;
			this.materialLabel4.Text = "Password";
			// 
			// materialLabel5
			// 
			this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.materialLabel5.AutoSize = true;
			this.materialLabel5.Depth = 0;
			this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel5.Location = new System.Drawing.Point(21, 199);
			this.materialLabel5.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel5.Name = "materialLabel5";
			this.materialLabel5.Size = new System.Drawing.Size(65, 19);
			this.materialLabel5.TabIndex = 5;
			this.materialLabel5.Text = "Position";
			// 
			// materialLabel6
			// 
			this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.materialLabel6.AutoSize = true;
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel6.Location = new System.Drawing.Point(12, 237);
			this.materialLabel6.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(74, 19);
			this.materialLabel6.TabIndex = 6;
			this.materialLabel6.Text = "Speciality";
			// 
			// materialLabel7
			// 
			this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.materialLabel7.AutoSize = true;
			this.materialLabel7.Depth = 0;
			this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel7.Location = new System.Drawing.Point(44, 279);
			this.materialLabel7.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel7.Name = "materialLabel7";
			this.materialLabel7.Size = new System.Drawing.Size(42, 19);
			this.materialLabel7.TabIndex = 7;
			this.materialLabel7.Text = "GMC";
			// 
			// idInput
			// 
			this.idInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.idInput.Depth = 0;
			this.idInput.Enabled = false;
			this.idInput.Hint = "";
			this.idInput.Location = new System.Drawing.Point(99, 7);
			this.idInput.MouseState = MaterialSkin.MouseState.HOVER;
			this.idInput.Name = "idInput";
			this.idInput.PasswordChar = '\0';
			this.idInput.SelectedText = "";
			this.idInput.SelectionLength = 0;
			this.idInput.SelectionStart = 0;
			this.idInput.Size = new System.Drawing.Size(43, 23);
			this.idInput.TabIndex = 8;
			this.idInput.UseSystemPasswordChar = false;
			// 
			// nameInput
			// 
			this.nameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nameInput.Depth = 0;
			this.nameInput.Hint = "";
			this.nameInput.Location = new System.Drawing.Point(99, 45);
			this.nameInput.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
			this.nameInput.MouseState = MaterialSkin.MouseState.HOVER;
			this.nameInput.Name = "nameInput";
			this.nameInput.PasswordChar = '\0';
			this.nameInput.SelectedText = "";
			this.nameInput.SelectionLength = 0;
			this.nameInput.SelectionStart = 0;
			this.nameInput.Size = new System.Drawing.Size(252, 23);
			this.nameInput.TabIndex = 9;
			this.nameInput.UseSystemPasswordChar = false;
			this.nameInput.Validating += new System.ComponentModel.CancelEventHandler(this.nameInput_Validating);
			// 
			// surnameInput
			// 
			this.surnameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.surnameInput.Depth = 0;
			this.surnameInput.Hint = "";
			this.surnameInput.Location = new System.Drawing.Point(99, 83);
			this.surnameInput.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
			this.surnameInput.MouseState = MaterialSkin.MouseState.HOVER;
			this.surnameInput.Name = "surnameInput";
			this.surnameInput.PasswordChar = '\0';
			this.surnameInput.SelectedText = "";
			this.surnameInput.SelectionLength = 0;
			this.surnameInput.SelectionStart = 0;
			this.surnameInput.Size = new System.Drawing.Size(252, 23);
			this.surnameInput.TabIndex = 10;
			this.surnameInput.UseSystemPasswordChar = false;
			this.surnameInput.Validating += new System.ComponentModel.CancelEventHandler(this.surnameInput_Validating);
			// 
			// loginInput
			// 
			this.loginInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.loginInput.Depth = 0;
			this.loginInput.Hint = "";
			this.loginInput.Location = new System.Drawing.Point(99, 121);
			this.loginInput.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
			this.loginInput.MouseState = MaterialSkin.MouseState.HOVER;
			this.loginInput.Name = "loginInput";
			this.loginInput.PasswordChar = '\0';
			this.loginInput.SelectedText = "";
			this.loginInput.SelectionLength = 0;
			this.loginInput.SelectionStart = 0;
			this.loginInput.Size = new System.Drawing.Size(252, 23);
			this.loginInput.TabIndex = 11;
			this.loginInput.UseSystemPasswordChar = false;
			this.loginInput.Validating += new System.ComponentModel.CancelEventHandler(this.loginInput_Validating);
			// 
			// passwordInput
			// 
			this.passwordInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordInput.Depth = 0;
			this.passwordInput.Hint = "";
			this.passwordInput.Location = new System.Drawing.Point(99, 159);
			this.passwordInput.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
			this.passwordInput.MouseState = MaterialSkin.MouseState.HOVER;
			this.passwordInput.Name = "passwordInput";
			this.passwordInput.PasswordChar = '\0';
			this.passwordInput.SelectedText = "";
			this.passwordInput.SelectionLength = 0;
			this.passwordInput.SelectionStart = 0;
			this.passwordInput.Size = new System.Drawing.Size(252, 23);
			this.passwordInput.TabIndex = 12;
			this.passwordInput.UseSystemPasswordChar = false;
			this.passwordInput.Validating += new System.ComponentModel.CancelEventHandler(this.passwordInput_Validating);
			// 
			// gmcInput
			// 
			this.gmcInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.gmcInput.Depth = 0;
			this.gmcInput.Enabled = false;
			this.gmcInput.Hint = "";
			this.gmcInput.Location = new System.Drawing.Point(99, 277);
			this.gmcInput.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
			this.gmcInput.MouseState = MaterialSkin.MouseState.HOVER;
			this.gmcInput.Name = "gmcInput";
			this.gmcInput.PasswordChar = '\0';
			this.gmcInput.SelectedText = "";
			this.gmcInput.SelectionLength = 0;
			this.gmcInput.SelectionStart = 0;
			this.gmcInput.Size = new System.Drawing.Size(252, 23);
			this.gmcInput.TabIndex = 13;
			this.gmcInput.UseSystemPasswordChar = false;
			this.gmcInput.Validating += new System.ComponentModel.CancelEventHandler(this.gmcInput_Validating);
			// 
			// comboBoxPosition
			// 
			this.comboBoxPosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPosition.FormattingEnabled = true;
			this.comboBoxPosition.Location = new System.Drawing.Point(99, 198);
			this.comboBoxPosition.Name = "comboBoxPosition";
			this.comboBoxPosition.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPosition.TabIndex = 14;
			this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
			// 
			// comboBoxSpeciality
			// 
			this.comboBoxSpeciality.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.comboBoxSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSpeciality.FormattingEnabled = true;
			this.comboBoxSpeciality.Location = new System.Drawing.Point(99, 236);
			this.comboBoxSpeciality.Name = "comboBoxSpeciality";
			this.comboBoxSpeciality.Size = new System.Drawing.Size(121, 21);
			this.comboBoxSpeciality.TabIndex = 15;
			// 
			// mainLabel
			// 
			this.mainLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mainLabel.AutoSize = true;
			this.mainLabel.Depth = 0;
			this.mainLabel.Font = new System.Drawing.Font("Roboto", 11F);
			this.mainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mainLabel.Location = new System.Drawing.Point(96, 9);
			this.mainLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Size = new System.Drawing.Size(195, 19);
			this.mainLabel.TabIndex = 3;
			this.mainLabel.Text = "Please leave all fields filled!";
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider1.ContainerControl = this;
			// 
			// EditOrAddEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 495);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.Name = "EditOrAddEmployee";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private MaterialSkin.Controls.MaterialRaisedButton buttonMain;
		private MaterialSkin.Controls.MaterialRaisedButton buttonExit;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private MaterialSkin.Controls.MaterialLabel materialLabelId;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private MaterialSkin.Controls.MaterialLabel materialLabel5;
		private MaterialSkin.Controls.MaterialLabel materialLabel6;
		private MaterialSkin.Controls.MaterialLabel materialLabel7;
		private MaterialSkin.Controls.MaterialSingleLineTextField idInput;
		private MaterialSkin.Controls.MaterialSingleLineTextField nameInput;
		private MaterialSkin.Controls.MaterialSingleLineTextField surnameInput;
		private MaterialSkin.Controls.MaterialSingleLineTextField loginInput;
		private MaterialSkin.Controls.MaterialSingleLineTextField passwordInput;
		private MaterialSkin.Controls.MaterialSingleLineTextField gmcInput;
		private MaterialSkin.Controls.MaterialLabel mainLabel;
		private System.Windows.Forms.ComboBox comboBoxPosition;
		private System.Windows.Forms.ComboBox comboBoxSpeciality;
	}
}