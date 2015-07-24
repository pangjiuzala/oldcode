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
using System.Collections;

namespace 客房管理系统_1._0
{
    public partial class MainForm : Form
    {
        
        

        public static User LoadedUser = null;
        public static Room CurrentRoom;
        public static Guest CurrentGuest;

        public Room SelectedRoom
        {
            get
            {
                if (this.listViewRoomInformation .SelectedItems.Count == 1)
                {
                    return new RoomManager().GetRoom(this.listViewRoomInformation.SelectedItems[0].Text );
                }
                else
                {
                    return null;
                }
            }
        }

        public Guest SelectedGuest
        {
            get
            {
                if (SelectedRoom.State == 1||SelectedRoom.State==4)
                    return new GuestManager().GetGuestByRoom(SelectedRoom);
                else
                    return null;
            }
        }

       
       
        
        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(InitateViewRoomInformation);

            this.入住房间ToolStripMenuItem.Click += this.InitateViewRoomInformation;
            this.toolStripMenuItem1.Click += this.InitateViewRoomInformation;

            this.退房ToolStripMenuItem.Click += this.InitateViewRoomInformation;
            this.toolStripMenuItem2.Click += this.InitateViewRoomInformation;

            this.客房维修ToolStripMenuItem.Click += this.InitateViewRoomInformation;
            this.客房维修ToolStripMenuItem1.Click += this.InitateViewRoomInformation;

            this.客房维修完毕ToolStripMenuItem.Click += this.InitateViewRoomInformation;
            this.客房维修完毕ToolStripMenuItem1.Click += this.InitateViewRoomInformation;

            this.客房信息ToolStripMenuItem.Click += this.InitateViewRoomInformation;
            this.客房信息ToolStripMenuItem1.Click += this.InitateViewRoomInformation;

            this.客房信息管理ToolStripMenuItem.Click += this.InitateViewRoomInformation;

            

            this.listViewRoomInformation.ContextMenuStrip  = this.contextMenuStripListViewRoomInformation;
            

            //系统管理菜单的菜单项
            this.注册新用户ToolStripMenuItem.Enabled=false;
            this.用户管理ToolStripMenuItem.Enabled=false;
            this.退出系统ToolStripMenuItem.Enabled = false;


            //经营管理菜单的菜单项
            this.入住房间ToolStripMenuItem.Enabled = false ;
            this.toolStripMenuItem1.Enabled =false ;

            this.退房ToolStripMenuItem.Enabled = false;
            this.toolStripMenuItem2.Enabled = false;

            this.客房维修ToolStripMenuItem.Enabled = false;
            this.客房维修ToolStripMenuItem1.Enabled = false;

            this.客房维修完毕ToolStripMenuItem.Enabled = false;
            this.客房维修完毕ToolStripMenuItem1.Enabled = false;

            this.客房信息ToolStripMenuItem.Enabled =false;
            this.客房信息ToolStripMenuItem1.Enabled = false;


            //酒店管理菜单的菜单项
            this.客房信息管理ToolStripMenuItem.Enabled=false;
            this.满客房ToolStripMenuItem.Enabled=false;
            this.空客房ToolStripMenuItem.Enabled=false;
            this.已到时客房ToolStripMenuItem.Enabled=false;
            this.维修中客房ToolStripMenuItem.Enabled=false;
            this.脏客房ToolStripMenuItem.Enabled=false;
            this.所有客房ToolStripMenuItem.Enabled = false;

            //资料管理菜单的菜单项
           
            this.住房客户记录ToolStripMenuItem.Enabled = false;
       
        }

        void InitateViewRoomInformation(object sender, EventArgs e)
        {
            this.listViewRoomInformation.Clear();
            this.listViewRoomInformation.View = View.LargeIcon;
            
            ArrayList rooms = new RoomManager().GetAllRooms();
            if (rooms == null)
            {
                MessageBox.Show("没有连接到数据库，请先安装数据库！", "提示");
                Application.Exit();

            }
            else
            {
                foreach (Room r in rooms)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = r.Name;
                    switch (r.State)
                    {
                        case 0:
                            lvi.ImageIndex = 0;
                            break;
                        case 1:
                            if (new GuestManager().IsUpTime(new GuestManager().GetGuestByRoom(r)))
                            {
                                new RoomManager().TimeIsUp(r);
                                lvi.ImageIndex = 4;
                            }
                            else
                                lvi.ImageIndex = 1;
                            
                            break;
                        case 2:
                            lvi.ImageIndex = 2;
                            break;
                        case 3:
                            lvi.ImageIndex = 3;
                            break;
                        case 4:
                            if (!new GuestManager().IsUpTime(new GuestManager().GetGuestByRoom(r)))
                            {
                                new RoomManager().FullRoom(r);
                                lvi.ImageIndex = 1;
                            }
                            else 
                                lvi.ImageIndex = 4;
                            break;
                    }
                    this.listViewRoomInformation.Items.Add(lvi);
                }
            }
        }

        private void listViewRoomInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoadedUser != null )
            {
                if (listViewRoomInformation.SelectedItems.Count == 1)
                {
                    this.经营管理ToolStripMenuItem.Enabled = true;

                    switch (SelectedRoom.State )
                    {
                        case 0:
                            this.入住房间ToolStripMenuItem.Enabled = true;
                            this.toolStripMenuItem1.Enabled = true;
                            this.退房ToolStripMenuItem.Enabled = false;
                            this.toolStripMenuItem2.Enabled = false;

                            this.客房维修ToolStripMenuItem.Enabled = false;
                            this.客房维修ToolStripMenuItem1.Enabled = false;
                            this.客房维修完毕ToolStripMenuItem.Enabled = false;
                            this.客房维修完毕ToolStripMenuItem1.Enabled = false;

                            this.客房信息ToolStripMenuItem.Enabled = false ;
                            this.客房信息ToolStripMenuItem1.Enabled = false ;
                          
                            this.toolTipRoomInformation.Show("空房间", this.listViewRoomInformation);
                            break;
                        case 1:
                            this.入住房间ToolStripMenuItem.Enabled = false;
                            this.toolStripMenuItem1.Enabled = false;
                            this.退房ToolStripMenuItem.Enabled = true;
                            this.toolStripMenuItem2.Enabled = true;
                            this.客房维修ToolStripMenuItem.Enabled = false;
                            this.客房维修ToolStripMenuItem1.Enabled = false;
                            this.客房维修完毕ToolStripMenuItem.Enabled = false;
                            this.客房维修完毕ToolStripMenuItem1.Enabled = false;

                            this.客房信息ToolStripMenuItem.Enabled = true;
                            this.客房信息ToolStripMenuItem1.Enabled = true;

                            CurrentRoom = this.SelectedRoom;
                            this.toolTipRoomInformation.Show("满房间", this.listViewRoomInformation);
                            break;
                        case 2:
                            this.入住房间ToolStripMenuItem.Enabled = false;
                            this.toolStripMenuItem1.Enabled = false;
                            this.退房ToolStripMenuItem.Enabled = false;
                            this.toolStripMenuItem2.Enabled = false;


                            this.客房维修ToolStripMenuItem.Enabled = true;
                            this.客房维修ToolStripMenuItem1.Enabled = true;
                            this.客房维修完毕ToolStripMenuItem.Enabled = false;
                            this.客房维修完毕ToolStripMenuItem1.Enabled = false;

                            this.客房信息ToolStripMenuItem.Enabled = false ;
                            this.客房信息ToolStripMenuItem1.Enabled = false ;

                            this.toolTipRoomInformation.Show("脏房间", this.listViewRoomInformation);
                            break;
                        case 3:

                            this.入住房间ToolStripMenuItem.Enabled = false;
                            this.toolStripMenuItem1.Enabled = false;
                            this.退房ToolStripMenuItem.Enabled = false;
                            this.toolStripMenuItem2.Enabled = false;

                            this.客房维修ToolStripMenuItem.Enabled = false;
                            this.客房维修ToolStripMenuItem1.Enabled = false;
                            this.客房维修完毕ToolStripMenuItem.Enabled = true;
                            this.客房维修完毕ToolStripMenuItem1.Enabled = true;

                            this.客房信息ToolStripMenuItem.Enabled = false ;
                            this.客房信息ToolStripMenuItem1.Enabled = false ;


                            this.toolTipRoomInformation.Show("维修中", this.listViewRoomInformation);
                            break;
                        case 4:

                            this.入住房间ToolStripMenuItem.Enabled = false;
                            this.toolStripMenuItem1.Enabled = false;
                            this.退房ToolStripMenuItem.Enabled = false;
                            this.toolStripMenuItem2.Enabled = false;

                            this.客房维修ToolStripMenuItem.Enabled = false;
                            this.客房维修ToolStripMenuItem1.Enabled = false;
                            this.客房维修完毕ToolStripMenuItem.Enabled = true;
                            this.客房维修完毕ToolStripMenuItem1.Enabled = true;

                            this.客房信息ToolStripMenuItem.Enabled = true  ;
                            this.客房信息ToolStripMenuItem1.Enabled = true ;


                            this.toolTipRoomInformation.Show("已到时", this.listViewRoomInformation);
                            break;
                    }

                }
                else
                {
                    this.入住房间ToolStripMenuItem.Enabled = false;
                    this.toolStripMenuItem1.Enabled = false;
                    this.退房ToolStripMenuItem.Enabled = false;
                    this.toolStripMenuItem2.Enabled = false;

                    this.客房维修ToolStripMenuItem.Enabled = false;
                    this.客房维修ToolStripMenuItem1.Enabled = false;
                    this.客房维修完毕ToolStripMenuItem.Enabled = false;
                    this.客房维修完毕ToolStripMenuItem1.Enabled = false;
                    this.客房信息ToolStripMenuItem.Enabled = false;
                    this.客房信息ToolStripMenuItem1.Enabled = false;



                }
            }
        }

        private void listViewRoomInformation_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            this.toolTipRoomInformation.Hide(this.listViewRoomInformation );
        }

        private void 系统登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedUser==null )
            {
                LoadedUser = new User();
                LoadForm newLoad = new LoadForm();
                if (newLoad.ShowDialog() == DialogResult.OK)
                {
                    
                    if (new UserManager().UserLoad(LoadedUser))
                    {
                        this.Text = "客房管理系统 1.0" + " " + LoadedUser.RegisteredName  + "登录";
                        this.注册新用户ToolStripMenuItem.Enabled = true;
                        this.用户管理ToolStripMenuItem.Enabled = true;
                        this.退出系统ToolStripMenuItem.Enabled = true;
                        this.客房信息管理ToolStripMenuItem.Enabled = true;
                        this.住房客户记录ToolStripMenuItem.Enabled = true;

                        this.满客房ToolStripMenuItem.Enabled = true;
                        this.空客房ToolStripMenuItem.Enabled = true;
                        this.已到时客房ToolStripMenuItem.Enabled = true;
                        this.维修中客房ToolStripMenuItem.Enabled = true;
                        this.脏客房ToolStripMenuItem.Enabled = true;
                        this.所有客房ToolStripMenuItem.Enabled = true;

                    }
                    else
                    {
                        LoadedUser = null; 
                        MessageBox.Show("登录信息不正确，请重新填写！","提示");
                    }
                }
            }
            else
            {
                MessageBox.Show("当前已有用户登录！", "提示");
            }

        }

        private void 注册新用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (LoadedUser==null)
            {
                MessageBox.Show("您还没有登录，请先登录系统！", "提示");
            }
            else
            {
                Register newRegister = new Register();
                if (newRegister.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedUser == null )
            {
                MessageBox.Show("当前没有用户登录！", "提示");
            }
            else
            {
                LoadedUser =null ;
                this.Text = "客房管理系统 1.0"+" "+"未登录";
                this.注册新用户ToolStripMenuItem.Enabled = false;
                this.用户管理ToolStripMenuItem.Enabled = false;
                this.退出系统ToolStripMenuItem.Enabled = false;

            }
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedUser == null)
            {
                MessageBox.Show("您好没有登录，请先登录系统！", "提示");
            }
            else
            {
                UserInformation newUserInformation = new UserInformation();
                newUserInformation.Tag = "UserInformation";
                newUserInformation.ShowDialog();
            }
        }


        //入住登记菜单
        void GetRoom(object sender, System.EventArgs e)
        {
            GetRoom newGetRoom = new GetRoom();
            do
            {
                CurrentGuest = new Guest();
                if ( newGetRoom.ShowDialog()!= DialogResult.OK)
                    break;

                if (new GuestManager().CheckGuestIn(CurrentGuest))
                {
                    //押金的计算
                    CurrentGuest.Deposit = CurrentGuest.StayTime * SelectedRoom.Deposit;

                    //入住时间
                    CurrentGuest.InTime = DateTime.Now;

                    CurrentGuest.Room = SelectedRoom.Name;

                    if (new GuestManager().GuestIn(CurrentGuest, SelectedRoom))
                    {

                        MessageBox.Show("您为客户'" + CurrentGuest.Name + "'订下了'" + CurrentGuest.Room + "'房间\n应收押金：'" + Convert.ToString(CurrentGuest.Deposit) + "'元",
                                        "提示",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                       
                        break;
                    }
                    else
                    {
                        MessageBox.Show("发生错误，操作失败！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("信息填写有错误！", "提示");
                }

            } while (true);

            
        }


        //退房登记菜单
        void OutRoom(object sender, System.EventArgs e)
        {
            //计算住宿时间和用费
            CurrentGuest = this.SelectedGuest;
            CurrentGuest.OutTime = DateTime.Now;
            TimeSpan stayTime = Convert.ToDateTime(CurrentGuest.OutTime).Subtract(Convert.ToDateTime(CurrentGuest.InTime));

            int days = Convert.ToInt32(stayTime.TotalDays) + 1;
            CurrentGuest.Payment = days * Convert.ToInt32(SelectedRoom.DayCount);
            decimal? need = CurrentGuest.Payment - CurrentGuest.Deposit;

            if (need >= 0)
            {
                MessageBox.Show("您住了：'" + Convert.ToString(days) + "'天\n总计：'" + Convert.ToString(CurrentGuest.Payment) + "'元\n已收押金：'" + Convert.ToString(CurrentGuest.Deposit) + "'元,还需交：'" + Convert.ToString(need) + "'元", "提示");
            }
            if (need < 0)
            {
                need = 0 - need;
                MessageBox.Show("您住了：'" + Convert.ToString(days) + "'天\n总计：'" + Convert.ToString(CurrentGuest.Payment) + "'元\n已收押金：'" + Convert.ToString(CurrentGuest.Deposit) + "'元,应退还：'" + Convert.ToString(need) + "'元", "提示");
            }

            if (new GuestManager().CheckGuestOut(CurrentGuest))
            {
                if (!new GuestManager().GuestOut(CurrentGuest, SelectedRoom))
                    MessageBox.Show("发生错误，操作失败！", "提示");
            }
            else
            {
                MessageBox.Show("数据有错误！", "提示");
            }
        }
        
        //客房维修菜单
        private void MaintainRoom(object sender, EventArgs e)
        {
            if (!new RoomManager().CleaningRoom(SelectedRoom))
                MessageBox.Show("发生错误，操作失败！","提示");
           
            
            
        }

        //客房维修完毕
        private void MaintainOver(object sender, EventArgs e)
        {
            if(!new RoomManager().EmptyRoom(SelectedRoom ))
                MessageBox.Show("发生错误，操作失败！","提示");
         
            
            
        }

        private void 客房信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedUser.Privilege ==0)
            {
                RoomInformation newRoomInformation = new RoomInformation();
                newRoomInformation.ShowDialog();
            }
            else
            {
                MessageBox.Show("您没有权限管理客房信息！","提示");
            }
            
        }

        void RoomGuest(object sender, System.EventArgs e)
        {
            if (SelectedRoom .State  == 1)
            {
                RoomGuest newRoomGuest = new RoomGuest();
                newRoomGuest.ShowDialog();
            }
            else if (SelectedRoom.State == 4)
            {
                CurrentGuest = this.SelectedGuest;
                CurrentRoom = this.SelectedRoom;
                RoomGuest newRoomGuest = new RoomGuest();
                newRoomGuest.Tag = "TimeIsUp";
                newRoomGuest.ShowDialog();
                
            }
            else
            { 
                MessageBox.Show("该房间目前没有客户入住！", "提示");
            }
        }

      

        private void 住房客户记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedUser.Privilege  == 0)
            {
                UserInformation newGuestRecord = new UserInformation();
                newGuestRecord.Tag = "GuestRecord";
                if (newGuestRecord.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("您没有权限查看客户记录！","提示");
            }
        }

        private void 满客房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewRoomInformation.Clear();
            this.listViewRoomInformation.View = View.LargeIcon;

            ArrayList rooms = new RoomManager().GetAllRooms();
 
            foreach (Room r in rooms)
            {
                if (r.State == 1)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = r.Name;
                    lvi.ImageIndex = 1;
                    this.listViewRoomInformation.Items.Add(lvi);
                }
            }
            
               
           
        }

        private void 空客房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewRoomInformation.Clear();
            this.listViewRoomInformation.View = View.LargeIcon;

            ArrayList rooms = new RoomManager().GetAllRooms();

            foreach (Room r in rooms)
            {
                if (r.State == 0)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = r.Name;
                    lvi.ImageIndex =0;
                    this.listViewRoomInformation.Items.Add(lvi);
                }
            }
        }

        private void 已到时客房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewRoomInformation.Clear();
            this.listViewRoomInformation.View = View.LargeIcon;

            ArrayList rooms = new RoomManager().GetAllRooms();

            foreach (Room r in rooms)
            {
                if (r.State == 4)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = r.Name;
                    lvi.ImageIndex = 4;
                    this.listViewRoomInformation.Items.Add(lvi);
                }
            }
        }

        private void 维修中客房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewRoomInformation.Clear();
            this.listViewRoomInformation.View = View.LargeIcon;

            ArrayList rooms = new RoomManager().GetAllRooms();

            foreach (Room r in rooms)
            {
                if (r.State == 3)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = r.Name;
                    lvi.ImageIndex = 3;
                    this.listViewRoomInformation.Items.Add(lvi);
                }
            }
        }

        private void 脏客房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewRoomInformation.Clear();
            this.listViewRoomInformation.View = View.LargeIcon;

            ArrayList rooms = new RoomManager().GetAllRooms();

            foreach (Room r in rooms)
            {
                if (r.State == 2)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = r.Name;
                    lvi.ImageIndex = 2;
                    this.listViewRoomInformation.Items.Add(lvi);
                }
            }
        }

        

      

       

        
      
    }
}