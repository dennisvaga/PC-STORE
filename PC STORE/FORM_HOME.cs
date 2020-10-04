using System;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_HOME : Form
    {
        public string userType;
        public FORM_HOME()
        {
            InitializeComponent();
 
        }
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_PRODUCT fmp = new FORM_MANAGE_PRODUCT();
            fmp.MdiParent = this;
            fmp.Show();
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CATEGORIES fmcg = new FORM_MANAGE_CATEGORIES();
            fmcg.MdiParent = this;
            fmcg.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_USER fmus = new FORM_MANAGE_USER();
            fmus.MdiParent = this;
            fmus.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CUSTOMER fmcm = new FORM_MANAGE_CUSTOMER();
            fmcm.MdiParent = this;
            fmcm.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_ORDER fmo = new FORM_MANAGE_ORDER();
            fmo.MdiParent = this;
            fmo.Show();
        }

        private void FORM_HOME_Load(object sender, EventArgs e)
        {

        }
    }
}
