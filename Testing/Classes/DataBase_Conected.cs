using System.Data.SqlClient;

namespace Testing.Class
{
    internal class DataBase_Conected
    {
        private SqlConnection SqlConnection { get; } = new SqlConnection(@"Data Source=DESKTOP-26JTM7C;Initial Catalog=Tests;Integrated Security=True");

        public void OpenConneciton()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed) { SqlConnection.Open(); }
        }

        public void CloseConneciton()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open) { SqlConnection.Close(); }
        }

        public SqlConnection GetConnection()
        {
            return SqlConnection;
        }
    }
}
