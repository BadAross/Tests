using System;
using System.Collections.Generic;
using System.Data;
using Testing.Class;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Results_Edit
{
    internal class List_Result_Info
    {
        public List<Result_Passing_Test> Results { set; get; }

        public List_Result_Info()
        {
            Results = Fills_List_With_Data_From_Database(Unloads_Data_From_Database());
        }

        private DataSet Unloads_Data_From_Database()
        {
            var query = @"select
                  Id_Result
                , Full_Name_User
                , Code_Group
                , Full_Name_Tester
                , Name_Test
                , Number_Correct_Answers
                , Percentage_Correct_Answers
                , Test_Start_Time
                , Time_Spent
                from Results
                join Tests on Id_Test = Test_Id
                join Testers on Id_Tester = Tester_Id
                join Users on Id_User = User_Id
                join Groups on Id_Group = Group_Id";
            return Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
        }

        private List<Result_Passing_Test> Fills_List_With_Data_From_Database(DataSet dataSet)
        {
            var list_Results = new List<Result_Passing_Test>();
            var result = new Result_Passing_Test();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                result.id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id_Result"]);
                result.full_Name_User = Convert.ToString(dataSet.Tables[0].Rows[i]["Full_Name_User"]);
                result.code_Group = Convert.ToString(dataSet.Tables[0].Rows[i]["Code_Group"]);
                result.full_Name_Tester = Convert.ToString(dataSet.Tables[0].Rows[i]["Full_Name_Tester"]);
                result.name_Test = Convert.ToString(dataSet.Tables[0].Rows[i]["Name_Test"]);
                result.number_Correct_Answers = Convert.ToString(dataSet.Tables[0].Rows[i]["Number_Correct_Answers"]);
                result.percentage_Correct_Answers = Convert.ToString(dataSet.Tables[0].Rows[i]["Percentage_Correct_Answers"]);
                result.test_Start_Time = Convert.ToString(dataSet.Tables[0].Rows[i]["Test_Start_Time"]);
                result.time_Spent = Convert.ToString(dataSet.Tables[0].Rows[i]["Time_Spent"]);

                list_Results.Add(result);
            }
            return list_Results;
        }
    }
}
