using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class UC_MANAGE_ORDER : UserControl
    {
        public UC_MANAGE_ORDER()
        {
            Category category = new Category();
            Customer customer = new Customer();
            InitializeComponent();
            DGV_CUSTOMER.DataSource = customer.GetCustomers();
            DGV_CUSTOMER.Columns[0].HeaderText = "תעודת זהות";
            DGV_CUSTOMER.Columns[1].HeaderText = "שם פרטי";
            DGV_CUSTOMER.Columns[2].HeaderText = "שם משפחה";
            DGV_CUSTOMER.Columns[3].HeaderText = "טלפון";
            DGV_CUSTOMER.Columns[4].HeaderText = "אימייל";

            COMBO_CATEGORIES.DataSource = category.GetCategories();
            COMBO_CATEGORIES.DisplayMember = "CAT_NAME";
            COMBO_CATEGORIES.ValueMember = "CAT_ID";

            //בונה את העמודות למוצרים בעגלה
            DataGridViewTextBoxColumn dgvPId = new DataGridViewTextBoxColumn
            {
                HeaderText = "קוד מוצר"
            };
            DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPId);

            DataGridViewTextBoxColumn dgvPn = new DataGridViewTextBoxColumn
            {
                HeaderText = "שם"
            };
            DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPn);

            DataGridViewTextBoxColumn dgvcPp = new DataGridViewTextBoxColumn
            {
                HeaderText = "מחיר"
            };
            DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvcPp);

            DataGridViewTextBoxColumn dgvPq = new DataGridViewTextBoxColumn
            {
                HeaderText = "כמות"
            };
            DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPq);

            DataGridViewTextBoxColumn dgvPqXp = new DataGridViewTextBoxColumn
            {
                HeaderText = "כמות x מחיר"
            };
            DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPqXp);

            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DGV_PRODUCTS.Columns[4];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_PRODUCTS.AllowUserToAddRows = false;
            DGV_PRODUCTS.RowTemplate.Height = 50;
        }

        private void UC_MANAGE_ORDER_Load(object sender, EventArgs e) //טעינה של מוצרים אם קיימים
        {
            COMBO_CATEGORIES_SelectedIndexChanged(null, null);
        }

        public void GetTotal() //חישוב סהכ מחיר
        {
            TB_SUM.Text = (from DataGridViewRow row in DGV_PRODUCTS_IN_ORDER.Rows
                           where row.Cells[4].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
        }

        private void BTN_PRINT_ORDER_Click(object sender, EventArgs e) //הדפסת הזמנה אחרונה
        {
            Order order = new Order();
            UC_ALL_ORDERS uao = new UC_ALL_ORDERS();
            uao.DGV_ALL_ORDERS.DataSource = order.GetLastOrder();
            uao.DGV_ALL_ORDERS.CurrentCell = uao.DGV_ALL_ORDERS.Rows[0].Cells[0];
            uao.BTN_PRINT_ORDER_Click(null, null);
        }
        private void BTN_SEARCH_CUST_Click(object sender, EventArgs e)//חיפוש לקוח
        {
            Customer customer = new Customer();
            DGV_CUSTOMER.DataSource = customer.SearchCustomers(TB_SEARCH_CUST.Text);
        }

        private void BTN_SEARCH_PRODUCT_Click(object sender, EventArgs e) //חיפוש מוצר
        {
            Product product = new Product();
            DGV_PRODUCTS.DataSource = product.SearchProducts(TB_SEARCH_PRODUCT.Text);
        }
        private void DGV_CUSTOMER_Click(object sender, EventArgs e) //שם את קוד הלקוח לטקסט בוקס
        {
            TB_CUSTOMER_ID.Text = DGV_CUSTOMER.CurrentRow.Cells[0].Value.ToString();
        }

        private void BTN_NEW_CUSTOMER_Click(object sender, EventArgs e) //הוספת לקוח חדש
        {
            Customer customer = new Customer();
            FORM_NEW_CUSTOMER fnc = new FORM_NEW_CUSTOMER();
            fnc.ShowDialog();
            DGV_CUSTOMER.DataSource = customer.GetCustomers();

        }
        private void COMBO_CATEGORIES_SelectedIndexChanged(object sender, EventArgs e) //מוצרים לפי קטגוריה
        {
            Product product = new Product();
            if (product.GetProducts().Rows.Count != 0)//בדיקה האם יש מוצרים להראות 
            {
                Int32.TryParse(COMBO_CATEGORIES.SelectedValue.ToString(), out int val);
                DGV_PRODUCTS.DataSource = product.GetProductsByCategory(val);
                DGV_PRODUCTS.Columns[0].HeaderText = "קוד מוצר";
                DGV_PRODUCTS.Columns[1].HeaderText = "שם";
                DGV_PRODUCTS.Columns[2].HeaderText = "כמות";
                DGV_PRODUCTS.Columns[3].HeaderText = "מחיר";
                DGV_PRODUCTS.Columns[4].HeaderText = "תמונה";
                DGV_PRODUCTS.Columns[5].Visible = false;
                DGV_PRODUCTS.Columns[6].HeaderText = "אחריות בחודשים";
                DGV_PRODUCTS.Columns[7].Visible = false;
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DGV_PRODUCTS.Columns[4];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                DGV_PRODUCTS.RowTemplate.Height = 90;
            }
        }

        private void BTN_DELETE_PRODUCTS_Click(object sender, EventArgs e)//מחיקת מוצרים מהטבלה
        {
            try
            {
                DGV_PRODUCTS_IN_ORDER.Rows.Remove(DGV_PRODUCTS_IN_ORDER.Rows[DGV_PRODUCTS_IN_ORDER.CurrentCell.RowIndex]);
                GetTotal();
            }
            catch (Exception)
            {
                MessageBox.Show("לא נבחר מוצר", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_INSERT_ORDER_Click(object sender, EventArgs e)//הוספת הזמנה
        {
            Order order = new Order();
            Employees employee = new Employees();

            if (TB_CUSTOMER_ID.Text == string.Empty)
                MessageBox.Show("לא נבחר לקוח", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (DGV_PRODUCTS_IN_ORDER.Rows.Count - 1 > 0)
            {
                order.InsertOrder(dateTimePicker1.Value, Convert.ToInt32(TB_CUSTOMER_ID.Text));
                int maxid = Convert.ToInt32(order.GetOrderMaxId().Rows[0][0]);//מוצא את הקוד שעכשיו נוצר בהזמנה

                DataTable tbl = employee.GetLastEnterEmployee();//מוצא את העובד שעכשיו משתמש בתוכנה
                //בדיקה אם המשתמש לא נכנס היום למשמרת אז זה אדמין
                DateTime check = employee.GetEmployeeLastEnterShiftDate(Convert.ToInt32(tbl.Rows[0]["EMPLOYEE_ID"]));
                int emp_id;

                if (check.Date != DateTime.Today)//אם המשתמש לא נכנס היום אז זה אדמין
                     emp_id = 324520741;
                else
                    emp_id = Convert.ToInt32(tbl.Rows[0]["EMPLOYEE_ID"]);

                for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
                {
                    order.InsertOrderDetail(Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[0].Value.ToString()), maxid,
                                           Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[3].Value.ToString()), emp_id,
                                           DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[2].Value.ToString(),
                                           DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[4].Value.ToString());
                }
                COMBO_CATEGORIES_SelectedIndexChanged(null, null);
                MessageBox.Show("ההזמנה נוספה בהצלחה");
                DGV_PRODUCTS_IN_ORDER.Rows.Clear();
            }
            else
                MessageBox.Show("לא נבחרו מוצרים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void DGV_PRODUCTS_DoubleClick(object sender, EventArgs e)// להוסיף מוצר לעגלת קניות
        {
            Product product = new Product();
            DataGridViewRow selectedRow = DGV_PRODUCTS.CurrentRow; //מאחסן את השורה המסומנת

            FORM_QUANTITY fq = new FORM_QUANTITY //פותח את תבנית של הכמות
            {
                pro_id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString())
            };
            fq.ShowDialog();

            int index = 0;
            bool isExist = false;

            if (fq.addTheProduct)//אם יש את הכמות הנדרשת במלאי 
            {
                string qty = fq.TB_QUANTITY.Text;//שומר את הכמות שנבחרה
                double quantityXprice = Convert.ToInt32(qty) * Convert.ToDouble(selectedRow.Cells[3].Value);

                if (DGV_PRODUCTS_IN_ORDER.Rows.Count - 1 > 0)
                {
                    for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++) //בדיקה אם המוצר קיים כבר בעגלה
                    {
                        if (selectedRow.Cells[0].Value.ToString() == DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[0].Value.ToString())
                        {
                            isExist = true;
                            index = i;
                        }
                    }
                    if (isExist)//אם המוצר כבר קיים שם בודקים אם יש מספיק מלאי
                    {
                        int pqty = Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[3].Value) + Convert.ToInt32(qty);//סהכ כמות
                        DataTable table = product.GetProduct(Convert.ToInt32(selectedRow.Cells[0].Value));
                        int qty2 = Convert.ToInt32(table.Rows[0]["STOCK_QTE"].ToString());
                        if (pqty > qty2)//אם אין מספיק מלאי הראה הודעת שגיאה
                        {
                            MessageBox.Show("איו כמות כזאת במלאי", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else //אחרת מוסיפים את המוצר
                        {
                            quantityXprice = pqty * Convert.ToDouble(selectedRow.Cells[3].Value.ToString());
                            DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[3].Value = pqty.ToString();
                            DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[4].Value = quantityXprice.ToString();
                            GetTotal();
                        }
                    }
                    else //האם המוצר לא קיים מוסיפים אותו         
                    {
                        DGV_PRODUCTS_IN_ORDER.Rows.Add(
                                               selectedRow.Cells[0].Value.ToString(),
                                               selectedRow.Cells[1].Value.ToString(),
                                               selectedRow.Cells[3].Value.ToString(),
                                               qty,
                                               quantityXprice.ToString());
                        GetTotal();
                    }
                }
                else if (DGV_PRODUCTS_IN_ORDER.Rows.Count - 1 == 0)//אם אין מוצרים בכלל אז מוסיפים
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
