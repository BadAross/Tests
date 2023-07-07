using System.Text.RegularExpressions;

namespace Testing.Classes
{
    public class Checking_Password_Reliability
    {
        public static bool Checks_Strength_Password(string password)
        {
            var numbers = new Regex(@"[0-9]+");
            var upper_Chars = new Regex(@"[A-Z]+");
            var password_Length = new Regex(@".{8,}");

            return numbers.IsMatch(password) & upper_Chars.IsMatch(password) & password_Length.IsMatch(password);
        }
    }
}