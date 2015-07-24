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
    public partial class 客户登记 : Form
    {
        public 客户登记()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new 客房信息();
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlstr = ("server=.;database=客房管理;uid=sa;pwd=sa");
            SqlConnection conn = new SqlConnection(sqlstr);
            //定义连接对象con
            conn.Open();//打开数据库 
            string sql = "Insert into 客户信息(姓名,身份证,性别,籍贯,年龄,客房号)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+ textBox6.Text+ "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("数据存储成功");
            conn.Close();
            string sqlstr1 = ("server=.;database=客房管理;uid=sa;pwd=sa");
            SqlConnection conn1 = new SqlConnection(sqlstr1);
            //定义连接对象con
            conn1.Open();//打开数据库 
            // string sql = "Insert into 房客信息(姓名,身份证,性别,年龄,客房号)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            string sql1 = "Update 客房信息 Set 房间信息 = '满' where 客房号 like '" + textBox6.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, conn1);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("数据存储成功");
            conn1.Close();
        }

        private void 来客登记_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}