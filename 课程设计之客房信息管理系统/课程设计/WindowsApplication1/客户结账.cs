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
    public partial class 客户结账 : Form
    {
        private float TotalMoney;
        public float FactTotalMoney;
        public float totalmoney;
        public 客户结账()
        {
            InitializeComponent();
            this.TotalMoney = totalmoney;
            this.FactTotalMoney = this.TotalMoney;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FactTotalMoney = this.TotalMoney * Convert.ToInt16(this.comboBox1.Text) / 100;
            
        }

        private void 客户结账_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“客房管理DataSet.客户信息”中。您可以根据需要移动或移除它。
            this.客户信息TableAdapter.Fill(this.客房管理DataSet.客户信息);
            // TODO: 这行代码将数据加载到表“客房管理DataSet.客房信息”中。您可以根据需要移动或移除它。
            this.客房信息TableAdapter.Fill(this.客房管理DataSet.客房信息);
            this.FactTotalMoney = this.TotalMoney;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double FactTotalMoney = Convert.ToDouble(this.comboBox2.Text) * Convert.ToDouble(this.comboBox1.Text) / 100;

            MessageBox.Show("客户" + comboBox3.Text + "，" + "您的消费金额为" + FactTotalMoney + "元,欢迎下次再来!");
             this.Close();
        } 

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textFactMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
