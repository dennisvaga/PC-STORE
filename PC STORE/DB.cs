using System.Data.SqlClient;
using System.Data;

namespace PC_STORE
{
    class DB
    {
        SqlConnection connection;

        public DB()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PC_STORE_DB;Integrated Security=True");
        }

        public void openConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public DataTable getData(string procedureName, SqlParameter[] procedureParams)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Connection = connection;
            if (procedureParams != null)
            {
                for (int i = 0; i < procedureParams.Length; i++)
                {
                    command.Parameters.Add(procedureParams[i]);
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void setData(string procedureName, SqlParameter[] procedureParams)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Connection = connection;
            if (procedureParams != null)
            {
                command.Parameters.AddRange(procedureParams);
            }

            command.ExecuteNonQuery();
        }
    }
}
