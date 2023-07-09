using System;
using System.Data;
using Testing.Class;
using Testing.Struct;

namespace Testing.Classes.Data
{
    internal class Array_Questoins_For_Passing_Test
    {
        public Question[] Questions { get; set; }
        public int id_Test;

        public Array_Questoins_For_Passing_Test(string name_Test)
        {
            Questions = Transfers_Questions_From_Database_To_The_Array(Return_DataSet(name_Test));
            
        }

        private DataSet Return_DataSet(string name_Tets)
        {
            return Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(@"select 
                  Id_Test 
                , Id_Question 
                , Text_Question
                , First_Answer
                , Second_Answer
                , Third_Answer
                , Fourth_Answer
                , Correct_Answer
                , Time_Complete
                from Questions 
                  join Tests on Test_Id=Id_Test
                where Name_Test = '" + name_Tets + "'");
        }

        private Question[] Transfers_Questions_From_Database_To_The_Array(DataSet test_Questions)
        {
            var question = new Question[test_Questions.Tables[0].Rows.Count];
            int[] random_Sequence = Composes_Random_Sequence(test_Questions.Tables[0].Rows.Count);
            id_Test = Convert.ToInt32(test_Questions.Tables[0].Rows[0]["Id_Test"]);

            for (var i = 0; i < test_Questions.Tables[0].Rows.Count; i++)
            {
                var answer_Options_Specified_Order = Return_Array_Answer_Options_Specified_Order(test_Questions, random_Sequence[i]);

                question[i].id_Question = Convert.ToInt32(test_Questions.Tables[0].Rows[random_Sequence[i]]["Id_Question"]);
                question[i].text_Question = Convert.ToString(test_Questions.Tables[0].Rows[random_Sequence[i]]["Text_Question"]);
                question[i].correct_Answer = Convert.ToString(test_Questions.Tables[0].Rows[random_Sequence[i]]["Correct_Answer"]);
                question[i].first_Answer = answer_Options_Specified_Order[0];
                question[i].second_Answer = answer_Options_Specified_Order[1];
                question[i].third_Answer = answer_Options_Specified_Order[2];
                question[i].fourth_Answer = answer_Options_Specified_Order[3];
            }
            return question;
        }

        private string[] Return_Array_Answer_Options_Specified_Order(DataSet test_Questions, int line_Number)
        {
            int[] random_Order = Composes_Random_Sequence(4);
            var array_Response_Options = new string[4];
            for (int i = 0; i < random_Order.Length; i++)
            {
                var answer_Option_Number = random_Order[i] + 3;
                array_Response_Options[i] = Convert.ToString(test_Questions.Tables[0].Rows[line_Number][answer_Option_Number]);
            }
            return array_Response_Options;
        }

        private int[] Composes_Random_Sequence(int number_Random_Elements)
        {
            var response_Options = new int[number_Random_Elements];

            for (var i = 0; i < number_Random_Elements; i++)
            {
                response_Options[i] = dsaf(number_Random_Elements, response_Options, i);
            }
            return response_Options;
        }

        private int dsaf(int number_Random_Elements, int[] response_Options, int i)
        {
            var rnd = new Random();
            int random_Number;

            do
            {
                random_Number = rnd.Next(number_Random_Elements);
            }
            while (dsfsaf(response_Options, random_Number, i));
            {
                return random_Number;
            }
        }

        private bool dsfsaf(int[] response_Options, int random_Number, int i)
        {
            for (int j = 0; j < i; j++)
            {
                var contains_Random_Number = response_Options[j] == random_Number;
                if (contains_Random_Number)
                {
                    return contains_Random_Number;
                }              
            }
            return false;
        }
    }
}
