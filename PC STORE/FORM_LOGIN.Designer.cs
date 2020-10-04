namespace PC_STORE
{
    partial class FORM_LOGIN
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
            this.TB_PASSWORD = new System.Windows.Forms.TextBox();
            this.TB_USERNAME = new System.Windows.Forms.TextBox();
            this.CB_PASSWORD = new System.Windows.Forms.CheckBox();
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.LABEL_PASSWORD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_LOGIN_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_PASSWORD
            // 
            this.TB_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_PASSWORD.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PASSWORD.Location = new System.Drawing.Point(110, 93);
            this.TB_PASSWORD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_PASSWORD.Multiline = true;
            this.TB_PASSWORD.Name = "TB_PASSWORD";
            this.TB_PASSWORD.PasswordChar = '*';
            this.TB_PASSWORD.Size = new System.Drawing.Size(232, 34);
            this.TB_PASSWORD.TabIndex = 7;
            this.TB_PASSWORD.Text = "admin";
            // 
            // TB_USERNAME
            // 
            this.TB_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_USERNAME.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_USERNAME.Location = new System.Drawing.Point(110, 41);
            this.TB_USERNAME.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_USERNAME.Multiline = true;
            this.TB_USERNAME.Name = "TB_USERNAME";
            this.TB_USERNAME.Size = new System.Drawing.Size(232, 32);
            this.TB_USERNAME.TabIndex = 6;
            this.TB_USERNAME.Text = "admin";
            // 
            // CB_PASSWORD
            // 
            this.CB_PASSWORD.Location = new System.Drawing.Point(211, 167);
            this.CB_PASSWORD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_PASSWORD.Name = "CB_PASSWORD";
            this.CB_PASSWORD.Size = new System.Drawing.Size(17, 15);
            this.CB_PASSWORD.TabIndex = 19;
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_USERNAME.Location = new System.Drawing.Point(20, 53);
            this.LABEL_USERNAME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(85, 20);
            this.LABEL_USERNAME.TabIndex = 13;
            this.LABEL_USERNAME.Text = "Username";
            // 
            // LABEL_PASSWORD
            // 
            this.LABEL_PASSWORD.AutoSize = true;
            this.LABEL_PASSWORD.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_PASSWORD.Location = new System.Drawing.Point(25, 106);
            this.LABEL_PASSWORD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABEL_PASSWORD.Name = "LABEL_PASSWORD";
            this.LABEL_PASSWORD.Size = new System.Drawing.Size(81, 20);
            this.LABEL_PASSWORD.TabIndex = 15;
            this.LABEL_PASSWORD.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Doppio One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Show password";
            // 
            // BTN_LOGIN_Click
            // 
            this.BTN_LOGIN_Click.Location = new System.Drawing.Point(274, 155);
            this.BTN_LOGIN_Click.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_LOGIN_Click.Name = "BTN_LOGIN_Click";
            this.BTN_LOGIN_Click.Size = new System.Drawing.Size(68, 37);
            this.BTN_LOGIN_Click.TabIndex = 18;
            this.BTN_LOGIN_Click.Text = "Login";
            this.BTN_LOGIN_Click.UseVisualStyleBackColor = true;
            this.BTN_LOGIN_Click.Click += new System.EventHandler(this.BTN_LOGIN_Click_Click);
            // 
            // FORM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(412, 253);
            this.Controls.Add(this.BTN_LOGIN_Click);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LABEL_PASSWORD);
            this.Controls.Add(this.LABEL_USERNAME);
            this.Controls.Add(this.CB_PASSWORD);
            this.Controls.Add(this.TB_PASSWORD);
            this.Controls.Add(this.TB_USERNAME);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FORM_LOGIN";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_PASSWORD;
        private System.Windows.Forms.TextBox TB_USERNAME;
        private System.Windows.Forms.CheckBox CB_PASSWORD;
        private System.Windows.Forms.Label LABEL_USERNAME;
        private System.Windows.Forms.Label LABEL_PASSWORD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_LOGIN_Click;
    }
}

