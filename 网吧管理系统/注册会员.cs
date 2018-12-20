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
    public partial class 注册会员 : Form
    {
        public 注册会员()
        {
            InitializeComponent();
        }

        private void btn_od_Click(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string id = txt_id.Text;
            string pwd = txt_pwd.Text;
            string twopwd = txt_twopwd.Text;
            string money = numericUpDown1.Value.ToString();
            if (id == "" || pwd == "" || twopwd == "")
            {
                MessageBox.Show("请填写完整信息", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pwd != twopwd)
            {
                MessageBox.Show("两次密码不相同，请检查", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string one = string.Format("select * from cardInfo where CardNumber='{0}'",id);
            SqlDataAdapter adapter = new SqlDataAdapter(one,con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("该用户已存在", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_id.Clear();
                txt_pwd.Clear();
                txt_twopwd.Clear();
            }
            else
            {
                string sql = string.Format("insert into cardInfo values('{0}','{1}','{2}',default)", id, pwd, money);
                SqlCommand cmd = new SqlCommand(sql, con);
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("注册失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("注册成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            con.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
