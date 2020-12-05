namespace HospitalExam
{
	partial class AddDuty
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonExit = new MaterialSkin.Controls.MaterialRaisedButton();
			this.buttonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.employeeLabel = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.comboboxEmployees = new System.Windows.Forms.ComboBox();
			this.labelPosition = new MaterialSkin.Controls.MaterialLabel();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
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
			this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 72);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 159);
			this.tableLayoutPanel1.TabIndex = 1;
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
			this.tableLayoutPanel2.Controls.Add(this.buttonAdd, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 108);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(387, 48);
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
			this.buttonExit.Size = new System.Drawing.Size(154, 42);
			this.buttonExit.TabIndex = 102;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAdd.Depth = 0;
			this.buttonAdd.Location = new System.Drawing.Point(20, 3);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
			this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Primary = true;
			this.buttonAdd.Size = new System.Drawing.Size(153, 42);
			this.buttonAdd.TabIndex = 101;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.14371F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(387, 99);
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
			this.tableLayoutPanel4.Controls.Add(this.employeeLabel, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.materialLabel2, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.dateTimePicker, 1, 1);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(381, 93);
			this.tableLayoutPanel4.TabIndex = 2;
			// 
			// employeeLabel
			// 
			this.employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.employeeLabel.AutoSize = true;
			this.employeeLabel.Depth = 0;
			this.employeeLabel.Font = new System.Drawing.Font("Roboto", 11F);
			this.employeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.employeeLabel.Location = new System.Drawing.Point(11, 13);
			this.employeeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.employeeLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.employeeLabel.Name = "employeeLabel";
			this.employeeLabel.Size = new System.Drawing.Size(75, 19);
			this.employeeLabel.TabIndex = 1;
			this.employeeLabel.Text = "Employee";
			// 
			// materialLabel2
			// 
			this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(46, 60);
			this.materialLabel2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(40, 19);
			this.materialLabel2.TabIndex = 2;
			this.materialLabel2.Text = "Date";
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.comboboxEmployees, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.labelPosition, 1, 0);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(99, 3);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(279, 40);
			this.tableLayoutPanel5.TabIndex = 3;
			// 
			// comboboxEmployees
			// 
			this.comboboxEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.comboboxEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboboxEmployees.FormattingEnabled = true;
			this.comboboxEmployees.Location = new System.Drawing.Point(3, 9);
			this.comboboxEmployees.Name = "comboboxEmployees";
			this.comboboxEmployees.Size = new System.Drawing.Size(133, 21);
			this.comboboxEmployees.TabIndex = 14;
			this.comboboxEmployees.SelectedValueChanged += new System.EventHandler(this.comboboxEmployees_SelectedValueChanged);
			// 
			// labelPosition
			// 
			this.labelPosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelPosition.AutoSize = true;
			this.labelPosition.Depth = 0;
			this.labelPosition.Font = new System.Drawing.Font("Roboto", 11F);
			this.labelPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelPosition.Location = new System.Drawing.Point(142, 10);
			this.labelPosition.MouseState = MaterialSkin.MouseState.HOVER;
			this.labelPosition.Name = "labelPosition";
			this.labelPosition.Size = new System.Drawing.Size(0, 19);
			this.labelPosition.TabIndex = 15;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(99, 59);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(279, 20);
			this.dateTimePicker.TabIndex = 4;
			// 
			// AddDuty
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 237);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "AddDuty";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add duty for employee";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private MaterialSkin.Controls.MaterialRaisedButton buttonExit;
		private MaterialSkin.Controls.MaterialRaisedButton buttonAdd;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private MaterialSkin.Controls.MaterialLabel employeeLabel;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private System.Windows.Forms.ComboBox comboboxEmployees;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private MaterialSkin.Controls.MaterialLabel labelPosition;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
	}
}