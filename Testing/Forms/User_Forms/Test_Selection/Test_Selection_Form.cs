using System;
using System.Linq;
using System.Windows.Forms;
using Testing.Forms.User_Forms.Test_Selection;

namespace Testing.Forms
{
    public partial class Test_Selection_Form : Form
    {
        private List_Tests_Pass list_Tests_Pass = new List_Tests_Pass();

        public Test_Selection_Form()
        {
            InitializeComponent();
            Fills_Combobox();
        }

        private void Fills_Combobox()
        {
            var bindingSource = new BindingSource();

            bindingSource.DataSource = list_Tests_Pass.tests.OrderBy(x => x.full_Name_Tester).Select(x => x.full_Name_Tester).Distinct().ToList();
            Tester_Name_ComboBox.DataSource = bindingSource.DataSource;

            bindingSource.DataSource = list_Tests_Pass.tests.OrderBy(x => x.name_Test).Select(x => x.name_Test).Distinct().ToList();
            Name_Test_ComboBox.DataSource = bindingSource.DataSource;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            var form = new User_Menu_Form();
            form.Show();
            Hide();
        }

        private void Start_Batton_Click(object sender, EventArgs e)
        {
            var form = new Passing_Test_Form(Name_Test_ComboBox.Text);
            form.Show();
            Hide();
        }

        private void AdminName_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bindingSource = new BindingSource();

            bindingSource.DataSource = list_Tests_Pass.tests.OrderBy(x => x.name_Test).Where(x => x.full_Name_Tester == Tester_Name_ComboBox.Text).Select(x => x.name_Test).Distinct().ToList();
            Name_Test_ComboBox.DataSource = bindingSource.DataSource;
        }
    }
}
