using System.Data.SqlClient;
using System.Data;

namespace PC_STORE
{
    class Product
    {
        public void InsertProduct(int cid, string name, float price, byte[] image, int quantity, string desc, int gntee)//להכניס מוצר
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@c_id", SqlDbType.Int),
                new SqlParameter("@p_name", SqlDbType.VarChar, 50),
                new SqlParameter("@s_qty", SqlDbType.Int),
                new SqlParameter("@price", SqlDbType.Float),
                new SqlParameter("@desc", SqlDbType.VarChar),
                new SqlParameter("@img", SqlDbType.Image),
                new SqlParameter("@gntee", SqlDbType.Int)
            };
            parameters[0].Value = cid;
            parameters[1].Value = name;
            parameters[2].Value = price;
            parameters[3].Value = image;
            parameters[4].Value = quantity;
            parameters[5].Value = desc;
            parameters[6].Value = gntee;

            db.SetData("spr_insert_product", parameters);
            db.CloseConnection();
        }

        public void UpdateProduct(int pid, int cid, string name, string price, byte[] image, int quantity, string desc)//עידכון מוצר
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@pid", SqlDbType.Int),
                new SqlParameter("@c_id", SqlDbType.Int),
                new SqlParameter("@p_name", SqlDbType.VarChar, 50),
                new SqlParameter("@s_qty", SqlDbType.Int),
                new SqlParameter("@price", SqlDbType.VarChar, 50),
                new SqlParameter("@desc", SqlDbType.VarChar),
                new SqlParameter("@img", SqlDbType.Image)
            };
            parameters[0].Value = pid;
            parameters[1].Value = cid;
            parameters[2].Value = name;
            parameters[3].Value = price;
            parameters[4].Value = image;
            parameters[5].Value = quantity;
            parameters[6].Value = desc;

            db.SetData("spr_update_product", parameters);
            db.CloseConnection();
        }
        public DataTable GetProducts()//משיכת מוצרים
        {
            DB db = new DB();
            DataTable tab = db.GetData("spr_get_products", null);
            db.CloseConnection();
            return tab;
        }

        public DataTable GetProduct(int id)//משיכת מוצר 
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = id
            };
            DataTable tab = db.GetData("spr_get_product_by_id", parameters);
            db.CloseConnection();
            return tab;
        }

        public DataTable GetProductsByCategory(int cat_id)//קבלת מוצרים פר קטגוריה
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@cid", SqlDbType.Int)
            {
                Value = cat_id
            };
            DataTable table = db.GetData("spr_products_by_category", parameters);
            db.CloseConnection();
            return table;
        }


        public DataTable SearchProducts(string valueToSearch)//חיפוש מוצרים
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100)
            {
                Value = valueToSearch
            };
            DataTable table = db.GetData("spr_search_products", parameters);
            db.CloseConnection();
            return table;
        }

        public void DeleteProducts(int product_id)//מחיקת מוצרים
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@pid", SqlDbType.Int)
            {
                Value = product_id
            };
            db.OpenConnection();
            db.SetData("spr_delete_products", parameters);
            db.CloseConnection();
        }


    }
}
