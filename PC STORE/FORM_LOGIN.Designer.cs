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
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.LABEL_PASSWORD = new System.Windows.Forms.Label();
            this.BTN_LOGIN_Click = new System.Windows.Forms.Button();
            this.BTN_END_SHIFT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_PASSWORD = new System.Windows.Forms.CheckBox();
            this.LBL_ENTER = new System.Windows.Forms.Label();
            this.LBL_EXIT = new System.Windows.Forms.Label();
            this.TB_USERNAME = new System.Windows.Forms.TextBox();
            this.TB_PASSWORD = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_USERNAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.LABEL_USERNAME.Location = new System.Drawing.Point(752, 143);
            this.LABEL_USERNAME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(138, 30);
            this.LABEL_USERNAME.TabIndex = 13;
            this.LABEL_USERNAME.Text = ":שם משתמש";
            // 
            // LABEL_PASSWORD
            // 
            this.LABEL_PASSWORD.AutoSize = true;
            this.LABEL_PASSWORD.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_PASSWORD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.LABEL_PASSWORD.Location = new System.Drawing.Point(805, 226);
            this.LABEL_PASSWORD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABEL_PASSWORD.Name = "LABEL_PASSWORD";
            this.LABEL_PASSWORD.Size = new System.Drawing.Size(85, 30);
            this.LABEL_PASSWORD.TabIndex = 15;
            this.LABEL_PASSWORD.Text = ":סיסמא";
            // 
            // BTN_LOGIN_Click
            // 
            this.BTN_LOGIN_Click.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_LOGIN_Click.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOGIN_Click.ForeColor = System.Drawing.Color.White;
            this.BTN_LOGIN_Click.Location = new System.Drawing.Point(506, 364);
            this.BTN_LOGIN_Click.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_LOGIN_Click.Name = "BTN_LOGIN_Click";
            this.BTN_LOGIN_Click.Size = new System.Drawing.Size(384, 34);
            this.BTN_LOGIN_Click.TabIndex = 18;
            this.BTN_LOGIN_Click.Text = "כניסה";
            this.BTN_LOGIN_Click.UseVisualStyleBackColor = false;
            this.BTN_LOGIN_Click.Click += new System.EventHandler(this.BTN_LOGIN_Click_Click);
            // 
            // BTN_END_SHIFT
            // 
            this.BTN_END_SHIFT.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_END_SHIFT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_END_SHIFT.ForeColor = System.Drawing.Color.White;
            this.BTN_END_SHIFT.Location = new System.Drawing.Point(506, 364);
            this.BTN_END_SHIFT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_END_SHIFT.Name = "BTN_END_SHIFT";
            this.BTN_END_SHIFT.Size = new System.Drawing.Size(389, 34);
            this.BTN_END_SHIFT.TabIndex = 20;
            this.BTN_END_SHIFT.Text = "יציאה";
            this.BTN_END_SHIFT.UseVisualStyleBackColor = false;
            this.BTN_END_SHIFT.Visible = false;
            this.BTN_END_SHIFT.Click += new System.EventHandler(this.BTN_END_SHIFT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(196)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 516);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PC_STORE.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(22, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(531, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = ":הראה סיסמא";
            // 
            // CB_PASSWORD
            // 
            this.CB_PASSWORD.AutoSize = true;
            this.CB_PASSWORD.Location = new System.Drawing.Point(511, 317);
            this.CB_PASSWORD.Name = "CB_PASSWORD";
            this.CB_PASSWORD.Size = new System.Drawing.Size(15, 14);
            this.CB_PASSWORD.TabIndex = 29;
            this.CB_PASSWORD.UseVisualStyleBackColor = true;
            this.CB_PASSWORD.CheckedChanged += new System.EventHandler(this.CB_PASSWORD_CheckedChanged);
            // 
            // LBL_ENTER
            // 
            this.LBL_ENTER.AutoSize = true;
            this.LBL_ENTER.Font = new System.Drawing.Font("Century Gothic", 36F);
            this.LBL_ENTER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.LBL_ENTER.Location = new System.Drawing.Point(757, 39);
            this.LBL_ENTER.Name = "LBL_ENTER";
            this.LBL_ENTER.Size = new System.Drawing.Size(128, 58);
            this.LBL_ENTER.TabIndex = 30;
            this.LBL_ENTER.Text = "כניסה";
            // 
            // LBL_EXIT
            // 
            this.LBL_EXIT.AutoSize = true;
            this.LBL_EXIT.Font = new System.Drawing.Font("Century Gothic", 36F);
            this.LBL_EXIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.LBL_EXIT.Location = new System.Drawing.Point(763, 39);
            this.LBL_EXIT.Name = "LBL_EXIT";
            this.LBL_EXIT.Size = new System.Drawing.Size(122, 58);
            this.LBL_EXIT.TabIndex = 31;
            this.LBL_EXIT.Text = "יציאה";
            // 
            // TB_USERNAME
            // 
            this.TB_USERNAME.Font = new System.Drawing.Font("Arial", 14.25F);
            this.TB_USERNAME.Location = new System.Drawing.Point(506, 184);
            this.TB_USERNAME.Name = "TB_USERNAME";
            this.TB_USERNAME.Size = new System.Drawing.Size(383, 29);
            this.TB_USERNAME.TabIndex = 32;
            this.TB_USERNAME.Text = "admin";
            // 
            // TB_PASSWORD
            // 
            this.TB_PASSWORD.Font = new System.Drawing.Font("Arial", 14.25F);
            this.TB_PASSWORD.Location = new System.Drawing.Point(507, 259);
            this.TB_PASSWORD.Name = "TB_PASSWORD";
            this.TB_PASSWORD.PasswordChar = '*';
            this.TB_PASSWORD.Size = new System.Drawing.Size(378, 29);
            this.TB_PASSWORD.TabIndex = 33;
            this.TB_PASSWORD.Text = "admin";
            // 
            // FORM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(924, 516);
            this.Controls.Add(this.TB_PASSWORD);
            this.Controls.Add(this.TB_USERNAME);
            this.Controls.Add(this.LBL_ENTER);
            this.Controls.Add(this.CB_PASSWORD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_END_SHIFT);
            this.Controls.Add(this.BTN_LOGIN_Click);
            this.Controls.Add(this.LABEL_PASSWORD);
            this.Controls.Add(this.LABEL_USERNAME);
            this.Controls.Add(this.LBL_EXIT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORM_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "כניסה/יציאה";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LABEL_USERNAME;
        private System.Windows.Forms.Label LABEL_PASSWORD;
        public System.Windows.Forms.Button BTN_END_SHIFT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BTN_LOGIN_Click;
        private System.Windows.Forms.CheckBox CB_PASSWORD;
        private System.Windows.Forms.TextBox TB_USERNAME;
        private System.Windows.Forms.TextBox TB_PASSWORD;
        public System.Windows.Forms.Label LBL_ENTER;
        public System.Windows.Forms.Label LBL_EXIT;
    }
}

