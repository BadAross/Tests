using System;

namespace Testing.Classes.Performers
{
    internal class Generat_Password
    {
        private static string Generated_Password()
        {
            var rnd = new Random();
            var password = string.Empty;
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                             "abcdefghijklmnopqrstuvwxyz" +
                             "0123456789" +
                             "!@#$%^*_+-=?/";

            for (int i = 0; i < 12; ++i)
            {
                password += symbols[rnd.Next(symbols.Length)];
            }
            return password;
        }

        public static string Returns_Generated_Password()
        {
            string password;

            do
            {
                password = Generated_Password();
            }
            while (!Checking_Password_Reliability.Checks_Strength_Password(password));

            return password;
        }
    }
}
