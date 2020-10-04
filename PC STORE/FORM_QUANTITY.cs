using System;
using System.Data;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_QUANTITY : Form
    {
        private Product product = new Product();
        public bool addTheProduct = false;
        public int pro_id;

        public FORM_QUANTITY()
        {
            InitializeComponent();
        }



        // if typed quantity exist in the stock 
        public Boolean ValidQty(int id)
        {
            DataTable table = product.GetProduct(id);
            int qty = Convert.ToInt32(table.Rows[0]["STOCK_QTE"].ToString());
            if (Convert.ToInt32(TB_QUANTITY.Text) > qty)
            {
                return addTheProduct = false;
            }
            else
            {
                return addTheProduct = true;

            }
        }


        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            addTheProduct = false;
            Close();
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            if (TB_QUANTITY.Text == String.Empty || Convert.ToInt32(TB_QUANTITY.Text) == 0)
            {
                MessageBox.Show("Quantity Can't Be Empty Or = 0", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addTheProduct = false;
            }
            else if (ValidQty(pro_id) == false)
            {
                MessageBox.Show("Unavailable Quantity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addTheProduct = false;
            }
            else
            {
                addTheProduct = true;
                Close();
            }
        }
    }
}
