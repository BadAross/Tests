using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms.Admin.User_Edit;
using Testing.Forms.Admin_Forms.Users_Edit.User_Info;
using Testing.Struct;

namespace Testing.Forms.Admin.Uzer_Editing
{
    public partial class Users_Show_Info_Form : Form
    {
        private List_User_Info list_User = new();

        public Users_Show_Info_Form()
        {
            InitializeComponent();
            Fills_ComboBox();
        }

        private void Fills_ComboBox()
        {
            var bindingSource = new BindingSource();

            bindingSource.DataSource = list_User.users.OrderBy(x => x.code_Group).Select(x => x.code_Group).Distinct().ToList();
            Filtering_Group_ComboBox.DataSource = bindingSource.DataSource;
        }

        private void Fills_DataGridView(List<User> dictionary_Result_Passing_Test)
        {
            for (var i = 0; i < dictionary_Result_Passing_Test.Count; ++i)
            {
                Users_DataGridView.Rows[i].Cells[0].Value = string.Join(Environment.NewLine, dictionary_Result_Passing_Test[i].id);
                Users_DataGridView.Rows[i].Cells[1].Value = string.Join(Environment.NewLine, dictionary_Result_Passing_Test[i].full_Name);
                Users_DataGridView.Rows[i].Cells[2].Value = string.Join(Environment.NewLine, dictionary_Result_Passing_Test[i].code_Group);
                Users_DataGridView.Rows[i].Cells[3].Value = string.Join(Environment.NewLine, dictionary_Result_Passing_Test[i].login);
                Users_DataGridView.Rows[i].Cells[4].Value = string.Join(Environment.NewLine, dictionary_Result_Passing_Test[i].password);
            }
        }

        private List<Column_Parameter> Returns_Array_Column_Parametrs()
        {
            var names_Column = new List<Column_Parameter>()
            {
                new Column_Parameter{ name = "Id записи", size = 50},
                new Column_Parameter{ name = "ФИО пользователя", size = 750},
                new Column_Parameter{ name = "Код группы", size = 285},
                new Column_Parameter{ name = "Логин", size = 400},
                new Column_Parameter{ name = "Пароль", size = 400},
            };
            return names_Column;
        }

        private int Returns_Id_Selected_Row()
        {
            try
            {
                return Convert.ToInt32(Users_DataGridView.CurrentRow.Cells[0].Value);
            }
            catch
            {
                return 0;
            }
        }

        private List<User> Defines_Selected_Filters()
        {
            var sorting_List_User = Returns_Filtered_Data_By_Selected_Parameter();

            if (Sorting_ComboBox.SelectedIndex != 0)
            {
                sorting_List_User = Sorts_Data_By_Specified_Parameter(sorting_List_User);
            }
            Data_Search.Clears_Datagridview_From_Search(Users_DataGridView);

            return sorting_List_User;
        }

        private List<User> Returns_Filtered_Data_By_Selected_Parameter()
        {
            var sorting_List_User = list_User.users;

            if (Filtering_Group_CheckBox.Checked)
            {
                sorting_List_User = sorting_List_User.Where(x => x.code_Group == Filtering_Group_ComboBox.Text).ToList();
            }
            return sorting_List_User;
        }

        private List<User> Sorts_Data_By_Specified_Parameter(List<User> sorting_List_User)
        {
            switch (Sorting_ComboBox.SelectedIndex)
            {
                case 1:
                    sorting_List_User = sorting_List_User.OrderBy(x => x.full_Name).ToList();
                    break;
                case 2:
                    sorting_List_User = sorting_List_User.OrderByDescending(x => x.full_Name).ToList();
                    break;
                case 3:
                    sorting_List_User = sorting_List_User.OrderBy(x => x.code_Group).ToList();
                    break;
                case 4:
                    sorting_List_User = sorting_List_User.OrderByDescending(x => x.code_Group).ToList();
                    break;
            }
            return sorting_List_User;
        }

        private void Determines_Presence_Records()
        {
            var sorting_List_User = Defines_Selected_Filters();

            if (sorting_List_User.Count > 0)
            {
                Show_Information_In_DataGridView(sorting_List_User);
            }
            else
            {
                Users_DataGridView.Rows.Clear();
                MessageBox.Show("Записей не найдено!");
            }
            Number_Entry_Label.Text = sorting_List_User.Count + " из " + list_User.users.Count;
        }

        private void Show_Information_In_DataGridView(List<User> sorting_List_User)
        {
            List<Column_Parameter> column_Parameters = Returns_Array_Column_Parametrs();
            Customization_DataGridView.Sets_Line_Height(Users_DataGridView);

            Users_DataGridView.RowCount = sorting_List_User.Count;
            Users_DataGridView.ColumnCount = column_Parameters.Count;

            Fills_DataGridView(sorting_List_User);

            Customization_DataGridView.Sets_Parameters_For_DataGridView(Users_DataGridView);
            Customization_DataGridView.Sets_Received_Titles_And_Size_For_Headings(Users_DataGridView, column_Parameters);
            Users_DataGridView.Focus();
        }

        private void Next_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Next_Entry(Users_DataGridView);
        }

        private void Previos_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Previos_Entry(Users_DataGridView);
        }

        private void Last_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_Last_Entry(Users_DataGridView);
        }

        private void First_Entry_Button_Click(object sender, EventArgs e)
        {
            Switching_Datagridview_Rows.Moves_First_Entry(Users_DataGridView);
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
            Data_Search.Searches_Requested_Information(Users_DataGridView, Search_TextBox);
        }

        private void Filtering_Full_Name_Uzer_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Determines_Presence_Records();
        }

        private void Filtering_Group_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Determines_Presence_Records();
        }

        private void Filter_Full_Name_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Determines_Presence_Records();
        }

        private void Filtering_Group_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Determines_Presence_Records();
        }

        private void Sorting_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Determines_Presence_Records();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            var form = new Admin_Menu_Form();
            form.Show();
            Hide();
        }

        private void Edit_Group_Button_Click(object sender, EventArgs e)
        {
            var form = new Group_Editing_Form();
            form.Show();
            Hide();
        }

        private void Edit_Entry_Button_Click(object sender, EventArgs e)
        {
            List<User> users = Defines_Selected_Filters();
            var form = new User_Editing_Form(users, Returns_Id_Selected_Row());
            form.Show();
            Hide();
        }

        private void Export_Excel_Button_Click(object sender, EventArgs e)
        {
            var name_File = "Список пользователей";
            var width_Column = new int[] { 5, 40, 20, 10, 10 };
            List<Column_Parameter> column_Parametrs = Returns_Array_Column_Parametrs();

            Groupbox_Display.Displays_Groupbox_Center_Form(save_Progress_GroupBox, ClientSize.Width, ClientSize.Height);
            Working_With_Excel.Save_File_Excel(Users_DataGridView, column_Parametrs, width_Column, name_File, Save_Progress_ProgressBar);
            save_Progress_GroupBox.Visible = false;
            Save_Progress_ProgressBar.Value = 0;
        }

        private void Fiter_Reset_Button_Click(object sender, EventArgs e)
        {
            Sorting_ComboBox.SelectedIndex = 0;
            Filtering_Group_ComboBox.SelectedIndex = 0;
            Filtering_Group_CheckBox.Checked = false;
            Search_TextBox.Text = string.Empty;
            Users_DataGridView.ClearSelection();
            Data_Search.Clears_Datagridview_From_Search(Users_DataGridView);
            Determines_Presence_Records();
        }
    }
}
