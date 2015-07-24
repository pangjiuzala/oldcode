using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using Common;
using Business;

namespace 客房管理系统_1._0
{
    public partial class RoomInformation : Form
    {
        public RoomInformation()
        {
            InitializeComponent();
            
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Load += new EventHandler(Initiate);
        }

        public static Room NewRoom = new Room();

        public Room SelectedRoom
        {
            get
            {
                if (this.listView1.SelectedItems.Count == 1)
                {
                    return new RoomManager().GetRoom(this.listView1.SelectedItems[0].Text);
                }
                else
                {
                    return null;
                }
            }
        }

        void Initiate(object sender, EventArgs e)
        {
            this.listView1.Clear();
            this.listView1.View = View.Details;
            this.listView1.GridLines = true;

            this.listView1.Columns.Add("房间名称",
                listView1.Width / 5, HorizontalAlignment.Center);
            this.listView1.Columns.Add("房间类型",
                 listView1.Width / 5, HorizontalAlignment.Center);
            this.listView1.Columns.Add("房间状态",
                listView1.Width / 5, HorizontalAlignment.Center);
            this.listView1.Columns.Add("房间日消费",
                listView1.Width / 5, HorizontalAlignment.Center);
            this.listView1.Columns.Add("房间押金",
                listView1.Width / 5, HorizontalAlignment.Center);

            ArrayList rooms=new RoomManager().GetAllRooms();

            foreach(Room r in rooms)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text =r.Name ;
                switch (r.Type )
                {
                    case 0:
                        lvi.SubItems.Add("单人间");
                        break;
                    case 1:
                        lvi.SubItems.Add("双人间");
                        break;
                    case 2:
                        lvi.SubItems.Add("三人间");
                        break;
                    case 3:
                        lvi.SubItems.Add("客房");
                        break;
                }

                switch (r.State )
                {
                    case 0:
                        lvi.SubItems.Add("空客房");
                        break;
                    case 1:
                        lvi.SubItems.Add("满客房");
                        break;
                    case 2:
                        lvi.SubItems.Add("脏客房");
                        break;
                    case 3:
                        lvi.SubItems.Add("维修中");
                        break;
                    case 4:
                        lvi.SubItems.Add("已到时");
                        break;
                }

                lvi.SubItems.Add(r.DayCount .ToString ());
                lvi.SubItems.Add(r.Deposit.ToString());
                listView1.Items.Add(lvi);
            } 
        }



        //删除客房
        void DeleteRoom(object sender, System.EventArgs e)
        {
            if (MainForm.LoadedUser.Privilege  == 0)
            {
                if (this.listView1.SelectedItems.Count != 1)
                {
                    MessageBox.Show("为了保证您数据的安全与准确，请一次选择一个房间！", "提示");
                }
                else
                {  
                    if (new RoomManager().GetRoomState(SelectedRoom)==1)
                    {
                         MessageBox.Show("当前客房不是空客房，不能进行此操作！", "提示");
                    }
                    else if (MessageBox.Show("您确定要删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (new RoomManager().DeleteRoom(SelectedRoom))
                            MessageBox.Show("删除成功！", "提示");
                        else
                            MessageBox.Show("没有成功删除，请重新删除！","提示");
                    }
                } 
            }
            else
            {
                MessageBox.Show("您没有权限删除客房","提示");
            }
        }
       

        //修改客房信息
        void UpdateRoom(object sender, System.EventArgs e)
        {
            if (MainForm.LoadedUser.Privilege  == 0)
            {
                if (this.listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("为了保证您数据的安全与准确，请一次选择一个房间！", "提示");
                }
                else
                {
                    if (new RoomManager().GetRoomState(SelectedRoom)==1)
                    {
                         MessageBox.Show("当前客房不是空客房，不能进行此操作！", "提示");
                    }
                    else 
                    {
                        AddRoom newAddRoom = new AddRoom();
                        newAddRoom.Text = "修改客房";
                        NewRoom = this.SelectedRoom;
                        if (newAddRoom.ShowDialog()==DialogResult.OK )
                        {
                            if (new RoomManager().CheckRoomData(NewRoom ))
                            {
                                if (MessageBox.Show("您确定要修改该客房吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                {
                                    if (new RoomManager().UpdateRoom(NewRoom ))
                                    {
                                        MessageBox.Show("修改成功!", "提示");
                                    }
                                    else
                                    {
                                        MessageBox.Show("没有成功修改，请重新修改！", "提示");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("您填写的信息有误，请重新填写！", "提示");
                            }
                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("您没有权限修改客房", "提示");
            }
        }

        //添加客房
        void AddRoom(object sender,System.EventArgs e)
        {
            if (MainForm.LoadedUser.Privilege == 0)
            {
                AddRoom newAddRoom = new AddRoom();
                newAddRoom.Text = "添加客房";
                if (newAddRoom.ShowDialog() == DialogResult.OK)
                {
                    if (new RoomManager().CheckRoomData(NewRoom ))
                    {
                        if (MessageBox.Show("您确定要添加该客房吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            if (new RoomManager().AddRoom(NewRoom))
                            {
                                MessageBox.Show("添加成功！", "提示");
                            }
                            else
                            {
                                MessageBox.Show("发生错误，没有添加成功！", "提示");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("您填写的信息有误，请重新填写！", "提示");
                    }
                }
            }
            else
            {
                MessageBox.Show("您没有权限添加客房", "提示");
            }
        }

      
       

        
        
    }
}