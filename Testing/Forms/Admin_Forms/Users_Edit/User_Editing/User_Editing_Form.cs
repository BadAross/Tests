using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms.Admin.Uzer_Editing;
using Testing.Forms.Admin_Forms.Users_Edit.User_Editing;
using Testing.Forms.Enum;
using Testing.Struct;

namespace Testing.Forms.Admin.User_Edit
{
    public partial class User_Editing_Form : Form
    {
        private int number_Entry;
        private List_User list_User;
        private List<int> id_User_Delete = new();

        public User_Editing_Form(List<User> users, int selected_Entry)
        {
            InitializeComponent();
            list_User = new(users);
            number_Entry = users.FindIndex(x => x.id == selected_Entry);
            Displays_Code_Group();
            Switches_Records();
        }

        private void Displays_Code_Group()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = list_User._Groups.OrderBy(x => x.code).Select(x => x.code).Distinct().ToList();
            Group_ComboBox.DataSource = bindingSource.DataSource;
        }

        private void Clears_TextBoxes()
        {
            Full_Name_TextBox.Clear();
            Login_TextBox.Clear();
            Password_TextBox.Clear();
        }

        private TextBox[] Returns_Array_TextBoxes()
        {
            return new TextBox[]
            {
                Full_Name_TextBox,
                Login_TextBox,
                Password_TextBox,
            };
        }

        private void Displays_User_Information()
        {
            Number_Entry_Label.Text = number_Entry + 1 + " из " + list_User._Users.Count;
            Full_Name_TextBox.Text = list_User._Users[number_Entry].full_Name;
            Login_TextBox.Text = list_User._Users[number_Entry].login;
            Password_TextBox.Text = list_User._Users[number_Entry].password;
            Group_ComboBox.Text = list_User._Users[number_Entry].code_Group;
        }

        private User Collects_Text_From_TextBoxes()
        {
            var user = new User();
            user.full_Name = Full_Name_TextBox.Text;
            user.code_Group = Group_ComboBox.Text;
            user.login = Login_TextBox.Text;
            user.password = Password_TextBox.Text;

            return user;
        }

        private void Switches_Records()
        {
            if (list_User._Users.Count > 0 & number_Entry + 1 <= list_User._Users.Count)
            {
                Displays_User_Information();
            }
            else if (number_Entry <= list_User._Users.Count & list_User._Users.Count > 0)
            {
                number_Entry--;
                Switches_Records();
            }
            else
            {
                number_Entry = 0;
                Number_Entry_Label.Text = number_Entry + " из " + list_User._Users.Count;
                Clears_TextBoxes();
            }
        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            Clears_TextBoxes();
        }

        private void Generate_Password_Button_Click(object sender, EventArgs e)
        {
            Password_TextBox.Text = Generat_Password.Returns_Generated_Password();
        }

        private void Next_Entry_Button_Click(object sender, EventArgs e)
        {
            if (list_User._Users.Count > number_Entry + 1)
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
            if (list_User._Users.Count != 0)
            {
                id_User_Delete.Add(list_User._Users[number_Entry].id);
                list_User._Users.RemoveAt(number_Entry);
                Switches_Records();
            }
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
                new Save_User_Change(list_User._Users, list_User._Groups, id_User_Delete);
                var form = new Users_Show_Info_Form();
                form.Show();
                Hide();
            }
        }

        private bool Return_Result_Checking_Filling_Textboxes()
        {
            if (Checking_Correctness_Input_Data.Cheks_Filling_All_Fields(Returns_Array_TextBoxes()))
            {
                return Return_Result_Password_Compliance_Check();
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            return false;
        }

        private bool Return_Result_Password_Compliance_Check()
        {
            if (Checking_Password_Reliability.Checks_Strength_Password(Password_TextBox.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Пароль не достаточно надежный! Необходимо: от 8 значений, 1 большая буква, 1 число и более.");
            }
            return false;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (Return_Result_Checking_Filling_Textboxes())
            {
                User user = Collects_Text_From_TextBoxes();
                user.password = Hash_Password.Retern_Hesh_Password(user.password);
                user.type_Change = (byte)Type_Change.Add;
                list_User._Users.Add(user);
                number_Entry = list_User._Users.Count;
                Switches_Records();
            }
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            if (Return_Result_Checking_Filling_Textboxes())
            {
                User user = Collects_Text_From_TextBoxes();
                user.password = Hash_Password.Retern_Hesh_Password(user.password);
                user.id = list_User._Users[number_Entry].id;
                user.type_Change = (byte)Type_Change.Modified;
                list_User._Users[number_Entry] = user;
            }
        }
    }
}
