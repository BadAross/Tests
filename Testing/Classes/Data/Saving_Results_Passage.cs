using System;
using Testing.Struct;

namespace Testing.Classes.Data
{
    public class Saving_Results_Passage
    {
        private readonly Question[] _questions;
        private readonly int _id_Test;
        public readonly int number_Correct_Answers;

        public Saving_Results_Passage(Question[] questions, int id_Test)
        {
            _questions = questions;
            _id_Test = id_Test;
            number_Correct_Answers = Counts_Number_Correct_Answers();
            Transmits_Information_About_Passing_Test_DataBase();
        }

        private void Transmits_Information_About_Passing_Test_DataBase()
        {
            int percentage_Passing_Test = (int)((float)number_Correct_Answers / (float)_questions.Length * 100);
            string time_Passing_Test = Test_Completion_Time.Returns_Time_Completion_Test();
            int id_Active_Account = Active_Account.Returns_Id_Active_Account();
            var percentage_Correct_Answers = number_Correct_Answers.ToString() + "/" + _questions.Length.ToString();
            var sql_Command = @"insert into Results(
                                    Test_Id
                                  , User_Id
                                  , Number_Correct_Answers
                                  , Percentage_Correct_Answers
                                  , Test_Start_Time 
                                  , Time_Spent
                                  ) values (" + _id_Test + "," + id_Active_Account + ",'" + percentage_Correct_Answers + "',"
                                  + percentage_Passing_Test + ",'" + DateTime.Now + "','" + time_Passing_Test + "')";

            DataBase_Editor.Edited_Information_To_DataBase(sql_Command);
        }

        private int Counts_Number_Correct_Answers()
        {
            var number_Correct_Answers = 0;
            for (int i = 0; i < _questions.Length; i++)
            {
                if (_questions[i].correct_Answer == _questions[i].selected_Answer)
                {
                    number_Correct_Answers++;
                }
            }
            return number_Correct_Answers;
        }
    }
}
