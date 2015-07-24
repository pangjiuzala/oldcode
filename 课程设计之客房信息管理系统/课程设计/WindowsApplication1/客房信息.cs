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

    public partial class 客房信息 : Form
    {
        public 客房信息()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“客房管理DataSet.客房信息”中。您可以根据需要移动或移除它。
            this.客房信息TableAdapter.Fill(this.客房管理DataSet.客房信息);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new 客户登记();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            SqlConnection conn = new SqlConnection("server=.;database=客房管理;uid=sa;pwd=sa"); //建立连接 
            SqlCommand command = new SqlCommand("select * from 客房信息", conn); ///执行SQL语句
            conn.Open();///打开数据库 
            // SqlDataReader sdr = command.ExecuteReader();
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            SqlCommandBuilder commandbuilder = new SqlCommandBuilder(dataadapter);
            dataadapter.Fill(datatable);
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = datatable;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            SqlConnection conn = new SqlConnection("server=.;database=客房管理;uid=sa;pwd=sa"); //建立连接 
            SqlCommand command = new SqlCommand("select * from 客户信息", conn); ///执行SQL语句
            conn.Open();///打开数据库 
            // SqlDataReader sdr = command.ExecuteReader();
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            SqlCommandBuilder commandbuilder = new SqlCommandBuilder(dataadapter);
            dataadapter.Fill(datatable);
            //datatable.Read();
            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = datatable;
            dataGridView2.DataSource = bindingSource2;
            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new 客户退房();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new 客户结账();
            f.Show();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }





    }
}