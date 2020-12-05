using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployees.Exceptions
{
	class IncorrectDateException : Exception
	{
		public IncorrectDateException() : base() { }
		public IncorrectDateException(string message) : base(message) { }
	}
}
