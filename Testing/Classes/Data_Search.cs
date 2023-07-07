using System.Drawing;
using System.Windows.Forms;

namespace Testing.Classes.Performers
{
    internal class Data_Search
    {
        public static void Searches_Requested_Information(DataGridView dataGridView, TextBox search_TextBox)
        {
            if (search_TextBox.Text != string.Empty && dataGridView.CurrentRow.Cells[0].Value != null)
            {
                Selects_Cells_With_Desired_Information(dataGridView, search_TextBox);
                search_TextBox.Focus();
            }
            else
            {
                MessageBox.Show("Ошибка поиска!");
            }
        }

        public static void Clears_Datagridview_From_Search(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    dataGridView[i, j].Style.BackColor = Color.FromArgb(244, 220, 162);
                    dataGridView[i, j].Style.ForeColor = Color.FromArgb(31, 57, 42);
                }
            }
        }

        private static void Notifies_About_Absence_Desired_Record(bool matching_Values)
        {
            if (matching_Values == false)
            {
                MessageBox.Show("Запись не найдена!");
            }
            matching_Values = false;
        }

        private static void Selects_Cells_With_Desired_Information(DataGridView dataGridView, TextBox textBox)
        {
            var matching_Values = false;
            dataGridView.ClearSelection();

            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    if (dataGridView[i, j].Value.ToString().Contains(textBox.Text))
                    {
                        dataGridView[i, j].Style.BackColor = Color.FromArgb(24, 48, 24);
                        dataGridView[i, j].Style.ForeColor = Color.FromArgb(244, 220, 162);
                        matching_Values = true;
                    }
                    else
                    {
                        dataGridView[i, j].Style.BackColor = Color.FromArgb(244, 220, 162);
                        dataGridView[i, j].Style.ForeColor = Color.FromArgb(31, 57, 42);
                    }
                }
            }
            Notifies_About_Absence_Desired_Record(matching_Values);
        }
    }
}
