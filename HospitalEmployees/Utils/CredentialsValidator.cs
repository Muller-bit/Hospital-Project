namespace HospitalEmployees.Utils
{
	static public class CredentialsValidator
	{
        static char[] forbiddenSymbols = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', ' ', ';' };

        public static bool IsValid(string password)
        {
            return password.IndexOfAny(forbiddenSymbols) == -1;
        }
    }
}
