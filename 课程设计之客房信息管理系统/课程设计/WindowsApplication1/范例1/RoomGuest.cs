using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Common;
using Business;

namespace 客房管理系统_1._0
{
    public partial class RoomGuest : Form
    {
        public RoomGuest()
        {

            InitializeComponent();
            this.button1.DialogResult = DialogResult.OK;
            this.Load += new EventHandler(RoomGuest_Load);
        }

        void RoomGuest_Load(object sender, EventArgs e)
        {

            this.Text = "客房客户信息：" + MainForm.CurrentRoom.Name + "房间";
            Guest g = new GuestManager().GetGuestByRoom(MainForm.CurrentRoom);
            this.textBoxDeposit.Text = g.Deposit.ToString();
            this.textBoxID.Text = g.Id;
            this.textBoxInTime.Text = g.InTime.ToString();
            this.textBoxName.Text = g.Name;
            this.textBoxSex.Text = g.Sex;
            this.textBoxStayTime.Text = Convert.ToString(g.StayTime) + "天";
            if (this.Tag == "TimeIsUp")
            {
               
            }
            else
            {
                this.button1.Text = "确定";
            }  
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Tag == "TimeIsUp")
            {
                Pwd xvzhu = new Pwd();
                xvzhu.Tag = "xvzhu";
                if (xvzhu.ShowDialog() == DialogResult.OK)
                {
                    MainForm.CurrentGuest.StayTime = MainForm.CurrentGuest.StayTime + Pwd.days;
                    MainForm.CurrentRoom.Deposit = MainForm.CurrentGuest.Deposit + Pwd.days * MainForm.CurrentRoom.Deposit;
                    if (MessageBox.Show("您为客户：'" + MainForm.CurrentGuest.Name + "'办理的续住登记。\n客户续住'" + Pwd.days.ToString() + "'天\n应续交押金'" + Convert.ToString(Pwd.days * MainForm.CurrentRoom.Deposit) + "'元", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (new GuestManager().StayLonger(MainForm.CurrentGuest))
                        {
                            this.textBoxDeposit.Text = MainForm.CurrentGuest.Deposit.ToString();
                            this.textBoxStayTime.Text = MainForm.CurrentGuest.StayTime.ToString();
                            MessageBox.Show("续住登记成功！", "提示");

                        }
                        else
                        {
                            MessageBox.Show("操作没有成功，请重新登记！", "提示");
                        }
                    }
                }

            }
        }
    }
}