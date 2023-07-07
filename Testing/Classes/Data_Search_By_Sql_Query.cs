using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Testing.Class
{
    internal class Data_Search_By_Sql_Query
    {
        public static DataSet Returns_Data_From_Database_On_Request(string sqlRequest)
        {
            var dbCon = new DataBase_Conected();
            dbCon.OpenConneciton();
            var sqlAdapter = new SqlDataAdapter(sqlRequest, dbCon.GetConnection());
            var dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            dbCon.CloseConneciton();
            return dataSet;
        }

        public static DataSet Returns_Data_From_Database_On_Request(string sqlRequest, string nameTable)
        {
            var dbCon = new DataBase_Conected();
            dbCon.OpenConneciton();
            var sqlAdapter = new SqlDataAdapter(sqlRequest, dbCon.GetConnection());
            var dataSet = new DataSet();
            sqlAdapter.Fill(dataSet, nameTable);
            dbCon.CloseConneciton();
            return dataSet;
        }

        public static void Returns_Data_From_Database_On_Request(string sqlRequest, string nameTable, string nameColumn, ComboBox comboBox)
        {
            var dbCon = new DataBase_Conected();
            dbCon.OpenConneciton();
            var sqlAdapter = new SqlDataAdapter(sqlRequest, dbCon.GetConnection());
            var dataSet = new DataSet();
            sqlAdapter.Fill(dataSet, nameTable);
            comboBox.DataSource = dataSet.Tables[nameTable];
            comboBox.DisplayMember = nameColumn;
            dbCon.CloseConneciton();
        }
    }
}
