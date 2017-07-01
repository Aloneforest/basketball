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
    public partial class 系统管理员界面 : Form
    {
        public string uname;

        public 系统管理员界面()
        {
            InitializeComponent();
        }

        private void 系统管理员界面_Load(object sender, EventArgs e)
        {
            string str = "select gnum from Game";

            DataSet ds = 数据查询.查询(str);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cb1.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void tabControl1_Selected(object sender,  TabControlEventArgs e)
        {
            cb1.Items.Clear();
            cb2.Items.Clear();
            cb3.Items.Clear();

            string str = "select gnum from Game";

            DataSet ds = 数据查询.查询(str);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cb1.Items.Add(ds.Tables[0].Rows[i][0]);

            str = "select pname from Player";

            ds = 数据查询.查询(str);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cb2.Items.Add(ds.Tables[0].Rows[i][0]);
            
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select tnum from TGame";

            DataSet ds = 数据查询.查询(str);

            tb1_1.Text = ds.Tables[0].Rows[0][0].ToString();
            tb2_1.Text = ds.Tables[0].Rows[1][0].ToString();
        }

        private void bu1_Click(object sender, EventArgs e)
        {
            int f1=0, f2=0;
            if(radioButton1.Checked == true)
            {
                f1 = 1; f2 = 0;
            }
            else
            {
                f1 = 0; f2 = 1;
            }

            string str = "update TGame set [tpoints]=" + tb1_2.Text + ",[trebound]=" + tb1_3.Text + ",[tassist]=" 
                + tb1_4.Text + ",[tshoot]=" + tb1_5.Text + ",[t3-point]=" + tb1_6.Text + ",[tsteal]=" + tb1_7.Text + ",[tblock]=" 
                + tb1_8.Text + ",[tturnover]=" + tb1_9.Text + ",[tfoul]=" + tb1_10.Text + ",[twin]="+ f1 + " where tnum = '" + tb1_1.Text + "'";

            int flag1 = 数据操作.操作(str);

            str = "update TGame set [tpoints]=" + tb2_2.Text + ",[trebound]=" + tb2_3.Text + ",[tassist]="
                + tb2_4.Text + ",[tshoot]=" + tb2_5.Text + ",[t3-point]=" + tb2_6.Text + ",[tsteal]=" + tb2_7.Text + ",[tblock]="
                + tb2_8.Text + ",[tturnover]=" + tb2_9.Text + ",[tfoul]=" + tb2_10.Text + ",[twin]=" + f2 + " where tnum = '" + tb2_1.Text + "'";

            int flag2 = 数据操作.操作(str);

            if (flag1 == 0 || flag2 == 0)
                MessageBox.Show("fail");
            else
                MessageBox.Show("success");
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb3.Items.Clear();

            string str = "select pnum from Player where pname = '" + cb2.Text + "'";

            DataSet ds = 数据查询.查询(str);

            str = "select gnum from PGame where pnum = '" + ds.Tables[0].Rows[0][0] + "'";

            ds = 数据查询.查询(str);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cb3.Items.Add(ds.Tables[0].Rows[i][0]);
        }

        private void bu2_Click(object sender, EventArgs e)
        {
            string str = "select pnum from Player where pname = '" + cb2.Text + "'";

            DataSet ds = 数据查询.查询(str);

            str = "update PGame set [time]=" + tb3_1.Text + ",[points]=" + tb3_2.Text + ",[rebound]=" + tb3_3.Text + ",[assist]=" + tb3_4.Text
                + ",[shoot]=" + tb3_5.Text + ",[3-point]=" + tb3_6.Text + " ,[steal]=" + tb3_7.Text + ",[block]=" + tb3_8.Text
                + " ,[turnover]=" + tb3_9.Text + ",[foul]=" + tb3_10.Text + " where [pnum] = '" + ds.Tables[0].Rows[0][0] + "' and [gnum] = '" + cb3.Text + "'";

            int flag = 数据操作.操作(str);

            if (flag == 0)
                MessageBox.Show("fail");
            else
                MessageBox.Show("success");
        }

        private void bu3_Click(object sender, EventArgs e)
        {
            int f1 = 0, f2 = 0;

            if (radioButton3.Checked == true)
                f1 = 1;
            else
                f2 = 1;

            string str = "select * from Team where tnum = '" + tb4_1.Text + "'";

            DataSet ds = 数据查询.查询(str);

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("用户已存在");
                return;
            }

            str = "insert into Team (tnum,tname,tmnum,tmpwd,saiqu) values('" 
                + tb4_1.Text + "', '" + tb4_2.Text + "','" + tb4_3.Text + "','" + tb4_4.Text + "'," + f1 + ");";

            int flag = 数据操作.操作(str);

            if(flag == 0)
                MessageBox.Show("fail");
            else
                MessageBox.Show("success");

        }

        private void bu4_Click(object sender, EventArgs e)
        {
            tb4_1.Text = null;
            tb4_2.Text = null;
            tb4_3.Text = null;
            tb4_4.Text = null;
            radioButton3.Checked = true;
            pictureBox1.Image = null;
        }

        private void bu5_Click(object sender, EventArgs e)
        {
            string str = "select * from AAdm where aanum = '" + uname + "' and aapwd = '" + tb5_1.Text + "'";

            DataSet ds = 数据查询.查询(str);

            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("密码错误");
            else
            {
                str = "update AAdm set aapwd = '" + tb5_2.Text + "' where aanum = '" + uname + "'";

                int flag = 数据操作.操作(str);

                if (flag == 0)
                    MessageBox.Show("fail");
                else
                    MessageBox.Show("success");
            }
        }

        private void 系统管理员界面_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
