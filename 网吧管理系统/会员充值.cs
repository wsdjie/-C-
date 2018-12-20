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
    public partial class 会员充值 : Form
    {
        public 会员充值()
        {
            InitializeComponent();
        }

        private void 会员充值_Load(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            string sql = "select CardNumber from CardInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cbo_id.DataSource = ds.Tables[0].DefaultView;
            cbo_id.DisplayMember = "CardNumber";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            int money = int.Parse(nub_money.Value.ToString());
            string id = cbo_id.Text;
            string sql = string.Format("update CardInfo set CardBalance=CardBalance+'{0}' where CardNumber='{1}' ", money, id);
            SqlCommand cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("充值成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
            }
            else
            {
                MessageBox.Show("充值失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
