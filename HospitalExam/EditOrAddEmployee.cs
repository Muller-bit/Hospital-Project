using HospitalEmployees;
using HospitalEmployees.Classes;
using HospitalEmployees.Enums;
using HospitalEmployees.Utils;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace HospitalExam
{
	public partial class EditOrAddEmployee : MaterialForm
	{
		Employee _currentEmployee;
		string state = "Edit";
		public EditOrAddEmployee(Employee employee)
		{
			InitializeComponent();

			_currentEmployee = employee;
			this.state = "Edit";

			this.Text += ". Employee id: " + employee.Id;

			loadComboboxes();

			idInput.Text = _currentEmployee.Id.ToString();
			nameInput.Text = _currentEmployee.Name;
			surnameInput.Text = _currentEmployee.Surname;
			loginInput.Text = _currentEmployee.Login;
			loginInput.Enabled = false;
			comboBoxPosition.SelectedItem = _currentEmployee.TypeOfUser;
			comboBoxSpeciality.SelectedItem = _currentEmployee.Speciality;
			if (_currentEmployee.TypeOfUser == Position.Doctor)
				gmcInput.Text = _currentEmployee.GMC;
			else
				gmcInput.Enabled = false;

			this.passwordInput.Hint = "Fill to change";

		}

		public EditOrAddEmployee()
		{
			InitializeComponent();
			this.state = "Add";

			this.Text = "Add";
			this.buttonMain.Text = "Add";


			for (int i = Main.HospitalStructure.Employees.Min(e => e.Id); i < int.MaxValue; i++)
			{
				if (!Main.HospitalStructure.Employees.Any(e => e.Id == i))
				{
					this.idInput.Text = i.ToString();
					break;
				}
			}

			loadComboboxes();
			comboBoxPosition.Items.Add(Position.Banned);

		}

		private void loadComboboxes()
		{
			if (this.state == "Edit" && _currentEmployee.Id == 1)
			{
				comboBoxPosition.SelectedIndexChanged -= comboBoxPosition_SelectedIndexChanged;
				comboBoxPosition.Items.Add(Position.Administration);
				comboBoxPosition.SelectedIndex = 0;
				comboBoxSpeciality.Items.Add(Speciality.None);

				if (Main.CurrentUserId != 1)
				{
					passwordInput.Enabled = false;
					nameInput.Enabled = false;
					surnameInput.Enabled = false;
					comboBoxPosition.Enabled = false;
					comboBoxSpeciality.Enabled = false;
				}
			}
			else
			{
				comboBoxPosition.Items.Add(Position.Doctor);
				comboBoxPosition.Items.Add(Position.Nurse);
				comboBoxPosition.Items.Add(Position.Administration);
				if (this.state == "Edit") comboBoxPosition.Items.Add(Position.Banned);
				comboBoxPosition.SelectedIndex = 1;
			}
		}

		private void buttonExit_Click(object sender, EventArgs e) => this.Close();

		private void nameInput_Validating(object sender, CancelEventArgs e)
		{
			string input = nameInput.Text;

			if (string.IsNullOrEmpty(input))
				errorProvider1.SetError(nameInput, "Please enter name!");
			else if (input.Length < 2)
				errorProvider1.SetError(nameInput, "Name should be at least 2 digits long!");
			else if (!CredentialsValidator.IsValid(input))
				errorProvider1.SetError(nameInput, "Name contains forbidden symbols!");
			else
				errorProvider1.SetError(nameInput, null);
		}

		private void surnameInput_Validating(object sender, CancelEventArgs e)
		{
			string input = surnameInput.Text;

			if (string.IsNullOrEmpty(input))
				errorProvider1.SetError(surnameInput, "Please enter surname!");
			else if (input.Length < 2)
				errorProvider1.SetError(surnameInput, "Surname should be at least 2 digits long!");
			else if (!CredentialsValidator.IsValid(input))
				errorProvider1.SetError(surnameInput, "Surname contains forbidden symbols!");
			else
				errorProvider1.SetError(surnameInput, null);
		}

		private void loginInput_Validating(object sender, CancelEventArgs e)
		{
			string input = loginInput.Text;

			if (string.IsNullOrEmpty(input))
				errorProvider1.SetError(loginInput, "Please enter your login!");
			else if (input.Length < 6)
				errorProvider1.SetError(loginInput, "Login should be at least 6 digits long!");
			else if (!CredentialsValidator.IsValid(input))
				errorProvider1.SetError(loginInput, "Login contains forbidden symbols!");
			else if (Main.HospitalStructure.Employees.Any(any => any.Login == input))
				errorProvider1.SetError(loginInput, "This login is already used!");
			else
				errorProvider1.SetError(loginInput, null);
		}

		private void passwordInput_Validating(object sender, CancelEventArgs e)
		{
			string input = passwordInput.Text;

			if (this.state == "Edit" && input == "")
				errorProvider1.SetError(passwordInput, null);
			else if (string.IsNullOrEmpty(input))
				errorProvider1.SetError(passwordInput, "Please enter your password!");
			else if (input.Length < 6)
				errorProvider1.SetError(passwordInput, "Password should be at least 6 digits long!");
			else if (!CredentialsValidator.IsValid(input))
				errorProvider1.SetError(passwordInput, "Password contains forbidden symbols!");
			else
				errorProvider1.SetError(passwordInput, null);
		}

		private void gmcInput_Validating(object sender, CancelEventArgs e)
		{
			string input = gmcInput.Text;

			if (string.IsNullOrEmpty(input))
				errorProvider1.SetError(gmcInput, "Please enter GMC Number!");
			else if (input.Length != 7)
				errorProvider1.SetError(gmcInput, "GMC should be 7 digits long!");
			else if (!CredentialsValidator.IsValid(input))
				errorProvider1.SetError(gmcInput, "GMC contains forbidden symbols!");
			else if (Main.HospitalStructure.Employees.Any(any => any.GMC != null && any.GMC == input))
			{
				if (this.state == "Edit" && _currentEmployee.GMC == input)
					errorProvider1.SetError(gmcInput, null);
				else
					errorProvider1.SetError(gmcInput, "This GMC is already used!");
			}
			else
				errorProvider1.SetError(gmcInput, null);
		}

		private void buttonMain_Click(object sender, EventArgs e)
		{
			if (errorProvider1.GetError(nameInput) == "" &&
				errorProvider1.GetError(surnameInput) == "" &&
				errorProvider1.GetError(loginInput) == "" &&
				errorProvider1.GetError(passwordInput) == "" &&
				errorProvider1.GetError(gmcInput) == "" &&
				nameInput.Text.Trim() != "" &&
				surnameInput.Text.Trim() != "" &&
				loginInput.Text.Trim() != "" &&
				(passwordInput.Text.Trim() != "" || this.state == "Edit") &&
				(gmcInput.Text.Trim() != "" || ((Position)comboBoxPosition.SelectedItem != Position.Doctor)))
			{

				if (this.state == "Add")
				{
					string salt = CryptographyProcessor.CreateSalt(Main.HospitalStructure.SaltLength);

					Position type = (Position)comboBoxPosition.SelectedItem;
					Speciality speciality = (Speciality)comboBoxSpeciality.SelectedItem;
					string gmc = gmcInput.Text == "" ? null : gmcInput.Text;

					Employee user = new Employee(
						int.Parse(idInput.Text),
						nameInput.Text,
						surnameInput.Text,
						loginInput.Text,
						CryptographyProcessor.GenerateHash(passwordInput.Text, salt),
						salt,
						type,
						speciality,
						gmc);

					Main.HospitalStructure.Employees.Add(user);

					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else if (this.state == "Edit")
				{
					Position type = (Position)comboBoxPosition.SelectedItem;
					Speciality speciality = (Speciality)comboBoxSpeciality.SelectedItem;
					string gmc = gmcInput.Text == "" ? null : gmcInput.Text;

					if ((_currentEmployee.TypeOfUser == Position.Doctor || _currentEmployee.TypeOfUser == Position.Nurse) &&
						(type == Position.Administration || type == Position.Banned))
					{
						if (MessageBox.Show(
							$"Position has been changed from {_currentEmployee.TypeOfUser} to {type}. Do you want to delete all duties of employee?",
							"Question",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Question) == DialogResult.Yes)
						{
							List<Duty> listToDelete = new List<Duty>();

							foreach (Duty d in Main.HospitalStructure.Duties)
							{
								if (d.EmployeeId == _currentEmployee.Id)
									listToDelete.Add(d);
							}

							foreach (Duty d in listToDelete)
								Main.HospitalStructure.Duties.Remove(d);
						}
					}

					_currentEmployee.Name = nameInput.Text;
					_currentEmployee.Surname = surnameInput.Text;

					if (passwordInput.Text != "")
						_currentEmployee.Password
							= CryptographyProcessor.GenerateHash(
								passwordInput.Text,
								_currentEmployee.Salt);

					_currentEmployee.TypeOfUser = type;
					_currentEmployee.Speciality = speciality;
					_currentEmployee.GMC = gmc;

					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
		}

		private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxSpeciality.Items.Clear();

			if (comboBoxPosition.SelectedIndex == 0)
			{
				comboBoxSpeciality.Items.Add(Speciality.Cardiologist);
				comboBoxSpeciality.Items.Add(Speciality.Urologist);
				comboBoxSpeciality.Items.Add(Speciality.Neurologist);
				comboBoxSpeciality.Items.Add(Speciality.Laryngologist);

				gmcInput.Text = new Random().Next(0, 9999999).ToString("D7");
				gmcInput.Enabled = true;
			}
			else
			{
				comboBoxSpeciality.Items.Add(Speciality.None);
				gmcInput.Text = "";
				gmcInput.Enabled = false;
				errorProvider1.SetError(gmcInput, null);
			}

			comboBoxSpeciality.SelectedIndex = 0;
		}
	}
}
