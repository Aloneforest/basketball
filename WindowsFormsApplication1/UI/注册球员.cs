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
    public partial class 注册球员 : Form
    {
        public string uname = "qiuduiguanli1";

        public 注册球员()
        {
            InitializeComponent();
        }

        private void 注册球员_Load(object sender, EventArgs e)
        {
            string str = "select pname from Player where tnum = '0'";

            DataSet ds = 数据查询.查询(str);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                lb1.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void bu1_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedItem == null)
                return;

            string str = "select tnum from Team where tmnum = '" + uname + "'";

            DataSet ds = 数据查询.查询(str);

            str = "update Player set tnum = '" + ds.Tables[0].Rows[0][0] + "' where pname = '" + lb1.SelectedItem + "'";

            int flag = 数据操作.操作(str);

            if (flag == 0)
                MessageBox.Show("fail");
            else
            {
                MessageBox.Show("success");

                lb1.Items.Clear();

                str = "select pname from Player where tnum = '0'";

                ds = 数据查询.查询(str);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    lb1.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }

        private void bu2_Click(object sender, EventArgs e)
        {
            string str = "select * from Player where pnum = '" + tb1.Text + "'";

            DataSet ds = 数据查询.查询(str);

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("用户已存在");
                return;
            }

            str = "select tnum from Team where tmnum = '" + uname + "'";

            ds = 数据查询.查询(str);

            string tnum = ds.Tables[0].Rows[0][0].ToString();

            str = "insert into Player ([pnum],[tnum],[pname],[gao],[weizhi] ,[zhong] ,[pno] ,[ppwd]"+
            ",[age] ,[birth] ,[gametime] ,[juntime],[junpoint],[junrebound]"+
            ",[junassist],[junshoot],[jun3-point],[junsteal] ,[junturnover],[junfoul] ,[junblock])"+
            "values ('" + tb1.Text + "','" + tnum + "','" + tb2.Text + "'," + tb3.Text + "," + cb4.SelectedIndex + 
            "," + tb5.Text + "," + tb6.Text + "," + tb7.Text + "," + tb8.Text + "," + tb9.Text + ",0,0,0,0,0,0,0,0,0,0,0)";

            int flag = 数据操作.操作(str);

            if (flag == 0)
                MessageBox.Show("fail");
            else
                MessageBox.Show("success");
        }

        private void bu3_Click(object sender, EventArgs e)
        {
            tb1.Text = null;
            tb2.Text = null;
            tb3.Text = null;
            cb4.Text = null;
            tb5.Text = null;
            tb6.Text = null;
            tb7.Text = null;
            tb8.Text = null;
            tb9.Text = null;
        }
    }
}
