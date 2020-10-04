using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_NEW_PRODUCT : Form
    {
        Category catg = new Category();
        Product product = new Product();

        public FORM_NEW_PRODUCT()
        {
            InitializeComponent();
            loadComboCategory();
        }

        public void loadComboCategory()
        {
            COMBO_CATEGORIES.DataSource = catg.GetCategories();
            COMBO_CATEGORIES.DisplayMember = "CAT_NAME";
            COMBO_CATEGORIES.ValueMember = "CAT_ID";
        }


        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            if (TB_NAME.Text == string.Empty)
            {
                MessageBox.Show("Enter Product Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (TB_PRICE.Text == string.Empty && TB_QUANTITY.Text == string.Empty)
            {
                MessageBox.Show("Quantity and Price Can't Be Empty", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PB_BROWSE_IMAGE.Image == null)
            {
                MessageBox.Show("No Image Selected", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MemoryStream ms = new MemoryStream();
                PB_BROWSE_IMAGE.Image.Save(ms, PB_BROWSE_IMAGE.Image.RawFormat);
                byte[] image = ms.ToArray();

                product.InsertProduct(Convert.ToInt32(COMBO_CATEGORIES.SelectedValue), TB_NAME.Text,
                                     TB_PRICE.Text, image, Convert.ToInt32(TB_QUANTITY.Text), TB_DESCRIPTION.Text);
                MessageBox.Show("New Product Inserted Successfully", "New Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)
        {
            FORM_ADD_NEW_CATEGORY addc = new FORM_ADD_NEW_CATEGORY();
            addc.ShowDialog();
            loadComboCategory();
        }

        private void PB_BROWSE_IMAGE_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImagefileDialog = new OpenFileDialog();
            ImagefileDialog.Filter = "Image |*.JPG; *.PNG; *.GIF";
            if (ImagefileDialog.ShowDialog() == DialogResult.OK)
            {
                PB_BROWSE_IMAGE.Image = Image.FromFile(ImagefileDialog.FileName);
            }
        }

        private void COMBO_CATEGORIES_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_NAME.Focus();
        }

        private void TB_NAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TB_DESCRIPTION.Focus();
        }

        private void TB_DESCRIPTION_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TB_QUANTITY.Focus();
        }

        private void TB_QUANTITY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TB_PRICE.Focus();
        }

        private void TB_PRICE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PB_BROWSE_IMAGE_Click(sender,e);
        }

        private void TB_QUANTITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TB_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }   
        }
    }
}
