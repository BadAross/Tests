using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Testing.Class;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms.Admin_Forms.Users_Edit.Group_Editing;
using Testing.Forms.General_Forms.Registration;
using Testing.Struct;

namespace Testing.Forms.General
{
    public partial class Registration_Form : Form
    {
        private List_Group list_Group = new();

        public Registration_Form()
        {
            InitializeComponent();
            Fills_Combobox();
        }

        private void Fills_Combobox()
        {
            var bindingSource = new BindingSource();

            bindingSource.DataSource = list_Group.Groups.OrderBy(x => x.code).Select(x => x.code).Distinct().ToList();
            Group_ComboBox.DataSource = bindingSource.DataSource;
        }

        private void Close_Form()
        {
            var form = new Avtorization_Form();
            form.Show();
            Hide();
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            Checks_Absence_Empty_TextBoxes();
        }

        private void Checks_Absence_Empty_TextBoxes()
        {
            if (Full_Name_TextBox.Text != string.Empty & Login_TextBox.Text != string.Empty & Password_TextBox.Text != string.Empty)
            {
                Checks_Strength_Password();
                return;
            }
            MessageBox.Show("Все поля должны быть заполнены!");
        }

        private void Checks_Strength_Password()
        {
            if (Checking_Password_Reliability.Checks_Strength_Password(Password_TextBox.Text))
            {
                Checks_Originality_Entered_Data();
                return;
            }
            MessageBox.Show("Пароль не достаточно надежный! Необходимо: от 8 значений, 1 большая буква, 1 число и более.");
        }

        private bool Returns_Result_Data_Identity_Check()
        {
            var fidentity_User_Verification_Sql_Command = @"select
                  Id_User
                from Users
                where Full_Name_User ='" + Full_Name_TextBox.Text + "' or Login_User = '" + Login_TextBox.Text + "'";
            var fidentity_Tester_Verification_Sql_Command = @"select
                  Id_Tester
                from Testers
                where Full_Name_Tester = '" + Full_Name_TextBox.Text + "' or Login_Tester = '" + Login_TextBox.Text + "'";

            DataSet users = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(fidentity_User_Verification_Sql_Command);
            DataSet testers = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(fidentity_Tester_Verification_Sql_Command);

            var originality_Users_Login = users.Tables[0].Rows.Count == 0;
            var originality_Testers_Login = testers.Tables[0].Rows.Count == 0;

            return originality_Users_Login & originality_Testers_Login;
        }

        private int Returns_Id_Selected_Group()
        {
            foreach (var group in list_Group.Groups.Where(x => x.code == Group_ComboBox.Text))
            {
                return group.id;
            }
            return -1;
        }

        private void Checks_Originality_Entered_Data()
        {
            if (Returns_Result_Data_Identity_Check())
            {
                Defines_Account_Type();
                return;
            }
            MessageBox.Show("ФИО или Логин уже используются!");
        }

        private void Defines_Account_Type()
        {
            if (User_RadioButton.Checked)
            {
                Adds_User_Account();
                return;
            }
            else if (Tester_RadioButton.Checked)
            {
                Adds_Tester_Account();
                return;
            }
            MessageBox.Show("Выберите тип использования!");
        }

        private void Adds_User_Account()
        {
            User user = new();
            var id_Group = Returns_Id_Selected_Group();

            user.full_Name = Full_Name_TextBox.Text;
            user.login = Login_TextBox.Text;
            user.password = Hash_Password.Retern_Hesh_Password(Password_TextBox.Text);

            Save_Account.Save_User_Account(user, id_Group);
            Close_Form();
        }

        private void Adds_Tester_Account()
        {
            Tester tester = new();

            tester.full_Name = Full_Name_TextBox.Text;
            tester.login = Login_TextBox.Text;
            tester.password = Hash_Password.Retern_Hesh_Password(Password_TextBox.Text);

            Save_Account.Save_Tester_Account(tester);
            Close_Form();
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
            Close_Form();
        }
    }
}
