namespace PC_STORE
{
    partial class FORM_ADD_NEW_CATEGORY
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
            this.TB_CATEGORY_NAME = new System.Windows.Forms.TextBox();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_ADD_CATEGORY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Categorie Name :";
            // 
            // TB_CATEGORY_NAME
            // 
            this.TB_CATEGORY_NAME.Location = new System.Drawing.Point(155, 37);
            this.TB_CATEGORY_NAME.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_CATEGORY_NAME.Name = "TB_CATEGORY_NAME";
            this.TB_CATEGORY_NAME.Size = new System.Drawing.Size(172, 20);
            this.TB_CATEGORY_NAME.TabIndex = 7;
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Location = new System.Drawing.Point(250, 71);
            this.BTN_CANCEL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(77, 30);
            this.BTN_CANCEL.TabIndex = 13;
            this.BTN_CANCEL.Text = "Cancel";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_ADD_CATEGORY
            // 
            this.BTN_ADD_CATEGORY.Location = new System.Drawing.Point(155, 71);
            this.BTN_ADD_CATEGORY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ADD_CATEGORY.Name = "BTN_ADD_CATEGORY";
            this.BTN_ADD_CATEGORY.Size = new System.Drawing.Size(77, 30);
            this.BTN_ADD_CATEGORY.TabIndex = 14;
            this.BTN_ADD_CATEGORY.Text = "Add";
            this.BTN_ADD_CATEGORY.UseVisualStyleBackColor = true;
            this.BTN_ADD_CATEGORY.Click += new System.EventHandler(this.BTN_ADD_CATEGORY_Click);
            // 
            // FORM_ADD_NEW_CATEGORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 148);
            this.Controls.Add(this.BTN_ADD_CATEGORY);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CATEGORY_NAME);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FORM_ADD_NEW_CATEGORY";
            this.Text = "FORM_ADD_NEW_CATEGORY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_CATEGORY_NAME;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_ADD_CATEGORY;
    }
}