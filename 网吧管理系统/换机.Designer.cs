namespace 网吧管理系统
{
    partial class 换机
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
            this.lbl_one = new System.Windows.Forms.Label();
            this.cbo_one = new System.Windows.Forms.ComboBox();
            this.lbl_two = new System.Windows.Forms.Label();
            this.cbo_two = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_one
            // 
            this.lbl_one.AutoSize = true;
            this.lbl_one.Location = new System.Drawing.Point(28, 44);
            this.lbl_one.Name = "lbl_one";
            this.lbl_one.Size = new System.Drawing.Size(17, 12);
            this.lbl_one.TabIndex = 0;
            this.lbl_one.Text = "从";
            // 
            // cbo_one
            // 
            this.cbo_one.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_one.FormattingEnabled = true;
            this.cbo_one.Location = new System.Drawing.Point(51, 41);
            this.cbo_one.Name = "cbo_one";
            this.cbo_one.Size = new System.Drawing.Size(121, 20);
            this.cbo_one.TabIndex = 1;
            // 
            // lbl_two
            // 
            this.lbl_two.AutoSize = true;
            this.lbl_two.Location = new System.Drawing.Point(190, 44);
            this.lbl_two.Name = "lbl_two";
            this.lbl_two.Size = new System.Drawing.Size(17, 12);
            this.lbl_two.TabIndex = 2;
            this.lbl_two.Text = "到";
            // 
            // cbo_two
            // 
            this.cbo_two.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_two.FormattingEnabled = true;
            this.cbo_two.Location = new System.Drawing.Point(225, 41);
            this.cbo_two.Name = "cbo_two";
            this.cbo_two.Size = new System.Drawing.Size(121, 20);
            this.cbo_two.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(97, 76);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(225, 76);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 5;
            this.btn_no.Text = "取消";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // 换机
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 111);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cbo_two);
            this.Controls.Add(this.lbl_two);
            this.Controls.Add(this.cbo_one);
            this.Controls.Add(this.lbl_one);
            this.Name = "换机";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "换机";
            this.Load += new System.EventHandler(this.换机_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_one;
        private System.Windows.Forms.ComboBox cbo_one;
        private System.Windows.Forms.Label lbl_two;
        private System.Windows.Forms.ComboBox cbo_two;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_no;
    }
}