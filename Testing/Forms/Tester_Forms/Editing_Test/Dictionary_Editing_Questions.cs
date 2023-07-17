using System;
using System.Collections.Generic;
using System.Data;
using Testing.Class;
using Testing.Struct;

namespace Testing.Forms.Tester_Forms.Editing_Test
{
    internal class Dictionary_Editing_Questions
    {
        public readonly int _id_Test;
        public Dictionary<int, Question> Editing_Questions { set; get; }
        public string name_Test { set; get; }
        public int test_Time { set; get; }

        public Dictionary_Editing_Questions(int id_Test)
        {
            _id_Test = id_Test;
            var dataSet = Returns_DataSet();
            Editing_Questions = Returns_Dictionary_Questions_From_Database(dataSet);
            test_Time = Convert.ToInt32(dataSet.Tables[0].Rows[0]["Time_Complete"]);
            name_Test = Convert.ToString(dataSet.Tables[0].Rows[0]["Name_Test"]);
        }

        private DataSet Returns_DataSet()
        {
            var query = @"select * 
                from Tests
                join Questions on Id_Test=Test_Id 
                where Id_Test =" + _id_Test;
            return Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
        }

        private Dictionary<int, Question> Returns_Dictionary_Questions_From_Database(DataSet dataSet)
        {
            var editing_Questions = new Dictionary<int, Question>();
            var question = new Question();

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                question.id_Question = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id_Question"]);
                question.text_Question = Convert.ToString(dataSet.Tables[0].Rows[i]["Text_Question"]);
                question.correct_Answer = Convert.ToString(dataSet.Tables[0].Rows[i]["Correct_Answer"]);
                question.first_Answer = Convert.ToString(dataSet.Tables[0].Rows[i]["First_Answer"]);
                question.second_Answer = Convert.ToString(dataSet.Tables[0].Rows[i]["Second_Answer"]);
                question.third_Answer = Convert.ToString(dataSet.Tables[0].Rows[i]["Third_Answer"]);
                question.fourth_Answer = Convert.ToString(dataSet.Tables[0].Rows[i]["Fourth_Answer"]);
                editing_Questions.Add(i, question);
            }
            return editing_Questions;
        }
    }
}
