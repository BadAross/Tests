using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Testing.Class;
using Testing.Classes;
using Testing.Struct;

namespace Testing.Forms
{
    public partial class Passing_Test_Form : Form
    {
        private int question_Number = 0;
        private int time_In_Seconds = 0;
        private DateTime test_Start_Time = DateTime.Now;
        private Stopwatch stop_Watch = new Stopwatch();
        private Question[] questions;


        public Passing_Test_Form(string name_Tets)
        {
            InitializeComponent();
            Name_Test_Label.Text = name_Tets;
            DataSet test_Questions = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request("select Id_Test, Id_Question, " +
                "Text_Question, First_Answer, Second_Answer, Third_Answer, Fourth_Answer, Correct_Answer, Time_Complete from Questions join Tests " +
                "on Test_Id=Id_Test where Name_Test = '" + name_Tets + "'");
            questions = Transfers_Questions_From_Database_To_The_Array(test_Questions);

            Shows_Questions(question_Number);
            Sets_Timer_Time(Convert.ToInt32(test_Questions.Tables[0].Rows[0]["Time_Complete"]));
            stop_Watch.Start();
        }

        private void Saves_Selected_Response(string radionButton_Text)
        {
            questions[question_Number].selected_Answer = radionButton_Text;
            Moves_On_Next_Question();
        }

        private string Returns_Time_Passing_Test()
        {
            stop_Watch.Stop();
            var ts = stop_Watch.Elapsed;
            return Convert.ToString(ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds);
        }

        private void Shows_Questions(int question_Number)
        {
            Question_Text_Label.Text = questions[question_Number].text_Question;
            First_Answer_Option_RadioButton.Text = questions[question_Number].first_Answer;
            Second_Answer_Option_RadioButton.Text = questions[question_Number].second_Answer;
            Third_Answer_Option_RadioButton.Text = questions[question_Number].third_Answer;
            Fourth_Answer_Option_RadioButton.Text = questions[question_Number].fourth_Answer;

            Question_Number_Label.Text = Convert.ToString(question_Number + 1) + "/" + questions.Length;
        }

        private int Counts_Number_Correct_Answers()
        {
            var number_Correct_Answers = 0;
            for (int i = 0; i < questions.Length; i++)
            {
                if (questions[i].correct_Answer == questions[i].selected_Answer)
                {
                    number_Correct_Answers++;
                }
            }
            return number_Correct_Answers;
        }

        private void Transmits_Information_About_Passing_Test_DataBase(int number_Correct_Answers, int percentage_Passing_Test)
        {
            string time_Passing_Test = Returns_Time_Passing_Test();
            int id_Active_Account = Active_Account.Returns_Id_Active_Account();
            var percentage_Correct_Answers = number_Correct_Answers.ToString() + "/" + questions.Length.ToString();
            var sql_Command = "insert into Results (Test_Id, User_Id, Number_Correct_Answers, Percentage_Correct_Answers, Test_Start_Time, Time_Spent) " +
                "values (" + id_Active_Account + "," + id_Active_Account + ",'" + percentage_Correct_Answers + "'," +
                "" + percentage_Passing_Test + ",'" + test_Start_Time + "','" + time_Passing_Test + "')";

            DataBase_Editor.Edited_Information_To_DataBase(sql_Command);
        }

        private void Sets_Timer_Time(int test_Time)
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
        }

        private void Shows_Form_With_Result()
        {
            int number_Correct_Answers = Counts_Number_Correct_Answers();
            int percentage_Passing_Test = (int)((float)number_Correct_Answers / (float)questions.Length * 100);
            var correct_Answers = number_Correct_Answers.ToString() + " из " + questions.Length.ToString();

            Transmits_Information_About_Passing_Test_DataBase(number_Correct_Answers, percentage_Passing_Test);
            Time_Test_Timer.Stop();
            time_In_Seconds = 0;

            var test_Result = new Test_Result_Form(percentage_Passing_Test, correct_Answers);
            test_Result.Show();
            Hide();
        }

        private void Moves_On_Next_Question()
        {
            if (question_Number + 1 < questions.Length)
            {
                question_Number++;
                Shows_Questions(question_Number);
            }
            else if (question_Number + 1 >= questions.Length)
            {
                Returns_Time_Passing_Test();
                Shows_Form_With_Result();
            }

            if (question_Number + 1 == questions.Length)
            {
                Next_Question_Batton.BackgroundImage = new Bitmap(Properties.Resources.Confirm_Image);
            }
        }

        private string[] Return_Array_Answer_Options_Specified_Order(DataSet test_Questions, int line_Number)
        {
            int[] a = Composes_Random_Sequence(4);
            var d = new string[4];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    d[i] = Convert.ToString(test_Questions.Tables[0].Rows[line_Number]["First_Answer"]);
                }
                else if (a[i] == 1)
                {
                    d[i] = Convert.ToString(test_Questions.Tables[0].Rows[line_Number]["Second_Answer"]);
                }
                else if (a[i] == 2)
                {
                    d[i] = Convert.ToString(test_Questions.Tables[0].Rows[line_Number]["Third_Answer"]);
                }
                else if (a[i] == 3)
                {
                    d[i] = Convert.ToString(test_Questions.Tables[0].Rows[line_Number]["Fourth_Answer"]);
                }
            }
            return d;
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
            if (questions[question_Number].selected_Answer == First_Answer_Option_RadioButton.Text)
            {
                First_Answer_Option_RadioButton.Checked = true;
            }
            else if (questions[question_Number].selected_Answer == Second_Answer_Option_RadioButton.Text)
            {
                Second_Answer_Option_RadioButton.Checked = true;
            }
            else if (questions[question_Number].selected_Answer == Third_Answer_Option_RadioButton.Text)
            {
                Third_Answer_Option_RadioButton.Checked = true;
            }
            else if (questions[question_Number].selected_Answer == Fourth_Answer_Option_RadioButton.Text)
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

        private int[] Composes_Random_Sequence(int number_Random_Elements)
        {
            var rnd = new Random();
            int[] response_Options = new int[number_Random_Elements];

            for (int i = 0; i < number_Random_Elements; i++)
            {
                bool contains;
                int random_Number;
                do
                {
                    random_Number = rnd.Next(number_Random_Elements);
                    contains = false;
                    for (int j = 0; j < i; j++)
                    {
                        int n = response_Options[j];
                        if (n == random_Number)
                        {
                            contains = true;
                            break;
                        }
                    }
                }
                while (contains);
                response_Options[i] = random_Number;
            }
            return response_Options;
        }

        private Question[] Transfers_Questions_From_Database_To_The_Array(DataSet test_Questions)
        {
            var question = new Question[test_Questions.Tables[0].Rows.Count];
            int[] random_Sequence = Composes_Random_Sequence(test_Questions.Tables[0].Rows.Count);

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
            if (question_Number + 1 < questions.Length)
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
                stop_Watch.Stop();
                User_Menu_Form uzer_Menu = new User_Menu_Form();
                uzer_Menu.Show();
                Hide();
            }
        }

        private void Time_Test_Tick(object sender, EventArgs e)
        {
            if (time_In_Seconds > 0)
            {
                TimeSpan span = TimeSpan.FromSeconds(--time_In_Seconds);
                Time_Test_Label.Text = span.ToString(@"hh\:mm\:ss");
            }
            else if (time_In_Seconds <= 0 && Time_Test_Label.Text != "")
            {
                Time_Test_Timer.Stop();
                Returns_Time_Passing_Test();

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
