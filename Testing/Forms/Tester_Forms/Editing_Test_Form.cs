using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Testing.Class;
using Testing.Classes;
using Testing.Forms.Enum;
using Testing.Struct;

namespace Testing.Forms.Tester_Form
{
    public partial class Editing_Test_Form : Form
    {
        int question_Number = 0;
        List<int> id_Delete_Questions = new List<int>();
        private static int id_Test;
        private static string name_Test;
        private static int test_Time;
        private static Dictionary<int, Question> editing_Questions;

        public Editing_Test_Form(int selected_Test)
        {
            InitializeComponent();
            id_Test = selected_Test;
            editing_Questions = Returns_Dictionary_Questions_From_Database();
            Shows_Test_Info();
            Shows_Question_Info();
        }

        private TextBox[] Returns_Array_TextBoxes()
        {
            return new TextBox[]
            {

            };
        }

        private void Shows_Test_Info()
        {
            Name_Test_TextBox.Text = name_Test;
            Time_Complete_TextBox.Text = test_Time.ToString();
        }

        private void Saves_Changed_Information_About_Test()
        {
            var sql_Command = "update Tests set Name_Test='" + Name_Test_TextBox.Text + "', Time_Complete= " + Time_Complete_TextBox.Text +
             " where Id_Test =" + id_Test;
            DataBase_Editor.Edited_Information_To_DataBase(sql_Command);
        }

        private void Returns_To_Menu()
        {
            var test_List = new Test_List_Form();
            test_List.Show();
            Hide();
        }

        private void Deletes_Selected_Users()
        {
            for (var i = 0; i < id_Delete_Questions.Count; i++)
            {
                DataBase_Editor.Edited_Information_To_DataBase(" delete from Questions where Id_Question = " + id_Delete_Questions[i] + "");
            }
        }

        private void Saves_New_Question(Question question)
        {
            var sql_Command = "insert into Questions (Test_Id, Text_Question, First_Answer, Second_Answer, Third_Answer, Fourth_Answer, Correct_Answer) " +
              "values (" + id_Test + ",'" + question.text_Question + "','" + question.first_Answer + "' ,'" + question.second_Answer + "','"
              + question.third_Answer + "','" + question.fourth_Answer + "','" + question.correct_Answer + "')";
            DataBase_Editor.Edited_Information_To_DataBase(sql_Command);
        }

        private void Saves_Modified_Question(Question question)
        {
            var sql_Command = "update Questions set Text_Question='" + question.text_Question + "', First_Answer='" + question.first_Answer + "', " +
             "Second_Answer='" + question.second_Answer + "', Third_Answer ='" + question.third_Answer + "', Fourth_Answer='" + question.fourth_Answer + "', " +
             "Correct_Answer='" + question.correct_Answer + "' where  Id_Question =" + question.id_Question + "";
            DataBase_Editor.Edited_Information_To_DataBase(sql_Command);
        }

        private RadioButton[] Collects_RadioButton_Into_Array()
        {
            var radioButtons = new RadioButton[4]
            {
                 First_Answer_RadioButton,
                 Second_Answer_RadioButton,
                 Third_Answer_RadioButton,
                 Fourth_Answer_RadioButton
            };
            return radioButtons;
        }

        private TextBox[] Collects_TextBox_With_Answer_Options_Into_Array()
        {
            var textBox = new TextBox[4]
            {
                First_Answer_TextBox,
                Second_Answer_TextBox,
                Third_Answer_TextBox,
                Fourth_Answer_TextBox
            };
            return textBox;
        }

        private void Determines_Type_Changes_Made(int i, Question question)
        {
            if (editing_Questions[i].changing_Question == (byte)Type_Change.Add)
            {
                Saves_New_Question(question);
            }
            else if (editing_Questions[i].changing_Question == (byte)Type_Change.Modified)
            {
                Saves_Modified_Question(question);
            }
        }

        private void Determines_Correct_Answer()
        {
            var correct_Answer = editing_Questions[question_Number].correct_Answer;
            var answers = Collects_Answer_Options_From_Dictionary_Array();
            var number_Correct_Answer_Option = Checking_Correctness_Input_Data.Checks_Correct_Answer_Selected(answers, correct_Answer);
            var radioButtons = Collects_RadioButton_Into_Array();

            radioButtons[number_Correct_Answer_Option].Checked = true;
        }

        private void Goes_To_Test_List_Form()
        {
            DialogResult result = MessageBox.Show("Все внесенные изменения сохранены",
                  "Изменения сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Returns_To_Menu();
            }
        }

        private void Cheks_Filling_All_Fields(byte type_Change)
        {
            TextBox[] textBoxs = Collects_All_TextBox_Into_Array();
            bool filling_All_Fields = Checking_Correctness_Input_Data.Cheks_Filling_All_Fields(textBoxs);
            if (filling_All_Fields)
            {
                Determines_Selected_Answer_As_Correct(type_Change);
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

        private TextBox[] Collects_All_TextBox_Into_Array()
        {
            var textBox = new TextBox[7]
            {
                Name_Test_TextBox,
                Time_Complete_TextBox,
                Question_Text_TextBox,
                First_Answer_TextBox,
                Second_Answer_TextBox,
                Third_Answer_TextBox,
                Fourth_Answer_TextBox
            };
            return textBox;
        }

        private void Saves_Changes_And_Edit_Type(Question question)
        {
            if (question.changing_Question == (byte)Type_Change.Add)
            {
                editing_Questions.Add(editing_Questions.Count, question);
                question_Number = editing_Questions.Count - 1;
                Shows_Question_Info();
            }
            else if (question.changing_Question == (byte)Type_Change.Modified)
            {
                editing_Questions[question_Number] = question;
                Shows_Question_Info();
            }
        }

        private void Determines_Selected_Answer_As_Correct(byte type_Change)
        {
            var answer_Options_Array = Collects_TextBox_With_Answer_Options_Into_Array();
            var radioButton_Array = Collects_RadioButton_Into_Array();

            var x = Checking_Correctness_Input_Data.Checks_Correct_Answer_Selected(radioButton_Array);
            if (x == -1)
            {
                MessageBox.Show("Вы не выбрали вариант ответа!");
            }
            else
            {
                Brings_Modified_Data_The_Single_Type(answer_Options_Array[x].Text, type_Change);
            }
        }

        private void Saves_Changes_Database()
        {
            bool original_Name_Test = Checking_Correctness_Input_Data.Checks_Absence_Identical_Test_Names(Name_Test_TextBox.Text);
            if (original_Name_Test)
            {
                Saves_Changed_Information_About_Test();
                Returns_Questions_From_Dictionary();
                Deletes_Selected_Users();
                Goes_To_Test_List_Form();
            }
            else
            {
                MessageBox.Show("Данное название теста уже используется. Смените название.");
            }
        }

        private void Checks_Questions_Test()
        {
            if (editing_Questions.Count > 0)
            {
                Saves_Changes_Database();
            }
            else
            {
                var res = MessageBox.Show("В тесте нет вопросов. Пустой тест будет удален. Вы увенрены?", "Пустой тест", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    Returns_To_Menu();
                }
            }
        }

        private void Returns_Questions_From_Dictionary()
        {
            var question = new Question();
            for (int i = 0; i < editing_Questions.Count; i++)
            {
                question.id_Question = editing_Questions[i].id_Question;
                question.text_Question = editing_Questions[i].text_Question;
                question.first_Answer = editing_Questions[i].first_Answer;
                question.second_Answer = editing_Questions[i].second_Answer;
                question.third_Answer = editing_Questions[i].third_Answer;
                question.fourth_Answer = editing_Questions[i].fourth_Answer;
                question.correct_Answer = editing_Questions[i].correct_Answer;

                Determines_Type_Changes_Made(i, question);
            }
        }

        private void Shows_Question_Info()
        {
            Question_Text_TextBox.Text = editing_Questions[question_Number].text_Question;
            First_Answer_TextBox.Text = editing_Questions[question_Number].first_Answer;
            Second_Answer_TextBox.Text = editing_Questions[question_Number].second_Answer;
            Third_Answer_TextBox.Text = editing_Questions[question_Number].third_Answer;
            Fourth_Answer_TextBox.Text = editing_Questions[question_Number].fourth_Answer;

            Question_Number_Label.Text = Convert.ToString(question_Number + 1) + "/" + editing_Questions.Count;

            Determines_Correct_Answer();
        }

        private string[] Collects_Answer_Options_From_Dictionary_Array()
        {
            var first_Answer = editing_Questions[question_Number].first_Answer;
            var second_Answer = editing_Questions[question_Number].second_Answer;
            var third_Answer = editing_Questions[question_Number].third_Answer;
            var fourth_Answer = editing_Questions[question_Number].fourth_Answer;

            var answers = new string[4]
            {
                first_Answer,
                second_Answer,
                third_Answer,
                fourth_Answer
            };
            return answers;
        }

        private void Brings_Modified_Data_The_Single_Type(String correct_Answer, byte type_Change)
        {
            var question = new Question();
            question.id_Question = editing_Questions[question_Number].id_Question;
            question.text_Question = Question_Text_TextBox.Text;
            question.first_Answer = First_Answer_TextBox.Text;
            question.second_Answer = Second_Answer_TextBox.Text;
            question.third_Answer = Third_Answer_TextBox.Text;
            question.fourth_Answer = Fourth_Answer_TextBox.Text;
            question.correct_Answer = correct_Answer;
            question.changing_Question = type_Change;

            Saves_Changes_And_Edit_Type(question);
        }

        Dictionary<int, Question> Returns_Dictionary_Questions_From_Database()
        {
            var s = "select * from Tests join Questions on Id_Test=Test_Id where Id_Test =" + id_Test;
            DataSet dataSet = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(s);
            var editing_Questions = new Dictionary<int, Question>();
            var question = new Question();

            test_Time = Convert.ToInt32(dataSet.Tables[0].Rows[0]["Time_Complete"]);
            name_Test = Convert.ToString(dataSet.Tables[0].Rows[0]["Name_Test"]);

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

        private void Change_Button_Click(object sender, EventArgs e)
        {
            Cheks_Filling_All_Fields((byte)Type_Change.Modified);
        }

        private void Add_Question_Button_Click(object sender, EventArgs e)
        {
            Cheks_Filling_All_Fields((byte)Type_Change.Add);
        }

        private void Next_Question_Batton_Click(object sender, EventArgs e)
        {
            if (question_Number + 1 < editing_Questions.Count)
            {
                question_Number++;
                Shows_Question_Info();
            }
        }

        private void Previous_Question_Button_Click(object sender, EventArgs e)
        {
            if (question_Number > 0)
            {
                question_Number--;
                Shows_Question_Info();
            }
        }

        private void Delete_Question_Button_Click(object sender, EventArgs e)
        {
            if (editing_Questions.Count != 0)
            {
                id_Delete_Questions.Add(editing_Questions[question_Number].id_Question);
                editing_Questions.Remove(question_Number);
                Shows_Question_Info();
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Все изменения будут отменены. Вы уверены?",
                "Отменить редактирование", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var test_List = new Test_List_Form();
                test_List.Show();
                Hide();
            }
        }

        private void New_Question_Button_Click(object sender, EventArgs e)
        {
            Question_Text_TextBox.Clear();
            RadioButton[] radioButtons = Collects_RadioButton_Into_Array();
            TextBox[] textBoxes = Collects_TextBox_With_Answer_Options_Into_Array();
            for (var i = 0; i < radioButtons.Length; i++)
            {
                textBoxes[i].Clear();
                radioButtons[i].Checked = false;
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Checks_Questions_Test();
            }
        }
    }
}
