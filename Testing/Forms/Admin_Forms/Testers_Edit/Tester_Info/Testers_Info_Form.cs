using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms.Admin_Forms.Testers_Edit;
using Testing.Forms.Admin_Forms.Testers_Edit.Tester_Info;
using Testing.Struct;

namespace Testing.Forms.Admin.Testers_Edit
{
    public partial class Testers_Info_Form : Form
    {
        private List_Tester list_Tester = new();

        public Testers_Info_Form()
        {
            InitializeComponent();
            Show_Information_In_DataGridView();
        }

        private int Returns_Id_Selected_Row()
        {
            try
            {
                return Convert.ToInt32(Testers_DataGridView.CurrentRow.Cells[0].Value);
            }
            catch
            {
                return 0;
            }
        }

        private void Fills_DataGridView(List<Tester> list_Testers)
        {
            for (var i = 0; i < list_Testers.Count; ++i)
            {
                Testers_DataGridView.Rows[i].Cells[0].Value = string.Join(Environment.NewLine, list_Testers[i].id);
                Testers_DataGridView.Rows[i].Cells[1].Value = string.Join(Environment.NewLine, list_Testers[i].full_Name);
                Testers_DataGridView.Rows[i].Cells[2].Value = string.Join(Environment.NewLine, list_Testers[i].login);
                Testers_DataGridView.Rows[i].Cells[3].Value = string.Join(Environment.NewLine, list_Testers[i].password);
            }
        }

        private List<Column_Parameter> Returns_Array_Column_Parametrs()
        {
            var names_Column = new List<Column_Parameter>()
            {
                new Column_Parameter{ name = "Id записи", size = 50},
                new Column_Parameter{ name = "ФИО тестера", size = 1035},
                new Column_Parameter{ name = "Логин", size = 400},
                new Column_Parameter{ name = "Пароль", size = 400},
            };
            return names_Column;
        }

        private void Show_Information_In_DataGridView()
        {
            var list_Testers = list_Tester.testers;

            if (list_Testers.Count > 0)
            {
                List<Column_Parameter> column_Parameters = Returns_Array_Column_Parametrs();
                Customization_DataGridView.Sets_Line_Height(Testers_DataGridView);

                Testers_DataGridView.RowCount = list_Testers.Count;
                Testers_DataGridView.ColumnCount = column_Parameters.Count;

                Fills_DataGridView(list_Testers);

                Customization_DataGridView.Sets_Parameters_For_DataGridView(Testers_DataGridView);
                Customization_DataGridView.Sets_Received_Titles_And_Size_For_Headings(Testers_DataGridView, column_Parameters);
                Testers_DataGridView.Focus();
            }
            else
            {
                Testers_DataGridView.Rows.Clear();
                MessageBox.Show("Записей не найдено!");
            }
            Number_Entry_Label.Text = list_Testers.Count + " из " + list_Tester.testers.Count;
        }

        private void Next_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Next_Entry(Testers_DataGridView);
        }

        private void Previos_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Previos_Entry(Testers_DataGridView);
        }

        private void First_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_First_Entry(Testers_DataGridView);
        }

        private void Last_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Last_Entry(Testers_DataGridView);
        }

        private void Filter_Show_Button_Click(object sender, EventArgs e)
        {
            Groupbox_Display.Displays_Groupbox_Center_Form(Filter_GroupBox, ClientSize.Width, ClientSize.Height);
        }

        private void Hide_Filter_Button_Click(object sender, EventArgs e)
        {
            Filter_GroupBox.Visible = false;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Data_Search.Searches_Requested_Information(Testers_DataGridView, Search_TextBox);
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            var form = new Admin_Menu_Form();
            form.Show();
            Hide();
        }

        private void Edit_Entry_Button_Click(object sender, EventArgs e)
        {
            var form = new Tester_Edit_Form(list_Tester.testers, Returns_Id_Selected_Row());
            form.Show();
            Hide();
        }

        private void Fiter_Reset_Button_Click(object sender, EventArgs e)
        {
            Search_TextBox.Text = string.Empty;
            Testers_DataGridView.ClearSelection();
            Data_Search.Clears_Datagridview_From_Search(Testers_DataGridView);
            Show_Information_In_DataGridView();
        }

        private void Export_Excel_Button_Click(object sender, EventArgs e)
        {
            var name_File = "Список тестеров";
            var width_Column = new int[] { 5, 60, 20, 20 };
            List<Column_Parameter> column_Parametrs = Returns_Array_Column_Parametrs();

            Groupbox_Display.Displays_Groupbox_Center_Form(save_Progress_GroupBox, ClientSize.Width, ClientSize.Height);
            Working_With_Excel.Save_File_Excel(Testers_DataGridView, column_Parametrs, width_Column, name_File, Save_Progress_ProgressBar);
            save_Progress_GroupBox.Visible = false;
            Save_Progress_ProgressBar.Value = 0;
        }
    }
}
