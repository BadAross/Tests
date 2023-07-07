using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Testing.Class;
using Testing.Classes;
using Testing.Struct;

namespace Testing.Forms.Tester_Form
{
    public partial class Test_List_Form : Form
    {
        public Test_List_Form()
        {
            InitializeComponent();
            Show_Information_In_DataGridView();
        }

        private List<Column_Parameter> Returns_Array_Column_Names()
        {
            var names_Column = new List<Column_Parameter>()
            {
                new Column_Parameter{ name = "Id теста", size = 50},
                new Column_Parameter{ name = "Название теста", size = 625},
            };
            return names_Column;
        }

        private void Show_Information_In_DataGridView()
        {
            int id_Active_Account = Active_Account.Returns_Id_Active_Account();
            DataSet dataSet = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request("select id_Test, Name_Test " +
                "from Tests join Testers on Id_Tester = Tester_Id  where Id_Tester =" + id_Active_Account + "order by Name_Test ASC");
            Tests_DataGridView.DataSource = dataSet.Tables[0];

            List<Column_Parameter> column_Parameters = Returns_Array_Column_Names();

            Customization_DataGridView.Sets_Line_Height(Tests_DataGridView);
            Customization_DataGridView.Sets_Parameters_For_DataGridView(Tests_DataGridView);
            Customization_DataGridView.Sets_Received_Titles_And_Size_For_Headings(Tests_DataGridView, column_Parameters);
        }

        private void New_Test_Button_Click(object sender, EventArgs e)
        {
            var new_Test = new New_Test_Form();
            new_Test.Show();
            Hide();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            var form = new Tester_Menu_Form();
            form.Show();
            Hide();
        }

        private void Edit_Test_Button_Click(object sender, EventArgs e)
        {
            var id_Test = Convert.ToInt32(Tests_DataGridView.CurrentRow.Cells[0].Value);
            var form = new Editing_Test_Form(id_Test);
            form.Show();
            Hide();
        }

        private void Delete_Test_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("При удалении теста будут удалены и результаты его прохождения." +
                " Востановить данные будет не возможно. Вы уверены?",
                "Удалить тест", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var id_Test = Convert.ToInt32(Tests_DataGridView.CurrentRow.Cells[0].Value);
                var delete_Test = "delete from Questions where Test_Id = " + id_Test + "; " +
                    "delete from Results where Test_Id =  " + id_Test + "; delete from Tests where Id_Test =  " + id_Test + "";
                DataBase_Editor.Edited_Information_To_DataBase(delete_Test);
            }

            Show_Information_In_DataGridView();
        }
    }
}
