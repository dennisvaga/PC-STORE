namespace PC_STORE
{
    partial class FORM_UPDATE_PRODUCT
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
            this.LBL_PID = new System.Windows.Forms.Label();
            this.PB_BROWSE_IMAGE = new System.Windows.Forms.PictureBox();
            this.TB_PRICE = new System.Windows.Forms.TextBox();
            this.TB_QUANTITY = new System.Windows.Forms.TextBox();
            this.TB_DESCRIPTION = new System.Windows.Forms.TextBox();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.COMBO_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BROWSE_IMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_PID
            // 
            this.LBL_PID.AutoSize = true;
            this.LBL_PID.Location = new System.Drawing.Point(206, 30);
            this.LBL_PID.Name = "LBL_PID";
            this.LBL_PID.Size = new System.Drawing.Size(0, 17);
            this.LBL_PID.TabIndex = 26;
            this.LBL_PID.Visible = false;
            // 
            // PB_BROWSE_IMAGE
            // 
            this.PB_BROWSE_IMAGE.BackColor = System.Drawing.Color.Transparent;
            this.PB_BROWSE_IMAGE.Location = new System.Drawing.Point(218, 350);
            this.PB_BROWSE_IMAGE.Name = "PB_BROWSE_IMAGE";
            this.PB_BROWSE_IMAGE.Size = new System.Drawing.Size(290, 174);
            this.PB_BROWSE_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_BROWSE_IMAGE.TabIndex = 25;
            this.PB_BROWSE_IMAGE.TabStop = false;
            // 
            // TB_PRICE
            // 
            this.TB_PRICE.Location = new System.Drawing.Point(202, 290);
            this.TB_PRICE.Name = "TB_PRICE";
            this.TB_PRICE.Size = new System.Drawing.Size(250, 22);
            this.TB_PRICE.TabIndex = 24;
            // 
            // TB_QUANTITY
            // 
            this.TB_QUANTITY.Location = new System.Drawing.Point(202, 229);
            this.TB_QUANTITY.Name = "TB_QUANTITY";
            this.TB_QUANTITY.Size = new System.Drawing.Size(250, 22);
            this.TB_QUANTITY.TabIndex = 23;
            // 
            // TB_DESCRIPTION
            // 
            this.TB_DESCRIPTION.Location = new System.Drawing.Point(202, 151);
            this.TB_DESCRIPTION.Multiline = true;
            this.TB_DESCRIPTION.Name = "TB_DESCRIPTION";
            this.TB_DESCRIPTION.Size = new System.Drawing.Size(250, 58);
            this.TB_DESCRIPTION.TabIndex = 22;
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(202, 105);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(250, 22);
            this.TB_NAME.TabIndex = 21;
            // 
            // COMBO_CATEGORIES
            // 
            this.COMBO_CATEGORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_CATEGORIES.FormattingEnabled = true;
            this.COMBO_CATEGORIES.Location = new System.Drawing.Point(202, 46);
            this.COMBO_CATEGORIES.Name = "COMBO_CATEGORIES";
            this.COMBO_CATEGORIES.Size = new System.Drawing.Size(250, 24);
            this.COMBO_CATEGORIES.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Image:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Categorie:";
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.Location = new System.Drawing.Point(293, 561);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(104, 39);
            this.BTN_UPDATE.TabIndex = 43;
            this.BTN_UPDATE.Text = "Update";
            this.BTN_UPDATE.UseVisualStyleBackColor = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Location = new System.Drawing.Point(174, 561);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(104, 39);
            this.BTN_CANCEL.TabIndex = 44;
            this.BTN_CANCEL.Text = "Cancel";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // FORM_UPDATE_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 772);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_UPDATE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_PID);
            this.Controls.Add(this.PB_BROWSE_IMAGE);
            this.Controls.Add(this.TB_PRICE);
            this.Controls.Add(this.TB_QUANTITY);
            this.Controls.Add(this.TB_DESCRIPTION);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.COMBO_CATEGORIES);
            this.Name = "FORM_UPDATE_PRODUCT";
            this.Text = "FORM_UPDATE_PRODUCT";
            ((System.ComponentModel.ISupportInitialize)(this.PB_BROWSE_IMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label LBL_PID;
        public System.Windows.Forms.PictureBox PB_BROWSE_IMAGE;
        public System.Windows.Forms.TextBox TB_PRICE;
        public System.Windows.Forms.TextBox TB_QUANTITY;
        public System.Windows.Forms.TextBox TB_DESCRIPTION;
        public System.Windows.Forms.TextBox TB_NAME;
        public System.Windows.Forms.ComboBox COMBO_CATEGORIES;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_UPDATE;
        private System.Windows.Forms.Button BTN_CANCEL;
    }
}