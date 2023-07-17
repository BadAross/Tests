using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms.User_Forms.Statistic_User;
using Testing.Struct;

namespace Testing.Forms
{
    public partial class Statistic_User_Form : Form
    {
        private static List_Result_Passing_Test_User list_Passing_Test = new();

        public Statistic_User_Form()
        {
            InitializeComponent();
            Fills_Combobox();
        }

        private void Fills_Combobox()
        {
            var bindingSource = new BindingSource();

            bindingSource.DataSource = list_Passing_Test.results.OrderBy(x => x.full_Name_Tester).Select(x => x.full_Name_Tester).Distinct().ToList();
            Filtering_Full_Name_Tester_ComboBox.DataSource = bindingSource.DataSource;
        }

        private List<Result_Passing_Test> Returns_Filtered_Data_By_Selected_Parameter()
        {
            var filter_List = list_Passing_Test.results;

            if (Filtering_Full_Name_Tester_CheckBox.Checked)
            {
                filter_List = filter_List.Where(x => x.full_Name_Tester == Filtering_Full_Name_Tester_ComboBox.Text).ToList();
            }
            return filter_List;
        }

        private void Fills_DataGridView(List<Result_Passing_Test> list_Result_Passing_Test)
        {
            for (var i = 0; i < list_Result_Passing_Test.Count; ++i)
            {
                Test_Result_DataGridView.Rows[i].Cells[0].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].id);
                Test_Result_DataGridView.Rows[i].Cells[1].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].full_Name_Tester);
                Test_Result_DataGridView.Rows[i].Cells[2].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].name_Test);
                Test_Result_DataGridView.Rows[i].Cells[3].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].number_Correct_Answers);
                Test_Result_DataGridView.Rows[i].Cells[4].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].percentage_Correct_Answers);
                Test_Result_DataGridView.Rows[i].Cells[5].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].test_Start_Time);
                Test_Result_DataGridView.Rows[i].Cells[6].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].time_Spent);
            }
        }

        private List<Column_Parameter> Returns_Array_Column_Parametrs()
        {
            var names_Column = new List<Column_Parameter>()
            {
                new Column_Parameter{ name = "id", size = 50},
                new Column_Parameter{ name = "ФИО тестера", size = 500},
                new Column_Parameter{ name = "Название теста", size = 685},
                new Column_Parameter{ name = "Количество верных ответов", size = 200},
                new Column_Parameter{ name = "Процент прохождения", size = 150},
                new Column_Parameter{ name = "Время начала теста", size = 150},
                new Column_Parameter{ name = "Время прохождения теста", size = 150}
            };
            return names_Column;
        }

        private void Defines_Selected_Filters()
        {
            var filter_List = list_Passing_Test.results;

            if (Filtering_Full_Name_Tester_CheckBox.Checked)
            {
                filter_List = Returns_Filtered_Data_By_Selected_Parameter();
            }
            if (Sorting_ComboBox.SelectedIndex != 0)
            {
                filter_List = Sorts_Data_By_Specified_Parameter(filter_List);
            }

            Data_Search.Clears_Datagridview_From_Search(Test_Result_DataGridView);
            Show_Information_In_DataGridView(filter_List);
        }

        private void Show_Information_In_DataGridView(List<Result_Passing_Test> list_Result_Passing_Test)
        {
            if (list_Result_Passing_Test.Count > 0)
            {
                Determines_Presence_Records(list_Result_Passing_Test);
            }
            else
            {
                Test_Result_DataGridView.Rows.Clear();
                MessageBox.Show("Записей не найдено!");
            }
            Number_Entry_Label.Text = list_Result_Passing_Test.Count + " из " + list_Passing_Test.results.Count;
        }


        private void Determines_Presence_Records(List<Result_Passing_Test> list_Result_Passing_Test)
        {
            List<Column_Parameter> column_Parameters = Returns_Array_Column_Parametrs();
            Customization_DataGridView.Sets_Line_Height(Test_Result_DataGridView);

            Test_Result_DataGridView.RowCount = list_Result_Passing_Test.Count;
            Test_Result_DataGridView.ColumnCount = column_Parameters.Count;

            Fills_DataGridView(list_Result_Passing_Test);

            Customization_DataGridView.Sets_Parameters_For_DataGridView(Test_Result_DataGridView);
            Customization_DataGridView.Sets_Received_Titles_And_Size_For_Headings(Test_Result_DataGridView, column_Parameters);
            Test_Result_DataGridView.Focus();
        }


        private List<Result_Passing_Test> Sorts_Data_By_Specified_Parameter(List<Result_Passing_Test> list_Result_Passing_Test)
        {
            switch (Sorting_ComboBox.SelectedIndex)
            {
                case 1:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.name_Test).ToList();
                    break;
                case 2:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.name_Test).ToList();
                    break;
                case 3:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.percentage_Correct_Answers).ToList();
                    break;
                case 4:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.percentage_Correct_Answers).ToList();
                    break;
                case 5:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.test_Start_Time).ToList();
                    break;
                case 6:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.test_Start_Time).ToList();
                    break;
                case 7:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.time_Spent).ToList();
                    break;
                case 8:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.time_Spent).ToList();
                    break;
            }
            return list_Result_Passing_Test;
        }

        private void Filtering_Open_button_Click(object sender, System.EventArgs e)
        {
            Groupbox_Display.Displays_Groupbox_Center_Form(Filter_GroupBox, ClientSize.Width, ClientSize.Height);
        }

        private void Hide_Filter_Button_Click(object sender, EventArgs e)
        {
            Filter_GroupBox.Visible = false;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Data_Search.Searches_Requested_Information(Test_Result_DataGridView, Search_TextBox);
        }

        private void Filter_Name_Test_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Filtering_Full_Name_Tester_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Filtering_Name_Test_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Filtering_Full_Name_Tester_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Sorting_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Previos_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Previos_Entry(Test_Result_DataGridView);
        }

        private void First_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_First_Entry(Test_Result_DataGridView);
        }

        private void Last_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Last_Entry(Test_Result_DataGridView);
        }

        private void Next_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Next_Entry(Test_Result_DataGridView);
        }

        private void Close_Form_Button_Click(object sender, System.EventArgs e)
        {
            var uzer_Menu = new User_Menu_Form();
            uzer_Menu.Show();
            Hide();
        }

        private void Upload_In_Excel_Button_Click(object sender, System.EventArgs e)
        {
            var name_File = "Результаты тестировани ";
            var width_Column = new int[] { 5, 40, 60, 10, 10, 25, 20 };
            List<Column_Parameter> column_Parametrs = Returns_Array_Column_Parametrs();

            Groupbox_Display.Displays_Groupbox_Center_Form(save_Progress_GroupBox, ClientSize.Width, ClientSize.Height);
            Working_With_Excel.Save_File_Excel(Test_Result_DataGridView, column_Parametrs, width_Column, name_File, Save_Progress_ProgressBar);
            save_Progress_GroupBox.Visible = false;
            Save_Progress_ProgressBar.Value = 0;
        }

        private void Resetting_Filter_Button_Click(object sender, System.EventArgs e)
        {
            Sorting_ComboBox.SelectedIndex = 0;
            Search_TextBox.Text = string.Empty;
            Test_Result_DataGridView.ClearSelection();
            Data_Search.Clears_Datagridview_From_Search(Test_Result_DataGridView);
            Show_Information_In_DataGridView(list_Passing_Test.results);
        }
    }
}
