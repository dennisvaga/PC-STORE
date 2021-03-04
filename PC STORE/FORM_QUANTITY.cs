using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_QUANTITY : Form
    {
        public bool addTheProduct = false;
        public int pro_id;

        public FORM_QUANTITY()
        {
            InitializeComponent();
        }

        public Boolean ValidQty(int id) //בודק אם יש מספיק מלאי מהמוצר 
        {
            Product product = new Product();
            DataTable table = product.GetProduct(id);
            int qty = Convert.ToInt32(table.Rows[0]["STOCK_QTE"]);

            if (Convert.ToInt32(TB_QUANTITY.Text) > qty)
                return addTheProduct = false;

            else
                return addTheProduct = true;
        }
    
        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            addTheProduct = false;
            Close();
        }

        private void BTN_OK_Click(object sender, EventArgs e)//הוספת כמות
        {
            Regex regex = new Regex(@"^\d+$");
            if (TB_QUANTITY.Text == string.Empty || !(regex.Match(TB_QUANTITY.Text).Success) || Convert.ToInt32(TB_QUANTITY.Text) == 0)
            {
                MessageBox.Show("כמות לא תקינה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addTheProduct = false;
            }
            else if (ValidQty(pro_id) == false)
            {
                MessageBox.Show("אין מספיק מלאי מהמוצר", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
