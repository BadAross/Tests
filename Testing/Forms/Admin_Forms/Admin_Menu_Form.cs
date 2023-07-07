using System;
using System.Windows.Forms;
using Testing.Forms.Admin.Testers_Edit;
using Testing.Forms.Admin.Tests_Edit;
using Testing.Forms.Admin.Uzer_Editing;
using Testing.Forms.Admin_Forms.Results_Edit;

namespace Testing.Forms.Admin
{
    public partial class Admin_Menu_Form : Form
    {
        public Admin_Menu_Form()
        {
            InitializeComponent();
        }

        private void Shows_Select_Form(Form form)
        {
            form.Show();
            Hide();
        }

        private void Uzers_Button_Click(object sender, EventArgs e)
        {
            Shows_Select_Form(new Users_Show_Info_Form());
        }

        private void Tests_Button_Click(object sender, EventArgs e)
        {
            Shows_Select_Form(new Test_Show_Info_Form());
        }

        private void Testers_Button_Click(object sender, EventArgs e)
        {
            Shows_Select_Form(new Testers_Info_Form());
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Shows_Select_Form(new Avtorization_Form());
        }

        private void Results_Button_Click(object sender, EventArgs e)
        {
            Shows_Select_Form(new Result_Info_Form());
        }
    }
}
