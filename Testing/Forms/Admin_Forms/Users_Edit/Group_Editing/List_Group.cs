using System;
using System.Collections.Generic;
using System.Data;
using Testing.Class;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Users_Edit.Group_Editing
{
    internal class List_Group
    {
        public List<Group> Groups { get; set; }

        public List_Group()
        {
            Groups = Fills_List_Group(Unloads_Groups());
        }

        private DataSet Unloads_Groups()
        {
            var query = @"select
                  Id_Group
                , Code_Group
                from Groups";

            return Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
        }

        private List<Group> Fills_List_Group(DataSet dataSet)
        {
            var list_Groups = new List<Group>();
            var group = new Group();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                group.id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id_Group"]);
                group.code = Convert.ToString(dataSet.Tables[0].Rows[i]["Code_Group"]);

                list_Groups.Add(group);
            }
            return list_Groups;
        }
    }
}
