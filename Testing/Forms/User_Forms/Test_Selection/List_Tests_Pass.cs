using System;
using System.Collections.Generic;
using System.Data;
using Testing.Class;
using Testing.Classes;
using Testing.Struct;

namespace Testing.Forms.User_Forms.Test_Selection
{
    internal class List_Tests_Pass
    {
        public readonly List<Test_Pass> tests = new List<Test_Pass>();

        public List_Tests_Pass()
        {
            tests = Fills_List_With_Data_From_Database(Unloads_Data_From_Database());
        }

        private DataSet Unloads_Data_From_Database()
        {
            int id_Active_Account = Active_Account.Returns_Id_Active_Account();
            var query = @"select 
                  Full_Name_Tester
                , Name_Test 
                from Testers 
                join Tests on Id_Tester = Tester_Id";
            return Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
        }

        private List<Test_Pass> Fills_List_With_Data_From_Database(DataSet dataSet)
        {
            var list_Test_Pass = new List<Test_Pass>();
            var test_Pass = new Test_Pass();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                test_Pass.full_Name_Tester = Convert.ToString(dataSet.Tables[0].Rows[i]["Full_Name_Tester"]);
                test_Pass.name_Test = Convert.ToString(dataSet.Tables[0].Rows[i]["Name_Test"]);

                list_Test_Pass.Add(test_Pass);
            }
            return list_Test_Pass;
        }
    }
}
