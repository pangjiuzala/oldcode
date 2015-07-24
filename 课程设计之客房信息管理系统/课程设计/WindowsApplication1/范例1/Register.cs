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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.comboBoxRegisterSex.SelectedIndex = 0;
            this.comboBoxRegisterPrivilege.SelectedIndex = 0;
            
        }
        private User newUser =new User();

        private void textBoxRegisterName_TextChanged(object sender, EventArgs e)
        {
            newUser.RegisteredName = this.textBoxRegisterRegisteredName.Text;
         
        }

        private void buttonCheckUserName_Click(object sender, EventArgs e)
        {
           
            UserManager um = new UserManager();
            if(um.CheckRegisteredName (newUser ))
                this.buttonCheckUserName.Text = "该用户名可用";
            else
                this.buttonCheckUserName.Text = "该用户名不可用";

        }

        
  
        private void buttonRegisterOK_Click(object sender, EventArgs e)
        {
            if (this.Text == "注册新用户")
            {
                //创建User实体
                newUser.Name = this.textBoxRegisterName.Text;
                if (this.textBoxRegisterPwd1.Text == this.textBoxRegisterPwd2.Text)
                    newUser.Password = this.textBoxRegisterPwd1.Text;
                else
                    newUser.Password = null;
                newUser.Position = this.textBoxRegisterPosition.Text;
                newUser.Privilege = Convert.ToInt32(this.comboBoxRegisterPrivilege.SelectedItem.ToString());
                newUser.Sex = this.comboBoxRegisterSex.SelectedText;
                newUser.Telephone = this.textBoxRegisterTele.Text;

                //创建业务对象，添加实体
                if (new UserManager().Check(newUser))
                {
                    if (newUser.Privilege > MainForm.LoadedUser.Privilege)
                    {
                        if (new UserManager().AddUser(newUser))
                        {
                            MessageBox.Show("注册新用户成功！", "提示");
                        }
                        else
                        {
                            MessageBox.Show("注册没有成功，请重新注册新用户！", "提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("您没有权限注册该新用户！","提示");
                    }
                }
                else
                {
                    MessageBox.Show("注册信息填写有误，请重新注册新用户！", "提示");
                }
            }
            else if(this.Text =="修改信息")
            {
                UserInformation.CurrentUser.Name =this.textBoxRegisterName.Text ;
                if (this.textBoxRegisterPwd1.Text == this.textBoxRegisterPwd2.Text)
                {
                    UserInformation.CurrentUser.Password = this.textBoxRegisterPwd1.Text;
                }
                else
                {
                    UserInformation.CurrentUser.Password = null;
                }
                UserInformation.CurrentUser.Position =this.textBoxRegisterPosition.Text ;
                UserInformation.CurrentUser.Privilege = Convert.ToInt32(this.comboBoxRegisterPrivilege.SelectedItem.ToString());
                UserInformation.CurrentUser.RegisteredName =this.textBoxRegisterRegisteredName.Text;
                UserInformation.CurrentUser.Sex =this.comboBoxRegisterSex.SelectedText ;
                UserInformation.CurrentUser.Telephone =this.textBoxRegisterTele.Text;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            if (this.Text == "修改信息")
            {
                this.label8.Text = null;

                this.textBoxRegisterName.Text =UserInformation.CurrentUser.Name ;
                this.textBoxRegisterPwd1.Text = UserInformation.CurrentUser.Password ;
                this.textBoxRegisterPwd2.Text = UserInformation.CurrentUser.Password;
                this.textBoxRegisterPosition.Text=UserInformation.CurrentUser.Position ;
                this.comboBoxRegisterPrivilege.Text = UserInformation.CurrentUser.Privilege.ToString();
                this.comboBoxRegisterPrivilege.Enabled = false;
                this.textBoxRegisterRegisteredName.Text =UserInformation.CurrentUser.RegisteredName ;
                this.textBoxRegisterRegisteredName.Enabled = false;
                this.comboBoxRegisterSex.Text  = UserInformation.CurrentUser.Sex;
                this.textBoxRegisterTele.Text =UserInformation.CurrentUser.Telephone ;

                this.buttonCheckUserName.Visible = false;
            }
        }
    }
}