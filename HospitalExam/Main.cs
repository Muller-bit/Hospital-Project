using HospitalEmployees;
using HospitalEmployees.Classes;
using HospitalEmployees.Common;
using HospitalEmployees.Enums;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HospitalExam
{
	public partial class Main : MaterialForm
	{
		static public HospitalStructure HospitalStructure;
		private Employee _currentEmployee;
		static public int CurrentUserId;
		bool logout = false;

		public Main(Employee currentUser, HospitalStructure hospitalStructure)
		{
			InitializeComponent();

			MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
			manager.AddFormToManage(this);
			manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
			this.Sizable = true;

			_currentEmployee = currentUser;
			CurrentUserId = currentUser.Id;
			HospitalStructure = hospitalStructure;

			labelPosition.BackColor = Color.FromArgb(55, 71, 79);
			labelPosition.ForeColor = Color.White;
			labelPosition.Text = labelPosition.Text.Replace("{pos}", _currentEmployee.TypeOfUser.ToString());
			if (!_currentEmployee.IsAdmin())
				labelPosition.Text += $" - {_currentEmployee.Speciality}";
			dateTimePicker.Value = DateTime.Now;

			loadEmployees();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!logout &&
				MessageBox.Show(
					"Are you sure that you want to exit?",
					"Question",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question) != DialogResult.Yes)
			{
				e.Cancel = true;
				return;
			}

			if (HospitalStructure == null || _currentEmployee == null) return;

			SerializeData();
		}

		private void SerializeData()
		{

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(HospitalStructure));

			using (FileStream fs = new FileStream("hospital.xml", FileMode.Create))
				xmlSerializer.Serialize(fs, HospitalStructure);
		}

		private void employeeList_DoubleClick(object sender, EventArgs e)
		{
			if (_currentEmployee.IsAdmin())
				this.buttonEdit_Click(sender, e);
		}

		private void loadEmployees()
		{
			this.Controls.Remove(this.tableLayoutDuties);
			this.Controls.Add(this.tableLayoutPanelMain);

			if (_currentEmployee.IsAdmin())
			{
				this.tableLayoutPanelMain.Controls.Remove(this.buttonViewAllDutiesCommon);
				this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelAdmin, 0, 1);
			}
			else
			{
				this.tableLayoutPanelMain.Controls.Remove(this.tableLayoutPanelAdmin);
				this.tableLayoutPanelMain.Controls.Add(this.buttonViewAllDutiesCommon, 0, 1);
			}

			HospitalStructure.SortEmployees();
			employeeList.Columns.Clear();
			employeeList.View = View.Details;
			employeeList.Columns.Add("Id", 50);
			employeeList.Columns.Add("Name", 130);
			employeeList.Columns.Add("Surname", 130);
			if (_currentEmployee.IsAdmin())
				employeeList.Columns.Add("Login", 130);
			employeeList.Columns.Add("Position", 130);
			employeeList.Columns.Add("Speciality", 130);
			if (_currentEmployee.IsAdmin() || _currentEmployee.TypeOfUser == Position.Doctor)
				employeeList.Columns.Add("GMC", 80);

			employeeList.Items.Clear();

			foreach (Employee user in HospitalStructure.Employees)
			{
				if (user.IsAdmin() && !_currentEmployee.IsAdmin()) continue;

				ListViewItem lvi = new ListViewItem(user.Id.ToString());
				lvi.SubItems.Add(user.Name);
				lvi.SubItems.Add(user.Surname);
				if (_currentEmployee.IsAdmin())
					lvi.SubItems.Add(user.Login);
				lvi.SubItems.Add(user.TypeOfUser.ToString());
				lvi.SubItems.Add(user.Speciality.ToString());
				if (_currentEmployee.IsAdmin() || _currentEmployee.TypeOfUser == Position.Doctor)
					lvi.SubItems.Add(user.GMC == null ? "None" : user.GMC);
				employeeList.Items.Add(lvi);
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (!_currentEmployee.IsAdmin()) return;

			if (new EditOrAddEmployee().ShowDialog() == DialogResult.OK)
				this.loadEmployees();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (!_currentEmployee.IsAdmin()) return;

			if (employeeList.SelectedItems.Count == 0)
			{
				MessageBox.Show(
					"You have not selected any employee to edit!",
					"Something went wrong...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}
			Employee user = HospitalStructure.Employees
				.Where(em => em.Id.ToString() == employeeList.SelectedItems[0].SubItems[0].Text)
				.FirstOrDefault();

			if (new EditOrAddEmployee(user).ShowDialog() == DialogResult.OK)
				this.loadEmployees();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (!_currentEmployee.IsAdmin()) return;

			if (employeeList.SelectedItems.Count == 0)
			{
				MessageBox.Show(
					"You have not selected any employee to delete!",
					"Something went wrong...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}
			Employee user = HospitalStructure.Employees
				.Where(em => em.Id.ToString() == employeeList.SelectedItems[0].SubItems[0].Text)
				.FirstOrDefault();

			if (MessageBox.Show(
				$"Are you sure that you want delete user with name {user.Name} {user.Surname}?\nAll duties will be deleted as well.",
				"Question", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (user.Id == 1)
					return;

				HospitalStructure.Employees.Remove(user);

				if (user == _currentEmployee)
				{
					this.logout = true;
					this.Close();
				}

				List<Duty> listToDelete = new List<Duty>();

				foreach(Duty d in HospitalStructure.Duties)
				{
					if (d.EmployeeId == user.Id)
						listToDelete.Add(d);
				}

				foreach (Duty d in listToDelete)
					HospitalStructure.Duties.Remove(d);

				loadEmployees();
			}
		}

		private void buttonLeave_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(
				"Are you sure that you want to log out?",
				"Question",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				SerializeData();

				var t = new Thread(() => Application.Run(new Login()));
				t.Start();

				Thread.Sleep(50);
				logout = true;
				this.Close();
			}
		}

		private void loadDuties()
		{
			this.Controls.Remove(this.tableLayoutPanelMain);
			this.Controls.Add(this.tableLayoutDuties);

			if (!_currentEmployee.IsAdmin())
			{
				this.buttonAddDuty.Visible = false;
				this.buttonRemoveDuty.Visible = false;
			}

			dutyList.Columns.Clear();
			dutyList.View = View.Details;
			dutyList.Columns.Add("Employee", 130);
			dutyList.Columns.Add("Position", 130);
			dutyList.Columns.Add("Speciality", 130);
			dutyList.Columns.Add("Date", 130);

			dutyList.Items.Clear();

			HospitalStructure.SortDutiesList();
			foreach (Duty duty in HospitalStructure.Duties)
			{
				Employee user = HospitalStructure.Employees
						.Where(em => em.Id == duty.EmployeeId)
						.FirstOrDefault();

				if (dateTimePicker.Checked)
				{
					DateTime current = dateTimePicker.Value;
					if (current.Year != duty.Date.Year || current.Month != duty.Date.Month) continue;
				}

				ListViewItem lvi = new ListViewItem($"{user.Name} {user.Surname}");
				lvi.SubItems.Add(user.TypeOfUser.ToString());
				lvi.SubItems.Add(user.Speciality.ToString());
				lvi.SubItems.Add(duty.Date.ToString("dd/MM/yyyy"));
				lvi.Tag = HospitalStructure.Duties.IndexOf(duty);
				dutyList.Items.Add(lvi);
			}
		}

		private void buttonApply_Click(object sender, EventArgs e) => loadDuties();

		private void buttonRemoveDuty_Click(object sender, EventArgs e)
		{
			if (!_currentEmployee.IsAdmin()) return;

			if (dutyList.SelectedItems.Count == 0)
			{
				MessageBox.Show(
					"You have not selected any duty to delete!",
					"Something went wrong...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			Duty duty = HospitalStructure.Duties[int.Parse(dutyList.SelectedItems[0].Tag.ToString())];
			Employee user = HospitalStructure.Employees
					.Where(em => em.Id == duty.EmployeeId)
					.FirstOrDefault();

			if (MessageBox.Show(
				$"Are you sure that you want delete duty of {user.Name} {user.Surname}. Date: {duty.Date.ToShortDateString()}?",
				"Question", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				HospitalStructure.Duties.Remove(duty);
				loadDuties();
			}
		}

		private void buttonAddDuty_Click(object sender, EventArgs e)
		{
			if (!_currentEmployee.IsAdmin()) return;

			if (HospitalStructure.Employees.Count(em => !em.IsAdmin() && !em.IsBanned()) == 0)
			{
				MessageBox.Show(
					"There are no employees.",
					"Something went wrong",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				return;
			}

			if (new AddDuty().ShowDialog() == DialogResult.OK)
				loadDuties();
		}

		private void buttonViewDuties_Click(object sender, EventArgs e) => loadDuties();

		private void buttonGoBack_Click(object sender, EventArgs e) => loadEmployees();

		private void buttonViewAllDutiesCommon_Click(object sender, EventArgs e) => loadDuties();
	}
}