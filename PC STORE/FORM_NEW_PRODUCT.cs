using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_NEW_PRODUCT : Form
    {
        public FORM_NEW_PRODUCT()
        {
            InitializeComponent();
            LoadComboCategory();
        }

        public void LoadComboCategory()//טעינת קטגוריות לתיבה משולבת + כותרות
        {
            Category catg = new Category();
            COMBO_CATEGORIES.DataSource = catg.GetCategories();
            COMBO_CATEGORIES.DisplayMember = "CAT_NAME";
            COMBO_CATEGORIES.ValueMember = "CAT_ID";
        }

        private void BTN_ADD_Click(object sender, EventArgs e)//הוספת מוצר
        {
            Product product = new Product();
            Regex regex = new Regex(@"^\d+$");//רק מספרים

            if (TB_NAME.Text == string.Empty)
                MessageBox.Show("הכנס את שם המוצר", "מידע חסר", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (TB_PRICE.Text == string.Empty && TB_QUANTITY.Text == string.Empty)
                MessageBox.Show("מחיר וכמות לא יכולים להיות ריקים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (!(regex.Match(TB_PRICE.Text).Success) || !(regex.Match(TB_QUANTITY.Text).Success))
                MessageBox.Show("כמות או מחיר לא תקינים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (Convert.ToInt32(TB_PRICE.Text) < 0 || Convert.ToInt32(TB_QUANTITY.Text) < 0 )
                MessageBox.Show("כמות ומחיר לא יכולים להיות שליליים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (PB_BROWSE_IMAGE.Image == null)
                MessageBox.Show("לא בחרת תמונה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                int gntee = 0;
                if (CB_GUARANTEE.Checked == true)
                    gntee = Convert.ToInt32(TB_GUARANTEE.Text);

                MemoryStream ms = new MemoryStream();
                PB_BROWSE_IMAGE.Image.Save(ms, PB_BROWSE_IMAGE.Image.RawFormat);
                byte[] image = ms.ToArray();

                product.InsertProduct(Convert.ToInt32(COMBO_CATEGORIES.SelectedValue), TB_NAME.Text,
                                     (float)Convert.ToDouble(TB_PRICE.Text), image, Convert.ToInt32(TB_QUANTITY.Text),
                                     TB_DESCRIPTION.Text, gntee);
                MessageBox.Show("המוצר נוסף בהצלחה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)//הוספת קטגוריה
        {
            FORM_ADD_NEW_CATEGORY addc = new FORM_ADD_NEW_CATEGORY();
            addc.ShowDialog();
            LoadComboCategory();
        }

        private void PB_BROWSE_IMAGE_Click(object sender, EventArgs e)//בחירת תמונה
        {
            OpenFileDialog ImagefileDialog = new OpenFileDialog
            {
                Filter = "Image |*.JPG; *.PNG; *.GIF"
            };

            if (ImagefileDialog.ShowDialog() == DialogResult.OK)
                PB_BROWSE_IMAGE.Image = Image.FromFile(ImagefileDialog.FileName);
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)//עידכון מוצר
        {
            Product product = new Product();
            MemoryStream ms = new MemoryStream();

            PB_BROWSE_IMAGE.Image.Save(ms, PB_BROWSE_IMAGE.Image.RawFormat);
            byte[] image = ms.ToArray();

            if (TB_PRICE.Text == string.Empty && TB_QUANTITY.Text == string.Empty)
                MessageBox.Show("מחיר וכמות לא יכולים להיות ריקים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                product.UpdateProduct(Convert.ToInt32(LBL_PID.Text), Convert.ToInt32(COMBO_CATEGORIES.SelectedValue), TB_NAME.Text,
                                TB_PRICE.Text, image, Convert.ToInt32(TB_QUANTITY.Text), TB_DESCRIPTION.Text);
                MessageBox.Show("המוצר עודכן בהצלחה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CB_GUARANTEE_CheckedChanged(object sender, EventArgs e)//תיבת סימון 
        {
            if (CB_GUARANTEE.Checked == true)
            {
                TB_GUARANTEE.ReadOnly = false;
                TB_GUARANTEE.Text = "0";
            }
            else
                TB_GUARANTEE.ReadOnly = true;
        }
    }
}
