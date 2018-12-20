namespace 网吧管理系统
{
    partial class 注册会员
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
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_twopwd = new System.Windows.Forms.Label();
            this.txt_twopwd = new System.Windows.Forms.TextBox();
            this.lbl_money = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_od = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(126, 78);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(177, 21);
            this.txt_pwd.TabIndex = 9;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(45, 81);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(41, 12);
            this.lbl_pwd.TabIndex = 8;
            this.lbl_pwd.Text = "密码：";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(126, 25);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(177, 21);
            this.txt_id.TabIndex = 7;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(45, 28);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(65, 12);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "会员卡号：";
            // 
            // lbl_twopwd
            // 
            this.lbl_twopwd.AutoSize = true;
            this.lbl_twopwd.Location = new System.Drawing.Point(45, 134);
            this.lbl_twopwd.Name = "lbl_twopwd";
            this.lbl_twopwd.Size = new System.Drawing.Size(65, 12);
            this.lbl_twopwd.TabIndex = 10;
            this.lbl_twopwd.Text = "重复密码：";
            // 
            // txt_twopwd
            // 
            this.txt_twopwd.Location = new System.Drawing.Point(126, 131);
            this.txt_twopwd.Name = "txt_twopwd";
            this.txt_twopwd.Size = new System.Drawing.Size(177, 21);
            this.txt_twopwd.TabIndex = 11;
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Location = new System.Drawing.Point(45, 189);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(65, 12);
            this.lbl_money.TabIndex = 12;
            this.lbl_money.Text = "初始充值：";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(126, 187);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(177, 21);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btn_od
            // 
            this.btn_od.Location = new System.Drawing.Point(126, 234);
            this.btn_od.Name = "btn_od";
            this.btn_od.Size = new System.Drawing.Size(75, 23);
            this.btn_od.TabIndex = 14;
            this.btn_od.Text = "确定";
            this.btn_od.UseVisualStyleBackColor = true;
            this.btn_od.Click += new System.EventHandler(this.btn_od_Click);
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(228, 234);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 15;
            this.btn_no.Text = "取消";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // 注册会员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 281);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_od);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.txt_twopwd);
            this.Controls.Add(this.lbl_twopwd);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "注册会员";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册会员";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_twopwd;
        private System.Windows.Forms.TextBox txt_twopwd;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_od;
        private System.Windows.Forms.Button btn_no;
    }
}