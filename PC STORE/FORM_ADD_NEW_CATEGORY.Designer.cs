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
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_ADD_CATEGORY = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_CATEGORY_NAME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_CANCEL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BTN_CANCEL.Location = new System.Drawing.Point(90, 111);
            this.BTN_CANCEL.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(144, 30);
            this.BTN_CANCEL.TabIndex = 13;
            this.BTN_CANCEL.Text = "ביטול";
            this.BTN_CANCEL.UseVisualStyleBackColor = false;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_ADD_CATEGORY
            // 
            this.BTN_ADD_CATEGORY.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_ADD_CATEGORY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD_CATEGORY.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD_CATEGORY.Location = new System.Drawing.Point(260, 111);
            this.BTN_ADD_CATEGORY.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ADD_CATEGORY.Name = "BTN_ADD_CATEGORY";
            this.BTN_ADD_CATEGORY.Size = new System.Drawing.Size(143, 30);
            this.BTN_ADD_CATEGORY.TabIndex = 14;
            this.BTN_ADD_CATEGORY.Text = "הוסף";
            this.BTN_ADD_CATEGORY.UseVisualStyleBackColor = false;
            this.BTN_ADD_CATEGORY.Click += new System.EventHandler(this.BTN_ADD_CATEGORY_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(275, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = ":שם קטגוריה";
            // 
            // TB_CATEGORY_NAME
            // 
            this.TB_CATEGORY_NAME.BackColor = System.Drawing.SystemColors.Window;
            this.TB_CATEGORY_NAME.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CATEGORY_NAME.ForeColor = System.Drawing.Color.Black;
            this.TB_CATEGORY_NAME.Location = new System.Drawing.Point(104, 59);
            this.TB_CATEGORY_NAME.Margin = new System.Windows.Forms.Padding(2);
            this.TB_CATEGORY_NAME.Name = "TB_CATEGORY_NAME";
            this.TB_CATEGORY_NAME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_CATEGORY_NAME.Size = new System.Drawing.Size(278, 26);
            this.TB_CATEGORY_NAME.TabIndex = 42;
            this.TB_CATEGORY_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FORM_ADD_NEW_CATEGORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.TB_CATEGORY_NAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_ADD_CATEGORY);
            this.Controls.Add(this.BTN_CANCEL);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORM_ADD_NEW_CATEGORY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "קטגוריה חדשה";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_ADD_CATEGORY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_CATEGORY_NAME;
    }
}