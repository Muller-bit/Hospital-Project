using HospitalEmployees.Interfaces;
using HospitalEmployees.Enums;
using HospitalEmployees.Exceptions;
using System;
using System.Xml.Serialization;
using HospitalEmployees.Utils;

namespace HospitalEmployees.Classes
{
	[Serializable]
	[XmlRoot("HospitalStructure")]
	public class Employee : IEmployee
	{
		private int _id;
		public int Id
		{
			get => _id;
			set
			{
				if (value <= 0)
					throw new InvalidDataException("Id is less than 0.");
				this._id = value;
			}
		}

		private string _name;
		public string Name
		{
			get => _name;
			set
			{
				if (value.Split(' ').Length != 1 || value.Trim().Length < 2)
					throw new InvalidDataException("Invalid Name provided");
				this._name = value;
			}
		}
		private string _surname;
		public string Surname
		{
			get => _surname; set
			{
				if (value.Split(' ').Length != 1 || value.Length < 2)
					throw new InvalidDataException("Invalid Surname provided. Surname should be at least 2 symbols long");
				this._surname = value;
			}
		}

		private string _login;
		public string Login
		{
			get => _login;
			/*private*/ set
			{
				if (!CredentialsValidator.IsValid(value) || value.Length < 6)
					throw new InvalidDataException("Invalid login provided.");
				this._login = value;
			}
		}

		private string _password;
		public string Password
		{
			get => _password;
			set
			{
				if (!CredentialsValidator.IsValid(value) || value.Length < 6)
					throw new InvalidDataException("Invalid password provided.");
				this._password = value;
			}
		}

		private string _salt;
		public string Salt
		{
			get => _salt;
			set
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new InvalidDataException("Invalid salt provided. Salt should not be empty.");
				this._salt = value;
			}
		}
		public Position TypeOfUser { get; set; }

		private Speciality _speciality;
		public Speciality Speciality
		{
			get => _speciality;
			set
			{
				if (this.TypeOfUser != Position.Doctor && value != Speciality.None)
					throw new InvalidDataException("Unable to give speciality to not Doctor.");
				if (this.TypeOfUser == Position.Doctor && value == Speciality.None)
					throw new InvalidDataException("Unable to give create Doctor with no Speciality.");
				this._speciality = value;
			}
		}

		private string _gmc;
		public string GMC
		{
			get => _gmc;
			set
			{
				if (value == null)
					this._gmc = value;
				else if (this.TypeOfUser != Position.Doctor)
					throw new InvalidDataException("Unable to assign GMC value to not Doctor.");
				else if (value.Length != 7)
					throw new InvalidDataException("GMC number should be exactly 7 digits.");
				else if (!CredentialsValidator.IsValid(value))
					throw new InvalidDataException("GMC number contains forbidden symbols.");
				else this._gmc = value;
			}
		}

		public Employee(int id, string name, string surname, string login, string password, string salt, Position type, Speciality speciality = Speciality.None, string gmc = null)
		{
			if (type == Position.Banned)
				throw new InvalidDataException("Invalid type provided. Unable to add banned user.");

			this.Id = id;
			this.Name = name;
			this.Surname = surname;
			this.Login = login;
			this.Password = password;
			this.Salt = salt;
			this.TypeOfUser = type;
			this.Speciality = speciality;
			this.GMC = gmc;
		}

		public Employee() { }

		public bool IsAdmin()
		{
			return this.TypeOfUser == Position.Administration;
		}

		public bool IsBanned()
		{
			return this.TypeOfUser == Position.Banned;
		}

		public override string ToString()
		{
			return $"{this.Name} {this.Surname}";
		}
	}
}
