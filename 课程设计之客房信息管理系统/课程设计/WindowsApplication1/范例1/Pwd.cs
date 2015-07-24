using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 客房管理系统_1._0
{
    public partial class Pwd : Form
    {
        public Pwd()
        {
            InitializeComponent();
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }

        public static string pwd = null;
        public static int days=0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.Tag == "xvzhu")
            {
                try
                {
                    days = Convert.ToInt32(this.textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message ,"提示");
                }
            }
            else
            {
                pwd = this.textBox1.Text;
            }
            
        }

        private void Pwd_Load(object sender, EventArgs e)
        {
            if (this.Tag == "xvzhu")
            {
                this.Text = "请输入续住天数：";
            }
            else
            {
                this.textBox1.PasswordChar = '*';
            }
        }
    }
}