namespace PC_STORE
{
    partial class FORM_MANAGE_ORDER
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CB_SELECT_ALL = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_SUM = new System.Windows.Forms.TextBox();
            this.DGV_PRODUCTS_IN_ORDER = new System.Windows.Forms.DataGridView();
            this.DGV_PRODUCTS = new System.Windows.Forms.DataGridView();
            this.COMBO_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.TB_CUSTOMER_ID = new System.Windows.Forms.TextBox();
            this.TB_ORDER_ID = new System.Windows.Forms.TextBox();
            this.DGV_CUSTOMER = new System.Windows.Forms.DataGridView();
            this.BTN_NEW_CUSTOMER = new System.Windows.Forms.Button();
            this.BTN_INSERT_ORDER = new System.Windows.Forms.Button();
            this.BTN_DELETE_PRODUCTS = new System.Windows.Forms.Button();
            this.BTN_ALL_ORDERS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_ORDER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(613, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Order Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(613, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Order Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Customer Id :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(754, 170);
            this.dateTimePicker1.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // CB_SELECT_ALL
            // 
            this.CB_SELECT_ALL.AutoSize = true;
            this.CB_SELECT_ALL.BackColor = System.Drawing.Color.Transparent;
            this.CB_SELECT_ALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_SELECT_ALL.Location = new System.Drawing.Point(1314, 359);
            this.CB_SELECT_ALL.Name = "CB_SELECT_ALL";
            this.CB_SELECT_ALL.Size = new System.Drawing.Size(112, 24);
            this.CB_SELECT_ALL.TabIndex = 32;
            this.CB_SELECT_ALL.Text = "Select All";
            this.CB_SELECT_ALL.UseVisualStyleBackColor = false;
            this.CB_SELECT_ALL.CheckedChanged += new System.EventHandler(this.CB_SELECT_ALL_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1144, 698);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Total Amount :";
            // 
            // TB_SUM
            // 
            this.TB_SUM.Location = new System.Drawing.Point(1291, 698);
            this.TB_SUM.Name = "TB_SUM";
            this.TB_SUM.Size = new System.Drawing.Size(165, 22);
            this.TB_SUM.TabIndex = 29;
            // 
            // DGV_PRODUCTS_IN_ORDER
            // 
            this.DGV_PRODUCTS_IN_ORDER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS_IN_ORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS_IN_ORDER.Location = new System.Drawing.Point(685, 389);
            this.DGV_PRODUCTS_IN_ORDER.Name = "DGV_PRODUCTS_IN_ORDER";
            this.DGV_PRODUCTS_IN_ORDER.RowHeadersWidth = 51;
            this.DGV_PRODUCTS_IN_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTS_IN_ORDER.Size = new System.Drawing.Size(771, 300);
            this.DGV_PRODUCTS_IN_ORDER.TabIndex = 28;
            // 
            // DGV_PRODUCTS
            // 
            this.DGV_PRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS.Location = new System.Drawing.Point(35, 383);
            this.DGV_PRODUCTS.Name = "DGV_PRODUCTS";
            this.DGV_PRODUCTS.RowHeadersWidth = 51;
            this.DGV_PRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTS.Size = new System.Drawing.Size(558, 300);
            this.DGV_PRODUCTS.TabIndex = 27;
            this.DGV_PRODUCTS.DoubleClick += new System.EventHandler(this.DGV_PRODUCTS_DoubleClick);
            // 
            // COMBO_CATEGORIES
            // 
            this.COMBO_CATEGORIES.BackColor = System.Drawing.Color.White;
            this.COMBO_CATEGORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_CATEGORIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_CATEGORIES.ForeColor = System.Drawing.Color.Black;
            this.COMBO_CATEGORIES.FormattingEnabled = true;
            this.COMBO_CATEGORIES.Location = new System.Drawing.Point(389, 695);
            this.COMBO_CATEGORIES.Name = "COMBO_CATEGORIES";
            this.COMBO_CATEGORIES.Size = new System.Drawing.Size(204, 25);
            this.COMBO_CATEGORIES.TabIndex = 26;
            this.COMBO_CATEGORIES.SelectedIndexChanged += new System.EventHandler(this.COMBO_CATEGORIES_SelectedIndexChanged);
            // 
            // TB_CUSTOMER_ID
            // 
            this.TB_CUSTOMER_ID.Location = new System.Drawing.Point(754, 82);
            this.TB_CUSTOMER_ID.Name = "TB_CUSTOMER_ID";
            this.TB_CUSTOMER_ID.ReadOnly = true;
            this.TB_CUSTOMER_ID.Size = new System.Drawing.Size(200, 22);
            this.TB_CUSTOMER_ID.TabIndex = 25;
            // 
            // TB_ORDER_ID
            // 
            this.TB_ORDER_ID.Location = new System.Drawing.Point(754, 127);
            this.TB_ORDER_ID.Name = "TB_ORDER_ID";
            this.TB_ORDER_ID.ReadOnly = true;
            this.TB_ORDER_ID.Size = new System.Drawing.Size(200, 22);
            this.TB_ORDER_ID.TabIndex = 24;
            // 
            // DGV_CUSTOMER
            // 
            this.DGV_CUSTOMER.AllowUserToAddRows = false;
            this.DGV_CUSTOMER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CUSTOMER.Location = new System.Drawing.Point(35, 82);
            this.DGV_CUSTOMER.Name = "DGV_CUSTOMER";
            this.DGV_CUSTOMER.RowHeadersWidth = 51;
            this.DGV_CUSTOMER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CUSTOMER.Size = new System.Drawing.Size(558, 198);
            this.DGV_CUSTOMER.TabIndex = 23;
            this.DGV_CUSTOMER.Click += new System.EventHandler(this.DGV_CUSTOMER_Click);
            this.DGV_CUSTOMER.DoubleClick += new System.EventHandler(this.DGV_CUSTOMER_DoubleClick);
            // 
            // BTN_NEW_CUSTOMER
            // 
            this.BTN_NEW_CUSTOMER.Location = new System.Drawing.Point(413, 286);
            this.BTN_NEW_CUSTOMER.Name = "BTN_NEW_CUSTOMER";
            this.BTN_NEW_CUSTOMER.Size = new System.Drawing.Size(180, 45);
            this.BTN_NEW_CUSTOMER.TabIndex = 42;
            this.BTN_NEW_CUSTOMER.Text = "Add new customer";
            this.BTN_NEW_CUSTOMER.UseVisualStyleBackColor = true;
            this.BTN_NEW_CUSTOMER.Click += new System.EventHandler(this.BTN_NEW_CUSTOMER_Click);
            // 
            // BTN_INSERT_ORDER
            // 
            this.BTN_INSERT_ORDER.Location = new System.Drawing.Point(695, 695);
            this.BTN_INSERT_ORDER.Name = "BTN_INSERT_ORDER";
            this.BTN_INSERT_ORDER.Size = new System.Drawing.Size(166, 38);
            this.BTN_INSERT_ORDER.TabIndex = 43;
            this.BTN_INSERT_ORDER.Text = "Insert order";
            this.BTN_INSERT_ORDER.UseVisualStyleBackColor = true;
            this.BTN_INSERT_ORDER.Click += new System.EventHandler(this.BTN_INSERT_ORDER_Click);
            // 
            // BTN_DELETE_PRODUCTS
            // 
            this.BTN_DELETE_PRODUCTS.Location = new System.Drawing.Point(867, 695);
            this.BTN_DELETE_PRODUCTS.Name = "BTN_DELETE_PRODUCTS";
            this.BTN_DELETE_PRODUCTS.Size = new System.Drawing.Size(146, 38);
            this.BTN_DELETE_PRODUCTS.TabIndex = 45;
            this.BTN_DELETE_PRODUCTS.Text = "Delete product";
            this.BTN_DELETE_PRODUCTS.UseVisualStyleBackColor = true;
            this.BTN_DELETE_PRODUCTS.Click += new System.EventHandler(this.BTN_DELETE_PRODUCTS_Click);
            // 
            // BTN_ALL_ORDERS
            // 
            this.BTN_ALL_ORDERS.Location = new System.Drawing.Point(35, 792);
            this.BTN_ALL_ORDERS.Name = "BTN_ALL_ORDERS";
            this.BTN_ALL_ORDERS.Size = new System.Drawing.Size(245, 87);
            this.BTN_ALL_ORDERS.TabIndex = 44;
            this.BTN_ALL_ORDERS.Text = "Show all orders";
            this.BTN_ALL_ORDERS.UseVisualStyleBackColor = true;
            this.BTN_ALL_ORDERS.Click += new System.EventHandler(this.BTN_ALL_ORDERS_Click);
            // 
            // FORM_MANAGE_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 1044);
            this.Controls.Add(this.BTN_DELETE_PRODUCTS);
            this.Controls.Add(this.BTN_ALL_ORDERS);
            this.Controls.Add(this.BTN_INSERT_ORDER);
            this.Controls.Add(this.BTN_NEW_CUSTOMER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CB_SELECT_ALL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_SUM);
            this.Controls.Add(this.DGV_PRODUCTS_IN_ORDER);
            this.Controls.Add(this.DGV_PRODUCTS);
            this.Controls.Add(this.COMBO_CATEGORIES);
            this.Controls.Add(this.TB_CUSTOMER_ID);
            this.Controls.Add(this.TB_ORDER_ID);
            this.Controls.Add(this.DGV_CUSTOMER);
            this.Name = "FORM_MANAGE_ORDER";
            this.Text = "FORM_MANAGE_ORDER";
            this.Load += new System.EventHandler(this.FORM_MANAGE_ORDER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_ORDER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox CB_SELECT_ALL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_SUM;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS_IN_ORDER;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS;
        private System.Windows.Forms.ComboBox COMBO_CATEGORIES;
        private System.Windows.Forms.TextBox TB_CUSTOMER_ID;
        private System.Windows.Forms.TextBox TB_ORDER_ID;
        public System.Windows.Forms.DataGridView DGV_CUSTOMER;
        private System.Windows.Forms.Button BTN_NEW_CUSTOMER;
        private System.Windows.Forms.Button BTN_INSERT_ORDER;
        private System.Windows.Forms.Button BTN_DELETE_PRODUCTS;
        private System.Windows.Forms.Button BTN_ALL_ORDERS;
    }
}