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
    public partial class 登录 : Skin_Mac
    {
        public 登录()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pwd = textBox2.Text;
            int id = 1;
            if (radioButton1.Checked == true)
                id = 1;
            else if (radioButton2.Checked == true)
                id = 2;
            else if (radioButton3.Checked == true)
                id = 3;
            else if (radioButton4.Checked == true)
                id = 4;

            bool result = 登录处理.检查(uname, pwd, id);

            //判断用户名和密码是否匹配
            if (result == true)
            {
                if (id == 1)
                {
                    球队界面 form = new 球队界面();
                    form.uname = textBox1.Text;
                    form.Show();
                    this.Visible = false;
                }
                else if(id == 2)
                {
                    球员界面 form = new 球员界面();
                    form.uname = textBox1.Text;
                    form.Show();
                    this.Visible = false;
                }
                else if(id == 3)
                {
                    球迷界面 form = new 球迷界面();
                    form.uname = textBox1.Text;
                    form.Show();
                    this.Visible = false;
                }
                else if (id == 4)
                {
                    系统管理员界面 form = new 系统管理员界面();
                    form.uname = textBox1.Text;
                    form.Show();
                    this.Visible = false;
                }
            }
            else MessageBox.Show("err");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            比赛统计 form = new 比赛统计();
            form.Show();
        }

    }
}
