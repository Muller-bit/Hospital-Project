using MaterialSkin.Controls;
using System;
using HospitalEmployees.Classes;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HospitalEmployees;
using HospitalEmployees.Enums;

namespace HospitalExam
{
	public partial class AddDuty : MaterialForm
	{
		public AddDuty()
		{
			InitializeComponent();

			dateTimePicker.Value = DateTime.Now;
			dateTimePicker.MinDate = DateTime.Now;

			loadEmployees();
		}

		private void buttonExit_Click(object sender, EventArgs e) => this.Close();

		private void loadEmployees()
		{
			foreach (Employee user in Main.HospitalStructure.Employees)
			{
				if (user.IsAdmin() || user.IsBanned()) continue;
				comboboxEmployees.Items.Add(user);
			}

			comboboxEmployees.SelectedIndex = 0;
		}

		private void comboboxEmployees_SelectedValueChanged(object sender, EventArgs e)
		{
			Employee user = comboboxEmployees.SelectedItem as Employee;
			labelPosition.Text = $"{user.TypeOfUser} - {user.Speciality}";
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			Employee user = comboboxEmployees.SelectedItem as Employee;

			DateTime pickedDate = new DateTime(
				dateTimePicker.Value.Year,
				dateTimePicker.Value.Month,
				dateTimePicker.Value.Day);

			Duty duty = new Duty(user.Id, pickedDate);

			if (Main.HospitalStructure.Duties.Any(d => d.Date == pickedDate.AddDays(1) && d.EmployeeId == user.Id) ||
				Main.HospitalStructure.Duties.Any(d => d.Date == pickedDate.AddDays(-1) && d.EmployeeId == user.Id) ||
				Main.HospitalStructure.Duties.Any(d => d.Date == pickedDate && d.EmployeeId == user.Id))
			{
				MessageBox.Show(
					"Employee cannot work 2 days in a row or twice in the same day! Please change date.",
					"Something went wrong...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}
			else if (user.TypeOfUser == Position.Doctor &&
				Main.HospitalStructure.Duties.Any(d => d.Date == pickedDate &&
					(Main.HospitalStructure.Employees
					.Where(em => em.Id == d.EmployeeId)
					.FirstOrDefault()).Speciality == user.Speciality))
			{
				MessageBox.Show(
					"Doctor with the same speciality is working on selected date!",
					"Something went wrong...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}
			else if (Main.HospitalStructure.Duties.Count(d => d.Date.Month == pickedDate.Month
														&& d.Date.Year == pickedDate.Year &&
														d.EmployeeId == user.Id) == 10)
			{
				MessageBox.Show(
					"Selected employee has already reached limit of 10 duties a month!",
					"Something went wrong...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			Main.HospitalStructure.Duties.Add(duty);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
