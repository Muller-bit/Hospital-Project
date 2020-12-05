using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployees.Exceptions
{
	class WrongEmployeeException : Exception
	{
		public WrongEmployeeException() : base() { }
		public WrongEmployeeException(string message) : base(message) { }
	}
}
