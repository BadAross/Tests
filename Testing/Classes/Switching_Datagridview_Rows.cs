using System.Windows.Forms;

namespace Testing.Classes.Performers
{
    internal class Switching_Datagridview_Rows
    {
        public static void Moves_Next_Entry(DataGridView dataGridView)
        {
            try
            {
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex + 1].Cells[dataGridView.CurrentCell.ColumnIndex];
            }
            catch
            {
            }
        }

        public static void Moves_Previos_Entry(DataGridView dataGridView)
        {
            try
            {
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex - 1].Cells[dataGridView.CurrentCell.ColumnIndex];
            }
            catch
            {
            }
        }

        public static void Moves_First_Entry(DataGridView dataGridView)
        {
            try
            {
                dataGridView.CurrentCell = dataGridView.Rows[0].Cells[1];
            }
            catch
            {
            }
        }

        public static void Moves_Last_Entry(DataGridView dataGridView)
        {
            try
            {
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.RowCount - 1].Cells[dataGridView.ColumnCount - 1];
            }
            catch
            {
            }
        }
    }
}
