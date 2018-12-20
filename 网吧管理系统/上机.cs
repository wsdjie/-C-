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
    public partial class 上机 : Form
    {
        public 上机()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_time.Text = DateTime.Now.ToString();
        }

        private void 上机_Load(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";  
            SqlConnection con = new SqlConnection(conn);
         
                string sql = "select PCId from PCInfo where PCUse=0";
                SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                cbo_bianhao.DataSource = ds.Tables[0].DefaultView;
                cbo_bianhao.DisplayMember = "PCId";
           
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string conn = "server=.;database=NetBarDB;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string pcid = cbo_bianhao.Text;
            string id = txt_id.Text;
            string pwd = txt_pwd.Text;
            string time = txt_time.Text;
            int money =2;

                string pcsql =string.Format("select * from cardInfo where CardNumber='{0}'",id);
                SqlDataAdapter adapter = new SqlDataAdapter(pcsql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
              string   oneid = ds.Tables[0].Rows[0]["CardId"].ToString();
            string whether = string.Format("select * from recordInfo where CardId='{0}' and endTime is null", ds.Tables[0].Rows[0]["CardId"]);
            SqlDataAdapter adap = new SqlDataAdapter(whether,con);
            DataSet da = new DataSet();
            adap.Fill(da);
            if(da.Tables[0].Rows.Count>0)
            {
                MessageBox.Show("该会员正在上机！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                txt_id.Clear();
                txt_pwd.Clear();
                return;
            }
            string sql = string.Format("select * from cardInfo where CardNumber='{0}' and CardPassword='{1}'",id,pwd);
            SqlCommand cmd = new SqlCommand(sql, con);
            object obj = cmd.ExecuteScalar();
            if (obj == null)
            {
                MessageBox.Show("用户名或密码错误，请检查后重新输入", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql1 = string.Format("insert into  recordInfo values('{0}','{1}','{2}',null,'{3}')", oneid, pcid, time, money);
                SqlCommand cmd1 = new SqlCommand(sql1,con);
                string change = string.Format("update PCInfo set PCUse=1 where PCId='{0}'", pcid);
                SqlCommand cmd2 = new SqlCommand(change, con);
                int i = cmd1.ExecuteNonQuery();
                int k = cmd2.ExecuteNonQuery();
                if(i!=0&&k!=0)
                {
                    MessageBox.Show("上机成功","上机提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    txt_id.Clear();
                    txt_pwd.Clear();
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
