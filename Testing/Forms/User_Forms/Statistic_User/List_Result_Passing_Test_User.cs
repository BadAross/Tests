using System;
using System.Collections.Generic;
using System.Data;
using Testing.Class;
using Testing.Classes;
using Testing.Struct;

namespace Testing.Forms.User_Forms.Statistic_User
{
    internal class List_Result_Passing_Test_User
    {
        public readonly List<Result_Passing_Test> results;

        public List_Result_Passing_Test_User()
        {
            results = Fills_List_With_Data_From_Database(Unloads_Data_From_Database());
        }

        private DataSet Unloads_Data_From_Database()
        {
            int id_Active_Account = Active_Account.Returns_Id_Active_Account();
            var query = @"select 
                  Id_Result
                , Full_Name_Tester
                , Name_Test
                , Number_Correct_Answers
                , Percentage_Correct_Answers
                , Test_Start_Time
                , Time_Spent
                from Results
                join Tests on Id_Test = Test_Id
                join Testers on Id_Tester = Tester_Id
                where User_Id =" + id_Active_Account + "";
            return Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
        }

        private List<Result_Passing_Test> Fills_List_With_Data_From_Database(DataSet dataSet)
        {
            var list_Result_Passing_Test = new List<Result_Passing_Test>();
            var result_Passing_Test = new Result_Passing_Test();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                result_Passing_Test.id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id_Result"]);
                result_Passing_Test.full_Name_Tester = Convert.ToString(dataSet.Tables[0].Rows[i]["Full_Name_Tester"]);
                result_Passing_Test.name_Test = Convert.ToString(dataSet.Tables[0].Rows[i]["Name_Test"]);
                result_Passing_Test.number_Correct_Answers = Convert.ToString(dataSet.Tables[0].Rows[i]["Number_Correct_Answers"]);
                result_Passing_Test.percentage_Correct_Answers = Convert.ToString(dataSet.Tables[0].Rows[i]["Percentage_Correct_Answers"]);
                result_Passing_Test.test_Start_Time = Convert.ToString(dataSet.Tables[0].Rows[i]["Test_Start_Time"]);
                result_Passing_Test.time_Spent = Convert.ToString(dataSet.Tables[0].Rows[i]["Time_Spent"]);

                list_Result_Passing_Test.Add(result_Passing_Test);
            }
            return list_Result_Passing_Test;
        }
    }
}
