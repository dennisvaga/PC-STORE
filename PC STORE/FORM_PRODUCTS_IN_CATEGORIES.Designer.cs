namespace PC_STORE
{
    partial class FORM_PRODUCTS_IN_CATEGORIES
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
            this.DGV_PRODUCTS_IN_CATEGORY = new System.Windows.Forms.DataGridView();
            this.LBL_CATEGORY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_CATEGORY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(185, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Products In The Categorie : ";
            // 
            // DGV_PRODUCTS_IN_CATEGORY
            // 
            this.DGV_PRODUCTS_IN_CATEGORY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS_IN_CATEGORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS_IN_CATEGORY.Location = new System.Drawing.Point(25, 127);
            this.DGV_PRODUCTS_IN_CATEGORY.Name = "DGV_PRODUCTS_IN_CATEGORY";
            this.DGV_PRODUCTS_IN_CATEGORY.RowHeadersWidth = 51;
            this.DGV_PRODUCTS_IN_CATEGORY.Size = new System.Drawing.Size(751, 321);
            this.DGV_PRODUCTS_IN_CATEGORY.TabIndex = 6;
            // 
            // LBL_CATEGORY
            // 
            this.LBL_CATEGORY.AutoSize = true;
            this.LBL_CATEGORY.BackColor = System.Drawing.Color.Transparent;
            this.LBL_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CATEGORY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.LBL_CATEGORY.Location = new System.Drawing.Point(502, 94);
            this.LBL_CATEGORY.Name = "LBL_CATEGORY";
            this.LBL_CATEGORY.Size = new System.Drawing.Size(70, 25);
            this.LBL_CATEGORY.TabIndex = 5;
            this.LBL_CATEGORY.Text = "label1";
            // 
            // FORM_PRODUCTS_IN_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_PRODUCTS_IN_CATEGORY);
            this.Controls.Add(this.LBL_CATEGORY);
            this.Name = "FORM_PRODUCTS_IN_CATEGORIES";
            this.Text = "FORM_PRODUCTS_IN_CATEGORIES";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_CATEGORY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DGV_PRODUCTS_IN_CATEGORY;
        public System.Windows.Forms.Label LBL_CATEGORY;
    }
}