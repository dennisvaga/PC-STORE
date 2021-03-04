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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_CUSTOMER = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_CUSTOMER_ORDERS = new System.Windows.Forms.DataGridView();
            this.DGV_CUSTOMER_DETAILS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER_ORDERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER_DETAILS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(576, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = ":מוצרים";
            // 
            // LBL_CUSTOMER
            // 
            this.LBL_CUSTOMER.AutoSize = true;
            this.LBL_CUSTOMER.BackColor = System.Drawing.Color.Transparent;
            this.LBL_CUSTOMER.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CUSTOMER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.LBL_CUSTOMER.Location = new System.Drawing.Point(828, 39);
            this.LBL_CUSTOMER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_CUSTOMER.Name = "LBL_CUSTOMER";
            this.LBL_CUSTOMER.Size = new System.Drawing.Size(74, 34);
            this.LBL_CUSTOMER.TabIndex = 11;
            this.LBL_CUSTOMER.Text = ":לקוח";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(902, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = ":הזמנות";
            // 
            // DGV_CUSTOMER_ORDERS
            // 
            this.DGV_CUSTOMER_ORDERS.AllowUserToAddRows = false;
            this.DGV_CUSTOMER_ORDERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMER_ORDERS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_CUSTOMER_ORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CUSTOMER_ORDERS.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_CUSTOMER_ORDERS.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DGV_CUSTOMER_ORDERS.Location = new System.Drawing.Point(671, 138);
            this.DGV_CUSTOMER_ORDERS.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_CUSTOMER_ORDERS.Name = "DGV_CUSTOMER_ORDERS";
            this.DGV_CUSTOMER_ORDERS.ReadOnly = true;
            this.DGV_CUSTOMER_ORDERS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_CUSTOMER_ORDERS.RowHeadersWidth = 51;
            this.DGV_CUSTOMER_ORDERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CUSTOMER_ORDERS.Size = new System.Drawing.Size(319, 429);
            this.DGV_CUSTOMER_ORDERS.TabIndex = 13;
            this.DGV_CUSTOMER_ORDERS.Click += new System.EventHandler(this.DGV_CUSTOMER_ORDERS_Click);
            // 
            // DGV_CUSTOMER_DETAILS
            // 
            this.DGV_CUSTOMER_DETAILS.AllowUserToAddRows = false;
            this.DGV_CUSTOMER_DETAILS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMER_DETAILS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_CUSTOMER_DETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CUSTOMER_DETAILS.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_CUSTOMER_DETAILS.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DGV_CUSTOMER_DETAILS.Location = new System.Drawing.Point(22, 138);
            this.DGV_CUSTOMER_DETAILS.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_CUSTOMER_DETAILS.Name = "DGV_CUSTOMER_DETAILS";
            this.DGV_CUSTOMER_DETAILS.ReadOnly = true;
            this.DGV_CUSTOMER_DETAILS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_CUSTOMER_DETAILS.RowHeadersWidth = 51;
            this.DGV_CUSTOMER_DETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CUSTOMER_DETAILS.Size = new System.Drawing.Size(632, 429);
            this.DGV_CUSTOMER_DETAILS.TabIndex = 14;
            // 
            // FORM_CUSTOMER_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1076, 643);
            this.Controls.Add(this.DGV_CUSTOMER_DETAILS);
            this.Controls.Add(this.DGV_CUSTOMER_ORDERS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_CUSTOMER);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORM_CUSTOMER_ORDERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הזמנות של לקוחות";
            this.Load += new System.EventHandler(this.FORM_CUSTOMER_ORDERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER_ORDERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER_DETAILS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LBL_CUSTOMER;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView DGV_CUSTOMER_ORDERS;
        public System.Windows.Forms.DataGridView DGV_CUSTOMER_DETAILS;
    }
}