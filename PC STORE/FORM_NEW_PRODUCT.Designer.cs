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
            this.TB_PRICE = new System.Windows.Forms.TextBox();
            this.TB_QUANTITY = new System.Windows.Forms.TextBox();
            this.TB_DESCRIPTION = new System.Windows.Forms.TextBox();
            this.TB_NAME = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.PB_BROWSE_IMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_BROWSE_IMAGE
            // 
            this.PB_BROWSE_IMAGE.BackColor = System.Drawing.Color.White;
            this.PB_BROWSE_IMAGE.Location = new System.Drawing.Point(146, 412);
            this.PB_BROWSE_IMAGE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PB_BROWSE_IMAGE.Name = "PB_BROWSE_IMAGE";
            this.PB_BROWSE_IMAGE.Size = new System.Drawing.Size(242, 141);
            this.PB_BROWSE_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_BROWSE_IMAGE.TabIndex = 27;
            this.PB_BROWSE_IMAGE.TabStop = false;
            this.PB_BROWSE_IMAGE.Click += new System.EventHandler(this.PB_BROWSE_IMAGE_Click);
            // 
            // TB_PRICE
            // 
            this.TB_PRICE.Location = new System.Drawing.Point(146, 363);
            this.TB_PRICE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_PRICE.Name = "TB_PRICE";
            this.TB_PRICE.Size = new System.Drawing.Size(188, 20);
            this.TB_PRICE.TabIndex = 26;
            this.TB_PRICE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_PRICE_KeyDown);
            this.TB_PRICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_PRICE_KeyPress);
            // 
            // TB_QUANTITY
            // 
            this.TB_QUANTITY.Location = new System.Drawing.Point(146, 313);
            this.TB_QUANTITY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_QUANTITY.Name = "TB_QUANTITY";
            this.TB_QUANTITY.Size = new System.Drawing.Size(188, 20);
            this.TB_QUANTITY.TabIndex = 25;
            this.TB_QUANTITY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_QUANTITY_KeyDown);
            this.TB_QUANTITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_QUANTITY_KeyPress);
            // 
            // TB_DESCRIPTION
            // 
            this.TB_DESCRIPTION.Location = new System.Drawing.Point(146, 134);
            this.TB_DESCRIPTION.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_DESCRIPTION.Multiline = true;
            this.TB_DESCRIPTION.Name = "TB_DESCRIPTION";
            this.TB_DESCRIPTION.Size = new System.Drawing.Size(188, 161);
            this.TB_DESCRIPTION.TabIndex = 24;
            this.TB_DESCRIPTION.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_DESCRIPTION_KeyDown);
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(146, 97);
            this.TB_NAME.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(188, 20);
            this.TB_NAME.TabIndex = 23;
            this.TB_NAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_NAME_KeyDown);
            // 
            // COMBO_CATEGORIES
            // 
            this.COMBO_CATEGORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_CATEGORIES.FormattingEnabled = true;
            this.COMBO_CATEGORIES.Location = new System.Drawing.Point(146, 49);
            this.COMBO_CATEGORIES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.COMBO_CATEGORIES.Name = "COMBO_CATEGORIES";
            this.COMBO_CATEGORIES.Size = new System.Drawing.Size(146, 21);
            this.COMBO_CATEGORIES.TabIndex = 22;
            this.COMBO_CATEGORIES.SelectedIndexChanged += new System.EventHandler(this.COMBO_CATEGORIES_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Categorie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 367);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 412);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Image:";
            // 
            // BTN_ADD_CATEGORY
            // 
            this.BTN_ADD_CATEGORY.Location = new System.Drawing.Point(307, 36);
            this.BTN_ADD_CATEGORY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ADD_CATEGORY.Name = "BTN_ADD_CATEGORY";
            this.BTN_ADD_CATEGORY.Size = new System.Drawing.Size(112, 33);
            this.BTN_ADD_CATEGORY.TabIndex = 37;
            this.BTN_ADD_CATEGORY.Text = "Add new category";
            this.BTN_ADD_CATEGORY.UseVisualStyleBackColor = true;
            this.BTN_ADD_CATEGORY.Click += new System.EventHandler(this.BTN_ADD_CATEGORY_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Location = new System.Drawing.Point(146, 586);
            this.BTN_CANCEL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(87, 33);
            this.BTN_CANCEL.TabIndex = 38;
            this.BTN_CANCEL.Text = "Cancel";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(246, 586);
            this.BTN_ADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(87, 33);
            this.BTN_ADD.TabIndex = 39;
            this.BTN_ADD.Text = "Add";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // FORM_NEW_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 715);
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
            this.Controls.Add(this.TB_PRICE);
            this.Controls.Add(this.TB_QUANTITY);
            this.Controls.Add(this.TB_DESCRIPTION);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.COMBO_CATEGORIES);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FORM_NEW_PRODUCT";
            this.Text = "FORM_NEW_PRODUCT";
            ((System.ComponentModel.ISupportInitialize)(this.PB_BROWSE_IMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PB_BROWSE_IMAGE;
        private System.Windows.Forms.TextBox TB_PRICE;
        private System.Windows.Forms.TextBox TB_QUANTITY;
        private System.Windows.Forms.TextBox TB_DESCRIPTION;
        private System.Windows.Forms.TextBox TB_NAME;
        public System.Windows.Forms.ComboBox COMBO_CATEGORIES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_ADD_CATEGORY;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_ADD;
    }
}