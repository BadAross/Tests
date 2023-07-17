using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms.Admin;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Results_Edit
{
    public partial class Result_Info_Form : Form
    {
        private List_Result_Info list_Result = new();

        public Result_Info_Form()
        {
            InitializeComponent();
            Fills_ComboBoxes();
        }

        private void Fills_ComboBoxes()
        {
            var bindingSource = new BindingSource();

            bindingSource.DataSource = list_Result.Results.OrderBy(x => x.full_Name_User).Select(x => x.full_Name_User).Distinct().ToList();
            Filtering_Full_Name_User_ComboBox.DataSource = bindingSource.DataSource;

            bindingSource.DataSource = list_Result.Results.OrderBy(x => x.code_Group).Select(x => x.code_Group).Distinct().ToList();
            Filtering_Code_Group_ComboBox.DataSource = bindingSource.DataSource;

            bindingSource.DataSource = list_Result.Results.OrderBy(x => x.full_Name_Tester).Select(x => x.full_Name_Tester).Distinct().ToList();
            Filtering_Full_Name_Tester_ComboBox.DataSource = bindingSource.DataSource;

            bindingSource.DataSource = list_Result.Results.OrderBy(x => x.name_Test).Select(x => x.name_Test).Distinct().ToList();
            Filtering_Name_Test_ComboBox.DataSource = bindingSource.DataSource;
        }

        private void Fills_DataGridView(List<Result_Passing_Test> list_Result_Passing_Test)
        {
            for (var i = 0; i < list_Result_Passing_Test.Count; ++i)
            {
                Result_DataGridView.Rows[i].Cells[0].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].id);
                Result_DataGridView.Rows[i].Cells[1].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].full_Name_User);
                Result_DataGridView.Rows[i].Cells[2].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].code_Group);
                Result_DataGridView.Rows[i].Cells[3].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].full_Name_Tester);
                Result_DataGridView.Rows[i].Cells[4].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].name_Test);
                Result_DataGridView.Rows[i].Cells[5].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].number_Correct_Answers);
                Result_DataGridView.Rows[i].Cells[6].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].percentage_Correct_Answers);
                Result_DataGridView.Rows[i].Cells[7].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].test_Start_Time);
                Result_DataGridView.Rows[i].Cells[8].Value = string.Join(Environment.NewLine, list_Result_Passing_Test[i].time_Spent);
            }
        }

        private List<Column_Parameter> Returns_Array_Column_Parametrs()
        {
            var names_Column = new List<Column_Parameter>()
            {
                new Column_Parameter{ name = "Id записи", size = 50},
                new Column_Parameter{ name = "ФИО пользователя", size = 300},
                new Column_Parameter{ name = "Код группы", size = 200},
                new Column_Parameter{ name = "ФИО тестера", size = 300},
                new Column_Parameter{ name = "Название теста", size = 435},
                new Column_Parameter{ name = "Количество верных ответов", size = 150},
                new Column_Parameter{ name = "Процент прохождения", size = 150},
                new Column_Parameter{ name = "Время начала теста", size = 150},
                new Column_Parameter{ name = "Время прохождения", size = 150},
            };
            return names_Column;
        }

        private List<Result_Passing_Test> Defines_Selected_Filters()
        {
            var list_Result_Passing_Test = list_Result.Results;

            if (Filtering_Full_Name_User_CheckBox.Checked | Filtering_Code_Group_CheckBox.Checked |
                Filtering_Full_Name_Tester_CheckBox.Checked | Filtering_Name_Test_CheckBox.Checked)
            {
                list_Result_Passing_Test = Returns_Filtered_Data_By_Selected_Parameter();
            }
            if (Sorting_ComboBox.SelectedIndex != 0)
            {
                list_Result_Passing_Test = Sorts_Data_By_Specified_Parameter(list_Result_Passing_Test);
            }

            Data_Search.Clears_Datagridview_From_Search(Result_DataGridView);

            return list_Result_Passing_Test;
        }

        private void Show_Information_In_DataGridView()
        {
            var list_Result_Passing_Test = Defines_Selected_Filters();

            if (list_Result_Passing_Test.Count > 0)
            {
                List<Column_Parameter> column_Parameters = Returns_Array_Column_Parametrs();
                Customization_DataGridView.Sets_Line_Height(Result_DataGridView);

                Result_DataGridView.RowCount = list_Result_Passing_Test.Count;
                Result_DataGridView.ColumnCount = column_Parameters.Count;

                Fills_DataGridView(list_Result_Passing_Test);

                Customization_DataGridView.Sets_Parameters_For_DataGridView(Result_DataGridView);
                Customization_DataGridView.Sets_Received_Titles_And_Size_For_Headings(Result_DataGridView, column_Parameters);
                Result_DataGridView.Focus();
            }
            else
            {
                Result_DataGridView.Rows.Clear();
                MessageBox.Show("Записей не найдено!");
            }
            Number_Entry_Label.Text = list_Result_Passing_Test.Count + " из " + list_Result.Results.Count;
        }

        private List<Result_Passing_Test> Returns_Filtered_Data_By_Selected_Parameter()
        {
            var list_Result_Passing_Test = list_Result.Results;

            if (Filtering_Full_Name_User_CheckBox.Checked)
            {
                list_Result_Passing_Test = list_Result_Passing_Test.Where(x => x.full_Name_User == Filtering_Full_Name_User_ComboBox.Text).ToList();
            }
            if (Filtering_Code_Group_CheckBox.Checked)
            {
                list_Result_Passing_Test = list_Result_Passing_Test.Where(x => x.code_Group == Filtering_Code_Group_ComboBox.Text).ToList();
            }
            if (Filtering_Full_Name_Tester_CheckBox.Checked)
            {
                list_Result_Passing_Test = list_Result_Passing_Test.Where(x => x.full_Name_Tester == Filtering_Full_Name_Tester_ComboBox.Text).ToList();
            }
            if (Filtering_Name_Test_CheckBox.Checked)
            {
                list_Result_Passing_Test = list_Result_Passing_Test.Where(x => x.name_Test == Filtering_Name_Test_ComboBox.Text).ToList();
            }
            return list_Result_Passing_Test;
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
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.full_Name_Tester).ToList();
                    break;
                case 6:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.full_Name_Tester).ToList();
                    break;
                case 7:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderBy(x => x.name_Test).ToList();
                    break;
                case 8:
                    list_Result_Passing_Test = list_Result_Passing_Test.OrderByDescending(x => x.name_Test).ToList();
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

        private void Next_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Next_Entry(Result_DataGridView);
        }

        private void Filter_Show_Button_Click(object sender, EventArgs e)
        {
            Groupbox_Display.Displays_Groupbox_Center_Form(Filter_GroupBox, ClientSize.Width, ClientSize.Height);
        }

        private void Last_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Last_Entry(Result_DataGridView);
        }

        private void First_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_First_Entry(Result_DataGridView);
        }

        private void Previos_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Previos_Entry(Result_DataGridView);
        }

        private void Hide_Filter_Button_Click(object sender, EventArgs e)
        {
            Filter_GroupBox.Visible = false;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Data_Search.Searches_Requested_Information(Result_DataGridView, Search_TextBox);
        }

        private void Filtering_Full_Name_User_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Filtering_Full_Name_User_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Filtering_Code_Group_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Filtering_Code_Group_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Filtering_Full_Name_Tester_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Filtering_Full_Name_Tester_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Filtering_Name_Test_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Filtering_Name_Test_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Sorting_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            var form = new Admin_Menu_Form();
            form.Show();
            Hide();
        }

        private void Export_Excel_Button_Click(object sender, EventArgs e)
        {
            var name_File = "Результаты тестирования";
            var width_Column = new int[] { 5, 40, 20, 40, 40, 20, 20, 20, 20 };
            List<Column_Parameter> column_Parametrs = Returns_Array_Column_Parametrs();

            Groupbox_Display.Displays_Groupbox_Center_Form(save_Progress_GroupBox, ClientSize.Width, ClientSize.Height);
            Working_With_Excel.Save_File_Excel(Result_DataGridView, column_Parametrs, width_Column, name_File, Save_Progress_ProgressBar);
            save_Progress_GroupBox.Visible = false;
            Save_Progress_ProgressBar.Value = 0;
        }

        private void Delete_Entry_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Данная запись будет удалена. Вы уверены?",
                 "Удаление результата", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var id_Result = Convert.ToInt32(Result_DataGridView.CurrentRow.Cells[0].Value);
                Delete_Result.Delete_Select_Result(id_Result);
                list_Result.Results.RemoveAt(id_Result);
                Show_Information_In_DataGridView();
            }
        }

        private void Sets_Zero_Index_Comboboxes()
        {
            Filtering_Full_Name_User_ComboBox.SelectedIndex = 0;
            Filtering_Code_Group_ComboBox.SelectedIndex = 0;
            Filtering_Full_Name_Tester_ComboBox.SelectedIndex = 0;
            Filtering_Name_Test_ComboBox.SelectedIndex = 0;
        }

        private void Unchecked_Checkboxes()
        {
            Filtering_Full_Name_User_CheckBox.Checked = false;
            Filtering_Code_Group_CheckBox.Checked = false;
            Filtering_Full_Name_Tester_CheckBox.Checked = false;
            Filtering_Name_Test_CheckBox.Checked = false;
        }

        private void Fiter_Reset_Button_Click(object sender, EventArgs e)
        {
            Sorting_ComboBox.SelectedIndex = 0;
            Sets_Zero_Index_Comboboxes();
            Unchecked_Checkboxes();
            Search_TextBox.Text = string.Empty;
            Result_DataGridView.ClearSelection();
            Data_Search.Clears_Datagridview_From_Search(Result_DataGridView);
            Show_Information_In_DataGridView();
        }
    }
}
