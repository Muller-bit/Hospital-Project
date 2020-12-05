using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HospitalEmployees.Classes
{
	[Serializable]
	[XmlRoot("HospitalStructure")]
	public class Duty
	{
		public int EmployeeId { get; set; }
		public DateTime Date { get; set; }

		public Duty(int employeeId, DateTime date)
		{
			this.EmployeeId = employeeId;
			this.Date = date;
		}

		public Duty() { }
	}
}
