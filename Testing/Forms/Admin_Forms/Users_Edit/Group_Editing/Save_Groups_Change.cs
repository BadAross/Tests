using System.Collections.Generic;
using Testing.Classes;
using Testing.Forms.Enum;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Users_Edit.Group_Editing
{
    internal class Save_Groups_Change
    {
        private readonly List<Group> _groups;
        private readonly List<int> _id_Groups_Delete;

        public Save_Groups_Change(List<Group> groups, List<int> id_Groups_Delete)
        {
            _groups = groups;
            _id_Groups_Delete = id_Groups_Delete;
            Iterates_Through_List_Groups();
            Deletes_Selected_Groups();
        }

        private void Iterates_Through_List_Groups()
        {
            for (var i = 0; i < _groups.Count; i++)
            {
                if (_groups[i].type_Change == (byte)Type_Change.Add)
                {
                    Adds_Group(_groups[i]);
                }
                else if (_groups[i].type_Change == (byte)Type_Change.Modified)
                {
                    Change_Group(_groups[i]);
                }
            }
        }

        private void Adds_Group(Group group)
        {
            DataBase_Editor.Edited_Information_To_DataBase(@"insert 
                into Groups (
                  Code_Group
                ) values ('" + group.code + "')");
        }

        private void Change_Group(Group group)
        {
            DataBase_Editor.Edited_Information_To_DataBase("update Groups set " +
                "Code_Group = '" + group.code + "' " +
                "Where Id_Group =" + group.id + "");
        }

        private void Deletes_Selected_Groups()
        {
            for (var i = 0; i < _id_Groups_Delete.Count; i++)
            {
                DataBase_Editor.Edited_Information_To_DataBase(@"delete
                    from Groups
                    where Id_Group = " + _id_Groups_Delete[i] + "");
            }
        }
    }
}
