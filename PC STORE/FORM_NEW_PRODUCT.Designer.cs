namespace PC_STORE
{
    partial class FORM_NEW_PRODUCT
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
            this.PB_BROWSE_IMAGE = new System.Windows.Forms.PictureBox();
            this.TB_DESCRIPTION = new System.Windows.Forms.TextBox();
            this.COMBO_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_ADD_CATEGORY = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.LBL_PID = new System.Windows.Forms.Label();
            this.TB_QUANTITY = new System.Windows.Forms.TextBox();
            this.TB_PRICE = new System.Windows.Forms.TextBox();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.TB_GUARANTEE = new System.Windows.Forms.TextBox();
            this.CB_GUARANTEE = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BROWSE_IMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_BROWSE_IMAGE
            // 
            this.PB_BROWSE_IMAGE.BackColor = System.Drawing.Color.White;
            this.PB_BROWSE_IMAGE.Location = new System.Drawing.Point(98, 592);
            this.PB_BROWSE_IMAGE.Margin = new System.Windows.Forms.Padding(2);
            this.PB_BROWSE_IMAGE.Name = "PB_BROWSE_IMAGE";
            this.PB_BROWSE_IMAGE.Size = new System.Drawing.Size(229, 140);
            this.PB_BROWSE_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_BROWSE_IMAGE.TabIndex = 27;
            this.PB_BROWSE_IMAGE.TabStop = false;
            this.PB_BROWSE_IMAGE.Click += new System.EventHandler(this.PB_BROWSE_IMAGE_Click);
            // 
            // TB_DESCRIPTION
            // 
            this.TB_DESCRIPTION.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DESCRIPTION.Location = new System.Drawing.Point(98, 204);
            this.TB_DESCRIPTION.Margin = new System.Windows.Forms.Padding(2);
            this.TB_DESCRIPTION.Multiline = true;
            this.TB_DESCRIPTION.Name = "TB_DESCRIPTION";
            this.TB_DESCRIPTION.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_DESCRIPTION.Size = new System.Drawing.Size(229, 183);
            this.TB_DESCRIPTION.TabIndex = 24;
            this.TB_DESCRIPTION.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // COMBO_CATEGORIES
            // 
            this.COMBO_CATEGORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_CATEGORIES.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.COMBO_CATEGORIES.FormattingEnabled = true;
            this.COMBO_CATEGORIES.Location = new System.Drawing.Point(98, 62);
            this.COMBO_CATEGORIES.Margin = new System.Windows.Forms.Padding(2);
            this.COMBO_CATEGORIES.Name = "COMBO_CATEGORIES";
            this.COMBO_CATEGORIES.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.COMBO_CATEGORIES.Size = new System.Drawing.Size(229, 25);
            this.COMBO_CATEGORIES.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(254, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = ":קטגוריה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(283, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = ":שם ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(271, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = ":תיאור";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(276, 403);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = ":כמות";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(276, 451);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = ":מחיר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label6.Location = new System.Drawing.Point(267, 568);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = ":תמונה";
            // 
            // BTN_ADD_CATEGORY
            // 
            this.BTN_ADD_CATEGORY.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_ADD_CATEGORY.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD_CATEGORY.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD_CATEGORY.Location = new System.Drawing.Point(98, 91);
            this.BTN_ADD_CATEGORY.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ADD_CATEGORY.Name = "BTN_ADD_CATEGORY";
            this.BTN_ADD_CATEGORY.Size = new System.Drawing.Size(141, 31);
            this.BTN_ADD_CATEGORY.TabIndex = 37;
            this.BTN_ADD_CATEGORY.Text = "הוסף קטגוריה";
            this.BTN_ADD_CATEGORY.UseVisualStyleBackColor = false;
            this.BTN_ADD_CATEGORY.Click += new System.EventHandler(this.BTN_ADD_CATEGORY_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_CANCEL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BTN_CANCEL.Location = new System.Drawing.Point(82, 746);
            this.BTN_CANCEL.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(119, 33);
            this.BTN_CANCEL.TabIndex = 38;
            this.BTN_CANCEL.Text = "ביטול";
            this.BTN_CANCEL.UseVisualStyleBackColor = false;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_ADD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD.Location = new System.Drawing.Point(222, 746);
            this.BTN_ADD.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(121, 33);
            this.BTN_ADD.TabIndex = 39;
            this.BTN_ADD.Text = "הוסף";
            this.BTN_ADD.UseVisualStyleBackColor = false;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_UPDATE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UPDATE.ForeColor = System.Drawing.Color.White;
            this.BTN_UPDATE.Location = new System.Drawing.Point(222, 747);
            this.BTN_UPDATE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(121, 32);
            this.BTN_UPDATE.TabIndex = 44;
            this.BTN_UPDATE.Text = "עדכן";
            this.BTN_UPDATE.UseVisualStyleBackColor = false;
            this.BTN_UPDATE.Visible = false;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // LBL_PID
            // 
            this.LBL_PID.AutoSize = true;
            this.LBL_PID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PID.Location = new System.Drawing.Point(32, 668);
            this.LBL_PID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_PID.Name = "LBL_PID";
            this.LBL_PID.Size = new System.Drawing.Size(0, 21);
            this.LBL_PID.TabIndex = 45;
            this.LBL_PID.Visible = false;
            // 
            // TB_QUANTITY
            // 
            this.TB_QUANTITY.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TB_QUANTITY.Location = new System.Drawing.Point(98, 428);
            this.TB_QUANTITY.Name = "TB_QUANTITY";
            this.TB_QUANTITY.Size = new System.Drawing.Size(229, 25);
            this.TB_QUANTITY.TabIndex = 77;
            this.TB_QUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_PRICE
            // 
            this.TB_PRICE.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TB_PRICE.Location = new System.Drawing.Point(98, 476);
            this.TB_PRICE.Name = "TB_PRICE";
            this.TB_PRICE.Size = new System.Drawing.Size(229, 25);
            this.TB_PRICE.TabIndex = 78;
            this.TB_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_NAME
            // 
            this.TB_NAME.BackColor = System.Drawing.SystemColors.Window;
            this.TB_NAME.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NAME.ForeColor = System.Drawing.Color.Black;
            this.TB_NAME.Location = new System.Drawing.Point(98, 152);
            this.TB_NAME.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_NAME.Size = new System.Drawing.Size(229, 26);
            this.TB_NAME.TabIndex = 79;
            this.TB_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_GUARANTEE
            // 
            this.TB_GUARANTEE.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TB_GUARANTEE.Location = new System.Drawing.Point(98, 540);
            this.TB_GUARANTEE.Name = "TB_GUARANTEE";
            this.TB_GUARANTEE.ReadOnly = true;
            this.TB_GUARANTEE.Size = new System.Drawing.Size(229, 25);
            this.TB_GUARANTEE.TabIndex = 80;
            this.TB_GUARANTEE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CB_GUARANTEE
            // 
            this.CB_GUARANTEE.AutoSize = true;
            this.CB_GUARANTEE.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_GUARANTEE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.CB_GUARANTEE.Location = new System.Drawing.Point(241, 508);
            this.CB_GUARANTEE.Name = "CB_GUARANTEE";
            this.CB_GUARANTEE.Size = new System.Drawing.Size(86, 26);
            this.CB_GUARANTEE.TabIndex = 82;
            this.CB_GUARANTEE.Text = ":אחריות";
            this.CB_GUARANTEE.UseVisualStyleBackColor = true;
            this.CB_GUARANTEE.CheckedChanged += new System.EventHandler(this.CB_GUARANTEE_CheckedChanged);
            // 
            // FORM_NEW_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 839);
            this.Controls.Add(this.CB_GUARANTEE);
            this.Controls.Add(this.TB_GUARANTEE);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.TB_PRICE);
            this.Controls.Add(this.TB_QUANTITY);
            this.Controls.Add(this.LBL_PID);
            this.Controls.Add(this.BTN_UPDATE);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_ADD_CATEGORY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_BROWSE_IMAGE);
            this.Controls.Add(this.TB_DESCRIPTION);
            this.Controls.Add(this.COMBO_CATEGORIES);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORM_NEW_PRODUCT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מוצר ";
            ((System.ComponentModel.ISupportInitialize)(this.PB_BROWSE_IMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox COMBO_CATEGORIES;
        public System.Windows.Forms.Label LBL_PID;
        public System.Windows.Forms.PictureBox PB_BROWSE_IMAGE;
        public System.Windows.Forms.TextBox TB_DESCRIPTION;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button BTN_ADD_CATEGORY;
        public System.Windows.Forms.Button BTN_CANCEL;
        public System.Windows.Forms.Button BTN_ADD;
        public System.Windows.Forms.Button BTN_UPDATE;
        public System.Windows.Forms.TextBox TB_QUANTITY;
        public System.Windows.Forms.TextBox TB_PRICE;
        public System.Windows.Forms.TextBox TB_NAME;
        public System.Windows.Forms.TextBox TB_GUARANTEE;
        private System.Windows.Forms.CheckBox CB_GUARANTEE;
    }
}