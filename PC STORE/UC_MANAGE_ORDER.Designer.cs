namespace PC_STORE
{
    partial class UC_MANAGE_ORDER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_DELETE_PRODUCTS = new System.Windows.Forms.Button();
            this.BTN_INSERT_ORDER = new System.Windows.Forms.Button();
            this.BTN_NEW_CUSTOMER = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_SUM = new System.Windows.Forms.TextBox();
            this.DGV_PRODUCTS_IN_ORDER = new System.Windows.Forms.DataGridView();
            this.DGV_PRODUCTS = new System.Windows.Forms.DataGridView();
            this.COMBO_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.TB_CUSTOMER_ID = new System.Windows.Forms.TextBox();
            this.DGV_CUSTOMER = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_SEARCH_CUST = new System.Windows.Forms.TextBox();
            this.TB_SEARCH_PRODUCT = new System.Windows.Forms.TextBox();
            this.BTN_SEARCH_PRODUCT = new System.Windows.Forms.Button();
            this.BTN_SEARCH_CUST = new System.Windows.Forms.Button();
            this.BTN_PRINT_ORDER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_ORDER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label7.Location = new System.Drawing.Point(682, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 28);
            this.label7.TabIndex = 67;
            this.label7.Text = ":מוצרים בעגלה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label6.Location = new System.Drawing.Point(1249, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 28);
            this.label6.TabIndex = 66;
            this.label6.Text = ":מוצרים במלאי";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(1314, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 65;
            this.label5.Text = ":לקוחות";
            // 
            // BTN_DELETE_PRODUCTS
            // 
            this.BTN_DELETE_PRODUCTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DELETE_PRODUCTS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_PRODUCTS.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE_PRODUCTS.Location = new System.Drawing.Point(488, 700);
            this.BTN_DELETE_PRODUCTS.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DELETE_PRODUCTS.Name = "BTN_DELETE_PRODUCTS";
            this.BTN_DELETE_PRODUCTS.Size = new System.Drawing.Size(116, 37);
            this.BTN_DELETE_PRODUCTS.TabIndex = 64;
            this.BTN_DELETE_PRODUCTS.Text = "מחק";
            this.BTN_DELETE_PRODUCTS.UseVisualStyleBackColor = false;
            this.BTN_DELETE_PRODUCTS.Click += new System.EventHandler(this.BTN_DELETE_PRODUCTS_Click);
            // 
            // BTN_INSERT_ORDER
            // 
            this.BTN_INSERT_ORDER.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_INSERT_ORDER.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INSERT_ORDER.ForeColor = System.Drawing.Color.White;
            this.BTN_INSERT_ORDER.Location = new System.Drawing.Point(700, 700);
            this.BTN_INSERT_ORDER.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_INSERT_ORDER.Name = "BTN_INSERT_ORDER";
            this.BTN_INSERT_ORDER.Size = new System.Drawing.Size(133, 40);
            this.BTN_INSERT_ORDER.TabIndex = 63;
            this.BTN_INSERT_ORDER.Text = "הוסף הזמנה";
            this.BTN_INSERT_ORDER.UseVisualStyleBackColor = false;
            this.BTN_INSERT_ORDER.Click += new System.EventHandler(this.BTN_INSERT_ORDER_Click);
            // 
            // BTN_NEW_CUSTOMER
            // 
            this.BTN_NEW_CUSTOMER.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_NEW_CUSTOMER.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEW_CUSTOMER.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW_CUSTOMER.Location = new System.Drawing.Point(1283, 289);
            this.BTN_NEW_CUSTOMER.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_NEW_CUSTOMER.Name = "BTN_NEW_CUSTOMER";
            this.BTN_NEW_CUSTOMER.Size = new System.Drawing.Size(117, 37);
            this.BTN_NEW_CUSTOMER.TabIndex = 62;
            this.BTN_NEW_CUSTOMER.Text = "הוסף לקוח ";
            this.BTN_NEW_CUSTOMER.UseVisualStyleBackColor = false;
            this.BTN_NEW_CUSTOMER.Click += new System.EventHandler(this.BTN_NEW_CUSTOMER_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(748, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 61;
            this.label4.Text = ":תאריך הזמנה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(760, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = ":תעודת זהות";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(643, 185);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(384, 713);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 57;
            this.label1.Text = ":סה\"כ מחיר";
            // 
            // TB_SUM
            // 
            this.TB_SUM.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SUM.Location = new System.Drawing.Point(255, 706);
            this.TB_SUM.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SUM.Name = "TB_SUM";
            this.TB_SUM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_SUM.Size = new System.Drawing.Size(125, 29);
            this.TB_SUM.TabIndex = 56;
            // 
            // DGV_PRODUCTS_IN_ORDER
            // 
            this.DGV_PRODUCTS_IN_ORDER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS_IN_ORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_PRODUCTS_IN_ORDER.DefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_PRODUCTS_IN_ORDER.Location = new System.Drawing.Point(255, 407);
            this.DGV_PRODUCTS_IN_ORDER.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_PRODUCTS_IN_ORDER.Name = "DGV_PRODUCTS_IN_ORDER";
            this.DGV_PRODUCTS_IN_ORDER.ReadOnly = true;
            this.DGV_PRODUCTS_IN_ORDER.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_PRODUCTS_IN_ORDER.RowHeadersWidth = 51;
            this.DGV_PRODUCTS_IN_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTS_IN_ORDER.Size = new System.Drawing.Size(578, 289);
            this.DGV_PRODUCTS_IN_ORDER.TabIndex = 55;
            // 
            // DGV_PRODUCTS
            // 
            this.DGV_PRODUCTS.AllowUserToAddRows = false;
            this.DGV_PRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_PRODUCTS.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGV_PRODUCTS.Location = new System.Drawing.Point(887, 407);
            this.DGV_PRODUCTS.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_PRODUCTS.Name = "DGV_PRODUCTS";
            this.DGV_PRODUCTS.ReadOnly = true;
            this.DGV_PRODUCTS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_PRODUCTS.RowHeadersWidth = 51;
            this.DGV_PRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTS.Size = new System.Drawing.Size(509, 288);
            this.DGV_PRODUCTS.TabIndex = 54;
            this.DGV_PRODUCTS.DoubleClick += new System.EventHandler(this.DGV_PRODUCTS_DoubleClick);
            // 
            // COMBO_CATEGORIES
            // 
            this.COMBO_CATEGORIES.BackColor = System.Drawing.Color.White;
            this.COMBO_CATEGORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_CATEGORIES.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_CATEGORIES.ForeColor = System.Drawing.Color.Black;
            this.COMBO_CATEGORIES.FormattingEnabled = true;
            this.COMBO_CATEGORIES.Location = new System.Drawing.Point(1201, 699);
            this.COMBO_CATEGORIES.Margin = new System.Windows.Forms.Padding(2);
            this.COMBO_CATEGORIES.Name = "COMBO_CATEGORIES";
            this.COMBO_CATEGORIES.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.COMBO_CATEGORIES.Size = new System.Drawing.Size(197, 26);
            this.COMBO_CATEGORIES.TabIndex = 53;
            this.COMBO_CATEGORIES.SelectedIndexChanged += new System.EventHandler(this.COMBO_CATEGORIES_SelectedIndexChanged);
            // 
            // TB_CUSTOMER_ID
            // 
            this.TB_CUSTOMER_ID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CUSTOMER_ID.Location = new System.Drawing.Point(643, 117);
            this.TB_CUSTOMER_ID.Margin = new System.Windows.Forms.Padding(2);
            this.TB_CUSTOMER_ID.Name = "TB_CUSTOMER_ID";
            this.TB_CUSTOMER_ID.ReadOnly = true;
            this.TB_CUSTOMER_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_CUSTOMER_ID.Size = new System.Drawing.Size(219, 26);
            this.TB_CUSTOMER_ID.TabIndex = 52;
            // 
            // DGV_CUSTOMER
            // 
            this.DGV_CUSTOMER.AllowUserToAddRows = false;
            this.DGV_CUSTOMER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CUSTOMER.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGV_CUSTOMER.Location = new System.Drawing.Point(889, 112);
            this.DGV_CUSTOMER.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_CUSTOMER.Name = "DGV_CUSTOMER";
            this.DGV_CUSTOMER.ReadOnly = true;
            this.DGV_CUSTOMER.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_CUSTOMER.RowHeadersWidth = 51;
            this.DGV_CUSTOMER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CUSTOMER.Size = new System.Drawing.Size(509, 173);
            this.DGV_CUSTOMER.TabIndex = 50;
            this.DGV_CUSTOMER.Click += new System.EventHandler(this.DGV_CUSTOMER_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label8.Location = new System.Drawing.Point(1253, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 44);
            this.label8.TabIndex = 97;
            this.label8.Text = "הזמנה חדשה";
            // 
            // TB_SEARCH_CUST
            // 
            this.TB_SEARCH_CUST.BackColor = System.Drawing.SystemColors.Window;
            this.TB_SEARCH_CUST.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SEARCH_CUST.ForeColor = System.Drawing.Color.Black;
            this.TB_SEARCH_CUST.Location = new System.Drawing.Point(970, 84);
            this.TB_SEARCH_CUST.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SEARCH_CUST.Name = "TB_SEARCH_CUST";
            this.TB_SEARCH_CUST.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_SEARCH_CUST.Size = new System.Drawing.Size(204, 26);
            this.TB_SEARCH_CUST.TabIndex = 98;
            this.TB_SEARCH_CUST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_SEARCH_PRODUCT
            // 
            this.TB_SEARCH_PRODUCT.BackColor = System.Drawing.SystemColors.Window;
            this.TB_SEARCH_PRODUCT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SEARCH_PRODUCT.ForeColor = System.Drawing.Color.Black;
            this.TB_SEARCH_PRODUCT.Location = new System.Drawing.Point(970, 377);
            this.TB_SEARCH_PRODUCT.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SEARCH_PRODUCT.Name = "TB_SEARCH_PRODUCT";
            this.TB_SEARCH_PRODUCT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_SEARCH_PRODUCT.Size = new System.Drawing.Size(202, 26);
            this.TB_SEARCH_PRODUCT.TabIndex = 100;
            this.TB_SEARCH_PRODUCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTN_SEARCH_PRODUCT
            // 
            this.BTN_SEARCH_PRODUCT.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_SEARCH_PRODUCT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH_PRODUCT.Image = global::PC_STORE.Properties.Resources.search_30px1;
            this.BTN_SEARCH_PRODUCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH_PRODUCT.Location = new System.Drawing.Point(887, 369);
            this.BTN_SEARCH_PRODUCT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SEARCH_PRODUCT.Name = "BTN_SEARCH_PRODUCT";
            this.BTN_SEARCH_PRODUCT.Size = new System.Drawing.Size(79, 34);
            this.BTN_SEARCH_PRODUCT.TabIndex = 101;
            this.BTN_SEARCH_PRODUCT.Text = "חפש";
            this.BTN_SEARCH_PRODUCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SEARCH_PRODUCT.UseVisualStyleBackColor = false;
            this.BTN_SEARCH_PRODUCT.Click += new System.EventHandler(this.BTN_SEARCH_PRODUCT_Click);
            // 
            // BTN_SEARCH_CUST
            // 
            this.BTN_SEARCH_CUST.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_SEARCH_CUST.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH_CUST.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH_CUST.Image = global::PC_STORE.Properties.Resources.search_30px1;
            this.BTN_SEARCH_CUST.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH_CUST.Location = new System.Drawing.Point(887, 74);
            this.BTN_SEARCH_CUST.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SEARCH_CUST.Name = "BTN_SEARCH_CUST";
            this.BTN_SEARCH_CUST.Size = new System.Drawing.Size(79, 34);
            this.BTN_SEARCH_CUST.TabIndex = 99;
            this.BTN_SEARCH_CUST.Text = "חפש";
            this.BTN_SEARCH_CUST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SEARCH_CUST.UseVisualStyleBackColor = false;
            this.BTN_SEARCH_CUST.Click += new System.EventHandler(this.BTN_SEARCH_CUST_Click);
            // 
            // BTN_PRINT_ORDER
            // 
            this.BTN_PRINT_ORDER.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_PRINT_ORDER.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRINT_ORDER.ForeColor = System.Drawing.Color.White;
            this.BTN_PRINT_ORDER.Image = global::PC_STORE.Properties.Resources.send_to_printer_40px1;
            this.BTN_PRINT_ORDER.Location = new System.Drawing.Point(255, 812);
            this.BTN_PRINT_ORDER.Name = "BTN_PRINT_ORDER";
            this.BTN_PRINT_ORDER.Size = new System.Drawing.Size(183, 72);
            this.BTN_PRINT_ORDER.TabIndex = 68;
            this.BTN_PRINT_ORDER.UseVisualStyleBackColor = false;
            this.BTN_PRINT_ORDER.Click += new System.EventHandler(this.BTN_PRINT_ORDER_Click);
            // 
            // UC_MANAGE_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_SEARCH_PRODUCT);
            this.Controls.Add(this.TB_SEARCH_PRODUCT);
            this.Controls.Add(this.BTN_SEARCH_CUST);
            this.Controls.Add(this.TB_SEARCH_CUST);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTN_PRINT_ORDER);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_DELETE_PRODUCTS);
            this.Controls.Add(this.BTN_INSERT_ORDER);
            this.Controls.Add(this.BTN_NEW_CUSTOMER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_SUM);
            this.Controls.Add(this.DGV_PRODUCTS_IN_ORDER);
            this.Controls.Add(this.DGV_PRODUCTS);
            this.Controls.Add(this.COMBO_CATEGORIES);
            this.Controls.Add(this.TB_CUSTOMER_ID);
            this.Controls.Add(this.DGV_CUSTOMER);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.Name = "UC_MANAGE_ORDER";
            this.Size = new System.Drawing.Size(1456, 890);
            this.Load += new System.EventHandler(this.UC_MANAGE_ORDER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_ORDER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_PRINT_ORDER;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_DELETE_PRODUCTS;
        private System.Windows.Forms.Button BTN_INSERT_ORDER;
        private System.Windows.Forms.Button BTN_NEW_CUSTOMER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_SUM;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS_IN_ORDER;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS;
        private System.Windows.Forms.ComboBox COMBO_CATEGORIES;
        private System.Windows.Forms.TextBox TB_CUSTOMER_ID;
        public System.Windows.Forms.DataGridView DGV_CUSTOMER;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_SEARCH_CUST;
        private System.Windows.Forms.TextBox TB_SEARCH_CUST;
        private System.Windows.Forms.Button BTN_SEARCH_PRODUCT;
        private System.Windows.Forms.TextBox TB_SEARCH_PRODUCT;
    }
}
