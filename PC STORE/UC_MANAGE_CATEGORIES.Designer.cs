namespace PC_STORE
{
    partial class UC_MANAGE_CATEGORIES
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_INSERT_CTG = new System.Windows.Forms.Button();
            this.BTN_UPDATE_CTG = new System.Windows.Forms.Button();
            this.BTN_DELETE_CTG = new System.Windows.Forms.Button();
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_CATG_ID = new System.Windows.Forms.TextBox();
            this.DGV_CATEGORIES = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_CATG_NAME = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_INSERT_CTG
            // 
            this.BTN_INSERT_CTG.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_INSERT_CTG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INSERT_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_INSERT_CTG.Location = new System.Drawing.Point(1058, 481);
            this.BTN_INSERT_CTG.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_INSERT_CTG.Name = "BTN_INSERT_CTG";
            this.BTN_INSERT_CTG.Size = new System.Drawing.Size(107, 33);
            this.BTN_INSERT_CTG.TabIndex = 36;
            this.BTN_INSERT_CTG.Text = "הוסף";
            this.BTN_INSERT_CTG.UseVisualStyleBackColor = false;
            this.BTN_INSERT_CTG.Click += new System.EventHandler(this.BTN_INSERT_CTG_Click);
            // 
            // BTN_UPDATE_CTG
            // 
            this.BTN_UPDATE_CTG.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_UPDATE_CTG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UPDATE_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_UPDATE_CTG.Location = new System.Drawing.Point(947, 481);
            this.BTN_UPDATE_CTG.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_UPDATE_CTG.Name = "BTN_UPDATE_CTG";
            this.BTN_UPDATE_CTG.Size = new System.Drawing.Size(107, 33);
            this.BTN_UPDATE_CTG.TabIndex = 35;
            this.BTN_UPDATE_CTG.Text = "עדכן";
            this.BTN_UPDATE_CTG.UseVisualStyleBackColor = false;
            this.BTN_UPDATE_CTG.Click += new System.EventHandler(this.BTN_UPDATE_CTG_Click);
            // 
            // BTN_DELETE_CTG
            // 
            this.BTN_DELETE_CTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DELETE_CTG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE_CTG.Location = new System.Drawing.Point(792, 481);
            this.BTN_DELETE_CTG.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DELETE_CTG.Name = "BTN_DELETE_CTG";
            this.BTN_DELETE_CTG.Size = new System.Drawing.Size(107, 33);
            this.BTN_DELETE_CTG.TabIndex = 34;
            this.BTN_DELETE_CTG.Text = "מחק";
            this.BTN_DELETE_CTG.UseVisualStyleBackColor = false;
            this.BTN_DELETE_CTG.Click += new System.EventHandler(this.BTN_DELETE_CTG_Click);
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_USERNAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.LABEL_USERNAME.Location = new System.Drawing.Point(1295, 117);
            this.LABEL_USERNAME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(99, 24);
            this.LABEL_USERNAME.TabIndex = 37;
            this.LABEL_USERNAME.Text = ":קוד קטגוריה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(1295, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = ":שם קטגוריה";
            // 
            // TB_CATG_ID
            // 
            this.TB_CATG_ID.BackColor = System.Drawing.SystemColors.Control;
            this.TB_CATG_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_CATG_ID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CATG_ID.ForeColor = System.Drawing.Color.Black;
            this.TB_CATG_ID.Location = new System.Drawing.Point(1195, 144);
            this.TB_CATG_ID.Name = "TB_CATG_ID";
            this.TB_CATG_ID.ReadOnly = true;
            this.TB_CATG_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_CATG_ID.Size = new System.Drawing.Size(200, 26);
            this.TB_CATG_ID.TabIndex = 42;
            this.TB_CATG_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DGV_CATEGORIES
            // 
            this.DGV_CATEGORIES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CATEGORIES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CATEGORIES.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_CATEGORIES.Location = new System.Drawing.Point(792, 144);
            this.DGV_CATEGORIES.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_CATEGORIES.Name = "DGV_CATEGORIES";
            this.DGV_CATEGORIES.ReadOnly = true;
            this.DGV_CATEGORIES.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_CATEGORIES.RowHeadersWidth = 51;
            this.DGV_CATEGORIES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CATEGORIES.Size = new System.Drawing.Size(373, 333);
            this.DGV_CATEGORIES.TabIndex = 56;
            this.DGV_CATEGORIES.Click += new System.EventHandler(this.DGV_CATEGORIES_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(1340, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 44);
            this.label5.TabIndex = 83;
            this.label5.Text = "קטגוריות";
            // 
            // TB_CATG_NAME
            // 
            this.TB_CATG_NAME.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CATG_NAME.Location = new System.Drawing.Point(1195, 215);
            this.TB_CATG_NAME.Name = "TB_CATG_NAME";
            this.TB_CATG_NAME.Size = new System.Drawing.Size(200, 25);
            this.TB_CATG_NAME.TabIndex = 84;
            this.TB_CATG_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UC_MANAGE_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_CATG_NAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV_CATEGORIES);
            this.Controls.Add(this.TB_CATG_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LABEL_USERNAME);
            this.Controls.Add(this.BTN_INSERT_CTG);
            this.Controls.Add(this.BTN_UPDATE_CTG);
            this.Controls.Add(this.BTN_DELETE_CTG);
            this.Name = "UC_MANAGE_CATEGORIES";
            this.Size = new System.Drawing.Size(1485, 899);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_INSERT_CTG;
        private System.Windows.Forms.Button BTN_UPDATE_CTG;
        private System.Windows.Forms.Button BTN_DELETE_CTG;
        private System.Windows.Forms.Label LABEL_USERNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_CATG_ID;
        private System.Windows.Forms.DataGridView DGV_CATEGORIES;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_CATG_NAME;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
