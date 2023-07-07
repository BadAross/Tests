using System;
using System.Windows.Forms;
using Testing.Classes;

namespace Testing.Forms
{
    public partial class User_Menu_Form : Form
    {
        public User_Menu_Form()
        {
            InitializeComponent();
        }

        private void Shows_Select_Form(Form form)
        {
            form.Show();
            Hide();
        }

        private void Statistic_Button_Click(object sender, EventArgs e)
        {
            Shows_Select_Form(new Statistic_User_Form());
        }

        private void Start_Batton_Click(object sender, EventArgs e)
        {
            Shows_Select_Form(new Test_Selection_Form());
        }

        private void User_Menu_Form_Load(object sender, EventArgs e)
        {
            string full_Name = Active_Account.Returns_full_Name_Active_Account();
            Name_User_Label.Text = "Здравствуйте, " + full_Name + "!";
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Active_Account.Clears_Data_Active_Account();
            Shows_Select_Form(new Avtorization_Form());
        }
    }
}
