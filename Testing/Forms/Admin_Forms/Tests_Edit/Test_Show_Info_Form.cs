using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Testing.Class;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Struct;

namespace Testing.Forms.Admin.Tests_Edit
{
    public partial class Test_Show_Info_Form : Form
    {
        private List<Test> tests;

        public Test_Show_Info_Form()
        {
            InitializeComponent();
            Unloads_Data_From_Database();
            Fills_Combobox();
        }

        private List<Test> Return_Standard_Data_List()
        {
            return tests.OrderBy(x => x.name).ToList();
        }

        private void Unloads_Data_From_Database()
        {
            var query = "select Id_Test, Name_Test, Full_Name_Tester, Time_Complete " +
                "from Tests join Testers on Id_Tester = Tester_Id";
            DataSet dataSet = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);

            tests = Fills_Dictionary_With_Data_From_Database(dataSet);
            Show_Information_In_DataGridView();
        }

        private List<Test> Fills_Dictionary_With_Data_From_Database(DataSet dataSet)
        {
            var list_Tests = new List<Test>();
            var test = new Test();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                test.id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id_Test"]);
                test.name = Convert.ToString(dataSet.Tables[0].Rows[i]["Name_Test"]);
                test.name_Tester = Convert.ToString(dataSet.Tables[0].Rows[i]["Full_Name_Tester"]);
                if (Convert.ToInt32(dataSet.Tables[0].Rows[i]["Time_Complete"]) == 0)
                {
                    test.time_Complete = "Не ограничено";
                }
                else
                {
                    test.time_Complete = Convert.ToString(dataSet.Tables[0].Rows[i]["Time_Complete"]) + " мин.";
                }

                list_Tests.Add(test);
            }
            return list_Tests;
        }

        private void Fills_Combobox()
        {
            var bindingSource = new BindingSource();

            bindingSource.DataSource = tests.OrderBy(x => x.name_Tester).Select(x => x.name_Tester).Distinct().ToList();
            Filtering_Full_Name_Tester_ComboBox.DataSource = bindingSource.DataSource;
        }

        private void Show_Information_In_DataGridView()
        {
            var list_Tests = Defines_Selected_Filters();

            if (list_Tests.Count > 0)
            {
                List<Column_Parameter> column_Parameters = Returns_Array_Column_Parametrs();
                Customization_DataGridView.Sets_Line_Height(Tests_DataGridView);

                Tests_DataGridView.RowCount = list_Tests.Count;
                Tests_DataGridView.ColumnCount = column_Parameters.Count;

                Fills_DataGridView(list_Tests);

                Customization_DataGridView.Sets_Parameters_For_DataGridView(Tests_DataGridView);
                Customization_DataGridView.Sets_Received_Titles_And_Size_For_Headings(Tests_DataGridView, column_Parameters);
                Tests_DataGridView.Focus();
            }
            else
            {
                Tests_DataGridView.Rows.Clear();
                MessageBox.Show("Записей не найдено!");
            }
            Number_Entry_Label.Text = list_Tests.Count + " из " + tests.Count;
        }

        private void Fills_DataGridView(List<Test> list_Tests)
        {
            for (var i = 0; i < list_Tests.Count; ++i)
            {
                Tests_DataGridView.Rows[i].Cells[0].Value = string.Join(Environment.NewLine, list_Tests[i].id);
                Tests_DataGridView.Rows[i].Cells[1].Value = string.Join(Environment.NewLine, list_Tests[i].name);
                Tests_DataGridView.Rows[i].Cells[2].Value = string.Join(Environment.NewLine, list_Tests[i].name_Tester);
                Tests_DataGridView.Rows[i].Cells[3].Value = string.Join(Environment.NewLine, list_Tests[i].time_Complete);
            }
        }

        private List<Column_Parameter> Returns_Array_Column_Parametrs()
        {
            var names_Column = new List<Column_Parameter>()
            {
                new Column_Parameter{ name = "Id записи", size = 50},
                new Column_Parameter{ name = "Название теста", size = 950},
                new Column_Parameter{ name = "ФИО тестера", size = 485},
                new Column_Parameter{ name = "Время прохождения", size = 400},
            };
            return names_Column;
        }

        private List<Test> Defines_Selected_Filters()
        {
            var list_Tests = Return_Standard_Data_List();

            if (Filtering_Full_Name_CheckBox.Checked)
            {
                list_Tests = Returns_Filtered_Data_By_Selected_Parameter();
            }
            if (Sorting_ComboBox.SelectedIndex != 0)
            {
                list_Tests = Sorts_Data_By_Specified_Parameter(list_Tests);
            }

            Data_Search.Clears_Datagridview_From_Search(Tests_DataGridView);
            return list_Tests;
        }

        private List<Test> Returns_Filtered_Data_By_Selected_Parameter()
        {
            var list_Tests = Return_Standard_Data_List();

            if (Filtering_Full_Name_CheckBox.Checked)
            {
                list_Tests = list_Tests.Where(x => x.name_Tester == Filtering_Full_Name_Tester_ComboBox.Text).ToList();
            }
            return list_Tests;
        }

        private List<Test> Sorts_Data_By_Specified_Parameter(List<Test> list_Test)
        {
            switch (Sorting_ComboBox.SelectedIndex)
            {
                case 1:
                    list_Test = list_Test.OrderBy(x => x.name).ToList();
                    break;
                case 2:
                    list_Test = list_Test.OrderByDescending(x => x.name).ToList();
                    break;
                case 3:
                    list_Test = list_Test.OrderBy(x => x.name_Tester).ToList();
                    break;
                case 4:
                    list_Test = list_Test.OrderByDescending(x => x.name_Tester).ToList();
                    break;
            }
            return list_Test;
        }

        private void Next_Entry_Button_Click(object sender, System.EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Next_Entry(Tests_DataGridView);
        }

        private void Last_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Last_Entry(Tests_DataGridView);
        }

        private void First_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_First_Entry(Tests_DataGridView);
        }

        private void Previos_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Previos_Entry(Tests_DataGridView);
        }

        private void Filter_Show_Button_Click(object sender, EventArgs e)
        {
            Groupbox_Display.Displays_Groupbox_Center_Form(Filter_GroupBox, ClientSize.Width, ClientSize.Height);
        }

        private void Fiter_Reset_Button_Click(object sender, EventArgs e)
        {
            Sorting_ComboBox.SelectedIndex = 0;
            Filtering_Full_Name_CheckBox.Checked = false;
            Search_TextBox.Text = string.Empty;
            Tests_DataGridView.ClearSelection();
            Data_Search.Clears_Datagridview_From_Search(Tests_DataGridView);
            Show_Information_In_DataGridView();
        }

        private void Export_Excel_Button_Click(object sender, EventArgs e)
        {
            var name_File = "Сипсок тестов";
            var width_Column = new int[] { 5, 80, 50, 20 };
            List<Column_Parameter> column_Parametrs = Returns_Array_Column_Parametrs();

            Groupbox_Display.Displays_Groupbox_Center_Form(save_Progress_GroupBox, ClientSize.Width, ClientSize.Height);
            Working_With_Excel.Save_File_Excel(Tests_DataGridView, column_Parametrs, width_Column, name_File, Save_Progress_ProgressBar);
            save_Progress_GroupBox.Visible = false;
            Save_Progress_ProgressBar.Value = 0;
        }

        private void Update_DataGridView_Button_Click(object sender, EventArgs e)
        {
            Unloads_Data_From_Database();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            var form = new Admin_Menu_Form();
            form.Show();
            Hide();
        }

        private void Hide_Filter_Button_Click(object sender, EventArgs e)
        {
            Filter_GroupBox.Visible = false;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Data_Search.Searches_Requested_Information(Tests_DataGridView, Search_TextBox);
        }

        private void Filtering_Full_Name_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Filtering_Full_Name_Tester_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Sorting_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Delete_Entry_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Тест, вопросы и результаты прохождения данного теста будут удалены без возмоности востановления. Вы уверены?",
                 "Удаление теста", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var id_Test = Convert.ToInt32(Tests_DataGridView.CurrentRow.Cells[0].Value);
                DataBase_Editor.Edited_Information_To_DataBase("delete from Qustions where Test_Id = " + id_Test + "; " +
                    "delete from Results where Test_Id = " + id_Test + "; delete from Tests where Id_Test = " + id_Test + "");
            }
        }
    }
}
