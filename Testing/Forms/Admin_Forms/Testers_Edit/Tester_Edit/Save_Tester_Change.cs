using System.Collections.Generic;
using Testing.Classes;
using Testing.Forms.Enum;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Testers_Edit.Tester_edit
{
    internal class Save_Tester_Change
    {
        private readonly List<Tester> _testers;
        private readonly List<int> _id_Tester_Delete;

        public Save_Tester_Change(List<Tester> testers, List<int> id_Tester_Delete)
        {
            _testers = testers;
            _id_Tester_Delete = id_Tester_Delete;
            Iterates_Through_List_Tester();
            Deletes_Selected_Tester();
        }

        private void Adds_Tester(Tester tester)
        {
            DataBase_Editor.Edited_Information_To_DataBase(@"insert into Testers (
                  Full_Name_Tester
                , Login_Tester
                , Password_Tester
                ) values ('" + tester.full_Name + "', '" + tester.login + "', '" + tester.password + "')");
        }
        private void Change_Taster(Tester tester)
        {
            DataBase_Editor.Edited_Information_To_DataBase("update Testers set " +
                "Full_Name_Tester = '" + tester.full_Name + "'," +
                "Login_Tester = '" + tester.login + "', " +
                "Password_Tester = '" + tester.password + "' " +
                "Where Id_Tester =" + tester.id + "");
        }

        private void Deletes_Selected_Tester()
        {
            for (var i = 0; i < _id_Tester_Delete.Count; i++)
            {
                DataBase_Editor.Edited_Information_To_DataBase(@"delete
                    from Testers
                    where Id_Tester = " + _id_Tester_Delete[i] + "");
            }
        }

        private void Iterates_Through_List_Tester()
        {
            for (var i = 0; i < _testers.Count; i++)
            {
                if (_testers[i].type_Change == (byte)Type_Change.Add)
                {
                    Adds_Tester(_testers[i]);
                }
                else if (_testers[i].type_Change == (byte)Type_Change.Modified)
                {
                    Change_Taster(_testers[i]);
                }
            }
        }
    }
}
