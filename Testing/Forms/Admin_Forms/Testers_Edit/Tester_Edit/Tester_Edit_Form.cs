using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Testing.Classes;
using Testing.Classes.Performers;
using Testing.Forms.Admin.Testers_Edit;
using Testing.Forms.Admin_Forms.Testers_Edit.Tester_edit;
using Testing.Forms.Enum;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Testers_Edit
{
    public partial class Tester_Edit_Form : Form
    {
        private int number_Entry;
        private List_Tester_Edit list_Tester;
        private List<int> id_Tester_Delete = new List<int>();

        public Tester_Edit_Form(List<Tester> testers, int selected_Entry)
        {
            InitializeComponent();
            list_Tester = new(testers);

            Goes_Selected_Entry(selected_Entry);
        }

        private void Goes_Selected_Entry(int selected_Entry)
        {
            if (list_Tester.Testers.Count == 0)
            {
                Number_Entry_Label.Text = 0 + " из " + 0;
            }
            else
            {
                number_Entry = list_Tester.Testers.FindIndex(x => x.id == selected_Entry);
                Switches_Records();
            }
        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            Clears_TextBoxes();
        }

        private void Clears_TextBoxes()
        {
            Full_Name_TextBox.Clear();
            Login_TextBox.Clear();
            Password_TextBox.Clear();
        }

        private void Displays_Tester_Information()
        {
            Number_Entry_Label.Text = number_Entry + 1 + " из " + list_Tester.Testers.Count;
            Full_Name_TextBox.Text = list_Tester.Testers[number_Entry].full_Name;
            Login_TextBox.Text = list_Tester.Testers[number_Entry].login;
            Password_TextBox.Text = list_Tester.Testers[number_Entry].password;
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

        private void Switches_Records()
        {
            if (list_Tester.Testers.Count > 0 & number_Entry + 1 <= list_Tester.Testers.Count)
            {
                Displays_Tester_Information();
            }
            else if (number_Entry <= list_Tester.Testers.Count & list_Tester.Testers.Count > 0)
            {
                number_Entry--;
                Switches_Records();
            }
            else
            {
                number_Entry = 0;
                Number_Entry_Label.Text = number_Entry + " из " + list_Tester.Testers.Count;
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
            if (list_Tester.Testers.Count > number_Entry + 1)
            {
                number_Entry++;
                Switches_Records();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (list_Tester.Testers.Count != 0)
            {
                id_Tester_Delete.Add(list_Tester.Testers[number_Entry].id);
                list_Tester.Testers.RemoveAt(number_Entry);
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
                new Save_Tester_Change(list_Tester.Testers, id_Tester_Delete);
                var form = new Testers_Info_Form();
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
                Tester tester = Collects_Text_From_TextBoxes();
                tester.password = Hash_Password.Retern_Hesh_Password(tester.password);
                tester.type_Change = (byte)Type_Change.Add;
                list_Tester.Testers.Add(tester);
                number_Entry = list_Tester.Testers.Count;
                Switches_Records();
            }
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            if (Return_Result_Checking_Filling_Textboxes())
            {
                Tester tester = Collects_Text_From_TextBoxes();
                tester.password = Hash_Password.Retern_Hesh_Password(tester.password);
                tester.id = list_Tester.Testers[number_Entry].id;
                if (tester.type_Change == 0)
                {
                    tester.type_Change = (byte)Type_Change.Modified;
                }
                list_Tester.Testers[number_Entry] = tester;
            }
        }
    }
}
