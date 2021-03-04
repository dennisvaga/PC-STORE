using System.Data;
using System.Data.SqlClient;
namespace PC_STORE
{
    class Login
    {
        public DataTable login(string username, string password)//כניסה למערכת
        {
            DB db = new DB();
            SqlParameter[] parameters =
            {
                new SqlParameter("@username", SqlDbType.VarChar, 20),
                new SqlParameter("@pass", SqlDbType.VarChar, 20)
            };
            parameters[0].Value = username;
            parameters[1].Value = password;

            DataTable tab = db.GetData("spr_login", parameters);
            db.CloseConnection();
            return tab;
        }
    }
}
