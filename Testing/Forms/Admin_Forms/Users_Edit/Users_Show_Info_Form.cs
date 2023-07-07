using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Testing.Class;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms.Admin.User_Edit;
using Testing.Struct;

namespace Testing.Forms.Admin.Uzer_Editing
{
    public partial class Users_Show_Info_Form : Form
    {
        private List<User> users;

        public Users_Show_Info_Form()
        {
            InitializeComponent();
            Unloads_Data_From_Database();
            Fills_Combobox();
        }

        private List<User> Return_Standard_Data_List()
        {
            return users.OrderBy(x => x.full_Name).ToList();
        }

        private void Fills_Combobox()
        {
            var bindingSource = new BindingSource();

            bindingSource.DataSource = users.OrderBy(x => x.code_Group).Select(x => x.code_Group).Distinct().ToList();
            Filtering_Group_ComboBox.DataSource = bindingSource.DataSource;
        }

        private void Unloads_Data_From_Database()
        {
            var query = "select Id_User, Full_Name_User, Code_Group, Login_User, Password_User " +
                "from Users join Groups on Id_Group = Group_Id";
            DataSet dataSet = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);

            users = Fills_Dictionary_With_Data_From_Database(dataSet);
            Show_Information_In_DataGridView();
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
                Convert.ToInt32(Users_DataGridView.CurrentRow.Cells[0].Value);
            }
            catch
            {
                return 0;
            }
            return Convert.ToInt32(Users_DataGridView.CurrentRow.Cells[0].Value);
        }

        private List<User> Fills_Dictionary_With_Data_From_Database(DataSet dataSet)
        {
            var list_Users = new List<User>();
            var user = new User();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                user.id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id_User"]);
                user.full_Name = Convert.ToString(dataSet.Tables[0].Rows[i]["Full_Name_User"]);
                user.code_Group = Convert.ToString(dataSet.Tables[0].Rows[i]["Code_Group"]);
                user.login = Convert.ToString(dataSet.Tables[0].Rows[i]["Login_User"]);
                user.password = Convert.ToString(dataSet.Tables[0].Rows[i]["Password_User"]);

                list_Users.Add(user);
            }
            return list_Users;
        }

        private List<User> Defines_Selected_Filters()
        {
            var dictionary_Result_Passing_Test = Return_Standard_Data_List();

            if (Sorting_ComboBox.SelectedIndex != 0)
            {
                dictionary_Result_Passing_Test = Sorts_Data_By_Specified_Parameter(dictionary_Result_Passing_Test);
            }

            Data_Search.Clears_Datagridview_From_Search(Users_DataGridView);

            return dictionary_Result_Passing_Test;
        }

        private List<User> Returns_Filtered_Data_By_Selected_Parameter()
        {
            var dictionary_Result_Passing_Test = Return_Standard_Data_List();

            if (Filtering_Group_CheckBox.Checked)
            {
                dictionary_Result_Passing_Test = dictionary_Result_Passing_Test.Where(x => x.code_Group == Filtering_Group_ComboBox.Text).ToList();
            }
            return dictionary_Result_Passing_Test;
        }

        private List<User> Sorts_Data_By_Specified_Parameter(List<User> dictionary_Result_Passing_Test)
        {
            switch (Sorting_ComboBox.SelectedIndex)
            {
                case 1:
                    dictionary_Result_Passing_Test = dictionary_Result_Passing_Test.OrderBy(x => x.full_Name).ToList();
                    break;
                case 2:
                    dictionary_Result_Passing_Test = dictionary_Result_Passing_Test.OrderByDescending(x => x.full_Name).ToList();
                    break;
                case 3:
                    dictionary_Result_Passing_Test = dictionary_Result_Passing_Test.OrderBy(x => x.code_Group).ToList();
                    break;
                case 4:
                    dictionary_Result_Passing_Test = dictionary_Result_Passing_Test.OrderByDescending(x => x.code_Group).ToList();
                    break;
            }
            return dictionary_Result_Passing_Test;
        }

        private void Show_Information_In_DataGridView()
        {
            var dictionary_Result_Passing_Test = Defines_Selected_Filters();

            if (dictionary_Result_Passing_Test.Count > 0)
            {
                List<Column_Parameter> column_Parameters = Returns_Array_Column_Parametrs();
                Customization_DataGridView.Sets_Line_Height(Users_DataGridView);

                Users_DataGridView.RowCount = dictionary_Result_Passing_Test.Count;
                Users_DataGridView.ColumnCount = column_Parameters.Count;

                Fills_DataGridView(dictionary_Result_Passing_Test);

                Customization_DataGridView.Sets_Parameters_For_DataGridView(Users_DataGridView);
                Customization_DataGridView.Sets_Received_Titles_And_Size_For_Headings(Users_DataGridView, column_Parameters);
                Users_DataGridView.Focus();
            }
            else
            {
                Users_DataGridView.Rows.Clear();
                MessageBox.Show("Записей не найдено!");
            }
            Number_Entry_Label.Text = dictionary_Result_Passing_Test.Count + " из " + users.Count;
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
            Show_Information_In_DataGridView();
        }

        private void Filtering_Group_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Filter_Full_Name_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Filtering_Group_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
        }

        private void Sorting_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Information_In_DataGridView();
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
            Show_Information_In_DataGridView();
        }
    }
}
