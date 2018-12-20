namespace 网吧管理系统
{
    partial class 上机
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
            this.components = new System.ComponentModel.Container();
            this.lbl_bianhao = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.cbo_bianhao = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_bianhao
            // 
            this.lbl_bianhao.AutoSize = true;
            this.lbl_bianhao.Location = new System.Drawing.Point(34, 30);
            this.lbl_bianhao.Name = "lbl_bianhao";
            this.lbl_bianhao.Size = new System.Drawing.Size(65, 12);
            this.lbl_bianhao.TabIndex = 0;
            this.lbl_bianhao.Text = "机器编号：";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(34, 81);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(53, 12);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "会员号：";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(138, 78);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(154, 21);
            this.txt_id.TabIndex = 3;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(34, 134);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(41, 12);
            this.lbl_pwd.TabIndex = 4;
            this.lbl_pwd.Text = "密码：";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(138, 131);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(154, 21);
            this.txt_pwd.TabIndex = 5;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(34, 184);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(65, 12);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "上机时间：";
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(138, 181);
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(154, 21);
            this.txt_time.TabIndex = 7;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(36, 227);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(217, 227);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 9;
            this.btn_no.Text = "取消";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // cbo_bianhao
            // 
            this.cbo_bianhao.FormattingEnabled = true;
            this.cbo_bianhao.Location = new System.Drawing.Point(138, 27);
            this.cbo_bianhao.Name = "cbo_bianhao";
            this.cbo_bianhao.Size = new System.Drawing.Size(154, 20);
            this.cbo_bianhao.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 上机
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 262);
            this.Controls.Add(this.cbo_bianhao);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_bianhao);
            this.Name = "上机";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上机";
            this.Load += new System.EventHandler(this.上机_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bianhao;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.ComboBox cbo_bianhao;
        private System.Windows.Forms.Timer timer1;
    }
}