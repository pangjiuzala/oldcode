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
    public partial class 客户退房 : Form
    {
        public 客户退房()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlstr = ("server=.;database=客房管理;uid=sa;pwd=sa");
            SqlConnection conn = new SqlConnection(sqlstr);
            //定义连接对象con
            conn.Open();//打开数据库   
            string sql = "Delete From 客户信息 where 客房号 = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("退房成功");
            conn.Close();
            string sqlstr1 = ("server=.;database=客房管理;uid=sa;pwd=sa");
            SqlConnection conn1 = new SqlConnection(sqlstr1);
            //定义连接对象con
            conn1.Open();//打开数据库         
            string sql1 = "Update 客房信息 Set 房间信息 = '空' where 客房号 like '" + textBox1.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, conn1);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("客户"+textBox2.Text+"您已退房成功，请结账！");;
            conn1.Close();
            Form mf = new 客户结账(); 
            mf.Show();
           
        }

        private void 退房_Load(object sender, EventArgs e)
        {

        }

        private void 姓名_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}