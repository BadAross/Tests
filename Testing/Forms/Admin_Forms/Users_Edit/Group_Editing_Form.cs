using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Testing.Class;
using Testing.Classes;
using Testing.Forms.Admin.Uzer_Editing;
using Testing.Forms.Enum;
using Testing.Struct;

namespace Testing.Forms.Admin.User_Edit
{
    public partial class Group_Editing_Form : Form
    {
        private int number_Entry;
        private List<Group> groups = new List<Group>();
        private List<int> id_Groups_Delete = new List<int>();

        public Group_Editing_Form()
        {
            InitializeComponent();
            groups = Unloads_Groups();
            Switches_Records();
        }

        private void Clears_TextBoxes()
        {
            Code_Group_MaskedTextBox.Clear();
        }

        private void Change_Group(int i)
        {
            DataBase_Editor.Edited_Information_To_DataBase("update Groups set Code_Group = '" + groups[i].code + "' Where Id_Group =" + groups[i].id + "");
        }

        private void Adds_Group(int i)
        {
            DataBase_Editor.Edited_Information_To_DataBase("insert into Groups (Code_Group) " +
                "values ('" + groups[i].code + "')");
        }

        private void Displays_User_Information()
        {
            Number_Entry_Label.Text = number_Entry + 1 + " из " + groups.Count;
            Code_Group_MaskedTextBox.Text = groups[number_Entry].code;
        }

        private void Deletes_Selected_Groups()
        {
            for (var i = 0; i < id_Groups_Delete.Count; i++)
            {
                DataBase_Editor.Edited_Information_To_DataBase(" delete from Groups where Id_Group = " + id_Groups_Delete[i] + "");
            }
        }

        private List<Group> Unloads_Groups()
        {
            var query = "select Id_Group, Code_Group from Groups";
            DataSet dataSet = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
            return Fills_List_Group(dataSet);
        }

        private List<Group> Fills_List_Group(DataSet dataSet)
        {
            var list_Groups = new List<Group>();
            var group = new Group();

            for (var i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                group.id = Convert.ToInt32(dataSet.Tables[0].Rows[i]["Id_Group"]);
                group.code = Convert.ToString(dataSet.Tables[0].Rows[i]["Code_Group"]);

                list_Groups.Add(group);
            }
            return list_Groups;
        }

        private void Switches_Records()
        {
            if (groups.Count > 0 & number_Entry + 1 <= groups.Count)
            {
                Displays_User_Information();
            }
            else if (number_Entry <= groups.Count & groups.Count > 0)
            {
                number_Entry--;
                Switches_Records();
            }
            else
            {
                number_Entry = 0;
                Number_Entry_Label.Text = number_Entry + " из " + groups.Count;
                Clears_TextBoxes();
            }
        }

        private void Iterates_Through_List_Groups()
        {
            for (var i = 0; i < groups.Count; i++)
            {
                if (groups[i].type_Change == (byte)Type_Change.Add)
                {
                    Adds_Group(i);
                }
                else if (groups[i].type_Change == (byte)Type_Change.Modified)
                {
                    Change_Group(i);
                }
            }
        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            Clears_TextBoxes();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            var group = new Group();
            group.code = Code_Group_MaskedTextBox.Text;
            group.type_Change = (byte)Type_Change.Add;
            groups.Add(group);
            Displays_User_Information();
        }

        private void Next_Entry_Button_Click(object sender, EventArgs e)
        {
            if (groups.Count > number_Entry + 1)
            {
                number_Entry++;
                Switches_Records();
            }
        }

        private void Previos_Entry_Button_Click(object sender, EventArgs e)
        {
            if (number_Entry - 1 >= 0)
            {
                number_Entry--;
                Switches_Records();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (groups.Count != 0)
            {
                id_Groups_Delete.Add(groups[number_Entry].id);
                groups.RemoveAt(number_Entry);
                Switches_Records();
            }
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            var group = new Group();
            group.id = groups[number_Entry].id;
            group.code = Code_Group_MaskedTextBox.Text;
            group.type_Change = (byte)Type_Change.Modified;
            groups[number_Entry] = group;
        }

        private void Cancellation_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Все изменения будут сброшены. Вы уверены?",
                 "Изменения сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var form = new Users_Show_Info_Form();
                form.Show();
                Hide();
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Все изменения будут сохранены. Вы уверены?",
                 "Изменения сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Iterates_Through_List_Groups();
                Deletes_Selected_Groups();

                var form = new Users_Show_Info_Form();
                form.Show();
                Hide();
            }
        }
    }
}
