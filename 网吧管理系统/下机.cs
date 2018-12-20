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
    public partial class 下机 : Form
    {
        public 下机()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_xtime.Text = DateTime.Now.ToString();
        }

        private void 下机_Load(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            string sql = "select PCId from PCInfo where PCUse=1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cbo_bianhao.DataSource = ds.Tables[0].DefaultView;
            cbo_bianhao.DisplayMember = "PCId";
            txt_xtime.Text = DateTime.Now.ToString();
        }

        private void cbo_bianhao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            string sql = string.Format("select * from recordInfo where PCId={0}", cbo_bianhao.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            txt_stime.Text = ds.Tables[0].Rows[0]["beginTime"].ToString();
            txt_money.Text = ds.Tables[0].Rows[0]["free"].ToString();
            string sqlcard = string.Format("select * from CardInfo where cardId={0}", ds.Tables[0].Rows[0]["cardId"]);
            SqlDataAdapter adapter1 = new SqlDataAdapter(sqlcard, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1);
            txt_id.Text = ds1.Tables[0].Rows[0]["cardNumber"].ToString();
            string sqltime = string.Format("select datediff(mi,begintime,getdate())/60+1 from recordInfo where PCId={0}", cbo_bianhao.Text);
            SqlDataAdapter adapter2 = new SqlDataAdapter(sqltime, con);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2);
            txt_sumtime.Text = ds2.Tables[0].Rows[0][0].ToString();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = string.Format("update recordInfo set endtime=getdate() where PCId={0} and endtime is null", cbo_bianhao.Text);
            SqlCommand cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            string sql1 = string.Format("update PCInfo set PCUse=0 where PCId={0}", cbo_bianhao.Text);
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            int j = cmd1.ExecuteNonQuery();
            string sql2 = string.Format("update CardInfo set cardBalance=cardBalance-{0} where CardId={1}", int.Parse(txt_money.Text), cbo_bianhao.Text);
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            int k = cmd2.ExecuteNonQuery();
            if (i > 0 && j > 0 && k > 0)
            {
                MessageBox.Show("下机成功", "下机提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
            }
            else
            {
                MessageBox.Show("下机失败", "下机提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
