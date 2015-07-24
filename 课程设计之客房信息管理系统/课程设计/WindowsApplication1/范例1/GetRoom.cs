using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 客房管理系统_1._0
{
    public partial class GetRoom : Form
    {
        public GetRoom()
        {
            InitializeComponent();
        }

       
        private void buttonOK_Click(object sender, EventArgs e)
        {
            MainForm.CurrentGuest.Name = this.textBoxGuestName.Text;
            MainForm.CurrentGuest.Sex = this.comboBoxGuestSex.SelectedItem.ToString();
            MainForm.CurrentGuest.Id = this.textBoxGuestId.Text;
            MainForm.CurrentGuest.StayTime = Convert.ToInt32(this.textBoxStayTime.Text);
        }
    }
}