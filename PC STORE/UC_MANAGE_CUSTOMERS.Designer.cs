namespace PC_STORE
{
    partial class UC_MANAGE_CUSTOMERS
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
            this.BTN_RESET = new System.Windows.Forms.Button();
            this.BTN_INSERT_CUSTOMER = new System.Windows.Forms.Button();
            this.BTN_DELETE_CUSTOMER = new System.Windows.Forms.Button();
            this.LBL_ORDER_COUNT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_UPDATE_CUSTOMER = new System.Windows.Forms.Button();
            this.LBL_ORDER_AMOUNT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBL_LAST_ORDER_DATE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_CUSTOMERS = new System.Windows.Forms.DataGridView();
            this.TB_ID_CUSTOMER = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_FNAME = new System.Windows.Forms.TextBox();
            this.TB_LNAME = new System.Windows.Forms.TextBox();
            this.TB_EMAIL = new System.Windows.Forms.TextBox();
            this.TB_TEL = new System.Windows.Forms.TextBox();
            this.TB_SEARCH = new System.Windows.Forms.TextBox();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMERS)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_RESET
            // 
            this.BTN_RESET.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_RESET.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RESET.ForeColor = System.Drawing.Color.White;
            this.BTN_RESET.Location = new System.Drawing.Point(1170, 415);
            this.BTN_RESET.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_RESET.Name = "BTN_RESET";
            this.BTN_RESET.Size = new System.Drawing.Size(95, 35);
            this.BTN_RESET.TabIndex = 69;
            this.BTN_RESET.Text = "איפוס";
            this.BTN_RESET.UseVisualStyleBackColor = false;
            this.BTN_RESET.Click += new System.EventHandler(this.BTN_RESET_Click);
            // 
            // BTN_INSERT_CUSTOMER
            // 
            this.BTN_INSERT_CUSTOMER.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_INSERT_CUSTOMER.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INSERT_CUSTOMER.ForeColor = System.Drawing.Color.White;
            this.BTN_INSERT_CUSTOMER.Location = new System.Drawing.Point(952, 511);
            this.BTN_INSERT_CUSTOMER.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_INSERT_CUSTOMER.Name = "BTN_INSERT_CUSTOMER";
            this.BTN_INSERT_CUSTOMER.Size = new System.Drawing.Size(128, 39);
            this.BTN_INSERT_CUSTOMER.TabIndex = 67;
            this.BTN_INSERT_CUSTOMER.Text = "הוסף לקוח";
            this.BTN_INSERT_CUSTOMER.UseVisualStyleBackColor = false;
            this.BTN_INSERT_CUSTOMER.Click += new System.EventHandler(this.BTN_INSERT_CUSTOMER_Click);
            // 
            // BTN_DELETE_CUSTOMER
            // 
            this.BTN_DELETE_CUSTOMER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DELETE_CUSTOMER.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_CUSTOMER.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE_CUSTOMER.Location = new System.Drawing.Point(405, 511);
            this.BTN_DELETE_CUSTOMER.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DELETE_CUSTOMER.Name = "BTN_DELETE_CUSTOMER";
            this.BTN_DELETE_CUSTOMER.Size = new System.Drawing.Size(122, 39);
            this.BTN_DELETE_CUSTOMER.TabIndex = 66;
            this.BTN_DELETE_CUSTOMER.Text = "מחק";
            this.BTN_DELETE_CUSTOMER.UseVisualStyleBackColor = false;
            this.BTN_DELETE_CUSTOMER.Click += new System.EventHandler(this.BTN_DELETE_CUSTOMER_Click);
            // 
            // LBL_ORDER_COUNT
            // 
            this.LBL_ORDER_COUNT.AutoSize = true;
            this.LBL_ORDER_COUNT.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ORDER_COUNT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.LBL_ORDER_COUNT.Location = new System.Drawing.Point(19, 41);
            this.LBL_ORDER_COUNT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_ORDER_COUNT.Name = "LBL_ORDER_COUNT";
            this.LBL_ORDER_COUNT.Size = new System.Drawing.Size(22, 24);
            this.LBL_ORDER_COUNT.TabIndex = 17;
            this.LBL_ORDER_COUNT.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(51, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = ":מספר הזמנות";
            // 
            // BTN_UPDATE_CUSTOMER
            // 
            this.BTN_UPDATE_CUSTOMER.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_UPDATE_CUSTOMER.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UPDATE_CUSTOMER.ForeColor = System.Drawing.Color.White;
            this.BTN_UPDATE_CUSTOMER.Location = new System.Drawing.Point(825, 511);
            this.BTN_UPDATE_CUSTOMER.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_UPDATE_CUSTOMER.Name = "BTN_UPDATE_CUSTOMER";
            this.BTN_UPDATE_CUSTOMER.Size = new System.Drawing.Size(123, 39);
            this.BTN_UPDATE_CUSTOMER.TabIndex = 68;
            this.BTN_UPDATE_CUSTOMER.Text = "עדכן";
            this.BTN_UPDATE_CUSTOMER.UseVisualStyleBackColor = false;
            this.BTN_UPDATE_CUSTOMER.Click += new System.EventHandler(this.BTN_UPDATE_CUSTOMER_Click);
            // 
            // LBL_ORDER_AMOUNT
            // 
            this.LBL_ORDER_AMOUNT.AutoSize = true;
            this.LBL_ORDER_AMOUNT.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ORDER_AMOUNT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.LBL_ORDER_AMOUNT.Location = new System.Drawing.Point(12, 41);
            this.LBL_ORDER_AMOUNT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_ORDER_AMOUNT.Name = "LBL_ORDER_AMOUNT";
            this.LBL_ORDER_AMOUNT.Size = new System.Drawing.Size(22, 24);
            this.LBL_ORDER_AMOUNT.TabIndex = 18;
            this.LBL_ORDER_AMOUNT.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(122, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = ":סה\"כ מחיר";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label8.Location = new System.Drawing.Point(1342, 295);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 65;
            this.label8.Text = ":אימייל";
            // 
            // LBL_LAST_ORDER_DATE
            // 
            this.LBL_LAST_ORDER_DATE.AutoSize = true;
            this.LBL_LAST_ORDER_DATE.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_LAST_ORDER_DATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.LBL_LAST_ORDER_DATE.Location = new System.Drawing.Point(2, 41);
            this.LBL_LAST_ORDER_DATE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_LAST_ORDER_DATE.Name = "LBL_LAST_ORDER_DATE";
            this.LBL_LAST_ORDER_DATE.Size = new System.Drawing.Size(43, 24);
            this.LBL_LAST_ORDER_DATE.TabIndex = 19;
            this.LBL_LAST_ORDER_DATE.Text = "-/-/-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label6.Location = new System.Drawing.Point(45, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = ":תאריך הזמנה אחרון";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label7.Location = new System.Drawing.Point(1346, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 64;
            this.label7.Text = ":טלפון";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(1300, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 63;
            this.label3.Text = ":שם משפחה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(1322, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 62;
            this.label2.Text = ":שם פרטי";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(1302, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = ":תעודת זהות";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(196)))), ((int)(((byte)(158)))));
            this.panel3.Controls.Add(this.LBL_LAST_ORDER_DATE);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(368, 650);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 81);
            this.panel3.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(196)))), ((int)(((byte)(158)))));
            this.panel2.Controls.Add(this.LBL_ORDER_AMOUNT);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(667, 650);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 81);
            this.panel2.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(196)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.LBL_ORDER_COUNT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(909, 650);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 81);
            this.panel1.TabIndex = 58;
            // 
            // DGV_CUSTOMERS
            // 
            this.DGV_CUSTOMERS.AllowUserToAddRows = false;
            this.DGV_CUSTOMERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CUSTOMERS.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_CUSTOMERS.Location = new System.Drawing.Point(405, 124);
            this.DGV_CUSTOMERS.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_CUSTOMERS.Name = "DGV_CUSTOMERS";
            this.DGV_CUSTOMERS.ReadOnly = true;
            this.DGV_CUSTOMERS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_CUSTOMERS.RowHeadersWidth = 51;
            this.DGV_CUSTOMERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CUSTOMERS.Size = new System.Drawing.Size(675, 383);
            this.DGV_CUSTOMERS.TabIndex = 57;
            this.DGV_CUSTOMERS.Click += new System.EventHandler(this.DGV_CUSTOMERS_Click);
            // 
            // TB_ID_CUSTOMER
            // 
            this.TB_ID_CUSTOMER.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TB_ID_CUSTOMER.Location = new System.Drawing.Point(1170, 124);
            this.TB_ID_CUSTOMER.Margin = new System.Windows.Forms.Padding(2);
            this.TB_ID_CUSTOMER.Name = "TB_ID_CUSTOMER";
            this.TB_ID_CUSTOMER.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_ID_CUSTOMER.Size = new System.Drawing.Size(229, 26);
            this.TB_ID_CUSTOMER.TabIndex = 56;
            this.TB_ID_CUSTOMER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label9.Location = new System.Drawing.Point(1351, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 44);
            this.label9.TabIndex = 83;
            this.label9.Text = "לקוחות";
            // 
            // TB_FNAME
            // 
            this.TB_FNAME.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FNAME.Location = new System.Drawing.Point(1169, 188);
            this.TB_FNAME.Name = "TB_FNAME";
            this.TB_FNAME.Size = new System.Drawing.Size(230, 25);
            this.TB_FNAME.TabIndex = 85;
            this.TB_FNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_LNAME
            // 
            this.TB_LNAME.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_LNAME.Location = new System.Drawing.Point(1169, 256);
            this.TB_LNAME.Name = "TB_LNAME";
            this.TB_LNAME.Size = new System.Drawing.Size(230, 25);
            this.TB_LNAME.TabIndex = 86;
            this.TB_LNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_EMAIL
            // 
            this.TB_EMAIL.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_EMAIL.Location = new System.Drawing.Point(1169, 322);
            this.TB_EMAIL.Name = "TB_EMAIL";
            this.TB_EMAIL.Size = new System.Drawing.Size(230, 25);
            this.TB_EMAIL.TabIndex = 87;
            this.TB_EMAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_TEL
            // 
            this.TB_TEL.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TEL.Location = new System.Drawing.Point(1169, 385);
            this.TB_TEL.Name = "TB_TEL";
            this.TB_TEL.Size = new System.Drawing.Size(230, 25);
            this.TB_TEL.TabIndex = 88;
            this.TB_TEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_SEARCH
            // 
            this.TB_SEARCH.BackColor = System.Drawing.SystemColors.Window;
            this.TB_SEARCH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SEARCH.ForeColor = System.Drawing.Color.Black;
            this.TB_SEARCH.Location = new System.Drawing.Point(497, 90);
            this.TB_SEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SEARCH.Name = "TB_SEARCH";
            this.TB_SEARCH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_SEARCH.Size = new System.Drawing.Size(204, 26);
            this.TB_SEARCH.TabIndex = 102;
            this.TB_SEARCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_SEARCH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH.Image = global::PC_STORE.Properties.Resources.search_30px;
            this.BTN_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH.Location = new System.Drawing.Point(405, 80);
            this.BTN_SEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(88, 36);
            this.BTN_SEARCH.TabIndex = 103;
            this.BTN_SEARCH.Text = "חיפוש";
            this.BTN_SEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // UC_MANAGE_CUSTOMERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.TB_SEARCH);
            this.Controls.Add(this.TB_TEL);
            this.Controls.Add(this.TB_EMAIL);
            this.Controls.Add(this.TB_LNAME);
            this.Controls.Add(this.TB_FNAME);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BTN_RESET);
            this.Controls.Add(this.BTN_INSERT_CUSTOMER);
            this.Controls.Add(this.BTN_DELETE_CUSTOMER);
            this.Controls.Add(this.BTN_UPDATE_CUSTOMER);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_CUSTOMERS);
            this.Controls.Add(this.TB_ID_CUSTOMER);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.Name = "UC_MANAGE_CUSTOMERS";
            this.Size = new System.Drawing.Size(1473, 882);
            this.Load += new System.EventHandler(this.UC_MANAGE_CUSTOMERS_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_RESET;
        private System.Windows.Forms.Button BTN_INSERT_CUSTOMER;
        private System.Windows.Forms.Button BTN_DELETE_CUSTOMER;
        private System.Windows.Forms.Label LBL_ORDER_COUNT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_UPDATE_CUSTOMER;
        private System.Windows.Forms.Label LBL_ORDER_AMOUNT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBL_LAST_ORDER_DATE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_CUSTOMERS;
        private System.Windows.Forms.TextBox TB_ID_CUSTOMER;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_FNAME;
        private System.Windows.Forms.TextBox TB_LNAME;
        private System.Windows.Forms.TextBox TB_EMAIL;
        private System.Windows.Forms.TextBox TB_TEL;
        private System.Windows.Forms.TextBox TB_SEARCH;
        private System.Windows.Forms.Button BTN_SEARCH;
    }
}
