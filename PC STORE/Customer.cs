using System.Data.SqlClient;
using System.Data;

namespace PC_STORE
{
    class Customer
    {

        public void InsertCustomer(string fname, string lname, string tel, string email)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@fname", SqlDbType.VarChar)
            {
                Value = fname
            };

            parameters[1] = new SqlParameter("@lname", SqlDbType.VarChar, 50)
            {
                Value = lname
            };

            parameters[2] = new SqlParameter("@tel", SqlDbType.NChar, 20)
            {
                Value = tel
            };

            parameters[3] = new SqlParameter("@mail", SqlDbType.VarChar, 50)
            {
                Value = email
            };

            db.setData("spr_insert_customer", parameters);
            db.closeConnection();

        }

        public DataTable GetCustomers()
        {
            DB db = new DB();
            DataTable tab = db.getData("spr_get_customers", null);
            db.closeConnection();
            return tab;
        }


        public DataTable SearchProducts(string valueToSearch)
        {

            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100)
            {
                Value = valueToSearch
            };
            DataTable table = db.getData("spr_search_Products", parameters);
            db.closeConnection();
            return table;
        }

        public void DeleteCustomer(int id)
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = id
            };

            db.openConnection();
            db.setData("spr_delete_customer", parameters);
            db.closeConnection();

        }

        public void UpdateCustomer(int id, string fname, string lname, string tel, string email)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = id
            };

            parameters[1] = new SqlParameter("@fname", SqlDbType.VarChar, 50)
            {
                Value = fname
            };

            parameters[2] = new SqlParameter("@lname", SqlDbType.VarChar, 50)
            {
                Value = lname
            };

            parameters[3] = new SqlParameter("@tel", SqlDbType.NChar, 20)
            {
                Value = tel
            };

            parameters[4] = new SqlParameter("@mail", SqlDbType.VarChar, 50)
            {
                Value = email
            };

            db.setData("spr_update_customer", parameters);
            db.closeConnection();

        }

    }
}
