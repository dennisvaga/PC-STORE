using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_MANAGE_ORDER : Form
    {
        private Customer customer = new Customer();
        private Category category = new Category();
        private Product product = new Product();
        private Order order = new Order();

        public FORM_MANAGE_ORDER()
        {
            InitializeComponent();
            DGV_CUSTOMER.DataSource = customer.GetCustomers();

            if (DGV_CUSTOMER.Rows.Count != 0 && order.GetOrderMaxId().Rows.Count - 1 != 0)//Check if there is customers or orders to show
            {
                COMBO_CATEGORIES.DataSource = category.GetCategories();
                COMBO_CATEGORIES.DisplayMember = "CAT_NAME";
                COMBO_CATEGORIES.ValueMember = "CAT_ID";

                TB_ORDER_ID.Text = (Convert.ToInt32(order.GetOrderMaxId().Rows[0][0]) + 1).ToString();


                // Datagridview products
                DataGridViewTextBoxColumn dgvPId = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Id"
                };
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPId);

                DataGridViewTextBoxColumn dgvPn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Name"
                };
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPn);

                DataGridViewTextBoxColumn dgvcPp = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Price"
                };
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvcPp);

                DataGridViewTextBoxColumn dgvPq = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Quantity"
                };
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPq);

                DataGridViewTextBoxColumn dgvPqXp = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Quantity X Price"
                };
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPqXp);

                DataGridViewCheckBoxColumn dgvPch = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Select"
                };
                DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPch);

                try
                {
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                    imageColumn = (DataGridViewImageColumn)DGV_PRODUCTS.Columns[4];
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    DGV_PRODUCTS.AllowUserToAddRows = false;
                    DGV_PRODUCTS.RowTemplate.Height = 50;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Change datagridview products based on the combo categories
        private void COMBO_CATEGORIES_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (product.GetProducts().Rows.Count != 0)//Check if there is products to show
            {
                Int32.TryParse(COMBO_CATEGORIES.SelectedValue.ToString(), out int val);

                DGV_PRODUCTS.DataSource = product.GetProductsByCategory(val);
                DGV_PRODUCTS.Columns[5].Visible = false;
                DGV_PRODUCTS.Columns[6].Visible = false;
            }

        }

        //Load datagridview PRODUCTS from the beginning
        private void FORM_MANAGE_ORDER_Load(object sender, EventArgs e)
        {
            COMBO_CATEGORIES_SelectedIndexChanged(null, null);
        }

     

        //Calculate order total amount
        public void GetTotal()
        {
            TB_SUM.Text = (from DataGridViewRow row in DGV_PRODUCTS_IN_ORDER.Rows
                           where row.Cells[4].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
        }

        //Delete the checked products from the datagridview
        private void BTN_DELETE_PRODUCTS_Click(object sender, EventArgs e)
        {
            for (int i = DGV_PRODUCTS_IN_ORDER.Rows.Count - 2; i >= 0; i--)
            {
                bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[5].Value;

                //if the checkbox cell is checked

                if (delete == true)
                {
                    DataGridViewRow rowToRemove = DGV_PRODUCTS_IN_ORDER.Rows[i];

                    DGV_PRODUCTS_IN_ORDER.Rows.Remove(rowToRemove);
                }
            }

            CB_SELECT_ALL.Checked = false;

            GetTotal();
        }

        //Select all or deselect all
        private void CB_SELECT_ALL_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_SELECT_ALL.Checked)
            {
                for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
                {
                    bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[5].Value;

                    if (delete == false)
                    {
                        DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[5].Value = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
                {
                    bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[5].Value;

                    if (delete == true)
                    {
                        DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[5].Value = false;
                    }
                }
            }
        }

        //Insert order
        private void BTN_INSERT_ORDER_Click(object sender, EventArgs e)
        {
            if (TB_CUSTOMER_ID.Text == string.Empty)
            {
                MessageBox.Show("No Customer Selected", "Error Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                order.InsertOrder(dateTimePicker1.Value, Convert.ToInt32(TB_CUSTOMER_ID.Text));
                for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
                {
                    order.InsertOrderDetail(Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[0].Value.ToString()),
                                           Convert.ToInt32(TB_ORDER_ID.Text),
                                           Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[3].Value.ToString()),
                                           DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[2].Value.ToString(),
                                           DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[4].Value.ToString());
                }

                COMBO_CATEGORIES_SelectedIndexChanged(null, null);
                MessageBox.Show("Order Inserted With Details");
                TB_ORDER_ID.Text = (Convert.ToInt32(order.GetOrderMaxId().Rows[0][0]) + 1).ToString();
            }
        }

        //Get customer id from selected DGV into textbox
        private void DGV_CUSTOMER_Click(object sender, EventArgs e)
        {
            TB_CUSTOMER_ID.Text = DGV_CUSTOMER.CurrentRow.Cells[0].Value.ToString();
        }

        //Show all selected customer orders
        private void DGV_CUSTOMER_DoubleClick(object sender, EventArgs e)
        {
            FORM_CUSTOMER_ORDERS fco = new FORM_CUSTOMER_ORDERS();
            fco.DGV_CUSTOMER_ORDERS.DataSource = order.GetCustomerOrders(Convert.ToInt32(DGV_CUSTOMER.CurrentRow.Cells[0].Value.ToString()));
            fco.LBL_CUSTOMER.Text = "Customer: " + DGV_CUSTOMER.CurrentRow.Cells[1].Value.ToString() + " " + DGV_CUSTOMER.CurrentRow.Cells[2].Value.ToString();
            fco.ShowDialog();
        }

        //Add new customer => call FORM NEW CUSTOMER
        private void BTN_NEW_CUSTOMER_Click(object sender, EventArgs e)
        {
            FORM_NEW_CUSTOMER fnc = new FORM_NEW_CUSTOMER();
            fnc.ShowDialog();
            DGV_CUSTOMER.DataSource = customer.GetCustomers();
        }


        //Show all orders
        private void BTN_ALL_ORDERS_Click(object sender, EventArgs e)
        {
            FORM_ALL_ORDERS fallOd = new FORM_ALL_ORDERS();
            fallOd.DGV_ALL_ORDERS.DataSource = order.GetAllOrders();
            fallOd.ShowDialog();
        }

        private void DGV_PRODUCTS_DoubleClick(object sender, EventArgs e)
        {
            //Get the selected product that you want to add to order
            DataGridViewRow selectedRow = DGV_PRODUCTS.CurrentRow;

            //Call add quantity form 
            FORM_QUANTITY fq = new FORM_QUANTITY
            {
                pro_id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString())
            };
            fq.ShowDialog();

            int index = 0;
            bool isExist = false;//To test if the product is already add

            if (fq.addTheProduct)//Check if quantity exists
            { 
                string qty = fq.TB_QUANTITY.Text;//Get the quantity from the quantity form
                double quantityXprice = Convert.ToInt32(qty) * Convert.ToDouble(selectedRow.Cells[3].Value.ToString());

                //If other products exist in the grid
                if (DGV_PRODUCTS_IN_ORDER.Rows.Count - 1 > 0)
                {
                    //Check if the product is already add and set isExist to true
                    for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
                    {
                        if (selectedRow.Cells[0].Value.ToString() == DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[0].Value.ToString())
                        {
                            isExist = true;
                            index = i;

                        }
                    }

                    //If the product already exist
                    //Check the stock quantity
                    if (isExist)
                    {
                        //The quantity sum
                        int pqty = Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[3].Value.ToString()) +
                                                   Convert.ToInt32(qty);

                        DataTable table = product.GetProduct(Convert.ToInt32(selectedRow.Cells[0].Value.ToString()));

                        //If the quantity is heigher than the stock quantity than show a message
                        int qty2 = Convert.ToInt32(table.Rows[0]["STOCK_QTE"].ToString());
                        if (pqty > qty2)
                        {
                            MessageBox.Show("Unavailable Quantity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                        //If quantity is fine add the product 
                        else
                        {
                            quantityXprice = Convert.ToInt32(pqty) * Convert.ToDouble(selectedRow.Cells[3].Value.ToString());
                            DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[3].Value = pqty.ToString();
                            DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[4].Value = quantityXprice.ToString();
                            GetTotal();
                        }

                    }

                    //If the product not exist => add product                  
                    else
                    {
                        DGV_PRODUCTS_IN_ORDER.Rows.Add(
                                               selectedRow.Cells[0].Value.ToString(),
                                               selectedRow.Cells[1].Value.ToString(),
                                               selectedRow.Cells[3].Value.ToString(),
                                               qty,
                                               quantityXprice.ToString(),
                                               false);
                        GetTotal();
                    }
                }

                //If the gridview is empty => add product       
                else if (DGV_PRODUCTS_IN_ORDER.Rows.Count - 1 == 0)
                {
                    DGV_PRODUCTS_IN_ORDER.Rows.Add(selectedRow.Cells[0].Value.ToString(),
                                            selectedRow.Cells[1].Value.ToString(),
                                            selectedRow.Cells[3].Value.ToString(),
                                            qty,
                                            quantityXprice.ToString(),
                                            false);
                    GetTotal();
                }

                GetTotal();

            }
        }
    }
}
