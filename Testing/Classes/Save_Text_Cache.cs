using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Struct;

namespace Testing.Classes
{
    internal class Save_Text_Cache
    {
        Question[] Transfers_Questions_Cache(DataSet test_Questions)
        {
            var question = new Question[test_Questions.Tables[0].Rows.Count];
            int[] random_Sequence = Composes_Random_Sequence(test_Questions.Tables[0].Rows.Count);

            Test_Questions.id_Test = Convert.ToInt32(test_Questions.Tables[0].Rows[0]["Test_Id"]);
            Test_Questions.test_Time = Convert.ToInt32(test_Questions.Tables[0].Rows[0]["Time_Complete"]);

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
    }
}
