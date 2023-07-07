using System.Security.Cryptography;
using System.Text;

namespace Testing.Classes.Performers
{
    internal class Hash_Password
    {
        public static string Retern_Hesh_Password(string password)
        {
            var sb = new StringBuilder();
            MD5 md5 = MD5.Create();

            byte[] array_Bytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(array_Bytes);

            foreach (byte b in hash)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
