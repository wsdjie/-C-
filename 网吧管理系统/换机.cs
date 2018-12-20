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
    public partial class 换机 : Form
    {
        public 换机()
        {
            InitializeComponent();
        }

        private void 换机_Load(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            string onesql = "select * from PCInfo where PCUse=1";
            SqlDataAdapter adapter = new SqlDataAdapter(onesql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cbo_one.DataSource = ds.Tables[0].DefaultView;
            cbo_one.DisplayMember = "PCId";

            string twosql = "select * from PCInfo where PCUse=0";
            SqlDataAdapter adapter1 = new SqlDataAdapter(twosql, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1);
            cbo_two.DataSource = ds1.Tables[0].DefaultView;
            cbo_two.DisplayMember = "PCId";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string one = cbo_one.Text;
            string two = cbo_two.Text;
            string sql = string.Format("update PCInfo set PCUse=0 where PCId='{0}'", one);
            SqlCommand cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            string sql1 = string.Format("update PCInfo set PCUse=1 where PCId='{0}'", two);
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            int j = cmd1.ExecuteNonQuery();
            string sql2 = string.Format("update recordInfo set PCId='{0}' where PCId='{1}'", two, one);
            SqlCommand cmd3 = new SqlCommand(sql2, con);
            int k = cmd3.ExecuteNonQuery();
            if (i > 0 && j > 0 && k > 0)
            {
                MessageBox.Show("换机成功", "换机提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
            }
            else
            {
                MessageBox.Show("换机失败", "换机提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
