using System.Windows.Forms;

namespace HospitalExam
{
	partial class Main
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.buttonViewAllDutiesCommon = new MaterialSkin.Controls.MaterialRaisedButton();
			this.employeeList = new System.Windows.Forms.ListView();
			this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
			this.tableLayoutPanelAdmin = new System.Windows.Forms.TableLayoutPanel();
			this.buttonEdit = new MaterialSkin.Controls.MaterialRaisedButton();
			this.buttonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonViewDuties = new MaterialSkin.Controls.MaterialRaisedButton();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.labelPosition = new System.Windows.Forms.Label();
			this.tableLayoutDuties = new System.Windows.Forms.TableLayoutPanel();
			this.dutyList = new System.Windows.Forms.ListView();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.buttonApply = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonRemoveDuty = new System.Windows.Forms.Button();
			this.buttonAddDuty = new MaterialSkin.Controls.MaterialRaisedButton();
			this.buttonGoBack = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanelAdmin.SuspendLayout();
			this.tableLayoutDuties.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanelMain.ColumnCount = 1;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Controls.Add(this.buttonViewAllDutiesCommon, 0, 1);
			this.tableLayoutPanelMain.Controls.Add(this.employeeList, 0, 0);
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(2, 64);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 2;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.19807F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.80193F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(681, 409);
			this.tableLayoutPanelMain.TabIndex = 0;
			// 
			// buttonViewAllDutiesCommon
			// 
			this.buttonViewAllDutiesCommon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.buttonViewAllDutiesCommon.Depth = 0;
			this.buttonViewAllDutiesCommon.Location = new System.Drawing.Point(225, 359);
			this.buttonViewAllDutiesCommon.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonViewAllDutiesCommon.Name = "buttonViewAllDutiesCommon";
			this.buttonViewAllDutiesCommon.Primary = true;
			this.buttonViewAllDutiesCommon.Size = new System.Drawing.Size(230, 47);
			this.buttonViewAllDutiesCommon.TabIndex = 2;
			this.buttonViewAllDutiesCommon.Text = "View all duties";
			this.buttonViewAllDutiesCommon.UseVisualStyleBackColor = true;
			this.buttonViewAllDutiesCommon.Click += new System.EventHandler(this.buttonViewAllDutiesCommon_Click);
			// 
			// employeeList
			// 
			this.employeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.employeeList.ContextMenuStrip = this.materialContextMenuStrip1;
			this.employeeList.FullRowSelect = true;
			this.employeeList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.employeeList.HideSelection = false;
			this.employeeList.Location = new System.Drawing.Point(3, 3);
			this.employeeList.MultiSelect = false;
			this.employeeList.Name = "employeeList";
			this.employeeList.Size = new System.Drawing.Size(675, 350);
			this.employeeList.TabIndex = 1;
			this.employeeList.UseCompatibleStateImageBehavior = false;
			this.employeeList.View = System.Windows.Forms.View.Details;
			this.employeeList.DoubleClick += new System.EventHandler(this.employeeList_DoubleClick);
			// 
			// materialContextMenuStrip1
			// 
			this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialContextMenuStrip1.Depth = 0;
			this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
			this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// tableLayoutPanelAdmin
			// 
			this.tableLayoutPanelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanelAdmin.ColumnCount = 4;
			this.tableLayoutPanelAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelAdmin.Controls.Add(this.buttonEdit, 1, 0);
			this.tableLayoutPanelAdmin.Controls.Add(this.buttonAdd, 0, 0);
			this.tableLayoutPanelAdmin.Controls.Add(this.buttonDelete, 3, 0);
			this.tableLayoutPanelAdmin.Controls.Add(this.buttonViewDuties, 2, 0);
			this.tableLayoutPanelAdmin.Location = new System.Drawing.Point(3, 359);
			this.tableLayoutPanelAdmin.Name = "tableLayoutPanelAdmin";
			this.tableLayoutPanelAdmin.RowCount = 1;
			this.tableLayoutPanelAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelAdmin.Size = new System.Drawing.Size(675, 47);
			this.tableLayoutPanelAdmin.TabIndex = 0;
			// 
			// buttonEdit
			// 
			this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonEdit.Depth = 0;
			this.buttonEdit.Location = new System.Drawing.Point(173, 5);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(5);
			this.buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Primary = true;
			this.buttonEdit.Size = new System.Drawing.Size(158, 37);
			this.buttonEdit.TabIndex = 1;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAdd.Depth = 0;
			this.buttonAdd.Location = new System.Drawing.Point(5, 5);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
			this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Primary = true;
			this.buttonAdd.Size = new System.Drawing.Size(158, 37);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDelete.BackColor = System.Drawing.Color.Red;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.buttonDelete.Location = new System.Drawing.Point(509, 5);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(5);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(161, 37);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "DELETE";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonViewDuties
			// 
			this.buttonViewDuties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonViewDuties.Depth = 0;
			this.buttonViewDuties.Location = new System.Drawing.Point(341, 5);
			this.buttonViewDuties.Margin = new System.Windows.Forms.Padding(5);
			this.buttonViewDuties.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonViewDuties.Name = "buttonViewDuties";
			this.buttonViewDuties.Primary = true;
			this.buttonViewDuties.Size = new System.Drawing.Size(158, 37);
			this.buttonViewDuties.TabIndex = 3;
			this.buttonViewDuties.Text = "View all duties";
			this.buttonViewDuties.UseVisualStyleBackColor = true;
			this.buttonViewDuties.Click += new System.EventHandler(this.buttonViewDuties_Click);
			// 
			// buttonLogout
			// 
			this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogout.Location = new System.Drawing.Point(584, 28);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(96, 30);
			this.buttonLogout.TabIndex = 1;
			this.buttonLogout.Text = "Logout";
			this.buttonLogout.UseVisualStyleBackColor = true;
			this.buttonLogout.Click += new System.EventHandler(this.buttonLeave_Click);
			// 
			// labelPosition
			// 
			this.labelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.labelPosition.AutoSize = true;
			this.labelPosition.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPosition.Location = new System.Drawing.Point(124, 35);
			this.labelPosition.Name = "labelPosition";
			this.labelPosition.Size = new System.Drawing.Size(143, 16);
			this.labelPosition.TabIndex = 2;
			this.labelPosition.Text = "Your position: {pos}";
			// 
			// tableLayoutDuties
			// 
			this.tableLayoutDuties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutDuties.ColumnCount = 1;
			this.tableLayoutDuties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutDuties.Controls.Add(this.dutyList, 0, 0);
			this.tableLayoutDuties.Controls.Add(this.tableLayoutPanel1, 0, 1);
			this.tableLayoutDuties.Location = new System.Drawing.Point(2, 66);
			this.tableLayoutDuties.Name = "tableLayoutDuties";
			this.tableLayoutDuties.RowCount = 2;
			this.tableLayoutDuties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.71605F));
			this.tableLayoutDuties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.28395F));
			this.tableLayoutDuties.Size = new System.Drawing.Size(680, 405);
			this.tableLayoutDuties.TabIndex = 3;
			// 
			// dutyList
			// 
			this.dutyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dutyList.FullRowSelect = true;
			this.dutyList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.dutyList.HideSelection = false;
			this.dutyList.Location = new System.Drawing.Point(3, 3);
			this.dutyList.MultiSelect = false;
			this.dutyList.Name = "dutyList";
			this.dutyList.Size = new System.Drawing.Size(674, 328);
			this.dutyList.TabIndex = 0;
			this.dutyList.UseCompatibleStateImageBehavior = false;
			this.dutyList.View = System.Windows.Forms.View.Details;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.74481F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.2552F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 337);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 65);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.dateTimePicker, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.buttonApply, 0, 1);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(180, 59);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker.CustomFormat = "MM/yyyy";
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(3, 3);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.ShowCheckBox = true;
			this.dateTimePicker.ShowUpDown = true;
			this.dateTimePicker.Size = new System.Drawing.Size(174, 20);
			this.dateTimePicker.TabIndex = 1;
			// 
			// buttonApply
			// 
			this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonApply.Depth = 0;
			this.buttonApply.Location = new System.Drawing.Point(3, 32);
			this.buttonApply.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Primary = true;
			this.buttonApply.Size = new System.Drawing.Size(174, 24);
			this.buttonApply.TabIndex = 2;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.Controls.Add(this.buttonRemoveDuty, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.buttonAddDuty, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.buttonGoBack, 2, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(189, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(482, 59);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// buttonRemoveDuty
			// 
			this.buttonRemoveDuty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRemoveDuty.BackColor = System.Drawing.Color.Red;
			this.buttonRemoveDuty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRemoveDuty.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonRemoveDuty.ForeColor = System.Drawing.Color.White;
			this.buttonRemoveDuty.Location = new System.Drawing.Point(163, 3);
			this.buttonRemoveDuty.Name = "buttonRemoveDuty";
			this.buttonRemoveDuty.Size = new System.Drawing.Size(154, 53);
			this.buttonRemoveDuty.TabIndex = 1;
			this.buttonRemoveDuty.Text = "REMOVE DUTY";
			this.buttonRemoveDuty.UseVisualStyleBackColor = false;
			this.buttonRemoveDuty.Click += new System.EventHandler(this.buttonRemoveDuty_Click);
			// 
			// buttonAddDuty
			// 
			this.buttonAddDuty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddDuty.Depth = 0;
			this.buttonAddDuty.Location = new System.Drawing.Point(3, 3);
			this.buttonAddDuty.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonAddDuty.Name = "buttonAddDuty";
			this.buttonAddDuty.Primary = true;
			this.buttonAddDuty.Size = new System.Drawing.Size(154, 53);
			this.buttonAddDuty.TabIndex = 0;
			this.buttonAddDuty.Text = "Add Duty";
			this.buttonAddDuty.UseVisualStyleBackColor = true;
			this.buttonAddDuty.Click += new System.EventHandler(this.buttonAddDuty_Click);
			// 
			// buttonGoBack
			// 
			this.buttonGoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGoBack.Depth = 0;
			this.buttonGoBack.Location = new System.Drawing.Point(323, 3);
			this.buttonGoBack.MouseState = MaterialSkin.MouseState.HOVER;
			this.buttonGoBack.Name = "buttonGoBack";
			this.buttonGoBack.Primary = true;
			this.buttonGoBack.Size = new System.Drawing.Size(156, 53);
			this.buttonGoBack.TabIndex = 2;
			this.buttonGoBack.Text = "Go back";
			this.buttonGoBack.UseVisualStyleBackColor = true;
			this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 475);
			this.Controls.Add(this.labelPosition);
			this.Controls.Add(this.buttonLogout);
			this.Controls.Add(this.tableLayoutDuties);
			this.MinimumSize = new System.Drawing.Size(685, 475);
			this.Name = "Main";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WSB Hospital";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelAdmin.ResumeLayout(false);
			this.tableLayoutDuties.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdmin;
		private System.Windows.Forms.ListView employeeList;
		private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
		private MaterialSkin.Controls.MaterialRaisedButton buttonEdit;
		private MaterialSkin.Controls.MaterialRaisedButton buttonAdd;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label labelPosition;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
		private MaterialSkin.Controls.MaterialRaisedButton buttonViewDuties;
		private System.Windows.Forms.TableLayoutPanel tableLayoutDuties;
		private System.Windows.Forms.ListView dutyList;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel3;
		private MaterialSkin.Controls.MaterialRaisedButton buttonApply;
		private TableLayoutPanel tableLayoutPanel4;
		private MaterialSkin.Controls.MaterialRaisedButton buttonAddDuty;
		private Button buttonRemoveDuty;
		private MaterialSkin.Controls.MaterialRaisedButton buttonGoBack;
		private MaterialSkin.Controls.MaterialRaisedButton buttonViewAllDutiesCommon;
	}
}

