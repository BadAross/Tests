using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Forms.Enum;
using Testing.Forms.Tester_Forms.Editing_Test;
using Testing.Struct;

namespace Testing.Forms.Tester_Form
{
    public partial class Editing_Test_Form : Form
    {
        private int question_Number = 0;
        private List<int> id_Delete_Questions = new();
        private Dictionary_Editing_Questions dictionary_Questions;

        public Editing_Test_Form(int selected_Test)
        {
            InitializeComponent();
            dictionary_Questions = new(selected_Test);
            Shows_Test_Info();
            Shows_Question_Info();
        }

        private void Shows_Test_Info()
        {
            Name_Test_TextBox.Text = dictionary_Questions.name_Test;
            Time_Complete_TextBox.Text = dictionary_Questions.test_Time.ToString();
        }

        private void Returns_To_Menu()
        {
            var test_List = new My_Tests_Form();
            test_List.Show();
            Hide();
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

        private void Determines_Correct_Answer()
        {
            var correct_Answer = dictionary_Questions.Editing_Questions[question_Number].correct_Answer;
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
                dictionary_Questions.Editing_Questions.Add(dictionary_Questions.Editing_Questions.Count, question);
                question_Number = dictionary_Questions.Editing_Questions.Count - 1;
                Shows_Question_Info();
            }
            else if (question.changing_Question == (byte)Type_Change.Modified)
            {
                dictionary_Questions.Editing_Questions[question_Number] = question;
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
                new Save_Test_Change(dictionary_Questions.Editing_Questions, id_Delete_Questions,
                    dictionary_Questions._id_Test, Name_Test_TextBox.Text, Convert.ToInt32(Time_Complete_TextBox.Text));
                Goes_To_Test_List_Form();
            }
            else
            {
                MessageBox.Show("Данное название теста уже используется. Смените название.");
            }
        }

        private void Checks_Questions_Test()
        {
            if (dictionary_Questions.Editing_Questions.Count > 0)
            {
                Saves_Changes_Database();
            }
            else
            {
                var result = MessageBox.Show("В тесте нет вопросов. Пустой тест будет удален. Вы увенрены?", "Пустой тест", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Returns_To_Menu();
                }
            }
        }

        private void Shows_Question_Info()
        {
            Question_Text_TextBox.Text = dictionary_Questions.Editing_Questions[question_Number].text_Question;
            First_Answer_TextBox.Text = dictionary_Questions.Editing_Questions[question_Number].first_Answer;
            Second_Answer_TextBox.Text = dictionary_Questions.Editing_Questions[question_Number].second_Answer;
            Third_Answer_TextBox.Text = dictionary_Questions.Editing_Questions[question_Number].third_Answer;
            Fourth_Answer_TextBox.Text = dictionary_Questions.Editing_Questions[question_Number].fourth_Answer;

            Question_Number_Label.Text = Convert.ToString(question_Number + 1) + "/" + dictionary_Questions.Editing_Questions.Count;

            Determines_Correct_Answer();
        }

        private string[] Collects_Answer_Options_From_Dictionary_Array()
        {
            var answers = new string[4]
            {
                dictionary_Questions.Editing_Questions[question_Number].first_Answer.ToString(),
                dictionary_Questions.Editing_Questions[question_Number].second_Answer.ToString(),
                dictionary_Questions.Editing_Questions[question_Number].third_Answer.ToString(),
                dictionary_Questions.Editing_Questions[question_Number].fourth_Answer.ToString()
            };
            return answers;
        }

        private void Brings_Modified_Data_The_Single_Type(String correct_Answer, byte type_Change)
        {
            var question = new Question();
            question.id_Question = dictionary_Questions.Editing_Questions[question_Number].id_Question;
            question.text_Question = Question_Text_TextBox.Text;
            question.first_Answer = First_Answer_TextBox.Text;
            question.second_Answer = Second_Answer_TextBox.Text;
            question.third_Answer = Third_Answer_TextBox.Text;
            question.fourth_Answer = Fourth_Answer_TextBox.Text;
            question.correct_Answer = correct_Answer;
            if (question.changing_Question != (byte)Type_Change.Add)
                question.changing_Question = type_Change;

            Saves_Changes_And_Edit_Type(question);
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
            if (question_Number + 1 < dictionary_Questions.Editing_Questions.Count)
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
            if (dictionary_Questions.Editing_Questions.Count != 0)
            {
                id_Delete_Questions.Add(dictionary_Questions.Editing_Questions[question_Number].id_Question);
                dictionary_Questions.Editing_Questions.Remove(question_Number);
                Shows_Question_Info();
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Все изменения будут отменены. Вы уверены?",
                "Отменить редактирование", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var test_List = new My_Tests_Form();
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
