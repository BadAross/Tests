using System.Collections.Generic;
using System.Linq;
using Testing.Classes;
using Testing.Forms.Enum;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Users_Edit.User_Editing
{
    internal class Save_User_Change
    {
        private readonly List<User> _users;
        private readonly List<Group> _groups;
        private readonly List<int> _id_User_Delete;

        public Save_User_Change(List<User> users, List<Group> groups, List<int> id_User_Delete)
        {
            _users = users;
            _groups = groups;
            _id_User_Delete = id_User_Delete;
            Iterates_Through_List_Users();
            Deletes_Selected_Users();
        }

        private int Returns_Id_Selected_Group(User user)
        {
            foreach (var group in _groups.Where(x => x.code == user.code_Group))
            {
                return group.id;
            }
            return -1;
        }

        private void Iterates_Through_List_Users()
        {
            for (var i = 0; i < _users.Count; i++)
            {
                if (_users[i].type_Change == (byte)Type_Change.Add)
                {
                    Adds_User(_users[i]);
                }
                else if (_users[i].type_Change == (byte)Type_Change.Modified)
                {
                    Change_User(_users[i]);
                }
            }
        }

        private void Adds_User(User user)
        {
            var id_Group = Returns_Id_Selected_Group(user);
            DataBase_Editor.Edited_Information_To_DataBase(@"insert into Users (
                  Full_Name_User
                , Group_Id
                , Login_User
                , Password_User
                ) values ('" + user.full_Name + "'," + id_Group + ", '" + user.login + "', '" + user.password + "')");
        }

        private void Change_User(User user)
        {
            var id_Group = Returns_Id_Selected_Group(user);
            DataBase_Editor.Edited_Information_To_DataBase(@"update Users set
                 Full_Name_User = '" + user.full_Name + "', " +
                "Group_Id = " + id_Group + ", " +
                "Login_User = '" + user.login + "', " +
                "Password_User = '" + user.password + "' " +
                "Where Id_User =" + user.id + "");
        }

        private void Deletes_Selected_Users()
        {
            for (var i = 0; i < _id_User_Delete.Count; i++)
            {
                DataBase_Editor.Edited_Information_To_DataBase(@"delete
                    from Users
                    where Id_User = " + _id_User_Delete[i] + "");
            }
        }
    }
}
