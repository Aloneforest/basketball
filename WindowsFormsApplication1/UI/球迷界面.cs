using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Handle;

namespace WindowsFormsApplication1
{
    public partial class 球迷界面 : Form
    {
        public string uname = "fensi1";

        public 球迷界面()
        {
            InitializeComponent();
        }

        private void 球迷界面_Load(object sender, EventArgs e)
        {
            string str = "select fname from Fans where fnum = '" + uname + "'";

            DataSet ds = 数据查询.查询(str);

            sl.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void bu1_Click(object sender, EventArgs e)
        {
            string str = "update Fans set fname = '" + tb1_1.Text + "' where fnum = '" + uname + "'";

            int flag = 数据操作.操作(str);

            if (flag == 0)
                MessageBox.Show("fail");
            else
                MessageBox.Show("success");
        }

        private void bu3_Click(object sender, EventArgs e)
        {
            string str = "select * from Fans where fnum = '" + uname + "' and fpwd = '" + tb2_1.Text + "'";

            DataSet ds = 数据查询.查询(str);

            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("密码错误");
            else
            {
                str = "update Fans set fpwd = '" + tb2_2.Text + "' where fnum = '" + uname + "'";

                int flag = 数据操作.操作(str);

                if (flag == 0)
                    MessageBox.Show("fail");
                else
                    MessageBox.Show("success");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            比赛统计 form = new 比赛统计();
            form.Show();
        }

        
    }
}
