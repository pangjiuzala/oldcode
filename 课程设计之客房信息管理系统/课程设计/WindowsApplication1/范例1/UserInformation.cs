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
    public partial class UserInformation : Form
    {
        public UserInformation()
        {
            InitializeComponent();
            this.Load+=new EventHandler(Initiate);
            this.修改用户信息ToolStripMenuItem.Click += this.Initiate;
            this.删除用户信息ToolStripMenuItem.Click += this.Initiate;
            this.刷新ToolStripMenuItem.Click += this.Initiate;
        }

        public User SelectedUser
        {
            get
            {
                if (this.listViewUserInformation.SelectedItems.Count == 1)
                    return new UserManager().GetUserByRegisteredName(this.listViewUserInformation.SelectedItems[0].Text);
                else
                    return null;
            }
        }

        public static User CurrentUser;

        private void Initiate(object sender,EventArgs e)
        {
            if (this.Tag == "UserInformation")
            {
                this.listViewUserInformation.ContextMenuStrip = this.contextMenuStrip;
                this.listViewUserInformation.Clear();
                this.listViewUserInformation.View = View.Details;
                this.listViewUserInformation.GridLines = true;
                this.listViewUserInformation.Columns.Add("用户名",
                    listViewUserInformation.Width / 6, HorizontalAlignment.Center);
                this.listViewUserInformation.Columns.Add("姓名",
                    listViewUserInformation.Width / 6, HorizontalAlignment.Center);
                this.listViewUserInformation.Columns.Add("性别",
                     listViewUserInformation.Width / 6, HorizontalAlignment.Center);
                this.listViewUserInformation.Columns.Add("电话",
                    listViewUserInformation.Width / 6, HorizontalAlignment.Center);
                this.listViewUserInformation.Columns.Add("权限",
                    listViewUserInformation.Width / 6, HorizontalAlignment.Center);
                this.listViewUserInformation.Columns.Add("职位",
                    listViewUserInformation.Width / 6, HorizontalAlignment.Center);

                ArrayList  users = new UserManager().GetAllUsers(MainForm.LoadedUser );
                foreach (User u in users)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = u.RegisteredName;
                    lvi.SubItems.Add(u.Name);
                    lvi.SubItems.Add(u.Sex );
                    lvi.SubItems.Add(u.Telephone );
                    lvi.SubItems.Add(Convert.ToString(u.Privilege ));
                    lvi.SubItems.Add(u.Position );
                    listViewUserInformation.Items.Add(lvi);
                }
            }
            else if (this.Tag == "GuestRecord")
            {
                this.Text = "客户记录";

                this.listViewUserInformation.Clear();
                this.listViewUserInformation.View = View.Details;
                this.listViewUserInformation.GridLines = true;
                this.listViewUserInformation.Columns.Add("姓名",
                    listViewUserInformation.Width / 6, HorizontalAlignment.Center);
                this.listViewUserInformation.Columns.Add("房间",
                    listViewUserInformation.Width / 6, HorizontalAlignment.Center);
                this.listViewUserInformation.Columns.Add("性别",
                     listViewUserInformation.Width / 6, HorizontalAlignment.Center);
                this.listViewUserInformation.Columns.Add("身份证",
                    listViewUserInformation.Width / 6, HorizontalAlignment.Center);
                this.listViewUserInformation.Columns.Add("入住时间",
                    listViewUserInformation.Width / 6, HorizontalAlignment.Center);
                this.listViewUserInformation.Columns.Add("退房时间",
                    listViewUserInformation.Width / 6, HorizontalAlignment.Center);
                this.listViewUserInformation.Columns.Add("消费",
                    listViewUserInformation.Width / 6, HorizontalAlignment.Center);


                ArrayList guests = new GuestManager().GetAllRecords();

                foreach(Guest g in guests )
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = g.Name ;
                    lvi.SubItems.Add(g.Room );
                    lvi.SubItems.Add(g.Sex );
                    lvi.SubItems.Add(g.Id );
                    lvi.SubItems.Add(Convert.ToString(g.InTime ));
                    lvi.SubItems.Add(Convert.ToString(g.OutTime ));
                    lvi.SubItems.Add(g.Payment.ToString());
                    listViewUserInformation.Items.Add(lvi);
                }
               
            }

        }

        private void 修改用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                CurrentUser =new UserManager().GetUserByRegisteredName(MainForm.LoadedUser.RegisteredName );
                Pwd newPwd = new Pwd();
                if (newPwd.ShowDialog() == DialogResult.OK)
                {
                    if (Pwd.pwd != CurrentUser.Password  )
                    {
                        MessageBox.Show("您输入的密码不正确！", "提示");
                    }
                    else
                    {
                        Register newRegister = new Register();
                        newRegister.Text = "修改信息";
                        DialogResult a;
                        do
                        {
                            a = newRegister.ShowDialog();
                            if (a != DialogResult.OK)
                                break;
                            if (new UserManager().Check(CurrentUser))
                            {
                                if (new UserManager().UpdateSelfInformation(CurrentUser ))
                                {
                                    MessageBox.Show("成功修改信息！","提示");
                                    break;
                                }    
                                else
                                {
                                    MessageBox.Show("没有成功修改信息！，请重新填写！", "提示");
                                }
                            }
                            else
                            {
                                MessageBox.Show("信息有误，请重新填写！", "提示");
                            }

                        } while (true);
                    }
                }

          
        }

        private void 删除用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listViewUserInformation.SelectedItems.Count == 0)
            {
                MessageBox.Show("您没有选择任何用户！", "提示");
            }
            else
            {
                if(SelectedUser.Privilege <=MainForm.LoadedUser.Privilege )
                {
                    MessageBox.Show("您没有权限删除该用户！","提示");
                }
                else
                {
                    if(MessageBox.Show("您确定要删除该用户？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning )==DialogResult.OK )
                    {
                        if(new UserManager().DeleteUser(SelectedUser))
                        {
                           MessageBox.Show("删除成功！", "提示");
                        }
                        else
                        {
                            MessageBox.Show("没有删除成功！", "提示");
                        }
                    }
                }               
            }
        }

      

    }
}