namespace 网吧管理系统
{
    partial class 会员充值
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.cbo_id = new System.Windows.Forms.ComboBox();
            this.lbl_money = new System.Windows.Forms.Label();
            this.nub_money = new System.Windows.Forms.NumericUpDown();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nub_money)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 40);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(41, 12);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "卡号：";
            // 
            // cbo_id
            // 
            this.cbo_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_id.FormattingEnabled = true;
            this.cbo_id.Location = new System.Drawing.Point(59, 37);
            this.cbo_id.Name = "cbo_id";
            this.cbo_id.Size = new System.Drawing.Size(107, 20);
            this.cbo_id.TabIndex = 1;
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Location = new System.Drawing.Point(183, 40);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(65, 12);
            this.lbl_money.TabIndex = 2;
            this.lbl_money.Text = "充值金额：";
            // 
            // nub_money
            // 
            this.nub_money.Location = new System.Drawing.Point(254, 36);
            this.nub_money.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nub_money.Name = "nub_money";
            this.nub_money.Size = new System.Drawing.Size(107, 21);
            this.nub_money.TabIndex = 3;
            this.nub_money.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(91, 91);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(221, 91);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 5;
            this.btn_no.Text = "取消";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // 会员充值
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 137);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.nub_money);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.cbo_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "会员充值";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员充值";
            this.Load += new System.EventHandler(this.会员充值_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nub_money)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ComboBox cbo_id;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.NumericUpDown nub_money;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_no;
    }
}