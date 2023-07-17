using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Testing.Forms.Admin.Uzer_Editing;
using Testing.Forms.Admin_Forms.Users_Edit.Group_Editing;
using Testing.Forms.Enum;
using Testing.Struct;

namespace Testing.Forms.Admin.User_Edit
{
    public partial class Group_Editing_Form : Form
    {
        private int number_Entry;
        private List_Group list_Group = new();
        private List<int> id_Groups_Delete = new List<int>();

        public Group_Editing_Form()
        {
            InitializeComponent();
            Switches_Records();
        }

        private void Clears_TextBoxes()
        {
            Code_Group_MaskedTextBox.Clear();
        }

        private void Displays_Group_Information()
        {
            Number_Entry_Label.Text = number_Entry + 1 + " из " + list_Group.Groups.Count;
            Code_Group_MaskedTextBox.Text = list_Group.Groups[number_Entry].code;
        }

        private void Switches_Records()
        {
            if (list_Group.Groups.Count > 0 & number_Entry + 1 <= list_Group.Groups.Count)
            {
                Displays_Group_Information();
            }
            else if (number_Entry <= list_Group.Groups.Count & list_Group.Groups.Count > 0)
            {
                number_Entry--;
                Switches_Records();
            }
            else
            {
                number_Entry = 0;
                Number_Entry_Label.Text = number_Entry + " из " + list_Group.Groups.Count;
                Clears_TextBoxes();
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
            list_Group.Groups.Add(group);
            Displays_Group_Information();
        }

        private void Next_Entry_Button_Click(object sender, EventArgs e)
        {
            if (list_Group.Groups.Count > number_Entry + 1)
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
            if (list_Group.Groups.Count != 0)
            {
                id_Groups_Delete.Add(list_Group.Groups[number_Entry].id);
                list_Group.Groups.RemoveAt(number_Entry);
                Switches_Records();
            }
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            var group = new Group();
            group.id = list_Group.Groups[number_Entry].id;
            group.code = Code_Group_MaskedTextBox.Text;
            if (list_Group.Groups[number_Entry].type_Change != (byte)Type_Change.Add)
            {
                group.type_Change = (byte)Type_Change.Modified;
            }
            list_Group.Groups[number_Entry] = group;
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
                new Save_Groups_Change(list_Group.Groups, id_Groups_Delete);

                var form = new Users_Show_Info_Form();
                form.Show();
                Hide();
            }
        }
    }
}
