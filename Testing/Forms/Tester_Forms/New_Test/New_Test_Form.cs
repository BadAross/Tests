using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Forms.Enum;
using Testing.Forms.Tester_Forms.New_Test;
using Testing.Struct;

namespace Testing.Forms.Tester_Form
{
    public partial class New_Test_Form : Form
    {
        private int question_Number = 0;
        private Dictionary_New_Questions list_New_Questions = new();

        public New_Test_Form()
        {
            InitializeComponent();
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

        private string[] Collects_Answer_Options_From_Array()
        {
            var answers = new string[4]
            {
               list_New_Questions.New_Questions[question_Number].first_Answer.ToString(),
               list_New_Questions.New_Questions[question_Number].second_Answer.ToString(),
               list_New_Questions.New_Questions[question_Number].third_Answer.ToString(),
               list_New_Questions.New_Questions[question_Number].fourth_Answer.ToString()
            };
            return answers;
        }

        private void Shows_Question_Info()
        {
            Question_Text_TextBox.Text = list_New_Questions.New_Questions[question_Number].text_Question;
            First_Answer_TextBox.Text = list_New_Questions.New_Questions[question_Number].first_Answer;
            Second_Answer_TextBox.Text = list_New_Questions.New_Questions[question_Number].second_Answer;
            Third_Answer_TextBox.Text = list_New_Questions.New_Questions[question_Number].third_Answer;
            Fourth_Answer_TextBox.Text = list_New_Questions.New_Questions[question_Number].fourth_Answer;

            Question_Number_Label.Text = Convert.ToString(question_Number + 1) + "/" + list_New_Questions.New_Questions.Count;

            Displays_Correct_Answer();
        }

        private void Displays_Correct_Answer()
        {
            string[] answer_Options = Collects_Answer_Options_From_Array();
            RadioButton[] radioButtons = Collects_RadioButton_Into_Array();
            var correct_Answer = list_New_Questions.New_Questions[question_Number].correct_Answer;

            int number_Answer_Options = Checking_Correctness_Input_Data.Checks_Correct_Answer_Selected(answer_Options, correct_Answer);
            radioButtons[number_Answer_Options].Checked = true;
        }

        private void Saves_Changes_And_Edit_Type(Question question)
        {
            if (question.changing_Question == (byte)Type_Change.Add)
            {
                Adds_Entry(question);
            }
        }

        private void Adds_Entry(Question question)
        {
            if (list_New_Questions.New_Questions == null)
            {
                var first_Question = new Dictionary<int, Question>
                {
                    { 0, question }
                };
                list_New_Questions.New_Questions = first_Question;
                Shows_Question_Info();
            }
            else
            {
                list_New_Questions.New_Questions.Add(list_New_Questions.New_Questions.Count, question);
                question_Number = list_New_Questions.New_Questions.Count - 1;
                Shows_Question_Info();
            }
        }

        private void Brings_Modified_Data_The_Single_Type(string correct_Answer, byte type_Change)
        {
            var question = new Question();
            question.text_Question = Question_Text_TextBox.Text;
            question.first_Answer = First_Answer_TextBox.Text;
            question.second_Answer = Second_Answer_TextBox.Text;
            question.third_Answer = Third_Answer_TextBox.Text;
            question.fourth_Answer = Fourth_Answer_TextBox.Text;
            question.correct_Answer = correct_Answer;
            question.changing_Question = type_Change;

            Saves_Changes_And_Edit_Type(question);
        }

        private void Cheks_Filling_All_Fields(byte type_Change)
        {
            var x = Collects_All_TextBox_Into_Array();
            bool v = Checking_Correctness_Input_Data.Cheks_Filling_All_Fields(x);
            if (v)
            {
                Determines_Selected_Answer_As_Correct(type_Change);
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
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

        private void Checks_Questions_Test()
        {
            if (list_New_Questions.New_Questions.Count > 0)
            {
                new Save_New_Test(list_New_Questions.New_Questions, Name_Test_TextBox.Text, Convert.ToInt32(Time_Complete_TextBox.Text));
                MessageBox.Show("Тест сохранен!");

                Returns_To_Menu();
            }
            else
            {
                var res = MessageBox.Show("В тесте нет вопросов. Пустой тест не будет сохранен. Вы увенрены?",
                    "Пустой тест", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    Returns_To_Menu();
                }
            }
        }

        private void Clears_Form_When_Last_Question_Deleted()
        {
            if (list_New_Questions.New_Questions.Count <= 0)
            {
                Question_Text_TextBox.Clear();
                var radioButtons = Collects_RadioButton_Into_Array();
                var textBoxes = Collects_TextBox_With_Answer_Options_Into_Array();
                for (var i = 0; i < radioButtons.Length; i++)
                {
                    textBoxes[i].Clear();
                    radioButtons[i].Checked = false;
                }

                Question_Number_Label.Text = 0 + "/" + 0;
            }
            else
            {
                question_Number = list_New_Questions.New_Questions.Count - 1;
                Shows_Question_Info();
            }
        }

        private void Add_Question_Button_Click(object sender, EventArgs e)
        {
            Cheks_Filling_All_Fields((byte)Type_Change.Add);
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            Cheks_Filling_All_Fields((byte)Type_Change.Add);
        }

        private void Next_Question_Batton_Click(object sender, EventArgs e)
        {
            if (question_Number + 1 < list_New_Questions.New_Questions.Count)
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

        private void New_Question_Button_Click(object sender, EventArgs e)
        {
            Question_Text_TextBox.Clear();
            var radioButtons = Collects_RadioButton_Into_Array();
            var textBoxes = Collects_TextBox_With_Answer_Options_Into_Array();
            for (var i = 0; i < radioButtons.Length; i++)
            {
                textBoxes[i].Clear();
                radioButtons[i].Checked = false;
            }
        }

        private void Cancellation_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Тест не будет сохранен. Вы уверены?", "Отменить создание теста", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var test_List = new My_Tests_Form();
                test_List.Show();
                Hide();
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

        private void Delete_Question_Button_Click(object sender, EventArgs e)
        {
            if (list_New_Questions.New_Questions == null)
            {
                MessageBox.Show("Чтобы удалить вопрос, необходимо его добавить!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Вопрос будет удален. Вы уверены?",
                "Отменить редактирование", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    list_New_Questions.New_Questions.Remove(question_Number);
                    Clears_Form_When_Last_Question_Deleted();
                }
            }
        }
    }
}
