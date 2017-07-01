using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using WindowsFormsApplication1.Handle;

namespace WindowsFormsApplication1
{
    public partial class 球队界面 : Skin_Mac
    {
        public string uname = "qiuduiguanli1";

        public 球队界面()
        {
            InitializeComponent();
        }

         void 球队界面_Load(object sender, EventArgs e)
        {
            string str = "select tname,win,fall,mingci,saiqu from Team where tmnum = '" + uname + "'";

            DataSet ds = 数据查询.查询(str);

            sl2_1.Text = ds.Tables[0].Rows[0][0].ToString();
            sl2_2.Text = ds.Tables[0].Rows[0][1].ToString();
            sl2_3.Text = ds.Tables[0].Rows[0][2].ToString();
            sl2_4.Text = ds.Tables[0].Rows[0][3].ToString();
            if (ds.Tables[0].Rows[0][4].ToString() == "1")
                sl2_5.Text = "东";
            else
                sl2_5.Text = "西";



            str = "select tnum from Team where tmnum = '" + uname + "'";

            ds = 数据查询.查询(str);

            string tnum = ds.Tables[0].Rows[0][0].ToString();

            str = "select pname from Player where tnum = '" + tnum + "'";

            ds = 数据查询.查询(str);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                lb1.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void bu1_Click(object sender, EventArgs e)
        {
            int f = 0;

            if (radioButton1.Checked == true)
                f = 1;

            string str = "update Team set tname = '" + tb1_1.Text + "',saiqu = " + f + " where tmnum = '" + uname + "'";

            int flag = 数据操作.操作(str);

            if (flag == 0)
                MessageBox.Show("fail");
            else
                MessageBox.Show("success");
        }

        private void bu3_Click(object sender, EventArgs e)
        {
            string str = "select * from Team where tmnum = '" + uname + "' and tmpwd = '" + tb2_1.Text + "'";

            DataSet ds = 数据查询.查询(str);

            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("密码错误");
            else
            {
                str = "update Team set tmpwd = '" + tb2_2.Text + "' where tmnum = '" + uname + "'";

                int flag = 数据操作.操作(str);

                if (flag == 0)
                    MessageBox.Show("fail");
                else
                    MessageBox.Show("success");
            }
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            string str = "select pname,gao,weizhi,zhong,pno,age,birth from Player where pname = '" + lb1.SelectedItem + "'";

            DataSet ds = 数据查询.查询(str);

            sl1_1.Text = ds.Tables[0].Rows[0][0].ToString();
            sl1_2.Text = ds.Tables[0].Rows[0][1].ToString();
            sl1_3.Text = ds.Tables[0].Rows[0][2].ToString();
            sl1_4.Text = ds.Tables[0].Rows[0][3].ToString();
            sl1_5.Text = ds.Tables[0].Rows[0][4].ToString();
            sl1_6.Text = ds.Tables[0].Rows[0][5].ToString();
            sl1_7.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void bu4_Click(object sender, EventArgs e)
        {
            string str = "update Player set tnum = '0' where pname = '" + lb1.SelectedItem + "'";

            int flag = 数据操作.操作(str);

            if (flag == 0)
                MessageBox.Show("fail");
            else
            {
                MessageBox.Show("success");

                lb1.Items.Clear();

                str = "select tnum from Team where tmnum = '" + uname + "'";

                DataSet ds = 数据查询.查询(str);

                string tnum = ds.Tables[0].Rows[0][0].ToString();

                str = "select pname from Player where tnum = '" + tnum + "'";

                ds = 数据查询.查询(str);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    lb1.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }

        private void bu5_Click(object sender, EventArgs e)
        {
            注册球员 form = new 注册球员();
            form.uname = uname;
            form.Show();
        }

        private void bu6_Click(object sender, EventArgs e)
        {
            比赛统计 form = new 比赛统计();
            form.Show();
        }
    }
}
