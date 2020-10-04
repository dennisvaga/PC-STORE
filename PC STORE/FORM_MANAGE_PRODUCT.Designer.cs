namespace PC_STORE
{
    partial class FORM_MANAGE_PRODUCT
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_SEARCH = new System.Windows.Forms.TextBox();
            this.DGV_PRODUCTS = new System.Windows.Forms.DataGridView();
            this.BTN_NEW_PRODUCT = new System.Windows.Forms.Button();
            this.BTN_DELETE_PRODUCT = new System.Windows.Forms.Button();
            this.BTN_UPDATE_PRODUCT = new System.Windows.Forms.Button();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_SEARCH
            // 
            this.TB_SEARCH.Location = new System.Drawing.Point(472, 61);
            this.TB_SEARCH.Name = "TB_SEARCH";
            this.TB_SEARCH.Size = new System.Drawing.Size(222, 22);
            this.TB_SEARCH.TabIndex = 11;
            // 
            // DGV_PRODUCTS
            // 
            this.DGV_PRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DGV_PRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS.Location = new System.Drawing.Point(153, 94);
            this.DGV_PRODUCTS.Name = "DGV_PRODUCTS";
            this.DGV_PRODUCTS.RowHeadersWidth = 51;
            this.DGV_PRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTS.Size = new System.Drawing.Size(652, 405);
            this.DGV_PRODUCTS.TabIndex = 7;
            // 
            // BTN_NEW_PRODUCT
            // 
            this.BTN_NEW_PRODUCT.Location = new System.Drawing.Point(29, 72);
            this.BTN_NEW_PRODUCT.Name = "BTN_NEW_PRODUCT";
            this.BTN_NEW_PRODUCT.Size = new System.Drawing.Size(90, 41);
            this.BTN_NEW_PRODUCT.TabIndex = 13;
            this.BTN_NEW_PRODUCT.Text = "New";
            this.BTN_NEW_PRODUCT.UseVisualStyleBackColor = true;
            this.BTN_NEW_PRODUCT.Click += new System.EventHandler(this.BTN_NEW_PRODUCT_Click);
            // 
            // BTN_DELETE_PRODUCT
            // 
            this.BTN_DELETE_PRODUCT.Location = new System.Drawing.Point(29, 129);
            this.BTN_DELETE_PRODUCT.Name = "BTN_DELETE_PRODUCT";
            this.BTN_DELETE_PRODUCT.Size = new System.Drawing.Size(90, 43);
            this.BTN_DELETE_PRODUCT.TabIndex = 14;
            this.BTN_DELETE_PRODUCT.Text = "Remove";
            this.BTN_DELETE_PRODUCT.UseVisualStyleBackColor = true;
            this.BTN_DELETE_PRODUCT.Click += new System.EventHandler(this.BTN_DELETE_PRODUCT_Click);
            // 
            // BTN_UPDATE_PRODUCT
            // 
            this.BTN_UPDATE_PRODUCT.Location = new System.Drawing.Point(29, 202);
            this.BTN_UPDATE_PRODUCT.Name = "BTN_UPDATE_PRODUCT";
            this.BTN_UPDATE_PRODUCT.Size = new System.Drawing.Size(90, 40);
            this.BTN_UPDATE_PRODUCT.TabIndex = 15;
            this.BTN_UPDATE_PRODUCT.Text = "Update";
            this.BTN_UPDATE_PRODUCT.UseVisualStyleBackColor = true;
            this.BTN_UPDATE_PRODUCT.Click += new System.EventHandler(this.BTN_UPDATE_PRODUCT_Click);
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.Location = new System.Drawing.Point(761, 38);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(84, 50);
            this.BTN_SEARCH.TabIndex = 16;
            this.BTN_SEARCH.Text = "Search";
            this.BTN_SEARCH.UseVisualStyleBackColor = true;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // FORM_MANAGE_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 568);
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.BTN_UPDATE_PRODUCT);
            this.Controls.Add(this.BTN_DELETE_PRODUCT);
            this.Controls.Add(this.BTN_NEW_PRODUCT);
            this.Controls.Add(this.TB_SEARCH);
            this.Controls.Add(this.DGV_PRODUCTS);
            this.Name = "FORM_MANAGE_PRODUCT";
            this.Text = "FORM_MANAGE_PRODUCT";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_SEARCH;
        public System.Windows.Forms.DataGridView DGV_PRODUCTS;
        private System.Windows.Forms.Button BTN_NEW_PRODUCT;
        private System.Windows.Forms.Button BTN_DELETE_PRODUCT;
        private System.Windows.Forms.Button BTN_UPDATE_PRODUCT;
        private System.Windows.Forms.Button BTN_SEARCH;
    }
}