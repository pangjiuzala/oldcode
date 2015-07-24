using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 客房管理系统_1._0
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
           
        }

        private void buttonLoadOK_Click(object sender, EventArgs e)
        {
            MainForm.LoadedUser.RegisteredName = this.textBoxLoadUserName.Text;
            MainForm.LoadedUser.Password = this.textBoxLoadUserPwd.Text;
        }

       
    }
}