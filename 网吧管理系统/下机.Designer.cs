namespace 网吧管理系统
{
    partial class 下机
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
            this.cbo_bianhao = new System.Windows.Forms.ComboBox();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_xtime = new System.Windows.Forms.TextBox();
            this.lbl_xtime = new System.Windows.Forms.Label();
            this.txt_stime = new System.Windows.Forms.TextBox();
            this.lbl_stime = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_bianhao = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_sumtime = new System.Windows.Forms.Label();
            this.txt_sumtime = new System.Windows.Forms.TextBox();
            this.lbl_money = new System.Windows.Forms.Label();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbo_bianhao
            // 
            this.cbo_bianhao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_bianhao.FormattingEnabled = true;
            this.cbo_bianhao.Location = new System.Drawing.Point(137, 28);
            this.cbo_bianhao.Name = "cbo_bianhao";
            this.cbo_bianhao.Size = new System.Drawing.Size(154, 20);
            this.cbo_bianhao.TabIndex = 20;
            this.cbo_bianhao.SelectedIndexChanged += new System.EventHandler(this.cbo_bianhao_SelectedIndexChanged);
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(216, 267);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 19;
            this.btn_no.Text = "取消";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(35, 267);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 18;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_xtime
            // 
            this.txt_xtime.Location = new System.Drawing.Point(137, 182);
            this.txt_xtime.Name = "txt_xtime";
            this.txt_xtime.ReadOnly = true;
            this.txt_xtime.Size = new System.Drawing.Size(154, 21);
            this.txt_xtime.TabIndex = 17;
            // 
            // lbl_xtime
            // 
            this.lbl_xtime.AutoSize = true;
            this.lbl_xtime.Location = new System.Drawing.Point(33, 185);
            this.lbl_xtime.Name = "lbl_xtime";
            this.lbl_xtime.Size = new System.Drawing.Size(65, 12);
            this.lbl_xtime.TabIndex = 16;
            this.lbl_xtime.Text = "下机时间：";
            // 
            // txt_stime
            // 
            this.txt_stime.Location = new System.Drawing.Point(137, 132);
            this.txt_stime.Name = "txt_stime";
            this.txt_stime.ReadOnly = true;
            this.txt_stime.Size = new System.Drawing.Size(154, 21);
            this.txt_stime.TabIndex = 15;
            // 
            // lbl_stime
            // 
            this.lbl_stime.AutoSize = true;
            this.lbl_stime.Location = new System.Drawing.Point(33, 135);
            this.lbl_stime.Name = "lbl_stime";
            this.lbl_stime.Size = new System.Drawing.Size(65, 12);
            this.lbl_stime.TabIndex = 14;
            this.lbl_stime.Text = "上机时间：";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(137, 79);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(154, 21);
            this.txt_id.TabIndex = 13;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(33, 82);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(53, 12);
            this.lbl_id.TabIndex = 12;
            this.lbl_id.Text = "会员号：";
            // 
            // lbl_bianhao
            // 
            this.lbl_bianhao.AutoSize = true;
            this.lbl_bianhao.Location = new System.Drawing.Point(33, 31);
            this.lbl_bianhao.Name = "lbl_bianhao";
            this.lbl_bianhao.Size = new System.Drawing.Size(65, 12);
            this.lbl_bianhao.TabIndex = 11;
            this.lbl_bianhao.Text = "机器编号：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_sumtime
            // 
            this.lbl_sumtime.AutoSize = true;
            this.lbl_sumtime.Location = new System.Drawing.Point(33, 231);
            this.lbl_sumtime.Name = "lbl_sumtime";
            this.lbl_sumtime.Size = new System.Drawing.Size(41, 12);
            this.lbl_sumtime.TabIndex = 21;
            this.lbl_sumtime.Text = "用时：";
            // 
            // txt_sumtime
            // 
            this.txt_sumtime.Location = new System.Drawing.Point(80, 228);
            this.txt_sumtime.Name = "txt_sumtime";
            this.txt_sumtime.ReadOnly = true;
            this.txt_sumtime.Size = new System.Drawing.Size(67, 21);
            this.txt_sumtime.TabIndex = 22;
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Location = new System.Drawing.Point(177, 231);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(41, 12);
            this.lbl_money.TabIndex = 23;
            this.lbl_money.Text = "费用：";
            // 
            // txt_money
            // 
            this.txt_money.Location = new System.Drawing.Point(224, 228);
            this.txt_money.Name = "txt_money";
            this.txt_money.ReadOnly = true;
            this.txt_money.Size = new System.Drawing.Size(67, 21);
            this.txt_money.TabIndex = 24;
            // 
            // 下机
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 302);
            this.Controls.Add(this.txt_money);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.txt_sumtime);
            this.Controls.Add(this.lbl_sumtime);
            this.Controls.Add(this.cbo_bianhao);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_xtime);
            this.Controls.Add(this.lbl_xtime);
            this.Controls.Add(this.txt_stime);
            this.Controls.Add(this.lbl_stime);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_bianhao);
            this.Name = "下机";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "下机";
            this.Load += new System.EventHandler(this.下机_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_bianhao;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_xtime;
        private System.Windows.Forms.Label lbl_xtime;
        private System.Windows.Forms.TextBox txt_stime;
        private System.Windows.Forms.Label lbl_stime;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_bianhao;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_sumtime;
        private System.Windows.Forms.TextBox txt_sumtime;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.TextBox txt_money;
    }
}