using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 网吧管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dl_Click(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string name = txt_name.Text;
            string pwd = txt_pwd.Text;
            string sql = string.Format("select * from userInfo where userName='{0}' and userPwd='{1}'", name, pwd);
            SqlCommand cmd = new SqlCommand(sql, con);
            object obj = cmd.ExecuteScalar();
            if (obj == null)
            {
                MessageBox.Show("用户名或密码错误，请检查后重新输入", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                主页面 xf = new 主页面();
                xf.Show();
                this.Hide();
            }
            con.Close();
        }
    }
}
