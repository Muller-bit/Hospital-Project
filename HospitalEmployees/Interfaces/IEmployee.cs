using HospitalEmployees.Classes;
using HospitalEmployees.Enums;
using HospitalEmployees.Exceptions;
using System;
using System.Xml.Serialization;

namespace HospitalEmployees.Interfaces
{
	public interface IEmployee
	{
		int Id { get; set; }
		string Name { get; set; }
		string Surname { get; set; }
		string Login { get; set; }
		string Password { get; set; }
		string Salt { get; set; }
		Position TypeOfUser { get; set; }
		Speciality Speciality { get; set; }
		string GMC { get; set; }
		bool IsAdmin();
		bool IsBanned();
		string ToString();
	}
}
