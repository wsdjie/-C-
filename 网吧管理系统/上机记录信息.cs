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
    public partial class 上机记录信息 : Form
    {
        public 上机记录信息()
        {
            InitializeComponent();
        }

        private void 上机记录信息_Load(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            string sql = "select cardId as 会员号,PCId as 电脑编号,beginTime as 开始时间,endTime as 结束时间,free as 上机费用 from recordInfo";
            SqlDataAdapter adadpter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adadpter.Fill(ds);
            dgv_begin.DataSource = ds.Tables[0].DefaultView;
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            string sql = "select cardId as 会员号,PCId as 电脑编号,beginTime as 开始时间,endTime as 结束时间,free as 上机费用 from recordInfo";
            SqlDataAdapter adadpter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adadpter.Fill(ds);
            dgv_begin.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
