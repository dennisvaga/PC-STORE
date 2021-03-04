using System.Data.SqlClient;
using System.Data;

namespace PC_STORE
{
    class DB
    {
        readonly SqlConnection connection;

        public DB()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PC_STORE_DB;Integrated Security=True");
        }

        public void OpenConnection()//פתיחת חיבור
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public void CloseConnection()//סגירת חיבור
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public DataTable GetData(string procedureName, SqlParameter[] procedureParams)//משיכת נתונים
        {
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = procedureName,
                Connection = connection
            };
            if (procedureParams != null)
            {
                for (int i = 0; i < procedureParams.Length; i++)
                    command.Parameters.Add(procedureParams[i]);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void SetData(string procedureName, SqlParameter[] procedureParams)//הכנסת נתונים
        {
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = procedureName,
                Connection = connection
            };
            if (procedureParams != null)
                command.Parameters.AddRange(procedureParams);
            command.ExecuteNonQuery();
        }
    }
}
