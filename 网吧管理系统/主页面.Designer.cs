namespace 网吧管理系统
{
    partial class 主页面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(主页面));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.业务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.换机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.会员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.营业记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算机信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上机记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.会员卡信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.业务ToolStripMenuItem,
            this.用户ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 业务ToolStripMenuItem
            // 
            this.业务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上机ToolStripMenuItem,
            this.下机ToolStripMenuItem,
            this.换机ToolStripMenuItem});
            this.业务ToolStripMenuItem.Name = "业务ToolStripMenuItem";
            this.业务ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.业务ToolStripMenuItem.Text = "业务";
            // 
            // 上机ToolStripMenuItem
            // 
            this.上机ToolStripMenuItem.Name = "上机ToolStripMenuItem";
            this.上机ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.上机ToolStripMenuItem.Text = "上机";
            this.上机ToolStripMenuItem.Click += new System.EventHandler(this.上机ToolStripMenuItem_Click);
            // 
            // 下机ToolStripMenuItem
            // 
            this.下机ToolStripMenuItem.Name = "下机ToolStripMenuItem";
            this.下机ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.下机ToolStripMenuItem.Text = "下机";
            this.下机ToolStripMenuItem.Click += new System.EventHandler(this.下机ToolStripMenuItem_Click);
            // 
            // 换机ToolStripMenuItem
            // 
            this.换机ToolStripMenuItem.Name = "换机ToolStripMenuItem";
            this.换机ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.换机ToolStripMenuItem.Text = "换机";
            this.换机ToolStripMenuItem.Click += new System.EventHandler(this.换机ToolStripMenuItem_Click);
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.会员信息ToolStripMenuItem});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // 会员信息ToolStripMenuItem
            // 
            this.会员信息ToolStripMenuItem.Name = "会员信息ToolStripMenuItem";
            this.会员信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.会员信息ToolStripMenuItem.Text = "会员信息";
            this.会员信息ToolStripMenuItem.Click += new System.EventHandler(this.会员信息ToolStripMenuItem_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.营业记录ToolStripMenuItem,
            this.计算机信息ToolStripMenuItem,
            this.上机记录ToolStripMenuItem,
            this.会员卡信息ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 营业记录ToolStripMenuItem
            // 
            this.营业记录ToolStripMenuItem.Name = "营业记录ToolStripMenuItem";
            this.营业记录ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.营业记录ToolStripMenuItem.Text = "营业记录";
            this.营业记录ToolStripMenuItem.Click += new System.EventHandler(this.营业记录ToolStripMenuItem_Click);
            // 
            // 计算机信息ToolStripMenuItem
            // 
            this.计算机信息ToolStripMenuItem.Name = "计算机信息ToolStripMenuItem";
            this.计算机信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.计算机信息ToolStripMenuItem.Text = "计算机信息";
            this.计算机信息ToolStripMenuItem.Click += new System.EventHandler(this.计算机信息ToolStripMenuItem_Click);
            // 
            // 上机记录ToolStripMenuItem
            // 
            this.上机记录ToolStripMenuItem.Name = "上机记录ToolStripMenuItem";
            this.上机记录ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.上机记录ToolStripMenuItem.Text = "上机记录";
            this.上机记录ToolStripMenuItem.Click += new System.EventHandler(this.上机记录ToolStripMenuItem_Click);
            // 
            // 会员卡信息ToolStripMenuItem
            // 
            this.会员卡信息ToolStripMenuItem.Name = "会员卡信息ToolStripMenuItem";
            this.会员卡信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.会员卡信息ToolStripMenuItem.Text = "会员卡信息";
            this.会员卡信息ToolStripMenuItem.Click += new System.EventHandler(this.会员卡信息ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(638, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "上机";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "下机";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "换机";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton4.Text = "注册会员";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton5.Text = "会员充值";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(638, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "欢迎";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "欢迎";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(510, 374);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(53, 12);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "lbl_time";
            // 
            // 主页面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 392);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "主页面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网吧管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 业务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 换机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.ToolStripMenuItem 营业记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算机信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上机记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会员卡信息ToolStripMenuItem;
    }
}