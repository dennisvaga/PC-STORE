namespace PC_STORE
{
    partial class UC_MANAGE_PRODUCT
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_UPDATE_PRODUCT = new System.Windows.Forms.Button();
            this.BTN_DELETE_PRODUCT = new System.Windows.Forms.Button();
            this.BTN_NEW_PRODUCT = new System.Windows.Forms.Button();
            this.TB_SEARCH = new System.Windows.Forms.TextBox();
            this.COMBO_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.DGV_PRODUCTS = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_UPDATE_PRODUCT
            // 
            this.BTN_UPDATE_PRODUCT.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_UPDATE_PRODUCT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UPDATE_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.BTN_UPDATE_PRODUCT.Location = new System.Drawing.Point(1096, 489);
            this.BTN_UPDATE_PRODUCT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_UPDATE_PRODUCT.Name = "BTN_UPDATE_PRODUCT";
            this.BTN_UPDATE_PRODUCT.Size = new System.Drawing.Size(142, 40);
            this.BTN_UPDATE_PRODUCT.TabIndex = 32;
            this.BTN_UPDATE_PRODUCT.Text = "עדכן";
            this.BTN_UPDATE_PRODUCT.UseVisualStyleBackColor = false;
            this.BTN_UPDATE_PRODUCT.Click += new System.EventHandler(this.BTN_UPDATE_PRODUCT_Click);
            // 
            // BTN_DELETE_PRODUCT
            // 
            this.BTN_DELETE_PRODUCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DELETE_PRODUCT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE_PRODUCT.Location = new System.Drawing.Point(576, 491);
            this.BTN_DELETE_PRODUCT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DELETE_PRODUCT.Name = "BTN_DELETE_PRODUCT";
            this.BTN_DELETE_PRODUCT.Size = new System.Drawing.Size(142, 38);
            this.BTN_DELETE_PRODUCT.TabIndex = 31;
            this.BTN_DELETE_PRODUCT.Text = "מחק";
            this.BTN_DELETE_PRODUCT.UseVisualStyleBackColor = false;
            this.BTN_DELETE_PRODUCT.Click += new System.EventHandler(this.BTN_DELETE_PRODUCT_Click);
            // 
            // BTN_NEW_PRODUCT
            // 
            this.BTN_NEW_PRODUCT.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_NEW_PRODUCT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEW_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW_PRODUCT.Location = new System.Drawing.Point(1242, 489);
            this.BTN_NEW_PRODUCT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_NEW_PRODUCT.Name = "BTN_NEW_PRODUCT";
            this.BTN_NEW_PRODUCT.Size = new System.Drawing.Size(142, 40);
            this.BTN_NEW_PRODUCT.TabIndex = 30;
            this.BTN_NEW_PRODUCT.Text = "מוצר חדש";
            this.BTN_NEW_PRODUCT.UseVisualStyleBackColor = false;
            this.BTN_NEW_PRODUCT.Click += new System.EventHandler(this.BTN_NEW_PRODUCT_Click);
            // 
            // TB_SEARCH
            // 
            this.TB_SEARCH.BackColor = System.Drawing.SystemColors.Window;
            this.TB_SEARCH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SEARCH.ForeColor = System.Drawing.Color.Black;
            this.TB_SEARCH.Location = new System.Drawing.Point(668, 107);
            this.TB_SEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SEARCH.Name = "TB_SEARCH";
            this.TB_SEARCH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_SEARCH.Size = new System.Drawing.Size(215, 26);
            this.TB_SEARCH.TabIndex = 29;
            this.TB_SEARCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // COMBO_CATEGORIES
            // 
            this.COMBO_CATEGORIES.BackColor = System.Drawing.SystemColors.Window;
            this.COMBO_CATEGORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_CATEGORIES.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_CATEGORIES.ForeColor = System.Drawing.Color.Black;
            this.COMBO_CATEGORIES.FormattingEnabled = true;
            this.COMBO_CATEGORIES.Location = new System.Drawing.Point(1150, 111);
            this.COMBO_CATEGORIES.Margin = new System.Windows.Forms.Padding(2);
            this.COMBO_CATEGORIES.Name = "COMBO_CATEGORIES";
            this.COMBO_CATEGORIES.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.COMBO_CATEGORIES.Size = new System.Drawing.Size(234, 26);
            this.COMBO_CATEGORIES.TabIndex = 37;
            this.COMBO_CATEGORIES.SelectedIndexChanged += new System.EventHandler(this.COMBO_CATEGORIES_SelectedIndexChanged);
            // 
            // DGV_PRODUCTS
            // 
            this.DGV_PRODUCTS.AllowUserToAddRows = false;
            this.DGV_PRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_PRODUCTS.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_PRODUCTS.Location = new System.Drawing.Point(576, 142);
            this.DGV_PRODUCTS.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_PRODUCTS.Name = "DGV_PRODUCTS";
            this.DGV_PRODUCTS.ReadOnly = true;
            this.DGV_PRODUCTS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_PRODUCTS.RowHeadersWidth = 51;
            this.DGV_PRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTS.Size = new System.Drawing.Size(808, 343);
            this.DGV_PRODUCTS.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label8.Location = new System.Drawing.Point(1350, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 44);
            this.label8.TabIndex = 97;
            this.label8.Text = "מוצרים";
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_SEARCH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH.Image = global::PC_STORE.Properties.Resources.search_30px;
            this.BTN_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH.Location = new System.Drawing.Point(576, 100);
            this.BTN_SEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(88, 37);
            this.BTN_SEARCH.TabIndex = 98;
            this.BTN_SEARCH.Text = "חיפוש";
            this.BTN_SEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // UC_MANAGE_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DGV_PRODUCTS);
            this.Controls.Add(this.COMBO_CATEGORIES);
            this.Controls.Add(this.BTN_UPDATE_PRODUCT);
            this.Controls.Add(this.BTN_DELETE_PRODUCT);
            this.Controls.Add(this.BTN_NEW_PRODUCT);
            this.Controls.Add(this.TB_SEARCH);
            this.Name = "UC_MANAGE_PRODUCT";
            this.Size = new System.Drawing.Size(1469, 890);
            this.Load += new System.EventHandler(this.UC_MANAGE_PRODUCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_UPDATE_PRODUCT;
        private System.Windows.Forms.Button BTN_DELETE_PRODUCT;
        private System.Windows.Forms.Button BTN_NEW_PRODUCT;
        private System.Windows.Forms.TextBox TB_SEARCH;
        private System.Windows.Forms.ComboBox COMBO_CATEGORIES;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_SEARCH;
    }
}
