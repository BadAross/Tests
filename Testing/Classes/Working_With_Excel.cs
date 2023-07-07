using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Testing.Struct;

namespace Testing.Classes
{
    public class Working_With_Excel
    {
        private static Microsoft.Office.Interop.Excel.Application excel_App = new Microsoft.Office.Interop.Excel.Application();

        public static void Save_File_Excel(DataGridView dataGridView, List<Column_Parameter> column_Parameters, int[] width_Columns_Excel_Table, string name_File, ProgressBar progressBar, string font_Name = "Times New Roman", int header_Font_Size = 13, int cell_Font_Size = 12)
        {
            var excel_Work_Book = excel_App.Workbooks.Add(System.Reflection.Missing.Value);
            var excel_Work_Sheet = (Worksheet)excel_Work_Book.Worksheets.get_Item(1);
            var start_Position_Table = new Position_Excel();
            var end_Position_Table = new Position_Excel();
            progressBar.Value = 10;

            Set_Cell_Parameters(dataGridView, excel_Work_Sheet, cell_Font_Size, font_Name);
            progressBar.Value = 20;

            Fills_Excel_Table_From_Datagridview(dataGridView, excel_Work_Sheet, width_Columns_Excel_Table, column_Parameters);
            progressBar.Value = 50;

            Returns_Coordinates_Excel_Table(dataGridView, out start_Position_Table, out end_Position_Table);
            var excel_Table_Position = (Range)excel_Work_Sheet.Range[excel_Work_Sheet.Cells[start_Position_Table.x, start_Position_Table.y], excel_Work_Sheet.Cells[end_Position_Table.x, end_Position_Table.y]];
            var header_Position = (Range)excel_Work_Sheet.Range[excel_Work_Sheet.Cells[start_Position_Table.x, start_Position_Table.y], excel_Work_Sheet.Cells[start_Position_Table.x, end_Position_Table.y]];

            Draws_Outline_Table(excel_Work_Sheet, excel_Table_Position);
            progressBar.Value = 60;

            Set_Header_Settings(header_Position, header_Font_Size);
            progressBar.Value = 80;

            Save_File_Excel(excel_Work_Book, name_File);
            progressBar.Value = 100;
            MessageBox.Show("Файл сохранён!", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void Fills_Excel_Table_From_Datagridview(DataGridView dataGridView, Worksheet worksheet, int[] widthColumn, List<Column_Parameter> column_Parameters)
        {
            var columns = worksheet.Columns;
            var cells = worksheet.Cells;

            for (int columnNumber = 1; columnNumber < dataGridView.ColumnCount; columnNumber++)
            {
                cells[1, columnNumber + 1] = column_Parameters[columnNumber].name;
                for (int rowNumber = 0; rowNumber < dataGridView.Rows.Count; rowNumber++)
                {
                    cells[rowNumber + 2, columnNumber + 1] = dataGridView.Rows[rowNumber].Cells[columnNumber].Value;
                    cells[rowNumber + 2, 1] = rowNumber + 1;
                }
                columns[columnNumber + 1].ColumnWidth = widthColumn[columnNumber];
            }
        }

        private static void Returns_Coordinates_Excel_Table(DataGridView dataGridView, out Position_Excel start_Position_Table, out Position_Excel end_Position_Table)
        {
            start_Position_Table = new Position_Excel()
            {
                x = 1,
                y = 1
            };

            end_Position_Table = new Position_Excel()
            {
                x = dataGridView.Rows.Count + 1,
                y = dataGridView.Columns.Count
            };
        }

        private static void Draws_Outline_Table(Worksheet worksheet, Range location_Table_Excel)
        {
            location_Table_Excel.Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            location_Table_Excel.Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            location_Table_Excel.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            location_Table_Excel.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            location_Table_Excel.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            location_Table_Excel.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
        }

        private static void Set_Cell_Parameters(DataGridView dataGridView, Worksheet worksheet, int fontSize, string FontName)
        {
            var columns = worksheet.Columns;
            var cells = worksheet.Cells;

            for (int i = 1; i <= dataGridView.Columns.Count; i++)
            {
                columns[i].NumberFormat = "@";
            }

            cells.Font.Name = FontName;
            cells.Font.Size = fontSize;
            worksheet.Cells.Style.WrapText = true;
        }

        private static void Set_Header_Settings(Range header_Location, int font_Size)
        {
            header_Location.VerticalAlignment = XlHAlign.xlHAlignCenter;
            header_Location.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            header_Location.Font.Size = font_Size;
            header_Location.Font.Bold = true;
        }

        private static void Save_File_Excel(Workbook excel_Work_Book, string name_File)
        {
            var time_Save_File_Excel = DateTime.Now;
            var file_Save_Folder = @"C:\Users\xac32\OneDrive\Рабочий стол\";
            var excel_File_Name = name_File + " от " + time_Save_File_Excel.ToShortDateString() + ".xlsx";
            var full_File_Name = System.IO.Path.Combine(file_Save_Folder, excel_File_Name);

            if (System.IO.File.Exists(full_File_Name))
            {
                System.IO.File.Delete(full_File_Name);
            }

            excel_Work_Book.SaveAs(full_File_Name, XlFileFormat.xlWorkbookDefault);
            excel_Work_Book.Close(false);
            excel_App.Quit();
        }
    }
}
