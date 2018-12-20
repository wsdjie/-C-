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
    public partial class 计算机信息表 : Form
    {
        public 计算机信息表()
        {
            InitializeComponent();
        }

        private void 计算机信息表_Load(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            string sql = "select PCUse as 电脑状态,PCNote as 机器位置 from PCInfo";
            SqlDataAdapter adadpter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adadpter.Fill(ds);
            dgv_computer.DataSource = ds.Tables[0].DefaultView;
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            string sql = "select PCUse as 电脑状态,PCNote as 机器位置 from PCInfo";
            SqlDataAdapter adadpter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adadpter.Fill(ds);
            dgv_computer.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
