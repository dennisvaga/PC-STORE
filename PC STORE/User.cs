using System.Data.SqlClient;
using System.Data;


namespace PC_STORE
{
    class User
    {
        public DataTable getUsers()
        {
            DB db = new DB();
            DataTable tab = db.getData("spr_get_users", null);
            db.closeConnection();
            return tab;
        }

        public void insertUser(string username, string fullname, string password, string tel, string email)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 20)
            {
                Value = username
            };

            parameters[1] = new SqlParameter("@FULL_NAME", SqlDbType.VarChar, 100)
            {
                Value = fullname
            };

            parameters[2] = new SqlParameter("@PASS", SqlDbType.VarChar, 20)
            {
                Value = password
            };

            parameters[3] = new SqlParameter("@TEL", SqlDbType.VarChar, 20)
            {
                Value = tel
            };

            parameters[4] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 20)
            {
                Value = email
            };

            db.setData("spr_insert_user", parameters);
            db.closeConnection();

        }

        public void updateUser(string username, string fullname, string password, string tel, string email, int uid)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 20)
            {
                Value = username
            };

            parameters[1] = new SqlParameter("@FULL_NAME", SqlDbType.VarChar, 100)
            {
                Value = fullname
            };

            parameters[2] = new SqlParameter("@PASS", SqlDbType.VarChar, 20)
            {
                Value = password
            };

            parameters[3] = new SqlParameter("@TEL", SqlDbType.VarChar, 20)
            {
                Value = tel
            };

            parameters[4] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 20)
            {
                Value = email
            };

            parameters[5] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = uid
            };

            db.setData("spr_update_user", parameters);
            db.closeConnection();

        }

        public void deleteUser(int userId)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@uid", SqlDbType.Int)
            {
                Value = userId
            };

            db.setData("spr_delete_user", parameters);
            db.closeConnection();

        }
    }
}
