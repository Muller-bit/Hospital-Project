using System;

namespace HospitalEmployees.Exceptions
{
	class InvalidDataException : Exception
	{
		public InvalidDataException() : base() { }
		public InvalidDataException(string message) : base(message) { }
	}
}
