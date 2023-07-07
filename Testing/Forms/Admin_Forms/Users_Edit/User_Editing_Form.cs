using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Testing.Class;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms.Admin.Uzer_Editing;
using Testing.Forms.Enum;
using Testing.Struct;

namespace Testing.Forms.Admin.User_Edit
{
    public partial class User_Editing_Form : Form
    {
        private int number_Entry;
        private List<User> users;
        private List<Group> groups;
        private List<int> id_User_Delete = new List<int>();

        public User_Editing_Form(List<User> users, int selected_Entry)
        {
            InitializeComponent();
            this.users = users;
            groups = Unloads_Groups();
            number_Entry = users.FindIndex(x => x.id == selected_Entry);
            Displays_Code_Group();
            Switches_Records();
        }

        private List<Group> Unloads_Groups()
        {
            var query = "select Id_Group, Code_Group from Groups";
            DataSet dataSet = Data_Search_By_Sql_Query.Returns_Data_From_Database_On_Request(query);
            return Fills_List_Group(dataSet);
        }

        private void Adds_User(int i)
        {
            var id_Group = Returns_Id_Selected_Group(users[i]);
            DataBase_Editor.Edited_Information_To_DataBase("insert into Users (Full_Name_User, Group_Id, Login_User ,Password_User) " +
                "values ('" + users[i].full_Name + "'," + id_Group + ", '" + users[i].login + "', '" + users[i].password + "')");
        }

        private void Change_User(int i)
        {
            var id_Group = Returns_Id_Selected_Group(users[i]);
            DataBase_Editor.Edited_Information_To_DataBase("update Users set Full_Name_User = '" + users[i].full_Name + "', Group_Id = " + id_Group + ", " +
                "Login_User = '" + users[i].login + "', Password_User = '" + users[i].password + "' Where Id_User =" + users[i].id + "");
        }

        private void Displays_Code_Group()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = groups.OrderBy(x => x.code).Select(x => x.code).Distinct().ToList();
            Group_ComboBox.DataSource = bindingSource.DataSource;
        }

        private void Deletes_Selected_Users()
        {
            for (var i = 0; i < id_User_Delete.Count; i++)
            {
                DataBase_Editor.Edited_Information_To_DataBase(" delete from Users where Id_User = " + id_User_Delete[i] + "");
            }
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
            Number_Entry_Label.Text = number_Entry + 1 + " из " + users.Count;
            Full_Name_TextBox.Text = users[number_Entry].full_Name;
            Login_TextBox.Text = users[number_Entry].login;
            Password_TextBox.Text = users[number_Entry].password;
            Group_ComboBox.Text = users[number_Entry].code_Group;
        }

        private int Returns_Id_Selected_Group(User user)
        {
            var id_Group = int.MinValue;

            foreach (var group in groups.Where(x => x.code == user.code_Group))
            {
                id_Group = group.id;
            }

            return id_Group;
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

        private void Iterates_Through_List_Users()
        {
            for (var i = 0; i < users.Count; i++)
            {
                if (users[i].type_Change == (byte)Type_Change.Add)
                {
                    Adds_User(i);
                }
                else if (users[i].type_Change == (byte)Type_Change.Modified)
                {
                    Change_User(i);
                }
            }
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
            if (users.Count > 0 & number_Entry + 1 <= users.Count)
            {
                Displays_User_Information();
            }
            else if (number_Entry <= users.Count & users.Count > 0)
            {
                number_Entry--;
                Switches_Records();
            }
            else
            {
                number_Entry = 0;
                Number_Entry_Label.Text = number_Entry + " из " + users.Count;
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
            if (users.Count > number_Entry + 1)
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
            if (users.Count != 0)
            {
                id_User_Delete.Add(users[number_Entry].id);
                users.RemoveAt(number_Entry);
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
                Iterates_Through_List_Users();
                Deletes_Selected_Users();

                var form = new Users_Show_Info_Form();
                form.Show();
                Hide();
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (Checking_Correctness_Input_Data.Cheks_Filling_All_Fields(Returns_Array_TextBoxes()))
            {
                if (Checking_Password_Reliability.Checks_Strength_Password(Password_TextBox.Text))
                {
                    User user = Collects_Text_From_TextBoxes();
                    user.password = Hash_Password.Retern_Hesh_Password(user.password);
                    user.type_Change = (byte)Type_Change.Add;
                    users.Add(user);
                    number_Entry = users.Count;
                    Switches_Records();
                }
                else
                {
                    MessageBox.Show("Пароль не достаточно надежный! Необходимо: от 8 значений, 1 большая буква, 1 число и более.");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            if (Checking_Correctness_Input_Data.Cheks_Filling_All_Fields(Returns_Array_TextBoxes()))
            {
                if (Checking_Password_Reliability.Checks_Strength_Password(Password_TextBox.Text))
                {
                    User user = Collects_Text_From_TextBoxes();
                    user.password = Hash_Password.Retern_Hesh_Password(user.password);
                    user.id = users[number_Entry].id;
                    user.type_Change = (byte)Type_Change.Modified;
                    users[number_Entry] = user;
                }
                else
                {
                    MessageBox.Show("Пароль не достаточно надежный! Необходимо: от 8 значений, 1 большая буква, 1 число и более.");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }
    }
}
