namespace 网吧管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_denglu = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_dl = new System.Windows.Forms.Button();
            this.btn_qx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_denglu
            // 
            this.lbl_denglu.AutoSize = true;
            this.lbl_denglu.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_denglu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_denglu.Location = new System.Drawing.Point(16, 13);
            this.lbl_denglu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_denglu.Name = "lbl_denglu";
            this.lbl_denglu.Size = new System.Drawing.Size(159, 19);
            this.lbl_denglu.TabIndex = 0;
            this.lbl_denglu.Text = "欢迎使用网吧管理系统";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_name.Location = new System.Drawing.Point(59, 64);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(56, 17);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "用户名：";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(139, 61);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(169, 23);
            this.txt_name.TabIndex = 2;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_pwd.Location = new System.Drawing.Point(59, 121);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(44, 17);
            this.lbl_pwd.TabIndex = 3;
            this.lbl_pwd.Text = "密码：";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(139, 118);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(169, 23);
            this.txt_pwd.TabIndex = 4;
            // 
            // btn_dl
            // 
            this.btn_dl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_dl.Location = new System.Drawing.Point(139, 183);
            this.btn_dl.Name = "btn_dl";
            this.btn_dl.Size = new System.Drawing.Size(75, 25);
            this.btn_dl.TabIndex = 5;
            this.btn_dl.Text = "登录";
            this.btn_dl.UseVisualStyleBackColor = true;
            this.btn_dl.Click += new System.EventHandler(this.btn_dl_Click);
            // 
            // btn_qx
            // 
            this.btn_qx.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_qx.Location = new System.Drawing.Point(233, 183);
            this.btn_qx.Name = "btn_qx";
            this.btn_qx.Size = new System.Drawing.Size(75, 25);
            this.btn_qx.TabIndex = 6;
            this.btn_qx.Text = "取消";
            this.btn_qx.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 220);
            this.Controls.Add(this.btn_dl);
            this.Controls.Add(this.btn_qx);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_denglu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_denglu;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_dl;
        private System.Windows.Forms.Button btn_qx;
    }
}

