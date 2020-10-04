using System.Data;
using System.Data.SqlClient;
namespace PC_STORE
{
    class Login
    {
        public DataTable login(string username, string password)
        {
            DB db = new DB();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 20)
            {
                Value = username
            };
            param[1] = new SqlParameter("@pass", SqlDbType.VarChar, 20)
            {
                Value = password
            };
            DataTable tab = db.getData("spr_login", param);
            db.closeConnection();
            return tab;
        }
    }
}
