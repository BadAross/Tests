using System.Data.SqlClient;
using Testing.Class;

namespace Testing.Classes
{
    internal class DataBase_Editor
    {
        public static void Edited_Information_To_DataBase(string SQL_Command)
        {
            var dbCon = new DataBase_Conected();
            var cmd = new SqlCommand();
            dbCon.OpenConneciton();
            cmd.Connection = dbCon.GetConnection();
            cmd.CommandText = SQL_Command;
            cmd.ExecuteNonQuery();
            dbCon.CloseConneciton();
        }
    }
}
