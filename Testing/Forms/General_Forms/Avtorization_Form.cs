using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Testing.Class;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms;
using Testing.Forms.Admin;
using Testing.Forms.General;
using Testing.Forms.Tester_Form;

namespace Testing
{
    public partial class Avtorization_Form : Form
    {
        private byte counter_Incorrectly_Entered_Passwords;

        public Avtorization_Form()
        {
            InitializeComponent();
            Login_TextBox.Focus();
            Password_TextBox.UseSystemPasswordChar = true;
        }

        private void Changes_Password_Hiding_Image()
        {
            if (Password_TextBox.UseSystemPasswordChar)
            {
                Show_Password_Button.BackgroundImage = new Bitmap(Properties.Resources.Show_Password_Image);
            }
            else
            {
                Show_Password_Button.BackgroundImage = new Bitmap(Properties.Resources.Hide_Password_Image);
            }
        }

        private void Opens_Captcha_Form()
        {
            MessageBox.Show("Не верный логин или пароль!");
            counter_Incorrectly_Entered_Passwords++;

            if (counter_Incorrectly_Entered_Passwords >= 2)
            {
                var captcha = new Сapcha_Form();
                captcha.Show();
                Hide();
            }
        }

        private void Finds_Accounts_Entered_Username_And_Password()
        {
            var password = Hash_Password.Retern_Hesh_Password(Password_TextBox.Text);

            var uzer_Account = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(@"select
                  Id_User
                , Full_Name_User
                from Users
                where Login_User ='" + Login_TextBox.Text + "' and Password_User = '" + password + "'");

            var tester_Account = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(@"select
                  Id_Tester
                , Full_Name_Tester
                from Testers
                where Login_Tester ='" + Login_TextBox.Text + "' and Password_Tester = '" + password + "'");

            var admin_Account = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(@"select
                  Id_Admin
                from Admins
                where Login_Admin ='" + Login_TextBox.Text + "' and Password_Admin = '" + password + "'");

            Identifies_User_By_Username_And_Password(uzer_Account, tester_Account, admin_Account);
        }

        private void Identifies_User_By_Username_And_Password(DataSet user_Account, DataSet tester_Account, DataSet admin_Account)
        {
            if (user_Account.Tables[0].Rows.Count == 1)
            {
                var form = new User_Menu_Form();
                Active_Account.Saves_Data_Active_Account(user_Account, "Id_User", "Full_Name_User");
                form.Show();
                Hide();
            }
            else if (tester_Account.Tables[0].Rows.Count == 1)
            {
                var form = new Tester_Menu_Form();
                Active_Account.Saves_Data_Active_Account(tester_Account, "Id_Tester", "Full_Name_Tester");
                form.Show();
                Hide();
            }
            else if (admin_Account.Tables[0].Rows.Count == 1)
            {
                var form = new Admin_Menu_Form();
                form.Show();
                Hide();
            }
            else
            {
                Login_TextBox.Clear();
                Password_TextBox.Clear();
                Opens_Captcha_Form();
            }
        }

        private void Enter_Batton_Click(object sender, EventArgs e)
        {
            Finds_Accounts_Entered_Username_And_Password();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPassword_Button_Click(object sender, EventArgs e)
        {
            Password_TextBox.UseSystemPasswordChar = !Password_TextBox.UseSystemPasswordChar;
            Changes_Password_Hiding_Image();
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            var form = new Registration_Form();
            form.Show();
            Hide();
        }
    }
}
