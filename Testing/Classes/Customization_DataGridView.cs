using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Testing.Struct;

namespace Testing.Classes
{
    internal class Customization_DataGridView
    {
        public static void Sets_Parameters_For_DataGridView(DataGridView dataGridView)
        {
            Color main_Color = Color.FromArgb(31, 57, 42);
            Color additional_Color = Color.FromArgb(244, 220, 162);
            Font font_Text = new Font("Segoe UI Semibold", 14f, FontStyle.Bold);
            Font font_Header = new Font("Segoe UI Semibold", 16f, FontStyle.Bold);

            Paints_DataGridView(dataGridView, main_Color, additional_Color);

            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.EnableHeadersVisualStyles = false;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dataGridView.ColumnHeadersDefaultCellStyle.Font = font_Header;
            dataGridView.DefaultCellStyle.Font = font_Text;

            dataGridView.Columns[0].Visible = false;
        }

        private static void Paints_DataGridView(DataGridView dataGridView, Color main_Color, Color additional_Color)
        {
            dataGridView.RowsDefaultCellStyle.BackColor = additional_Color;
            dataGridView.DefaultCellStyle.ForeColor = main_Color;
            dataGridView.DefaultCellStyle.SelectionForeColor = additional_Color;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = additional_Color;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = main_Color;
            dataGridView.RowHeadersDefaultCellStyle.BackColor = main_Color;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 48, 24);
            dataGridView.GridColor = main_Color;
        }

        public static void Sets_Received_Titles_And_Size_For_Headings(DataGridView dataGridView, List<Column_Parameter> Column_Parameters)
        {
            for (int i = 0; i < Column_Parameters.Count; i++)
            {
                dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[i].HeaderText = Column_Parameters[i].name;
                dataGridView.Columns[i].Width = Column_Parameters[i].size;
            }
        }

        public static void Sets_Line_Height(DataGridView dataGridView, int height_Cells = 80)
        {
            dataGridView.RowTemplate.MinimumHeight = height_Cells;
        }
    }
}
