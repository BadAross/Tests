using System;
using System.Windows.Forms;
using Testing.Class;

namespace Testing.Forms
{
    public partial class Test_Selection_Form : Form
    {
        public Test_Selection_Form()
        {
            InitializeComponent();
            Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request("select distinct (Full_Name_Tester) from Testers join Tests " +
                "on Id_Tester=Tester_Id order by Full_Name_Tester ASC", "Tester", "Full_Name_Tester", Tester_Name_ComboBox);
            Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request("select Name_Test from Tests order by Name_Test ASC", "Tests", "Name_Test", Name_Test_ComboBox);
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
            var full_Name_Tester = Tester_Name_ComboBox.Text;
            Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request("select Name_Test from Tests join Testers on Id_Tester = Tester_Id " +
                "where Full_Name_Tester = '" + full_Name_Tester + "' order by Name_Test ASC", "Tests", "Name_Test", Name_Test_ComboBox);
        }
    }
}
