using System;
using System.Collections.Generic;
using System.Data;
using Testing.Class;
using Testing.Classes;
using Testing.Struct;

namespace Testing.Forms.Tester_Forms.New_Test
{
    internal class Save_New_Test
    {
        private readonly Dictionary<int, Question> _new_Questions;

        public Save_New_Test(Dictionary<int, Question> new_Questions, string name_Test, int time_Complete)
        {
            _new_Questions = new_Questions;
            Saves_Test_Info(name_Test, time_Complete);
            Sorting_Through_New_Questions(Defines_Id_Saved_Test(name_Test));
        }

        private int Defines_Id_Saved_Test(string name_Test)
        {
            var query = @"select
                Id_Test
                from Tests
                where Name_Test = '" + name_Test + "'";
            DataSet tests = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
            return Convert.ToInt32(tests.Tables[0].Rows[0]["Id_Test"]);
        }

        private void Saves_Test_Info(string name_Test, int time_Complete)
        {
            var tester_Id = Active_Account.Returns_Id_Active_Account();

            var querty = @"insert into Tests (
                  Tester_Id
                , Name_Test
                , Time_Complete
                ) values (" + tester_Id + ",'" + name_Test + "','" + time_Complete + "')";
            DataBase_Editor.Edited_Information_To_DataBase(querty);
        }

        private void Sorting_Through_New_Questions(int id_Test)
        {
            for (int i = 0; i < _new_Questions.Count; i++)
            {
                Saves_Test_Questions(id_Test, _new_Questions[i]);
            }
        }

        private void Saves_Test_Questions(int id_Test, Question question)
        {
            var new_Question = @"insert into Questions (
                  Test_Id
                , Text_Question
                , First_Answer
                , Second_Answer
                , Third_Answer
                , Fourth_Answer
                , Correct_Answer
                ) values (" + id_Test + ",'" + question.text_Question + "','" + question.first_Answer + "' ,'" + question.second_Answer +
                    "','" + question.third_Answer + "','" + question.fourth_Answer + "','" + question.correct_Answer + "')";
            DataBase_Editor.Edited_Information_To_DataBase(new_Question);
        }
    }
}
