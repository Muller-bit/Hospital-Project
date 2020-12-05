using HospitalEmployees.Classes;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace HospitalEmployees.Common
{
	[Serializable]
	public class HospitalStructure
	{
		[XmlArray("Employees"), XmlArrayItem(typeof(Employee), ElementName = "Employee")]
		public List<Employee> Employees = new List<Employee>();

		[XmlArray("Duties"), XmlArrayItem(typeof(Duty), ElementName = "Duty")]
		public List<Duty> Duties = new List<Duty>();

		public int SaltLength = 10;

		public void SortDutiesList()
		{
			Duties.Sort((x, y) => x.Date.CompareTo(y.Date));
		}

		public void SortEmployees()
		{
			Employees.Sort((x, y) => x.Id.CompareTo(y.Id));
		}
	}
}
