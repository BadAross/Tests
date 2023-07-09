using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Classes.Data;
using Testing.Struct;

namespace Testing.Forms
{
    public partial class Passing_Test_Form : Form
    {
        private uint question_Number = 0;
        private int time_In_Seconds = 0;
        Array_Questoins_For_Passing_Test array_Questions;

        public Passing_Test_Form(string name_Tets)
        {
            InitializeComponent();
            Name_Test_Label.Text = name_Tets;
            array_Questions =new Array_Questoins_For_Passing_Test(name_Tets);
            Starts_Passing_Test();
        }

        private void Starts_Passing_Test()
        {
            Shows_Questions(question_Number);
            Test_Completion_Time.Start_Timer();
        }

        private void Saves_Selected_Response(string radionButton_Text)
        {
            array_Questions.Questions[question_Number].selected_Answer = radionButton_Text;
            Moves_On_Next_Question();
        }

        private void Shows_Questions(uint question_Number)
        {
            Question_Text_Label.Text = array_Questions.Questions[question_Number].text_Question;
            First_Answer_Option_RadioButton.Text = array_Questions.Questions[question_Number].first_Answer;
            Second_Answer_Option_RadioButton.Text = array_Questions.Questions[question_Number].second_Answer;
            Third_Answer_Option_RadioButton.Text = array_Questions.Questions[question_Number].third_Answer;
            Fourth_Answer_Option_RadioButton.Text = array_Questions.Questions[question_Number].fourth_Answer;

            Question_Number_Label.Text = Convert.ToString(question_Number + 1) + "/" + array_Questions.Questions.Length;
        }

        private int Counts_Number_Correct_Answers()
        {
            var number_Correct_Answers = 0;
            for (int i = 0; i < array_Questions.Questions.Length; i++)
            {
                if (array_Questions.Questions[i].correct_Answer == array_Questions.Questions[i].selected_Answer)
                {
                    number_Correct_Answers++;
                }
            }
            return number_Correct_Answers;
        }

        private void Transmits_Information_About_Passing_Test_DataBase(int number_Correct_Answers, int percentage_Passing_Test)
        {
            string time_Passing_Test = Test_Completion_Time.Returns_Time_Completion_Test();
            int id_Active_Account = Active_Account.Returns_Id_Active_Account();
            var percentage_Correct_Answers = number_Correct_Answers.ToString() + "/" + array_Questions.Questions.Length.ToString();
            var sql_Command = @"insert into Results(
                                    Test_Id
                                  , User_Id
                                  , Number_Correct_Answers
                                  , Percentage_Correct_Answers
                                  , Test_Start_Time 
                                  , Time_Spent
                                  ) values (" + array_Questions.id_Test + "," + id_Active_Account + ",'" + percentage_Correct_Answers + "'," 
                                  + percentage_Passing_Test + ",'" + DateTime.Now + "','" + time_Passing_Test + "')";

            DataBase_Editor.Edited_Information_To_DataBase(sql_Command);
        }

        private async void Sets_Timer_Time(int test_Time)
        {
            await Task.Run(() =>
            {
                if (test_Time != 0)
                {
                    time_In_Seconds = test_Time * 60;
                    Time_Test_Timer.Start();
                }
                else
                {
                    time_In_Seconds = 0;
                    Time_Test_Label.Text = "";
                }

            });
        }

        private void Shows_Form_With_Result()
        {
            int number_Correct_Answers = Counts_Number_Correct_Answers();
            int percentage_Passing_Test = (int)((float)number_Correct_Answers / (float)array_Questions.Questions.Length * 100);
            var correct_Answers = number_Correct_Answers.ToString() + " из " + array_Questions.Questions.Length.ToString();

            Transmits_Information_About_Passing_Test_DataBase(number_Correct_Answers, percentage_Passing_Test);
            Time_Test_Timer.Stop();
            time_In_Seconds = 0;

            var test_Result = new Test_Result_Form(percentage_Passing_Test, correct_Answers);
            test_Result.Show();
            Hide();
        }

        private void Moves_On_Next_Question()
        {
            if (question_Number + 1 < array_Questions.Questions.Length)
            {
                question_Number++;
                Shows_Questions(question_Number);
            }
            else if (question_Number + 1 >= array_Questions.Questions.Length)
            {
                Test_Completion_Time.Returns_Time_Completion_Test();
                Shows_Form_With_Result();
            }

            if (question_Number + 1 == array_Questions.Questions.Length)
            {
                Next_Question_Batton.BackgroundImage = new Bitmap(Properties.Resources.Confirm_Image);
            }
        }

        private void Determines_Selected_Response_Option()
        {
            if (First_Answer_Option_RadioButton.Checked)
            {
                Saves_Selected_Response(First_Answer_Option_RadioButton.Text);
            }
            else if (Second_Answer_Option_RadioButton.Checked)
            {
                Saves_Selected_Response(Second_Answer_Option_RadioButton.Text);
            }
            else if (Third_Answer_Option_RadioButton.Checked)
            {
                Saves_Selected_Response(Third_Answer_Option_RadioButton.Text);
            }
            else if (Fourth_Answer_Option_RadioButton.Checked)
            {
                Saves_Selected_Response(Fourth_Answer_Option_RadioButton.Text);
            }
            else
            {
                DialogResult result = MessageBox.Show("Не выбранные ответы будут засчитаны как не верные, " +
                    "но вы можете вернуся к ним во время прохождения теста. Продолжить?", "Ответ не выбран", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    Moves_On_Next_Question();
            }
        }

        private void Show_Selected_Answer_Option()
        {
            if (array_Questions.Questions[question_Number].selected_Answer == First_Answer_Option_RadioButton.Text)
            {
                First_Answer_Option_RadioButton.Checked = true;
            }
            else if (array_Questions.Questions[question_Number].selected_Answer == Second_Answer_Option_RadioButton.Text)
            {
                Second_Answer_Option_RadioButton.Checked = true;
            }
            else if (array_Questions.Questions[question_Number].selected_Answer == Third_Answer_Option_RadioButton.Text)
            {
                Third_Answer_Option_RadioButton.Checked = true;
            }
            else if (array_Questions.Questions[question_Number].selected_Answer == Fourth_Answer_Option_RadioButton.Text)
            {
                Fourth_Answer_Option_RadioButton.Checked = true;
            }
            else
            {
                First_Answer_Option_RadioButton.Checked = false;
                Second_Answer_Option_RadioButton.Checked = false;
                Third_Answer_Option_RadioButton.Checked = false;
                Fourth_Answer_Option_RadioButton.Checked = false;
            }
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
            if (question_Number + 1 < array_Questions.Questions.Length)
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

        private void Time_Test_Tick(object sender, EventArgs e)
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

                DialogResult result = MessageBox.Show("Вы не успели выполнить тест за указаное время. " +
                    "Оставшиеся вопросы будут засчитаны как не верно отвеченые.", "Время вышло", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    Shows_Form_With_Result();
                }
            }
        }
    }
}
