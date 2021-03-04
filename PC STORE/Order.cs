using System;
using System.Data;
using System.Data.SqlClient;

namespace PC_STORE
{
    class Order
    {
        public void InsertOrder(DateTime order_date, int customer_id)//הכנסת הזמנה
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@o_date", SqlDbType.DateTime),
                new SqlParameter("@cus_id", SqlDbType.Int),
            };
            parameters[0].Value = order_date;
            parameters[1].Value = customer_id;

            db.SetData("spr_insert_order", parameters);
            db.CloseConnection();
        }

        public void InsertOrderDetail(int p_id, int o_id, int qty, int emp_id, string price, string total)//הכנסת פרטי הזמנה
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@p_id", SqlDbType.Int),
                new SqlParameter("@o_id", SqlDbType.Int),
                new SqlParameter("@qty", SqlDbType.Int),
                new SqlParameter("@emp_id", SqlDbType.Int),
                new SqlParameter("@price", SqlDbType.VarChar, 50),
                new SqlParameter("@total", SqlDbType.VarChar, 50),
            };
            parameters[0].Value = p_id;
            parameters[1].Value = o_id;
            parameters[2].Value = qty;
            parameters[3].Value = emp_id;
            parameters[4].Value = price;
            parameters[5].Value = total;

            db.SetData("spr_insert_order_detail", parameters);
            db.CloseConnection();
        }

        public DataTable GetCustomerOrders(int customerId)//משיכת הזמנות של הלקוח
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = customerId
            };
            DataTable tab = db.GetData("spr_get_all_customer_orders", parameters);
            db.CloseConnection();
            return tab;
        }

        public DataTable GetAllOrders()//מושך את כל ההזמנות
        {
            DB db = new DB();
            DataTable tab = db.GetData("spr_get_all_orders", null);
            db.CloseConnection();
            return tab;
        }
        public DataTable GetLastOrder()//מושך את ההזמנה האחרונה
        {
            DB db = new DB();
            DataTable tab = db.GetData("spr_get_last_order", null);
            db.CloseConnection();
            return tab;
        }
        public DataTable GetOrderMaxId()
        {
            DB db = new DB();
            DataTable tab = db.GetData("spr_get_order_max_id", null);
            db.CloseConnection();
            return tab;
        }

        public DataTable GetOrderDetails(int orderId)//משיכת פרטי הזמנה
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = orderId
            };
            DataTable tab = db.GetData("spr_get_order_details", parameters);
            db.CloseConnection();
            return tab;
        }

        public DataTable GetOrderTotalAmount(int orderId)//קבלת סהכ סכום ההזמנה
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = orderId
            };
            DataTable tab = db.GetData("spr_get_total_order_amount", parameters);
            db.CloseConnection();
            return tab;
        }

        public string GetCustomerOrdersCount(int customerId)//קבלת סהכ ההזמנות של הלקוח
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = customerId
            };
            DataTable tab = db.GetData("spr_get_customer_orders_count", parameters);
            db.CloseConnection();
            if (tab.Rows.Count == 0)
                return "אין הזמנות";
            return tab.Rows[0][1].ToString();
        }

        public string GetCustomerOrdersTotalAmount(int customerId)//קבלת סהכ סכום של כל ההזמנות של הלקוח
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = customerId
            };
            DataTable tab = db.GetData("spr_get_customer_orders_amount", parameters);
            db.CloseConnection();
            if (tab.Rows.Count == 0)
                return "0";
            return tab.Rows[0][1].ToString();
        }

        public string GetCustomerLastOrderDate(int customerId)//קבלת תאריך הזמנה אחרון של הלקוח
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = customerId
            };
            DataTable tab = db.GetData("spr_get_customer_last_order_date", parameters);
            db.CloseConnection();
            if (tab.Rows.Count == 0)
                return "אין הזמנות";
            return tab.Rows[0][0].ToString();
        }

        public DataTable SearchOrder(string valueToSearch)//חיפוש הזמנה
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100)
            {
                Value = valueToSearch
            };
            DataTable table = db.GetData("spr_search_order", parameters);
            db.CloseConnection();
            return table;
        }

    }
}