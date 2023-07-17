using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms.Tester_Forms.Result_Test;
using Testing.Struct;

namespace Testing.Forms.Tester_Form
{
    public partial class Result_Tests_Form : Form
    {
        private List_Result_Tester list_Results = new();

        public Result_Tests_Form()
        {
            InitializeComponent();
            Fills_Combobox();
        }

        private void Fills_Combobox()
        {
            var bindingSource = new BindingSource();

            bindingSource.DataSource = list_Results.results.OrderBy(x => x.full_Name_User).Select(x => x.full_Name_User).Distinct().ToList();
            Filtering_Full_Name_Uzer_ComboBox.DataSource = bindingSource.DataSource;

            bindingSource.DataSource = list_Results.results.OrderBy(x => x.name_Test).Select(x => x.name_Test).Distinct().ToList();
            Filtering_Name_Test_ComboBox.DataSource = bindingSource.DataSource;

            bindingSource.DataSource = list_Results.results.OrderBy(x => x.code_Group).Select(x => x.code_Group).Distinct().ToList();
            Filtering_Group_ComboBox.DataSource = bindingSource.DataSource;
        }

        private List<Result_Passing_Test> Returns_Filtered_Data_By_Selected_Parameter()
        {
            var list_Result_Passing_Test = list_Results.results;

            if (Filter_Full_Name_CheckBox.Checked)
            {
                list_Result_Passing_Test = list_Result_Passing_Test.Where(x => x.full_Name_User == Filtering_Full_Name_Uzer_ComboBox.Text).ToList();
            }
            if (Filter_Name_Test_CheckBox.Checked)
            {
                list_Result_Passing_Test = list_Result_Passing_Test.Where(x => x.name_Test == Filtering_Name_Test_ComboBox.Text).ToList();
            }
            if (Filtering_Group_CheckBox.Checked)
            {
                list_Result_Passing_Test = list_Result_Passing_Test.Where(x => x.code_Group == Filtering_Group_ComboBox.Text).ToList();
            }
            return list_Result_Passing_Test;
        }

        private void Defines_Selected_Filters()
        {
            var list_Result_Passing_Test = list_Results.results;

            if (Filter_Full_Name_CheckBox.Checked | Filter_Name_Test_CheckBox.Checked | Filtering_Group_CheckBox.Checked)
            {
                list_Result_Passing_Test = Returns_Filtered_Data_By_Selected_Parameter();
            }
            if (Sorting_ComboBox.SelectedIndex != 0)
            {
                list_Result_Passing_Test = Sorts_Data_By_Specified_Parameter(list_Result_Passing_Test);
            }

            Data_Search.Clears_Datagridview_From_Search(Test_Result_DataGridView);
            Determines_Presence_Records(list_Result_Passing_Test);
        }

        private void Fills_DataGridView(List<Result_Passing_Test> list_Result_Passing_Test)
        {
            for (var i = 0; i < list_Result_Passing_Test.Count; ++i)
            {
                Test_Result_DataGridView.Rows[i].Cells[0].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].id);
                Test_Result_DataGridView.Rows[i].Cells[1].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].full_Name_User);
                Test_Result_DataGridView.Rows[i].Cells[2].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].code_Group);
                Test_Result_DataGridView.Rows[i].Cells[3].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].name_Test);
                Test_Result_DataGridView.Rows[i].Cells[4].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].number_Correct_Answers);
                Test_Result_DataGridView.Rows[i].Cells[5].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].percentage_Correct_Answers);
                Test_Result_DataGridView.Rows[i].Cells[6].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].test_Start_Time);
                Test_Result_DataGridView.Rows[i].Cells[7].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].time_Spent);
            }
        }

        private List<Column_Parameter> Returns_Array_Column_Parametrs()
        {
            var names_Column = new List<Column_Parameter>()
            {
                new Column_Parameter{ name = "Id записи", size = 50},
                new Column_Parameter{ name = "ФИО пользователя", size = 500},
                new Column_Parameter{ name = "Код группы", size = 185},
                new Column_Parameter{ name = "Название теста", size = 464},
                new Column_Parameter{ name = "Количество верных ответов", size = 200},
                new Column_Parameter{ name = "Процент прохождения", size = 150},
                new Column_Parameter{ name = "Время начала теста", size = 150},
                new Column_Parameter{ name = "Время прохождения теста", size = 150}
            };
            return names_Column;
        }

        private void Determines_Presence_Records(List<Result_Passing_Test> list_Result_Passing_Test)
        {
            if (list_Result_Passing_Test.Count > 0)
            {
                Show_Information_In_DataGridView(list_Result_Passing_Test);
            }
            else
            {
                Test_Result_DataGridView.Rows.Clear();
                MessageBox.Show("Записей не найдено!");
            }
            Number_Entry_Label.Text = list_Result_Passing_Test.Count + " из " + list_Results.results.Count;
        }

        private void Show_Information_In_DataGridView(List<Result_Passing_Test> list_Result_Passing_Test)
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
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.full_Name_User).ToList();
                    break;
                case 2:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.full_Name_User).ToList();
                    break;
                case 3:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.code_Group).ToList();
                    break;
                case 4:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.code_Group).ToList();
                    break;
                case 5:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.name_Test).ToList();
                    break;
                case 6:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.name_Test).ToList();
                    break;
                case 7:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.percentage_Correct_Answers).ToList();
                    break;
                case 8:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.percentage_Correct_Answers).ToList();
                    break;
                case 9:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.test_Start_Time).ToList();
                    break;
                case 10:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.test_Start_Time).ToList();
                    break;
                case 11:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.time_Spent).ToList();
                    break;
                case 12:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.time_Spent).ToList();
                    break;
            }
            return list_Result_Passing_Test;
        }

        private void Filtering_Open_button_Click(object sender, System.EventArgs e)
        {
            Groupbox_Display.Displays_Groupbox_Center_Form(Filter_GroupBox, ClientSize.Width, ClientSize.Height);
        }

        private void Sorting_ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Hide_Filter_Button_Click(object sender, System.EventArgs e)
        {
            Filter_GroupBox.Visible = false;
        }

        private void Filtering_Full_Name_Uzer_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Filtering_Name_Test_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Filtering_Group_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Filter_Full_Name_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Filter_Name_Test_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Filtering_Group_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Defines_Selected_Filters();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Data_Search.Searches_Requested_Information(Test_Result_DataGridView, Search_TextBox);
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

        private void Close_Form_Button_Click(object sender, EventArgs e)
        {
            var tester_Menu = new Tester_Menu_Form();
            tester_Menu.Show();
            Hide();
        }

        private void Resetting_Filter_Button_Click(object sender, System.EventArgs e)
        {
            Sorting_ComboBox.SelectedIndex = 0;
            Search_TextBox.Text = string.Empty;
            Test_Result_DataGridView.ClearSelection();
            Data_Search.Clears_Datagridview_From_Search(Test_Result_DataGridView);
            Determines_Presence_Records(list_Results.results);
        }

        private void Upload_In_Excel_Button_Click(object sender, EventArgs e)
        {
            var name_File = "Результаты тестировани ";
            var width_Column = new int[] { 5, 40, 20, 60, 10, 10, 25, 20 };
            List<Column_Parameter> column_Parametrs = Returns_Array_Column_Parametrs();

            Groupbox_Display.Displays_Groupbox_Center_Form(save_Progress_GroupBox, ClientSize.Width, ClientSize.Height);
            Working_With_Excel.Save_File_Excel(Test_Result_DataGridView, column_Parametrs, width_Column, name_File, Save_Progress_ProgressBar);
            save_Progress_GroupBox.Visible = false;
            Save_Progress_ProgressBar.Value = 0;
        }
    }
}
