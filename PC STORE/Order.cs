using System;
using System.Data;
using System.Data.SqlClient;

namespace PC_STORE
{
    class Order
    {
        private DB db = new DB();
        public void InsertOrder(DateTime order_date, int customer_id)
        {
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@o_date", SqlDbType.DateTime)
            {
                Value = order_date
            };

            parameters[1] = new SqlParameter("@cus_id", SqlDbType.Int)
            {
                Value = customer_id
            };

            db.setData("spr_insert_order", parameters);
            db.closeConnection();

        }

        public void InsertOrderDetail(int p_id, int o_id, int qty, string price, string total)
        {
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@p_id", SqlDbType.Int)
            {
                Value = p_id
            };

            parameters[1] = new SqlParameter("@o_id", SqlDbType.Int)
            {
                Value = o_id
            };

            parameters[2] = new SqlParameter("@qty", SqlDbType.Int)
            {
                Value = qty
            };

            parameters[3] = new SqlParameter("@price", SqlDbType.VarChar, 50)
            {
                Value = price
            };

            parameters[4] = new SqlParameter("@total", SqlDbType.VarChar, 50)
            {
                Value = total
            };

            db.setData("spr_insert_order_detail", parameters);
            db.closeConnection();

        }

        public DataTable GetCustomerOrders(int customerId)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = customerId
            };
            DataTable tab = db.getData("spr_get_all_customer_orders", parameters);
            db.closeConnection();

            return tab;
        }

        public DataTable GetAllOrders()
        {
            DataTable tab = db.getData("spr_get_all_orders", null);
            db.closeConnection();
            return tab;
        }

        public DataTable GetOrderMaxId()
        {
            DataTable tab = db.getData("spr_get_order_max_id", null);
            db.closeConnection();
            return tab;
        }

        public DataTable GetOrderDetails(int orderId)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = orderId
            };
            DataTable tab = db.getData("spr_get_order_details", parameters);
            db.closeConnection();
            return tab;
        }

        public DataTable GetOrderTotalAmount(int orderId)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = orderId
            };
            DataTable tab = db.getData("spr_get_total_order_amount", parameters);
            db.closeConnection();
            return tab;
        }

        public string GetCustomerOrdersCount(int customerId)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = customerId
            };
            DataTable tab = db.getData("spr_get_customer_orders_count", parameters);
            db.closeConnection();
            if (tab.Rows.Count == 0)
            {
                return "No Orders";
            }
            else
            {
                return tab.Rows[0][1].ToString();
            }
        }

        public string GetCustomerOrdersTotalAmount(int customerId)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = customerId
            };
            DataTable tab = db.getData("spr_get_customer_orders_amount", parameters);
            db.closeConnection();
            if (tab.Rows.Count == 0)
            {
                return "0";
            }
            else
            {
                return tab.Rows[0][1].ToString();
            }
        }

        public string GetCustomerLastOrderDate(int customerId)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = customerId
            };
            DataTable tab = db.getData("spr_get_customer_last_order_date", parameters);
            db.closeConnection();
            if (tab.Rows.Count == 0)
            {
                return "No Order";
            }
            else
            {
                return tab.Rows[0][0].ToString();
            }
        }
    }
}