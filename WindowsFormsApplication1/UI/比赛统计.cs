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
    public partial class 比赛统计 : Skin_Mac
    {
        public 比赛统计()
        {
            InitializeComponent();
        }

        private void 比赛统计_Load(object sender, EventArgs e)
        {
            string str = "select * from Game";

            DataSet ds = 数据查询.查询(str);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                lb1.Items.Add(ds.Tables[0].Rows[i][0]);

            str = "select * from Team";

            ds = 数据查询.查询(str);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                lb2.Items.Add(ds.Tables[0].Rows[i][0]);

            str = "select * from Player";

            ds = 数据查询.查询(str);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                lb3.Items.Add(ds.Tables[0].Rows[i][3]);
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            string str = "select * from TGame where gnum = '" + lb1.SelectedItem + "'";

            DataSet ds = 数据查询.查询(str);

            l1_1.Text = ds.Tables[0].Rows[0][0].ToString();
            l1_2.Text = ds.Tables[0].Rows[0][3].ToString();
            l2_1.Text = ds.Tables[0].Rows[1][0].ToString();
            l2_2.Text = ds.Tables[0].Rows[1][3].ToString();
        }

        private void lb2_Click(object sender, EventArgs e)
        {
            string str = "select win,fall,mingci from Team where tnum = '" + lb2.SelectedItem + "'";

            DataSet ds = 数据查询.查询(str);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void lb3_Click(object sender, EventArgs e)
        {
            string str = "select [juntime],[junpoint],[junrebound],[junassist],[junshoot],[jun3-point],[junsteal] ,[junturnover],[junfoul] ,[junblock] from Player where pname = '" + lb3.SelectedItem + "'";

            DataSet ds = 数据查询.查询(str);

            dataGridView2.DataSource = ds.Tables[0];
        }
    }
}
