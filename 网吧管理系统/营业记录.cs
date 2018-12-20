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
    public partial class 营业记录 : Form
    {
        public 营业记录()
        {
            InitializeComponent();
        }

        private void 营业记录_Load(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            string sql = "select recordId as 上机记录编号,cardId as 会员卡编号,PCId as 计算机编号,beginTime as 上机时间, endTime as 下机时间,free as 上机费用 from recordInfo";
            SqlDataAdapter adadpter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adadpter.Fill(ds);
            dgv_open.DataSource = ds.Tables[0].DefaultView;
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            string sql = "select recordId as 上机记录编号,cardId as 会员卡编号,PCId as 计算机编号,beginTime as 上机时间, endTime as 下机时间,free as 上机费用 from recordInfo";
            SqlDataAdapter adadpter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adadpter.Fill(ds);
            dgv_open.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
