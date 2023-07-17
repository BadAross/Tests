using System;
using System.Collections.Generic;
using System.Data;
using Testing.Class;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Tests_Edit
{
    internal class List_Tests
    {
        public readonly List<Test> tests;

        public List_Tests()
        {
            tests = Fills_List_With_Data_From_Database(Unloads_Data_From_Database());
        }

        private DataSet Unloads_Data_From_Database()
        {
            var query = @"select
                  Id_Test
                , Name_Test
                , Full_Name_Tester
                , Time_Complete
                from Tests join Testers on Id_Tester = Tester_Id";
            return Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
        }

        private List<Test> Fills_List_With_Data_From_Database(DataSet dataSet)
        {
            var list_Tests = new List<Test>();
            var test = new Test();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                test.id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id_Test"]);
                test.name = Convert.ToString(dataSet.Tables[0].Rows[i]["Name_Test"]);
                test.name_Tester = Convert.ToString(dataSet.Tables[0].Rows[i]["Full_Name_Tester"]);
                test.time_Complete = Returns_Time_Complete(dataSet, i);

                list_Tests.Add(test);
            }
            return list_Tests;
        }

        private string Returns_Time_Complete(DataSet dataSet, int i)
        {
            if (Convert.ToInt32(dataSet.Tables[0].Rows[i]["Time_Complete"]) == 0)
            {
                return "Не ограничено";
            }
            return Convert.ToString(dataSet.Tables[0].Rows[i]["Time_Complete"]) + " мин.";
        }
    }
}
