namespace PC_STORE
{
    partial class FORM_ALL_ORDERS
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
            this.DGV_ALL_ORDERS = new System.Windows.Forms.DataGridView();
            this.BTN_PRINT_ORDER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ALL_ORDERS)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_ALL_ORDERS
            // 
            this.DGV_ALL_ORDERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ALL_ORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ALL_ORDERS.Location = new System.Drawing.Point(30, 54);
            this.DGV_ALL_ORDERS.Name = "DGV_ALL_ORDERS";
            this.DGV_ALL_ORDERS.RowHeadersWidth = 51;
            this.DGV_ALL_ORDERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ALL_ORDERS.Size = new System.Drawing.Size(604, 539);
            this.DGV_ALL_ORDERS.TabIndex = 4;
            // 
            // BTN_PRINT_ORDER
            // 
            this.BTN_PRINT_ORDER.Location = new System.Drawing.Point(445, 615);
            this.BTN_PRINT_ORDER.Name = "BTN_PRINT_ORDER";
            this.BTN_PRINT_ORDER.Size = new System.Drawing.Size(189, 41);
            this.BTN_PRINT_ORDER.TabIndex = 6;
            this.BTN_PRINT_ORDER.Text = "Print selected";
            this.BTN_PRINT_ORDER.UseVisualStyleBackColor = true;
            this.BTN_PRINT_ORDER.Click += new System.EventHandler(this.BTN_PRINT_ORDER_Click);
            // 
            // FORM_ALL_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 696);
            this.Controls.Add(this.BTN_PRINT_ORDER);
            this.Controls.Add(this.DGV_ALL_ORDERS);
            this.Name = "FORM_ALL_ORDERS";
            this.Text = "FORM_ALL_ORDERS";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ALL_ORDERS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView DGV_ALL_ORDERS;
        private System.Windows.Forms.Button BTN_PRINT_ORDER;
    }
}