using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 网吧管理系统
{
    public partial class 主页面 : Form
    {
        public 主页面()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           lbl_time.Text= DateTime.Now.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            上机 sj = new 上机();
            sj.ShowDialog();
        }

        private void 上机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            上机 sj = new 上机();
            sj.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            下机 xj = new 下机();
            xj.ShowDialog();
        }

        private void 下机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            下机 xj = new 下机();
            xj.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            换机 hj = new 换机();
            hj.ShowDialog();
        }

        private void 换机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            换机 hj = new 换机();
            hj.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            注册会员 zc = new 注册会员();
            zc.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            会员充值 cz = new 会员充值();
            cz.ShowDialog();
        }

        private void 会员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            会员卡信息 xf = new 会员卡信息();
            xf.MdiParent = this;
            xf.Dock = DockStyle.Fill;
            xf.Show();
        }

        private void 营业记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            营业记录 xf = new 营业记录();
            xf.MdiParent = this;
            xf.Dock = DockStyle.Fill;
            xf.Show();
        }

        private void 计算机信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            计算机信息表 xf = new 计算机信息表();
            xf.MdiParent = this;
            xf.Dock = DockStyle.Fill;
            xf.Show();
        }

        private void 上机记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            上机记录信息 xf = new 上机记录信息();
            xf.MdiParent = this;
            xf.Dock = DockStyle.Fill;
            xf.Show();
        }

        private void 会员卡信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            会员卡信息 xf = new 会员卡信息();
            xf.MdiParent = this;
            xf.Dock = DockStyle.Fill;
            xf.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 xf = new Form1();
            xf.Show();
            this.Hide();
        }
    }
}
