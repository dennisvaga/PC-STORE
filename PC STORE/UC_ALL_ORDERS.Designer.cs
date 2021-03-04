namespace PC_STORE
{
    partial class UC_ALL_ORDERS
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
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_ALL_ORDERS = new System.Windows.Forms.DataGridView();
            this.TB_SEARCH = new System.Windows.Forms.TextBox();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.BTN_PRINT_ORDER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ALL_ORDERS)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(1552, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 44);
            this.label5.TabIndex = 81;
            this.label5.Text = "הזמנות";
            // 
            // DGV_ALL_ORDERS
            // 
            this.DGV_ALL_ORDERS.AllowUserToAddRows = false;
            this.DGV_ALL_ORDERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ALL_ORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ALL_ORDERS.Location = new System.Drawing.Point(803, 148);
            this.DGV_ALL_ORDERS.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_ALL_ORDERS.Name = "DGV_ALL_ORDERS";
            this.DGV_ALL_ORDERS.ReadOnly = true;
            this.DGV_ALL_ORDERS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_ALL_ORDERS.RowHeadersWidth = 51;
            this.DGV_ALL_ORDERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ALL_ORDERS.Size = new System.Drawing.Size(723, 438);
            this.DGV_ALL_ORDERS.TabIndex = 79;
            this.DGV_ALL_ORDERS.DoubleClick += new System.EventHandler(this.DGV_ALL_ORDERS_DoubleClick);
            // 
            // TB_SEARCH
            // 
            this.TB_SEARCH.BackColor = System.Drawing.SystemColors.Window;
            this.TB_SEARCH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SEARCH.ForeColor = System.Drawing.Color.Black;
            this.TB_SEARCH.Location = new System.Drawing.Point(895, 118);
            this.TB_SEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SEARCH.Name = "TB_SEARCH";
            this.TB_SEARCH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_SEARCH.Size = new System.Drawing.Size(215, 26);
            this.TB_SEARCH.TabIndex = 82;
            this.TB_SEARCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_SEARCH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH.Image = global::PC_STORE.Properties.Resources.search_30px;
            this.BTN_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH.Location = new System.Drawing.Point(803, 108);
            this.BTN_SEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(88, 36);
            this.BTN_SEARCH.TabIndex = 83;
            this.BTN_SEARCH.Text = "חיפוש";
            this.BTN_SEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // BTN_PRINT_ORDER
            // 
            this.BTN_PRINT_ORDER.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_PRINT_ORDER.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRINT_ORDER.ForeColor = System.Drawing.Color.White;
            this.BTN_PRINT_ORDER.Image = global::PC_STORE.Properties.Resources.send_to_printer_40px;
            this.BTN_PRINT_ORDER.Location = new System.Drawing.Point(803, 590);
            this.BTN_PRINT_ORDER.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_PRINT_ORDER.Name = "BTN_PRINT_ORDER";
            this.BTN_PRINT_ORDER.Size = new System.Drawing.Size(170, 69);
            this.BTN_PRINT_ORDER.TabIndex = 80;
            this.BTN_PRINT_ORDER.UseVisualStyleBackColor = false;
            this.BTN_PRINT_ORDER.Click += new System.EventHandler(this.BTN_PRINT_ORDER_Click);
            // 
            // UC_ALL_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.TB_SEARCH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_PRINT_ORDER);
            this.Controls.Add(this.DGV_ALL_ORDERS);
            this.Name = "UC_ALL_ORDERS";
            this.Size = new System.Drawing.Size(1672, 965);
            this.Load += new System.EventHandler(this.UC_ALL_ORDERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ALL_ORDERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView DGV_ALL_ORDERS;
        public System.Windows.Forms.Button BTN_PRINT_ORDER;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.TextBox TB_SEARCH;
    }
}
