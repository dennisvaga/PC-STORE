namespace PC_STORE
{
    partial class FORM_QUANTITY
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
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.TB_QUANTITY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(238, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = ":כמות";
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_CANCEL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BTN_CANCEL.Location = new System.Drawing.Point(66, 93);
            this.BTN_CANCEL.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(112, 37);
            this.BTN_CANCEL.TabIndex = 13;
            this.BTN_CANCEL.Text = "ביטול";
            this.BTN_CANCEL.UseVisualStyleBackColor = false;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_OK
            // 
            this.BTN_OK.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_OK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OK.ForeColor = System.Drawing.Color.White;
            this.BTN_OK.Location = new System.Drawing.Point(182, 93);
            this.BTN_OK.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(107, 37);
            this.BTN_OK.TabIndex = 14;
            this.BTN_OK.Text = "הוסף";
            this.BTN_OK.UseVisualStyleBackColor = false;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // TB_QUANTITY
            // 
            this.TB_QUANTITY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TB_QUANTITY.Location = new System.Drawing.Point(66, 62);
            this.TB_QUANTITY.Name = "TB_QUANTITY";
            this.TB_QUANTITY.Size = new System.Drawing.Size(223, 26);
            this.TB_QUANTITY.TabIndex = 77;
            // 
            // FORM_QUANTITY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 189);
            this.Controls.Add(this.TB_QUANTITY);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORM_QUANTITY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "כמות מהמוצר";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_OK;
        public System.Windows.Forms.TextBox TB_QUANTITY;
    }
}