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
    public partial class 会员卡信息 : Form
    {
        public 会员卡信息()
        {
            InitializeComponent();
        }

        private void 会员卡信息_Load(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            string sql = "select CardNumber as 会员号,CardPassword as 密码,CardBalance as 余额,TransactTime as 办理时间 from cardInfo";
            SqlDataAdapter adadpter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adadpter.Fill(ds);
            dgv_one.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
