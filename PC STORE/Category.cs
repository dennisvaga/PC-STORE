using System.Data;
using System.Data.SqlClient;

namespace PC_STORE
{
    class Category
    {
        public DataTable GetCategories()
        {
            DB db = new DB();
            DataTable tab = db.getData("spr_get_Categories", null);
            db.closeConnection();
            return tab;
        }

        public void InsertCategory(string name)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@cat_name", SqlDbType.VarChar)
            {
                Value = name
            };

            db.setData("spr_insert_category", parameters);
            db.closeConnection();

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

        public void DeleteCategory(int product_id)
        {

            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@cid", SqlDbType.Int)
            {
                Value = product_id
            };

            db.openConnection();
            db.setData("spr_delete_category", parameters);
            db.closeConnection();

        }

        public void UpdateCategory(int cid, string name)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@c_id", SqlDbType.Int)
            {
                Value = cid
            };

            parameters[1] = new SqlParameter("@c_name", SqlDbType.VarChar)
            {
                Value = name
            };

            db.setData("spr_update_category", parameters);
            db.closeConnection();
        }
    }
}
