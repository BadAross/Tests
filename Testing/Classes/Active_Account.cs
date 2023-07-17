using System;
using System.Data;
using Testing.Struct;

namespace Testing.Classes
{
    public static class Active_Account
    {
        private static Account active_Account;

        public static void Saves_Data_Active_Account(DataSet dataSet, string name_Column_Id, string name_Column_Full_Name)
        {
            active_Account.id = Convert.ToInt32(dataSet.Tables[0].Rows[0][name_Column_Id]);
            active_Account.full_Name = Convert.ToString(dataSet.Tables[0].Rows[0][name_Column_Full_Name]);
        }

        public static int Returns_Id_Active_Account()
        {
            return active_Account.id;
        }

        public static string Returns_full_Name_Active_Account()
        {
            return active_Account.full_Name;
        }

        public static void Clears_Data_Active_Account()
        {
            active_Account.id = 0;
            active_Account.full_Name = string.Empty;
        }
    }
}
