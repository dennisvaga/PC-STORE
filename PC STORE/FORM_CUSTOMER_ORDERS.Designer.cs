namespace PC_STORE
{
    partial class FORM_CUSTOMER_ORDERS
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
            this.label1 = new System.Windows.Forms.Label();
            this.LSB_CUSTOMER_ORDER_PRODUCTS = new System.Windows.Forms.ListBox();
            this.DGV_CUSTOMER_ORDERS = new System.Windows.Forms.DataGridView();
            this.LBL_CUSTOMER = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER_ORDERS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(336, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Products";
            // 
            // LSB_CUSTOMER_ORDER_PRODUCTS
            // 
            this.LSB_CUSTOMER_ORDER_PRODUCTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSB_CUSTOMER_ORDER_PRODUCTS.FormattingEnabled = true;
            this.LSB_CUSTOMER_ORDER_PRODUCTS.ItemHeight = 20;
            this.LSB_CUSTOMER_ORDER_PRODUCTS.Location = new System.Drawing.Point(336, 136);
            this.LSB_CUSTOMER_ORDER_PRODUCTS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LSB_CUSTOMER_ORDER_PRODUCTS.Name = "LSB_CUSTOMER_ORDER_PRODUCTS";
            this.LSB_CUSTOMER_ORDER_PRODUCTS.Size = new System.Drawing.Size(253, 344);
            this.LSB_CUSTOMER_ORDER_PRODUCTS.TabIndex = 7;
            // 
            // DGV_CUSTOMER_ORDERS
            // 
            this.DGV_CUSTOMER_ORDERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMER_ORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CUSTOMER_ORDERS.Location = new System.Drawing.Point(36, 136);
            this.DGV_CUSTOMER_ORDERS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_CUSTOMER_ORDERS.Name = "DGV_CUSTOMER_ORDERS";
            this.DGV_CUSTOMER_ORDERS.RowHeadersWidth = 51;
            this.DGV_CUSTOMER_ORDERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CUSTOMER_ORDERS.Size = new System.Drawing.Size(264, 344);
            this.DGV_CUSTOMER_ORDERS.TabIndex = 6;
            // 
            // LBL_CUSTOMER
            // 
            this.LBL_CUSTOMER.AutoSize = true;
            this.LBL_CUSTOMER.BackColor = System.Drawing.Color.Transparent;
            this.LBL_CUSTOMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CUSTOMER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.LBL_CUSTOMER.Location = new System.Drawing.Point(31, 102);
            this.LBL_CUSTOMER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_CUSTOMER.Name = "LBL_CUSTOMER";
            this.LBL_CUSTOMER.Size = new System.Drawing.Size(0, 25);
            this.LBL_CUSTOMER.TabIndex = 11;
            // 
            // FORM_CUSTOMER_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 548);
            this.Controls.Add(this.LBL_CUSTOMER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LSB_CUSTOMER_ORDER_PRODUCTS);
            this.Controls.Add(this.DGV_CUSTOMER_ORDERS);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FORM_CUSTOMER_ORDERS";
            this.Text = "FORM_CUSTOMER_ORDERS";
            this.Load += new System.EventHandler(this.FORM_CUSTOMER_ORDERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER_ORDERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox LSB_CUSTOMER_ORDER_PRODUCTS;
        public System.Windows.Forms.DataGridView DGV_CUSTOMER_ORDERS;
        public System.Windows.Forms.Label LBL_CUSTOMER;
    }
}