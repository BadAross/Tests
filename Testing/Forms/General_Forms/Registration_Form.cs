using System;
using System.Data;
using System.Windows.Forms;
using Testing.Class;
using Testing.Classes;
using Testing.Classes.Performers;

namespace Testing.Forms.General
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
            Fills_Combobox();
        }

        private void Fills_Combobox()
        {
            Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request("select Code_Group from Groups order by Code_Group ASC", "Groups", "Code_Group", Group_ComboBox);
        }

        private void Registers_Account(string add_Entry_Sql_Command)
        {
            DataBase_Editor.Edited_Information_To_DataBase(add_Entry_Sql_Command);
            MessageBox.Show("Аккаунт добавлен!");

            var form = new Avtorization_Form();
            form.Show();
            Hide();
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            if (Full_Name_TextBox.Text != string.Empty & Login_TextBox.Text != string.Empty & Password_TextBox.Text != string.Empty)
            {
                if (Checking_Password_Reliability.Checks_Strength_Password(Password_TextBox.Text))
                {
                    Defines_Account_Type();
                }
                else
                {
                    MessageBox.Show("Пароль не достаточно надежный! Необходимо: от 8 значений, 1 большая буква, 1 число и более.");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

        private void Checks_Identity_Entered_Data(string fidentity_User_Verification_Sql_Command, string fidentity_Tester_Verification_Sql_Command, string add_Entry_Sql_Command)
        {
            DataSet x = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(fidentity_User_Verification_Sql_Command);
            DataSet w = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(fidentity_Tester_Verification_Sql_Command);

            var q = x.Tables[0].Rows.Count == 0;
            var a = w.Tables[0].Rows.Count == 0;
            if (q & a)
            {
                Registers_Account(add_Entry_Sql_Command);
            }
            else
            {
                MessageBox.Show("ФИО или Логин уже используются!");
            }
        }

        private void Defines_Account_Type()
        {
            var fidentity_User_Verification_Sql_Command = "select Id_User from Users where Full_Name_User = " +
                "'" + Full_Name_TextBox.Text + "' or Login_User = '" + Login_TextBox.Text + "'";
            var fidentity_Tester_Verification_Sql_Command = "select Id_Tester from Testers where Full_Name_Tester = " +
                "'" + Full_Name_TextBox.Text + "' or Login_Tester = '" + Login_TextBox.Text + "'";
            var password = Hash_Password.Retern_Hesh_Password(Password_TextBox.Text);

            if (User_RadioButton.Checked)
            {
                DataSet dataSet = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(
                    "select Id_Group from Groups where Code_Group = '" + Group_ComboBox.Text + "'");
                var id_Group = Convert.ToInt32(dataSet.Tables[0].Rows[0][0]);

                Checks_Identity_Entered_Data(fidentity_User_Verification_Sql_Command, fidentity_Tester_Verification_Sql_Command,
                    "insert into Users (Full_Name_User, Group_Id, Login_User, Password_User) values ('" + Full_Name_TextBox.Text + "',"
                    + id_Group + ", '" + Login_TextBox.Text + "', '" + password + "')");
            }
            else if (Tester_RadioButton.Checked)
            {

                Checks_Identity_Entered_Data(fidentity_User_Verification_Sql_Command, fidentity_Tester_Verification_Sql_Command,
                    "insert into Testers (Full_Name_Tester, Login_Tester, Password_Tester) values ('" + Full_Name_TextBox.Text + "', '"
                    + Login_TextBox.Text + "', '" + password + "')");
            }
            else
            {
                MessageBox.Show("Выберите тип использования!");
            }
        }

        private void Generat_Password_Button_Click(object sender, EventArgs e)
        {
            Password_TextBox.Text = Generat_Password.Returns_Generated_Password();
        }

        private void User_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Group_Label.Visible = true;
            Group_ComboBox.Visible = true;
        }

        private void Tester_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Group_Label.Visible = false;
            Group_ComboBox.Visible = false;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            var form = new Avtorization_Form();
            form.Show();
            Hide();
        }
    }
}
