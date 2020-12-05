using MaterialSkin.Controls;
using System;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using HospitalEmployees;
using HospitalEmployees.Classes;
using System.Xml.Serialization;
using System.IO;
using System.Threading;
using HospitalEmployees.Common;
using HospitalEmployees.Enums;
using HospitalEmployees.Utils;

namespace HospitalExam
{
	public partial class Login : MaterialForm
	{
		HospitalStructure hospitalStructure;
		string filePath = "hospital.xml";
		public Login()
		{
			InitializeComponent();

			MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
			manager.AddFormToManage(this);
			manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;

			DeserializeData();
		}

		private void DeserializeData()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(HospitalStructure));

			if (!File.Exists(Directory.GetCurrentDirectory() + @"\" + filePath))
				createNewMainFile();

			try
			{
				StreamReader reader = new StreamReader(filePath);
				hospitalStructure = (HospitalStructure)serializer.Deserialize(reader);
				reader.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show(
					$"Error occured: {e.Message}.\nPlease delete or fix {filePath} file in folder with .exe file.",
					"Something went wrong...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				Environment.Exit(0);
			}
		}

		private void createNewMainFile()
		{
			hospitalStructure = new HospitalStructure();
			string salt = CryptographyProcessor.CreateSalt(hospitalStructure.SaltLength);
			Employee admin = new Employee(
				1,
				"Serhii",
				"Holishevskyi",
				"dnldcode",
				CryptographyProcessor.GenerateHash("password", salt),
				salt,
				Position.Administration);
			hospitalStructure.Employees.Add(admin);

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(HospitalStructure));
			try
			{
				using (FileStream fs = new FileStream(filePath, FileMode.Create))
				{
					xmlSerializer.Serialize(fs, hospitalStructure);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(
					$"Error occured: {e.Message}",
					"Something went wrong...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				Environment.Exit(0);
			}
		}

		private void loginInput_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(loginInput.Text))
				errorProvider1.SetError(loginInput, "Please enter your login!");
			else if (loginInput.Text.Length < 6)
				errorProvider1.SetError(loginInput, "Login should be at least 6 digits long!");
			else if (!CredentialsValidator.IsValid(loginInput.Text))
				errorProvider1.SetError(loginInput, "Login contains forbidden symbols!");
			else
				errorProvider1.SetError(loginInput, null);
		}

		private void passwordInput_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(passwordInput.Text))
				errorProvider1.SetError(passwordInput, "Please enter your password!");
			else if (passwordInput.Text.Length < 6)
				errorProvider1.SetError(passwordInput, "Password should be at least 6 digits long!");
			else if (!CredentialsValidator.IsValid(passwordInput.Text))
				errorProvider1.SetError(passwordInput, "Password contains forbidden symbols!");
			else
				errorProvider1.SetError(passwordInput, null);
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			if (errorProvider1.GetError(loginInput) == "" &&
				errorProvider1.GetError(passwordInput) == "" &&
				loginInput.Text.Trim() != "" &&
				passwordInput.Text.Trim() != "")
			{
				Employee currentUser = hospitalStructure.Employees.
					Where(user => user.Login == loginInput.Text).
					FirstOrDefault();

				if (currentUser == null)
				{
					MessageBox.Show(
						"No user found with given login.", "Something went wrong...",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}

				if (currentUser.IsBanned())
				{
					MessageBox.Show(
						"You are banned!",
						"Something went wrong...",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}

				if (CryptographyProcessor.AreEqual(passwordInput.Text, currentUser.Password, currentUser.Salt))
				{
					var t = new Thread(() => Application.Run(new Main(currentUser, hospitalStructure)));
					t.Start();

					Thread.Sleep(50);
					this.Close();
				}
				else
					MessageBox.Show(
						"Password is wrong! Please try again!",
						"Something went wrong...",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
			}
		}
	}
}
