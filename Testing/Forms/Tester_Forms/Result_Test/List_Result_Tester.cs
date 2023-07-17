using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Testing.Class;
using Testing.Classes;
using Testing.Struct;

namespace Testing.Forms.Tester_Forms.Result_Test
{
    internal class List_Result_Tester
    {
        public List<Result_Passing_Test> results;

        public List_Result_Tester()
        {
            results = Fills_List_With_Data_From_Database(Unloads_Data_From_Database());
            results = results.OrderByDescending(x => x.test_Start_Time).ToList();
        }

        private DataSet Unloads_Data_From_Database()
        {
            int id_Active_Account = Active_Account.Returns_Id_Active_Account();
            var query = @"select
                  Id_Result
                , Full_Name_User
                , Code_Group
                , Name_Test
                , Number_Correct_Answers
                , Percentage_Correct_Answers
                , Test_Start_Time
                , Time_Spent
                from Results
                join Users on Id_User = User_Id
                join Tests on Id_Test = Test_Id
                join Groups on Id_Group = Group_Id
                where Tester_Id =" + id_Active_Account + "";
            return Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
        }

        private List<Result_Passing_Test> Fills_List_With_Data_From_Database(DataSet dataSet)
        {
            var list_Result_Test = new List<Result_Passing_Test>();
            var result_Passing_Test = new Result_Passing_Test();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                result_Passing_Test.id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id_Result"]);
                result_Passing_Test.full_Name_User = Convert.ToString(dataSet.Tables[0].Rows[i]["Full_Name_User"]);
                result_Passing_Test.code_Group = Convert.ToString(dataSet.Tables[0].Rows[i]["Code_Group"]);
                result_Passing_Test.name_Test = Convert.ToString(dataSet.Tables[0].Rows[i]["Name_Test"]);
                result_Passing_Test.number_Correct_Answers = Convert.ToString(dataSet.Tables[0].Rows[i]["Number_Correct_Answers"]);
                result_Passing_Test.percentage_Correct_Answers = Convert.ToString(dataSet.Tables[0].Rows[i]["Percentage_Correct_Answers"]);
                result_Passing_Test.test_Start_Time = Convert.ToString(dataSet.Tables[0].Rows[i]["Test_Start_Time"]);
                result_Passing_Test.time_Spent = Convert.ToString(dataSet.Tables[0].Rows[i]["Time_Spent"]);

                list_Result_Test.Add(result_Passing_Test);
            }
            return list_Result_Test;
        }
    }
}
