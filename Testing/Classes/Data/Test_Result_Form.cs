using System.Windows.Forms;

namespace Testing.Forms
{
    public partial class Test_Result_Form : Form
    {
        public Test_Result_Form(float result, string number_Correct_Answers)
        {
            InitializeComponent();
            Result_Label.Text = result.ToString() + "%";
            Number_Correct_Answers_Label.Text = number_Correct_Answers;
        }

        private void Close_Batton_Click(object sender, System.EventArgs e)
        {
            var form = new User_Menu_Form();
            form.Show();
            Hide();
        }
    }
}
