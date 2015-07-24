using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 客房管理系统_1._0
{
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
            this.Load += new EventHandler(AddRoom_Load);
        }

      
        void AddRoom_Load(object sender, EventArgs e)
        {
            if (this.Text == "修改客房")
            {
                this.textBoxRoomName.Text = RoomInformation.NewRoom.Name;
                this.textBoxRoomDeposit.Text = Convert.ToString(RoomInformation.NewRoom.Deposit);
                this.textBoxRoomDayCount.Text = Convert.ToString(RoomInformation.NewRoom.DayCount);
                this.comboBoxRoomType.SelectedIndex = Convert.ToInt32(RoomInformation.NewRoom.Type);
                this.textBoxRoomName.ReadOnly = true;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            RoomInformation.NewRoom.Name = this.textBoxRoomName.Text;
            RoomInformation.NewRoom.Deposit  = Convert.ToDecimal(this.textBoxRoomDeposit.Text);
            RoomInformation.NewRoom.DayCount  = Convert.ToDecimal(this.textBoxRoomDayCount.Text);
            RoomInformation.NewRoom.Type  = this.comboBoxRoomType.SelectedIndex;
        }

       
    }
}