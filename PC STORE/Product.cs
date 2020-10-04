using System.Data.SqlClient;
using System.Data;

namespace PC_STORE
{
    class Product
    {
        DB db = new DB();
        public void InsertProduct(int cid, string name, string price, byte[] image, int quantity, string desc)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@c_id", SqlDbType.Int)
            {
                Value = cid
            };

            parameters[1] = new SqlParameter("@p_name", SqlDbType.VarChar, 50)
            {
                Value = name
            };

            parameters[2] = new SqlParameter("@s_qty", SqlDbType.Int)
            {
                Value = quantity
            };

            parameters[3] = new SqlParameter("@price", SqlDbType.VarChar, 50)
            {
                Value = price
            };

            parameters[4] = new SqlParameter("@desc", SqlDbType.VarChar)
            {
                Value = desc
            };

            parameters[5] = new SqlParameter("@img", SqlDbType.Image)
            {
                Value = image
            };

            db.setData("spr_insert_product", parameters);
            db.closeConnection();

        }

        public DataTable GetProducts()
        {
            DataTable tab = db.getData("spr_get_Products", null);
            db.closeConnection();
            return tab;
        }

        public DataTable GetProduct(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = id
            };
            DataTable tab = db.getData("spr_get_Product_by_id", parameters);
            db.closeConnection();
            return tab;
        }

        public DataTable GetProductsByCategory(int cat_id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@cid", SqlDbType.Int)
            {
                Value = cat_id
            };
            DataTable table = db.getData("spr_products_by_category", parameters);
            db.closeConnection();
            return table;
        }


        public DataTable SearchProducts(string valueToSearch)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100)
            {
                Value = valueToSearch
            };
            DataTable table = db.getData("spr_search_Products", parameters);
            db.closeConnection();
            return table;
        }

        public void DeleteProducts(int product_id)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@pid", SqlDbType.Int)
            {
                Value = product_id
            };

            db.openConnection();
            db.setData("spr_delete_Products", parameters);
            db.closeConnection();
        }

        public void UpdateProduct(int pid, int cid, string name, string price, byte[] image, int quantity, string desc)
        {
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[7];

            parameters[0] = new SqlParameter("@pid", SqlDbType.Int)
            {
                Value = pid
            };

            parameters[1] = new SqlParameter("@c_id", SqlDbType.Int)
            {
                Value = cid
            };

            parameters[2] = new SqlParameter("@p_name", SqlDbType.VarChar, 50)
            {
                Value = name
            };

            parameters[3] = new SqlParameter("@s_qty", SqlDbType.Int)
            {
                Value = quantity
            };

            parameters[4] = new SqlParameter("@price", SqlDbType.VarChar, 50)
            {
                Value = price
            };

            parameters[5] = new SqlParameter("@desc", SqlDbType.VarChar)
            {
                Value = desc
            };

            parameters[6] = new SqlParameter("@img", SqlDbType.Image)
            {
                Value = image
            };

            db.setData("spr_update_Product", parameters);
            db.closeConnection();

        }
    }
}
