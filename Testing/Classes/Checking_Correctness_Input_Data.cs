using System;
using System.Data;
using System.Windows.Forms;
using Testing.Class;

namespace Testing.Classes
{
    internal class Checking_Correctness_Input_Data
    {
        public static int Checks_Correct_Answer_Selected(RadioButton[] radioButtons)
        {
            for (var i = 0; i < radioButtons.Length; i++)
            {
                if (radioButtons[i].Checked)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int Checks_Correct_Answer_Selected(string[] answers, string correct_Answer)
        {
            for (var i = 0; i < answers.Length; i++)
            {
                if (answers[i] == correct_Answer)
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool Cheks_Filling_All_Fields(TextBox[] textBoxes)
        {
            for (var i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text == String.Empty)
                {
                    return false;
                }
            }
            return true;
        }



        public static bool Checks_Absence_Identical_Test_Names(string name_Test)
        {
            var x = "select * from Tests where Name_Test ='" + name_Test + "'";
            DataSet dataSet = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(x);
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
