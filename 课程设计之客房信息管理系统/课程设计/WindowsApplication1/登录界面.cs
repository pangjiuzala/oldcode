using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsApplication1
{
    public partial class 登录界面 : Form
    {
        SqlConnection conn;
        public 登录界面()
        {
            string connString = "server=.;database=客房管理;uid=sa;pwd=sa";
            conn = new SqlConnection(connString);
            InitializeComponent();
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            conn.Open();//打开数据库连接
            string sql = string.Format("select * from 管理员信息 where 用户名 ='{0}' and 密码='{1}'", userName, password);//构造用户名密码查询字符串
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();//构造返回结果集
            sda.Fill(ds);
            conn.Close();//关闭数据库连接
            if (((userName  == "刘兴") && ( password== "1121011323")) || ((userName  == "季洲晨") && ( password== "1121011328")) || ((userName  == "张航") && ( password== "1121011339")) || ((userName  == "肖仲垚") && ( password== "1121011523")))
            {
                MessageBox.Show("管理员认证成功，"+"登录成功！");
                textBox1.Clear();
                textBox2.Clear();
                Form myfrm = new 客房信息();
                myfrm.Show();

            }
            else
            {
                MessageBox.Show("非法用户，请重新输入！");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

           MessageBox.Show("取消登录，欢迎您再次使用！");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void 客房管理系统_Click(object sender, EventArgs e)
        {

        }
    }
}
