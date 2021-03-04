namespace PC_STORE
{
    partial class FORM_HOME_PAGE
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
            this.SINDE_PANEL = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_INCOME = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_ALL_ORDERS = new System.Windows.Forms.Button();
            this.BTN_EMPLOYEE_SHIFTS = new System.Windows.Forms.Button();
            this.BTN_EMPLOYEE_MANAGMENT = new System.Windows.Forms.Button();
            this.BTN_PRODUCTS = new System.Windows.Forms.Button();
            this.BTN_NEW_ORDER = new System.Windows.Forms.Button();
            this.BTN_CUSTOMERS = new System.Windows.Forms.Button();
            this.BTN_CATEGORIES = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_EXIT_SHIFT = new System.Windows.Forms.Button();
            this.uC_ALL_ORDERS1 = new PC_STORE.UC_ALL_ORDERS();
            this.uC_EMPLOYEE_SHIFTS1 = new PC_STORE.UC_EMPLOYEE_SHIFTS();
            this.uC_INCOME1 = new PC_STORE.UC_INCOME();
            this.uC_MANAGE_CATEGORIES1 = new PC_STORE.UC_MANAGE_CATEGORIES();
            this.uC_MANAGE_CUSTOMERS1 = new PC_STORE.UC_MANAGE_CUSTOMERS();
            this.uC_MANAGE_EMPLOYEE1 = new PC_STORE.UC_MANAGE_EMPLOYEE();
            this.uC_MANAGE_ORDER1 = new PC_STORE.UC_MANAGE_ORDER();
            this.uC_MANAGE_PRODUCT1 = new PC_STORE.UC_MANAGE_PRODUCT();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SINDE_PANEL
            // 
            this.SINDE_PANEL.BackColor = System.Drawing.Color.White;
            this.SINDE_PANEL.Location = new System.Drawing.Point(266, 52);
            this.SINDE_PANEL.Name = "SINDE_PANEL";
            this.SINDE_PANEL.Size = new System.Drawing.Size(11, 60);
            this.SINDE_PANEL.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.BTN_INCOME);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BTN_ALL_ORDERS);
            this.panel1.Controls.Add(this.BTN_EMPLOYEE_SHIFTS);
            this.panel1.Controls.Add(this.BTN_EMPLOYEE_MANAGMENT);
            this.panel1.Controls.Add(this.BTN_PRODUCTS);
            this.panel1.Controls.Add(this.SINDE_PANEL);
            this.panel1.Controls.Add(this.BTN_NEW_ORDER);
            this.panel1.Controls.Add(this.BTN_CUSTOMERS);
            this.panel1.Controls.Add(this.BTN_CATEGORIES);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1261, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 845);
            this.panel1.TabIndex = 0;
            // 
            // BTN_INCOME
            // 
            this.BTN_INCOME.FlatAppearance.BorderSize = 0;
            this.BTN_INCOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_INCOME.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INCOME.Image = global::PC_STORE.Properties.Resources.money_40px;
            this.BTN_INCOME.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_INCOME.Location = new System.Drawing.Point(125, 575);
            this.BTN_INCOME.Name = "BTN_INCOME";
            this.BTN_INCOME.Size = new System.Drawing.Size(142, 60);
            this.BTN_INCOME.TabIndex = 105;
            this.BTN_INCOME.Text = "הכנסות";
            this.BTN_INCOME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_INCOME.UseVisualStyleBackColor = true;
            this.BTN_INCOME.Click += new System.EventHandler(this.BTN_INCOME_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PC_STORE.Properties.Resources.logo_transparent3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 802);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 267);
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_ALL_ORDERS
            // 
            this.BTN_ALL_ORDERS.FlatAppearance.BorderSize = 0;
            this.BTN_ALL_ORDERS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ALL_ORDERS.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ALL_ORDERS.Image = global::PC_STORE.Properties.Resources.todo_list_50px;
            this.BTN_ALL_ORDERS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_ALL_ORDERS.Location = new System.Drawing.Point(3, 316);
            this.BTN_ALL_ORDERS.Name = "BTN_ALL_ORDERS";
            this.BTN_ALL_ORDERS.Size = new System.Drawing.Size(264, 60);
            this.BTN_ALL_ORDERS.TabIndex = 9;
            this.BTN_ALL_ORDERS.Text = "היסטוריית הזמנות";
            this.BTN_ALL_ORDERS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ALL_ORDERS.UseVisualStyleBackColor = true;
            this.BTN_ALL_ORDERS.Click += new System.EventHandler(this.BTN_ALL_ORDERS_Click);
            // 
            // BTN_EMPLOYEE_SHIFTS
            // 
            this.BTN_EMPLOYEE_SHIFTS.FlatAppearance.BorderSize = 0;
            this.BTN_EMPLOYEE_SHIFTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EMPLOYEE_SHIFTS.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EMPLOYEE_SHIFTS.Image = global::PC_STORE.Properties.Resources.future_48px;
            this.BTN_EMPLOYEE_SHIFTS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EMPLOYEE_SHIFTS.Location = new System.Drawing.Point(64, 509);
            this.BTN_EMPLOYEE_SHIFTS.Name = "BTN_EMPLOYEE_SHIFTS";
            this.BTN_EMPLOYEE_SHIFTS.Size = new System.Drawing.Size(203, 60);
            this.BTN_EMPLOYEE_SHIFTS.TabIndex = 8;
            this.BTN_EMPLOYEE_SHIFTS.Text = "שעות/דוחות";
            this.BTN_EMPLOYEE_SHIFTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EMPLOYEE_SHIFTS.UseVisualStyleBackColor = true;
            this.BTN_EMPLOYEE_SHIFTS.Click += new System.EventHandler(this.BTN_EMPLOYEE_SHIFTS_Click);
            // 
            // BTN_EMPLOYEE_MANAGMENT
            // 
            this.BTN_EMPLOYEE_MANAGMENT.FlatAppearance.BorderSize = 0;
            this.BTN_EMPLOYEE_MANAGMENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EMPLOYEE_MANAGMENT.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EMPLOYEE_MANAGMENT.Image = global::PC_STORE.Properties.Resources.coworking_48px;
            this.BTN_EMPLOYEE_MANAGMENT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EMPLOYEE_MANAGMENT.Location = new System.Drawing.Point(64, 443);
            this.BTN_EMPLOYEE_MANAGMENT.Name = "BTN_EMPLOYEE_MANAGMENT";
            this.BTN_EMPLOYEE_MANAGMENT.Size = new System.Drawing.Size(203, 60);
            this.BTN_EMPLOYEE_MANAGMENT.TabIndex = 7;
            this.BTN_EMPLOYEE_MANAGMENT.Text = "ניהול עובדים";
            this.BTN_EMPLOYEE_MANAGMENT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EMPLOYEE_MANAGMENT.UseVisualStyleBackColor = true;
            this.BTN_EMPLOYEE_MANAGMENT.Click += new System.EventHandler(this.BTN_EMPLOYEE_MANAGMENT_Click);
            // 
            // BTN_PRODUCTS
            // 
            this.BTN_PRODUCTS.FlatAppearance.BorderSize = 0;
            this.BTN_PRODUCTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRODUCTS.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRODUCTS.Image = global::PC_STORE.Properties.Resources.product_40px1;
            this.BTN_PRODUCTS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_PRODUCTS.Location = new System.Drawing.Point(125, 118);
            this.BTN_PRODUCTS.Name = "BTN_PRODUCTS";
            this.BTN_PRODUCTS.Size = new System.Drawing.Size(142, 60);
            this.BTN_PRODUCTS.TabIndex = 6;
            this.BTN_PRODUCTS.Text = "מוצרים";
            this.BTN_PRODUCTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_PRODUCTS.UseVisualStyleBackColor = true;
            this.BTN_PRODUCTS.Click += new System.EventHandler(this.BTN_PRODUCTS_Click);
            // 
            // BTN_NEW_ORDER
            // 
            this.BTN_NEW_ORDER.FlatAppearance.BorderSize = 0;
            this.BTN_NEW_ORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW_ORDER.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEW_ORDER.Image = global::PC_STORE.Properties.Resources.create_50px;
            this.BTN_NEW_ORDER.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_NEW_ORDER.Location = new System.Drawing.Point(52, 52);
            this.BTN_NEW_ORDER.Name = "BTN_NEW_ORDER";
            this.BTN_NEW_ORDER.Size = new System.Drawing.Size(215, 60);
            this.BTN_NEW_ORDER.TabIndex = 4;
            this.BTN_NEW_ORDER.Text = "הזמנה חדשה";
            this.BTN_NEW_ORDER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_NEW_ORDER.UseVisualStyleBackColor = true;
            this.BTN_NEW_ORDER.Click += new System.EventHandler(this.BTN_NEW_ORDER_Click);
            // 
            // BTN_CUSTOMERS
            // 
            this.BTN_CUSTOMERS.FlatAppearance.BorderSize = 0;
            this.BTN_CUSTOMERS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CUSTOMERS.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CUSTOMERS.Image = global::PC_STORE.Properties.Resources.user_group_48px;
            this.BTN_CUSTOMERS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_CUSTOMERS.Location = new System.Drawing.Point(125, 250);
            this.BTN_CUSTOMERS.Name = "BTN_CUSTOMERS";
            this.BTN_CUSTOMERS.Size = new System.Drawing.Size(142, 60);
            this.BTN_CUSTOMERS.TabIndex = 3;
            this.BTN_CUSTOMERS.Text = "לקוחות";
            this.BTN_CUSTOMERS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CUSTOMERS.UseVisualStyleBackColor = true;
            this.BTN_CUSTOMERS.Click += new System.EventHandler(this.BTN_CUSTOMERS_Click);
            // 
            // BTN_CATEGORIES
            // 
            this.BTN_CATEGORIES.FlatAppearance.BorderSize = 0;
            this.BTN_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CATEGORIES.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CATEGORIES.Image = global::PC_STORE.Properties.Resources.categorize_40px;
            this.BTN_CATEGORIES.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_CATEGORIES.Location = new System.Drawing.Point(110, 184);
            this.BTN_CATEGORIES.Name = "BTN_CATEGORIES";
            this.BTN_CATEGORIES.Size = new System.Drawing.Size(157, 60);
            this.BTN_CATEGORIES.TabIndex = 2;
            this.BTN_CATEGORIES.Text = "קטגוריות";
            this.BTN_CATEGORIES.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CATEGORIES.UseVisualStyleBackColor = true;
            this.BTN_CATEGORIES.Click += new System.EventHandler(this.BTN_CATEGORIES_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.panel2.BackgroundImage = global::PC_STORE.Properties.Resources.logo_transparent1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.BTN_EXIT_SHIFT);
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1761, 46);
            this.panel2.TabIndex = 2;
            // 
            // BTN_EXIT_SHIFT
            // 
            this.BTN_EXIT_SHIFT.FlatAppearance.BorderSize = 0;
            this.BTN_EXIT_SHIFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXIT_SHIFT.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXIT_SHIFT.Image = global::PC_STORE.Properties.Resources.exit_48px;
            this.BTN_EXIT_SHIFT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EXIT_SHIFT.Location = new System.Drawing.Point(3, -12);
            this.BTN_EXIT_SHIFT.Name = "BTN_EXIT_SHIFT";
            this.BTN_EXIT_SHIFT.Size = new System.Drawing.Size(59, 70);
            this.BTN_EXIT_SHIFT.TabIndex = 7;
            this.BTN_EXIT_SHIFT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EXIT_SHIFT.UseVisualStyleBackColor = true;
            this.BTN_EXIT_SHIFT.Click += new System.EventHandler(this.BTN_EXIT_SHIFT_Click);
            // 
            // uC_ALL_ORDERS1
            // 
            this.uC_ALL_ORDERS1.Location = new System.Drawing.Point(-414, 52);
            this.uC_ALL_ORDERS1.Name = "uC_ALL_ORDERS1";
            this.uC_ALL_ORDERS1.Size = new System.Drawing.Size(1672, 965);
            this.uC_ALL_ORDERS1.TabIndex = 3;
            // 
            // uC_EMPLOYEE_SHIFTS1
            // 
            this.uC_EMPLOYEE_SHIFTS1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.uC_EMPLOYEE_SHIFTS1.Location = new System.Drawing.Point(-320, 52);
            this.uC_EMPLOYEE_SHIFTS1.Name = "uC_EMPLOYEE_SHIFTS1";
            this.uC_EMPLOYEE_SHIFTS1.Size = new System.Drawing.Size(1578, 887);
            this.uC_EMPLOYEE_SHIFTS1.TabIndex = 4;
            // 
            // uC_INCOME1
            // 
            this.uC_INCOME1.Location = new System.Drawing.Point(-198, 52);
            this.uC_INCOME1.Name = "uC_INCOME1";
            this.uC_INCOME1.Size = new System.Drawing.Size(1456, 997);
            this.uC_INCOME1.TabIndex = 5;
            // 
            // uC_MANAGE_CATEGORIES1
            // 
            this.uC_MANAGE_CATEGORIES1.Location = new System.Drawing.Point(-227, 52);
            this.uC_MANAGE_CATEGORIES1.Name = "uC_MANAGE_CATEGORIES1";
            this.uC_MANAGE_CATEGORIES1.Size = new System.Drawing.Size(1485, 899);
            this.uC_MANAGE_CATEGORIES1.TabIndex = 6;
            // 
            // uC_MANAGE_CUSTOMERS1
            // 
            this.uC_MANAGE_CUSTOMERS1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.uC_MANAGE_CUSTOMERS1.Location = new System.Drawing.Point(-215, 52);
            this.uC_MANAGE_CUSTOMERS1.Name = "uC_MANAGE_CUSTOMERS1";
            this.uC_MANAGE_CUSTOMERS1.Size = new System.Drawing.Size(1473, 882);
            this.uC_MANAGE_CUSTOMERS1.TabIndex = 7;
            // 
            // uC_MANAGE_EMPLOYEE1
            // 
            this.uC_MANAGE_EMPLOYEE1.Location = new System.Drawing.Point(-236, 52);
            this.uC_MANAGE_EMPLOYEE1.Name = "uC_MANAGE_EMPLOYEE1";
            this.uC_MANAGE_EMPLOYEE1.Size = new System.Drawing.Size(1491, 937);
            this.uC_MANAGE_EMPLOYEE1.TabIndex = 8;
            // 
            // uC_MANAGE_ORDER1
            // 
            this.uC_MANAGE_ORDER1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.uC_MANAGE_ORDER1.Location = new System.Drawing.Point(-198, 52);
            this.uC_MANAGE_ORDER1.Name = "uC_MANAGE_ORDER1";
            this.uC_MANAGE_ORDER1.Size = new System.Drawing.Size(1456, 890);
            this.uC_MANAGE_ORDER1.TabIndex = 9;
            // 
            // uC_MANAGE_PRODUCT1
            // 
            this.uC_MANAGE_PRODUCT1.Location = new System.Drawing.Point(-211, 49);
            this.uC_MANAGE_PRODUCT1.Name = "uC_MANAGE_PRODUCT1";
            this.uC_MANAGE_PRODUCT1.Size = new System.Drawing.Size(1469, 890);
            this.uC_MANAGE_PRODUCT1.TabIndex = 10;
            // 
            // FORM_HOME_PAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.uC_MANAGE_PRODUCT1);
            this.Controls.Add(this.uC_MANAGE_ORDER1);
            this.Controls.Add(this.uC_MANAGE_EMPLOYEE1);
            this.Controls.Add(this.uC_MANAGE_CUSTOMERS1);
            this.Controls.Add(this.uC_MANAGE_CATEGORIES1);
            this.Controls.Add(this.uC_INCOME1);
            this.Controls.Add(this.uC_EMPLOYEE_SHIFTS1);
            this.Controls.Add(this.uC_ALL_ORDERS1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FORM_HOME_PAGE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_HOME_PAGE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BTN_EXIT_SHIFT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_CATEGORIES;
        private System.Windows.Forms.Button BTN_CUSTOMERS;
        private System.Windows.Forms.Button BTN_NEW_ORDER;
        public System.Windows.Forms.Panel SINDE_PANEL;
        private System.Windows.Forms.Button BTN_PRODUCTS;
        public System.Windows.Forms.Button BTN_EMPLOYEE_MANAGMENT;
        public System.Windows.Forms.Button BTN_EMPLOYEE_SHIFTS;
        public System.Windows.Forms.Button BTN_ALL_ORDERS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button BTN_INCOME;
        private UC_ALL_ORDERS uC_ALL_ORDERS1;
        private UC_EMPLOYEE_SHIFTS uC_EMPLOYEE_SHIFTS1;
        private UC_INCOME uC_INCOME1;
        private UC_MANAGE_CATEGORIES uC_MANAGE_CATEGORIES1;
        private UC_MANAGE_CUSTOMERS uC_MANAGE_CUSTOMERS1;
        private UC_MANAGE_EMPLOYEE uC_MANAGE_EMPLOYEE1;
        private UC_MANAGE_ORDER uC_MANAGE_ORDER1;
        private UC_MANAGE_PRODUCT uC_MANAGE_PRODUCT1;
    }
}