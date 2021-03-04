using System.Data.SqlClient;
using System.Data;

namespace PC_STORE
{
    class Customer
    {
        public void InsertCustomer(int id, string fname, string lname, string tel, string email)//הכנסת לקוח
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", SqlDbType.VarChar),
                new SqlParameter("@fname", SqlDbType.VarChar),
                new SqlParameter("@lname", SqlDbType.VarChar, 50),
                new SqlParameter("@tel", SqlDbType.NChar, 20),
                new SqlParameter("@mail", SqlDbType.VarChar, 50)
            };
            parameters[0].Value = id;
            parameters[1].Value = fname;
            parameters[2].Value = lname;
            parameters[3].Value = tel;
            parameters[4].Value = email;

            db.SetData("spr_insert_customer", parameters);
            db.CloseConnection();
        }
        public void UpdateCustomer(int id, string fname, string lname, string tel, string email)//עידכון לקוח
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", SqlDbType.Int),
                new SqlParameter("@fname", SqlDbType.VarChar, 50),
                new SqlParameter("@lname", SqlDbType.VarChar, 50),
                new SqlParameter("@tel", SqlDbType.NChar, 20),
                new SqlParameter("@mail", SqlDbType.VarChar, 50)
            };
            parameters[0].Value = id;
            parameters[1].Value = fname;
            parameters[2].Value = lname;
            parameters[3].Value = tel;
            parameters[4].Value = email;

            db.SetData("spr_update_customer", parameters);
            db.CloseConnection();
        }
        public DataTable GetCustomers()//למשוך לקוחות
        {
            DB db = new DB();
            DataTable tab = db.GetData("spr_get_customers", null);
            db.CloseConnection();
            return tab;
        }

        public void DeleteCustomer(int id)//מחיקת לקוח
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = id
            };
            db.OpenConnection();
            db.SetData("spr_delete_customer", parameters);
            db.CloseConnection();

        }
       
        public DataTable SearchCustomers(string valueToSearch)//חיפוש לקוח
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100)
            {
                Value = valueToSearch
            };
            DataTable table = db.GetData("spr_search_customer", parameters);
            db.CloseConnection();
            return table;
        }
        public DataTable CheckDup(string valueToSearch)//בדיקת כפילויות
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@cust_id", SqlDbType.Int)
            {
                Value = valueToSearch
            };
            DataTable table = db.GetData("spr_check_customer_dup", parameters);
            db.CloseConnection();
            return table;
        }


    }
}
