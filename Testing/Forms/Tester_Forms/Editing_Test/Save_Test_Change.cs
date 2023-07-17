using System.Collections.Generic;
using Testing.Classes;
using Testing.Forms.Enum;
using Testing.Struct;

namespace Testing.Forms.Tester_Forms.Editing_Test
{
    internal class Save_Test_Change
    {
        private readonly Dictionary<int, Question> _dictionary_Questions;
        private readonly List<int> _id_Delete_Questions = new List<int>();
        private readonly int _id_Test;
        private readonly int _time_Complete;
        private readonly string _name_Test;


        public Save_Test_Change(Dictionary<int, Question> dictionary_Questions, List<int> id_Delete_Questions, int id_Test, string name_Test, int time_Complete)
        {
            _dictionary_Questions = dictionary_Questions;
            _id_Delete_Questions = id_Delete_Questions;
            _name_Test = name_Test;
            _time_Complete = time_Complete;
            _id_Test = id_Test;

            Saves_Changed_Information_About_Test();
            Returns_Questions_From_Dictionary();
            Deletes_Selected_Questions();
        }

        private void Deletes_Selected_Questions()
        {
            for (var i = 0; i < _id_Delete_Questions.Count; i++)
            {
                DataBase_Editor.Edited_Information_To_DataBase(" delete from Questions where Id_Question = " + _id_Delete_Questions[i] + "");
            }
        }

        private void Saves_Changed_Information_About_Test()
        {
            var sql_Command = "update Tests set Name_Test='" + _name_Test + "', Time_Complete= " + _time_Complete +
             " where Id_Test =" + _id_Test;
            DataBase_Editor.Edited_Information_To_DataBase(sql_Command);
        }

        private void Returns_Questions_From_Dictionary()
        {
            for (int i = 0; i < _dictionary_Questions.Count; i++)
            {
                Determines_Type_Changes_Made(_dictionary_Questions[i]);
            }
        }

        private void Determines_Type_Changes_Made(Question question)
        {
            if (question.changing_Question == (byte)Type_Change.Add)
            {
                Saves_New_Question(question);
            }
            else if (question.changing_Question == (byte)Type_Change.Modified)
            {
                Saves_Modified_Question(question);
            }
        }

        private void Saves_New_Question(Question question)
        {
            var sql_Command = @"insert
                into Questions (
                  Test_Id
                , Text_Question
                , First_Answer
                , Second_Answer
                , Third_Answer
                , Fourth_Answer
                , Correct_Answer)
                values (" + _id_Test + ",'" + question.text_Question + "','" + question.first_Answer + "' ,'" + question.second_Answer + "','"
              + question.third_Answer + "','" + question.fourth_Answer + "','" + question.correct_Answer + "')";
            DataBase_Editor.Edited_Information_To_DataBase(sql_Command);
        }

        private void Saves_Modified_Question(Question question)
        {
            var sql_Command = "update Questions set " +
                "Text_Question='" + question.text_Question + "', " +
                "First_Answer='" + question.first_Answer + "', " +
                "Second_Answer='" + question.second_Answer + "', " +
                "Third_Answer ='" + question.third_Answer + "', " +
                "Fourth_Answer='" + question.fourth_Answer + "', " +
                "Correct_Answer='" + question.correct_Answer + "' " +
                "where  Id_Question =" + question.id_Question + "";
            DataBase_Editor.Edited_Information_To_DataBase(sql_Command);
        }
    }
}
