namespace PC_STORE
{
    partial class FORM_MANAGE_CATEGORIES
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_CATG_NAME = new System.Windows.Forms.TextBox();
            this.TB_CATG_ID = new System.Windows.Forms.TextBox();
            this.DGV_CATEGORIES = new System.Windows.Forms.DataGridView();
            this.BTN_DELETE_CTG = new System.Windows.Forms.Button();
            this.BTN_UPDATE_CTG = new System.Windows.Forms.Button();
            this.BTN_INSERT_CTG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID : ";
            // 
            // TB_CATG_NAME
            // 
            this.TB_CATG_NAME.Location = new System.Drawing.Point(109, 90);
            this.TB_CATG_NAME.Name = "TB_CATG_NAME";
            this.TB_CATG_NAME.Size = new System.Drawing.Size(164, 22);
            this.TB_CATG_NAME.TabIndex = 19;
            // 
            // TB_CATG_ID
            // 
            this.TB_CATG_ID.Location = new System.Drawing.Point(109, 43);
            this.TB_CATG_ID.Name = "TB_CATG_ID";
            this.TB_CATG_ID.ReadOnly = true;
            this.TB_CATG_ID.Size = new System.Drawing.Size(164, 22);
            this.TB_CATG_ID.TabIndex = 18;
            // 
            // DGV_CATEGORIES
            // 
            this.DGV_CATEGORIES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CATEGORIES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CATEGORIES.Location = new System.Drawing.Point(309, 43);
            this.DGV_CATEGORIES.Name = "DGV_CATEGORIES";
            this.DGV_CATEGORIES.RowHeadersWidth = 51;
            this.DGV_CATEGORIES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CATEGORIES.Size = new System.Drawing.Size(340, 208);
            this.DGV_CATEGORIES.TabIndex = 14;
            this.DGV_CATEGORIES.Click += new System.EventHandler(this.DGV_CATEGORIES_Click);
            this.DGV_CATEGORIES.DoubleClick += new System.EventHandler(this.DGV_CATEGORIES_DoubleClick);
            // 
            // BTN_DELETE_CTG
            // 
            this.BTN_DELETE_CTG.Location = new System.Drawing.Point(549, 274);
            this.BTN_DELETE_CTG.Name = "BTN_DELETE_CTG";
            this.BTN_DELETE_CTG.Size = new System.Drawing.Size(100, 41);
            this.BTN_DELETE_CTG.TabIndex = 26;
            this.BTN_DELETE_CTG.Text = "Delete";
            this.BTN_DELETE_CTG.UseVisualStyleBackColor = true;
            this.BTN_DELETE_CTG.Click += new System.EventHandler(this.BTN_DELETE_CTG_Click);
            // 
            // BTN_UPDATE_CTG
            // 
            this.BTN_UPDATE_CTG.Location = new System.Drawing.Point(430, 274);
            this.BTN_UPDATE_CTG.Name = "BTN_UPDATE_CTG";
            this.BTN_UPDATE_CTG.Size = new System.Drawing.Size(100, 41);
            this.BTN_UPDATE_CTG.TabIndex = 27;
            this.BTN_UPDATE_CTG.Text = "Update";
            this.BTN_UPDATE_CTG.UseVisualStyleBackColor = true;
            this.BTN_UPDATE_CTG.Click += new System.EventHandler(this.BTN_UPDATE_CTG_Click);
            // 
            // BTN_INSERT_CTG
            // 
            this.BTN_INSERT_CTG.Location = new System.Drawing.Point(309, 274);
            this.BTN_INSERT_CTG.Name = "BTN_INSERT_CTG";
            this.BTN_INSERT_CTG.Size = new System.Drawing.Size(100, 41);
            this.BTN_INSERT_CTG.TabIndex = 28;
            this.BTN_INSERT_CTG.Text = "Insert";
            this.BTN_INSERT_CTG.UseVisualStyleBackColor = true;
            this.BTN_INSERT_CTG.Click += new System.EventHandler(this.BTN_INSERT_CTG_Click);
            // 
            // FORM_MANAGE_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 499);
            this.Controls.Add(this.BTN_INSERT_CTG);
            this.Controls.Add(this.BTN_UPDATE_CTG);
            this.Controls.Add(this.BTN_DELETE_CTG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CATG_NAME);
            this.Controls.Add(this.TB_CATG_ID);
            this.Controls.Add(this.DGV_CATEGORIES);
            this.Name = "FORM_MANAGE_CATEGORIES";
            this.Text = "FORM_MANAGE_CATEGORIES";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_CATG_NAME;
        private System.Windows.Forms.TextBox TB_CATG_ID;
        private System.Windows.Forms.DataGridView DGV_CATEGORIES;
        private System.Windows.Forms.Button BTN_DELETE_CTG;
        private System.Windows.Forms.Button BTN_UPDATE_CTG;
        private System.Windows.Forms.Button BTN_INSERT_CTG;
    }
}