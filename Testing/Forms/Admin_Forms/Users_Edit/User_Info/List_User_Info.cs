using System;
using System.Collections.Generic;
using System.Data;
using Testing.Class;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Users_Edit.User_Info
{
    internal class List_User_Info
    {
        public readonly List<User> users;

        public List_User_Info()
        {
            users = Fills_List_With_Data_From_Database(Unloads_Data_From_Database());
        }

        private DataSet Unloads_Data_From_Database()
        {
            var query = @"select
                  Id_User
                , Full_Name_User
                , Code_Group
                , Login_User
                , Password_User
                from Users
                join Groups on Id_Group = Group_Id";
            return Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
        }

        private List<User> Fills_List_With_Data_From_Database(DataSet dataSet)
        {
            var list_Users = new List<User>();
            var user = new User();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                user.id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id_User"]);
                user.full_Name = Convert.ToString(dataSet.Tables[0].Rows[i]["Full_Name_User"]);
                user.code_Group = Convert.ToString(dataSet.Tables[0].Rows[i]["Code_Group"]);
                user.login = Convert.ToString(dataSet.Tables[0].Rows[i]["Login_User"]);
                user.password = Convert.ToString(dataSet.Tables[0].Rows[i]["Password_User"]);

                list_Users.Add(user);
            }
            return list_Users;
        }
    }
}
