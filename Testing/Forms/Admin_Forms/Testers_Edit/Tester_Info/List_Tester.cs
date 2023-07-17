using System;
using System.Collections.Generic;
using System.Data;
using Testing.Class;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Testers_Edit.Tester_Info
{
    internal class List_Tester
    {
        public readonly List<Tester> testers;

        public List_Tester()
        {
            testers = Fills_list_With_Data_From_Database(Unloads_Data_From_Database());
        }

        private DataSet Unloads_Data_From_Database()
        {
            var query = "select Id_Tester, Full_Name_Tester, Login_Tester, Password_Tester from Testers";
            return Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
        }

        private List<Tester> Fills_list_With_Data_From_Database(DataSet dataSet)
        {
            var list_Testers = new List<Tester>();
            var tester = new Tester();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                tester.id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id_Tester"]);
                tester.full_Name = Convert.ToString(dataSet.Tables[0].Rows[i]["Full_Name_Tester"]);
                tester.login = Convert.ToString(dataSet.Tables[0].Rows[i]["Login_Tester"]);
                tester.password = Convert.ToString(dataSet.Tables[0].Rows[i]["Password_Tester"]);

                list_Testers.Add(tester);
            }
            return list_Testers;
        }
    }
}
