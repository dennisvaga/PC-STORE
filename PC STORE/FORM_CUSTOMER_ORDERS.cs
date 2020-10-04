using System;
using System.Data;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_CUSTOMER_ORDERS : Form
    {
        private Order order = new Order();
        public FORM_CUSTOMER_ORDERS()
        {
            InitializeComponent();

        }
        //Populate listbox with the product name in the slected order
        private void FORM_CUSTOMER_ORDERS_Load(object sender, EventArgs e)
        {
            //Show customer oreders
            if (DGV_CUSTOMER_ORDERS.Rows.Count - 1 != 0)
            {
                int orderId = Convert.ToInt32(DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value.ToString());
                // get the order details
                DataTable details = order.GetOrderDetails(orderId);
                if (details.Rows.Count != 0)
                {
                    // show the products in the listbox
                    LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = order.GetOrderDetails(orderId);
                    LSB_CUSTOMER_ORDER_PRODUCTS.DisplayMember = "PRO_NAME";
                }
                else
                {
                    LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = null;
                    LSB_CUSTOMER_ORDER_PRODUCTS.Items.Add("No Products");
                }
            }

        }

        // repopulate listbox with the product name in the slected order
        private void DGV_CUSTOMER_ORDERS_DoubleClick(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value.ToString());
            DataTable details = order.GetOrderDetails(orderId);
            if (details.Rows.Count != 0)
            {
                LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = order.GetOrderDetails(orderId);
                LSB_CUSTOMER_ORDER_PRODUCTS.DisplayMember = "PRO_NAME";
            }
            else
            {
                LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = null;
                LSB_CUSTOMER_ORDER_PRODUCTS.Items.Add("No Products");
            }
        }

        // show products in the selected order 
        private void DGV_CUSTOMER_ORDERS_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value.ToString());
            DataTable details = order.GetOrderDetails(orderId);
            if (details.Rows.Count != 0)
            {
                LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = order.GetOrderDetails(orderId);
                LSB_CUSTOMER_ORDER_PRODUCTS.DisplayMember = "PRO_NAME";
            }
            else
            {
                LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = null;
                LSB_CUSTOMER_ORDER_PRODUCTS.Items.Add("No Products");
            }
        }


    }
}