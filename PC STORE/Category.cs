using System.Data;
using System.Data.SqlClient;

namespace PC_STORE
{
    class Category
    {
        public void InsertCategory(string name)//מכניס קטגוריות
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@cat_name", SqlDbType.VarChar)
            {
                Value = name
            };
            db.SetData("spr_insert_category", parameters);
            db.CloseConnection();
        }

        public void UpdateCategory(int cid, string name)//עידכון קטגוריה
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@c_id", SqlDbType.Int),
                new SqlParameter("@c_name", SqlDbType.VarChar)
            };
            parameters[0].Value = cid;
            parameters[1].Value = name;

            db.SetData("spr_update_category", parameters);
            db.CloseConnection();
        }

        public DataTable GetCategories()//מושך קטגוריות
        {
            DB db = new DB();
            DataTable tab = db.GetData("spr_get_categories", null);
            db.CloseConnection();
            return tab;
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

        public void DeleteCategory(int product_id)//מחיקת קטגוריה
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@cid", SqlDbType.Int)
            {
                Value = product_id
            };
            db.OpenConnection();
            db.SetData("spr_delete_category", parameters);
            db.CloseConnection();
        }

        public DataTable CheckDup(string valueToSearch)//בדיקת כפילויות
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@category", SqlDbType.VarChar, 50)
            {
                Value = valueToSearch
            };
            DataTable table = db.GetData("spr_check_category_dup", parameters);
            db.CloseConnection();
            return table;
        }


    }
}
