using System;
using System.Windows.Forms;
using Testing.Classes;

namespace Testing.Forms.Tester_Form
{
    public partial class Tester_Menu_Form : Form
    {
        public Tester_Menu_Form()
        {
            InitializeComponent();
        }

        private void Shows_Select_Form(Form form)
        {
            form.Show();
            Hide();
        }

        private void My_Tests_Batton_Click(object sender, EventArgs e)
        {
            Shows_Select_Form(new My_Tests_Form());
        }

        private void Result_Button_Click(object sender, EventArgs e)
        {
            Shows_Select_Form(new Result_Tests_Form());
        }

        private void Tester_Menu_Form_Load(object sender, EventArgs e)
        {
            string full_Name = Active_Account.Returns_full_Name_Active_Account();
            Name_Tester_Label.Text = "Здравствуйте, " + full_Name + "!";
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Active_Account.Clears_Data_Active_Account();
            Shows_Select_Form(new Avtorization_Form());
        }
    }
}
