using System.Windows.Forms;
using Testing.Classes;
using Testing.Struct;

namespace Testing.Forms.General_Forms.Registration
{
    public static class Save_Account
    {
        public static void Save_User_Account(User user, int id_Group)
        {
            Registers_Account(@"insert
                        into Users (
                          Full_Name_User
                        , Group_Id
                        , Login_User
                        , Password_User
                        ) values ('" + user.full_Name + "'," + id_Group + ", '" + user.login + "', '" + user.password + "')");
        }

        public static void Save_Tester_Account(Tester tester)
        {
            Registers_Account(@"insert
                        into Testers (
                          Full_Name_Tester
                        , Login_Tester
                        , Password_Tester
                        ) values ('" + tester.full_Name + "', '" + tester.login + "', '" + tester.password + "')");
        }

        private static void Registers_Account(string add_Entry_Sql_Command)
        {
            DataBase_Editor.Edited_Information_To_DataBase(add_Entry_Sql_Command);
            MessageBox.Show("Аккаунт добавлен!");
        }
    }
}
