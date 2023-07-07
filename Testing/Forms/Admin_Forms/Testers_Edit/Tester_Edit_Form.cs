using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms.Admin.Testers_Edit;
using Testing.Forms.Enum;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Testers_Edit
{
    public partial class Tester_Edit_Form : Form
    {
        private int number_Entry;
        private List<Tester> testers;
        private List<int> id_Tester_Delete = new List<int>();

        public Tester_Edit_Form(List<Tester> testers, int selected_Entry)
        {
            InitializeComponent();
            this.testers = testers;
            if (this.testers.Count == 0)
            {
                Number_Entry_Label.Text = 0 + " из " + 0;
            }
            else
            {
                number_Entry = testers.FindIndex(x => x.id == selected_Entry);
                Switches_Records();
            }

        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            Clears_TextBoxes();
        }

        private void Adds_Tester(int i)
        {
            DataBase_Editor.Edited_Information_To_DataBase("insert into Testers (Full_Name_Tester, Login_Tester, Password_Tester) " +
                "values ('" + testers[i].full_Name + "', '" + testers[i].login + "', '" + testers[i].password + "')");
        }

        private void Change_Taster(int i)
        {
            DataBase_Editor.Edited_Information_To_DataBase("update Testers set Full_Name_Tester = '" + testers[i].full_Name + "', " +
                "Login_Tester = '" + testers[i].login + "', Password_Tester = '" + testers[i].password + "' Where Id_Tester =" + testers[i].id + "");
        }

        private void Deletes_Selected_Tester()
        {
            for (var i = 0; i < id_Tester_Delete.Count; i++)
            {
                DataBase_Editor.Edited_Information_To_DataBase(" delete from Testers where Id_Tester = " + id_Tester_Delete[i] + "");
            }
        }

        private void Clears_TextBoxes()
        {
            Full_Name_TextBox.Clear();
            Login_TextBox.Clear();
            Password_TextBox.Clear();
        }

        private void Displays_User_Information()
        {
            Number_Entry_Label.Text = number_Entry + 1 + " из " + testers.Count;
            Full_Name_TextBox.Text = testers[number_Entry].full_Name;
            Login_TextBox.Text = testers[number_Entry].login;
            Password_TextBox.Text = testers[number_Entry].password;
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

        private Tester Collects_Text_From_TextBoxes()
        {
            var tester = new Tester();
            tester.full_Name = Full_Name_TextBox.Text;
            tester.login = Login_TextBox.Text;
            tester.password = Password_TextBox.Text;

            return tester;
        }

        private void Iterates_Through_List_Tester()
        {
            for (var i = 0; i < testers.Count; i++)
            {
                if (testers[i].type_Change == (byte)Type_Change.Add)
                {
                    Adds_Tester(i);
                }
                else if (testers[i].type_Change == (byte)Type_Change.Modified)
                {
                    Change_Taster(i);
                }
            }
        }

        private void Switches_Records()
        {
            if (testers.Count > 0 & number_Entry + 1 <= testers.Count)
            {
                Displays_User_Information();
            }
            else if (number_Entry <= testers.Count & testers.Count > 0)
            {
                number_Entry--;
                Switches_Records();
            }
            else
            {
                number_Entry = 0;
                Number_Entry_Label.Text = number_Entry + " из " + testers.Count;
                Clears_TextBoxes();
            }
        }

        private void Generate_Password_Button_Click(object sender, EventArgs e)
        {
            Password_TextBox.Text = Generat_Password.Returns_Generated_Password();
        }

        private void Previos_Entry_Button_Click(object sender, EventArgs e)
        {
            if (number_Entry - 1 >= 0)
            {
                number_Entry--;
                Switches_Records();
            }
        }

        private void Next_Entry_Button_Click(object sender, EventArgs e)
        {
            if (testers.Count > number_Entry + 1)
            {
                number_Entry++;
                Switches_Records();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (testers.Count != 0)
            {
                id_Tester_Delete.Add(testers[number_Entry].id);
                testers.RemoveAt(number_Entry);
                Switches_Records();
            }
        }

        private void Cancellation_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Все изменения будут сброшены. Вы уверены?",
                 "Изменения сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var form = new Testers_Info_Form();
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
                Iterates_Through_List_Tester();
                Deletes_Selected_Tester();

                var form = new Testers_Info_Form();
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
                    Tester tester = Collects_Text_From_TextBoxes();
                    tester.password = Hash_Password.Retern_Hesh_Password(tester.password);
                    tester.type_Change = (byte)Type_Change.Add;
                    testers.Add(tester);
                    number_Entry = testers.Count;
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
                    Tester tester = Collects_Text_From_TextBoxes();
                    tester.password = Hash_Password.Retern_Hesh_Password(tester.password);
                    tester.id = testers[number_Entry].id;
                    if (tester.type_Change == 0)
                    {
                        tester.type_Change = (byte)Type_Change.Modified;
                    }
                    testers[number_Entry] = tester;
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
