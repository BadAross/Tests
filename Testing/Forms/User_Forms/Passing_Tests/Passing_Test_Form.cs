using System;
using System.Drawing;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Classes.Data;

namespace Testing.Forms
{
    public partial class Passing_Test_Form : Form
    {
        private uint question_Number = 0;
        private uint time_In_Seconds = 0;
        private readonly Array_Questoins_For_Passing_Test array_Questions;

        public Passing_Test_Form(string name_Tets)
        {
            InitializeComponent();
            Name_Test_Label.Text = name_Tets;
            array_Questions = new Array_Questoins_For_Passing_Test(name_Tets);
            Starts_Passing_Test();
        }

        private void Starts_Passing_Test()
        {
            Shows_Questions(question_Number);
            Sets_Timer_Time(array_Questions.test_Time);
            Test_Completion_Time.Start_Timer();
        }

        private void Saves_Selected_Response(string radionButton_Text)
        {
            array_Questions.questions[question_Number].selected_Answer = radionButton_Text;
            Moves_On_Next_Question();
        }

        private void Shows_Questions(uint question_Number)
        {
            Question_Text_Label.Text = array_Questions.questions[question_Number].text_Question;
            First_Answer_Option_RadioButton.Text = array_Questions.questions[question_Number].first_Answer;
            Second_Answer_Option_RadioButton.Text = array_Questions.questions[question_Number].second_Answer;
            Third_Answer_Option_RadioButton.Text = array_Questions.questions[question_Number].third_Answer;
            Fourth_Answer_Option_RadioButton.Text = array_Questions.questions[question_Number].fourth_Answer;

            Question_Number_Label.Text = Convert.ToString(question_Number + 1) + "/" + array_Questions.questions.Length;
        }

        private void Sets_Timer_Time(uint test_Time)
        {
            if (test_Time != 0)
            {
                time_In_Seconds = (uint)test_Time * 60;
                Time_Test_Timer.Start();
            }
            else
            {
                time_In_Seconds = 0;
                Time_Test_Label.Text = "";
            }
        }

        private void Shows_Form_With_Result()
        {
            var saving_Results = new Saving_Results_Passage(array_Questions.questions, array_Questions.id_Test);
            var percentage_Passing_Test = (int)((float)saving_Results.number_Correct_Answers / (float)array_Questions.questions.Length * 100);
            var correct_Answers = saving_Results.number_Correct_Answers.ToString() + " из " + array_Questions.questions.Length.ToString();

            Time_Test_Timer.Stop();
            time_In_Seconds = 0;

            var form = new Test_Result_Form(percentage_Passing_Test, correct_Answers);
            form.Show();
            Hide();
        }

        private void Moves_On_Next_Question()
        {
            if (question_Number + 1 < array_Questions.questions.Length)
            {
                question_Number++;
                Shows_Questions(question_Number);
            }
            else if (question_Number + 1 >= array_Questions.questions.Length)
            {
                Test_Completion_Time.Returns_Time_Completion_Test();
                Shows_Form_With_Result();
            }

            if (question_Number + 1 == array_Questions.questions.Length)
            {
                Next_Question_Batton.BackgroundImage = new Bitmap(Properties.Resources.Confirm_Image);
            }
        }

        private void Determines_Selected_Response_Option()
        {
            var radioButtons = Returns_Array_RadioButton();
            var answer_Is_Selected = false;

            for (var i = 0; i < radioButtons.Length; i++)
            {
                if (radioButtons[i].Checked)
                {
                    Saves_Selected_Response(radioButtons[i].Text);
                    answer_Is_Selected = true;
                }
            }
            Warns_No_Response(answer_Is_Selected);
        }

        private void Warns_No_Response(bool answer_Is_Selected)
        {
            if (!answer_Is_Selected)
            {
                DialogResult result = MessageBox.Show(@"Не выбранные ответы будут засчитаны как не верные, 
                    но вы можете вернуся к ним во время прохождения теста. Продолжить?", "Ответ не выбран", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    Moves_On_Next_Question();
            }
        }

        private void Show_Selected_Answer_Option()
        {
            var radioButtons = Returns_Array_RadioButton();
            Turns_Off_RadioButtons();
            for (var i = 0; i < radioButtons.Length; i++)
            {
                if (array_Questions.questions[question_Number].selected_Answer == radioButtons[i].Text)
                {
                    radioButtons[i].Checked = true;
                }
            }
        }

        private RadioButton[] Returns_Array_RadioButton()
        {
            return new RadioButton[]
            {
                First_Answer_Option_RadioButton,
                Second_Answer_Option_RadioButton,
                Third_Answer_Option_RadioButton,
                Fourth_Answer_Option_RadioButton
            };
        }

        private void Turns_Off_RadioButtons()
        {
            First_Answer_Option_RadioButton.Checked = false;
            Second_Answer_Option_RadioButton.Checked = false;
            Third_Answer_Option_RadioButton.Checked = false;
            Fourth_Answer_Option_RadioButton.Checked = false;
        }

        private void Next_Question_Batton_Click(object sender, EventArgs e)
        {
            Determines_Selected_Response_Option();
            Show_Selected_Answer_Option();
        }

        private void Previous_Question_Button_Click(object sender, EventArgs e)
        {
            if (question_Number > 0)
            {
                question_Number--;
                Shows_Questions(question_Number);
                Show_Selected_Answer_Option();
            }
            if (question_Number + 1 < array_Questions.questions.Length)
            {
                Info_ToolTip.SetToolTip(Next_Question_Batton, "Закончить тест");
                Next_Question_Batton.BackgroundImage = new Bitmap(Properties.Resources.Next_Entry_Image);
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Програесс будет удален. Вы уверены что хотите выйти?",
                "Тест не окончен", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Test_Completion_Time.Stop_Timer();
                User_Menu_Form uzer_Menu = new User_Menu_Form();
                uzer_Menu.Show();
                Hide();
            }
        }

        private void Checks_End_Time()
        {
            if (time_In_Seconds > 0)
            {
                var span = TimeSpan.FromSeconds(--time_In_Seconds);
                Time_Test_Label.Text = span.ToString(@"hh\:mm\:ss");
            }
            else if (time_In_Seconds <= 0 && Time_Test_Label.Text != "")
            {
                Time_Test_Timer.Stop();
                Test_Completion_Time.Returns_Time_Completion_Test();

                Warns_About_End_Time();
            }
        }

        private void Warns_About_End_Time()
        {
            DialogResult result = MessageBox.Show("Вы не успели выполнить тест за указаное время. " +
                    "Оставшиеся вопросы будут засчитаны как не верно отвеченые.", "Время вышло", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Shows_Form_With_Result();
            }
        }

        private void Time_Test_Tick(object sender, EventArgs e)
        {
            Checks_End_Time();
        }
    }
}
