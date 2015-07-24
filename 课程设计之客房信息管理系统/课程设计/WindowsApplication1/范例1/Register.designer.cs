namespace 客房管理系统_1._0
{
    partial class Register
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegisterCancel = new System.Windows.Forms.Button();
            this.buttonRegisterOK = new System.Windows.Forms.Button();
            this.labelRegisterUserPwd1 = new System.Windows.Forms.Label();
            this.labelRegisterUserName = new System.Windows.Forms.Label();
            this.textBoxRegisterRegisteredName = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPwd1 = new System.Windows.Forms.TextBox();
            this.buttonCheckUserName = new System.Windows.Forms.Button();
            this.labelRegisterUserPwd2 = new System.Windows.Forms.Label();
            this.textBoxRegisterPwd2 = new System.Windows.Forms.TextBox();
            this.labelPrivilege = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserSex = new System.Windows.Forms.Label();
            this.labelTele = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxRegisterName = new System.Windows.Forms.TextBox();
            this.textBoxRegisterTele = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxRegisterSex = new System.Windows.Forms.ComboBox();
            this.comboBoxRegisterPrivilege = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonRegisterCancel
            // 
            this.buttonRegisterCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonRegisterCancel.Location = new System.Drawing.Point(48, 363);
            this.buttonRegisterCancel.Name = "buttonRegisterCancel";
            this.buttonRegisterCancel.Size = new System.Drawing.Size(87, 23);
            this.buttonRegisterCancel.TabIndex = 8;
            this.buttonRegisterCancel.Text = "取消";
            this.buttonRegisterCancel.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterOK
            // 
            this.buttonRegisterOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonRegisterOK.Location = new System.Drawing.Point(177, 363);
            this.buttonRegisterOK.Name = "buttonRegisterOK";
            this.buttonRegisterOK.Size = new System.Drawing.Size(87, 23);
            this.buttonRegisterOK.TabIndex = 9;
            this.buttonRegisterOK.Text = "确定";
            this.buttonRegisterOK.UseVisualStyleBackColor = true;
            this.buttonRegisterOK.Click += new System.EventHandler(this.buttonRegisterOK_Click);
            // 
            // labelRegisterUserPwd1
            // 
            this.labelRegisterUserPwd1.AutoSize = true;
            this.labelRegisterUserPwd1.Location = new System.Drawing.Point(46, 105);
            this.labelRegisterUserPwd1.Name = "labelRegisterUserPwd1";
            this.labelRegisterUserPwd1.Size = new System.Drawing.Size(29, 12);
            this.labelRegisterUserPwd1.TabIndex = 2;
            this.labelRegisterUserPwd1.Text = "密码";
            // 
            // labelRegisterUserName
            // 
            this.labelRegisterUserName.AutoSize = true;
            this.labelRegisterUserName.Location = new System.Drawing.Point(46, 51);
            this.labelRegisterUserName.Name = "labelRegisterUserName";
            this.labelRegisterUserName.Size = new System.Drawing.Size(41, 12);
            this.labelRegisterUserName.TabIndex = 3;
            this.labelRegisterUserName.Text = "用户名";
            // 
            // textBoxRegisterRegisteredName
            // 
            this.textBoxRegisterRegisteredName.Location = new System.Drawing.Point(141, 48);
            this.textBoxRegisterRegisteredName.Name = "textBoxRegisterRegisteredName";
            this.textBoxRegisterRegisteredName.Size = new System.Drawing.Size(123, 21);
            this.textBoxRegisterRegisteredName.TabIndex = 0;
            this.textBoxRegisterRegisteredName.TextChanged += new System.EventHandler(this.textBoxRegisterName_TextChanged);
            // 
            // textBoxRegisterPwd1
            // 
            this.textBoxRegisterPwd1.Location = new System.Drawing.Point(141, 102);
            this.textBoxRegisterPwd1.Name = "textBoxRegisterPwd1";
            this.textBoxRegisterPwd1.PasswordChar = '*';
            this.textBoxRegisterPwd1.Size = new System.Drawing.Size(123, 21);
            this.textBoxRegisterPwd1.TabIndex = 2;
            // 
            // buttonCheckUserName
            // 
            this.buttonCheckUserName.Location = new System.Drawing.Point(141, 74);
            this.buttonCheckUserName.Name = "buttonCheckUserName";
            this.buttonCheckUserName.Size = new System.Drawing.Size(123, 23);
            this.buttonCheckUserName.TabIndex = 1;
            this.buttonCheckUserName.Text = "检查用户名是否可用";
            this.buttonCheckUserName.UseVisualStyleBackColor = true;
            this.buttonCheckUserName.Click += new System.EventHandler(this.buttonCheckUserName_Click);
            // 
            // labelRegisterUserPwd2
            // 
            this.labelRegisterUserPwd2.AutoSize = true;
            this.labelRegisterUserPwd2.Location = new System.Drawing.Point(46, 143);
            this.labelRegisterUserPwd2.Name = "labelRegisterUserPwd2";
            this.labelRegisterUserPwd2.Size = new System.Drawing.Size(89, 12);
            this.labelRegisterUserPwd2.TabIndex = 6;
            this.labelRegisterUserPwd2.Text = "请再次输入密码";
            // 
            // textBoxRegisterPwd2
            // 
            this.textBoxRegisterPwd2.Location = new System.Drawing.Point(141, 140);
            this.textBoxRegisterPwd2.Name = "textBoxRegisterPwd2";
            this.textBoxRegisterPwd2.PasswordChar = '*';
            this.textBoxRegisterPwd2.Size = new System.Drawing.Size(123, 21);
            this.textBoxRegisterPwd2.TabIndex = 3;
            // 
            // labelPrivilege
            // 
            this.labelPrivilege.AutoSize = true;
            this.labelPrivilege.Location = new System.Drawing.Point(46, 181);
            this.labelPrivilege.Name = "labelPrivilege";
            this.labelPrivilege.Size = new System.Drawing.Size(77, 12);
            this.labelPrivilege.TabIndex = 1;
            this.labelPrivilege.Text = "用户权限级别";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(46, 219);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(29, 12);
            this.labelUserName.TabIndex = 11;
            this.labelUserName.Text = "姓名";
            // 
            // labelUserSex
            // 
            this.labelUserSex.AutoSize = true;
            this.labelUserSex.Location = new System.Drawing.Point(46, 251);
            this.labelUserSex.Name = "labelUserSex";
            this.labelUserSex.Size = new System.Drawing.Size(29, 12);
            this.labelUserSex.TabIndex = 12;
            this.labelUserSex.Text = "性别";
            // 
            // labelTele
            // 
            this.labelTele.AutoSize = true;
            this.labelTele.Location = new System.Drawing.Point(46, 285);
            this.labelTele.Name = "labelTele";
            this.labelTele.Size = new System.Drawing.Size(53, 12);
            this.labelTele.TabIndex = 13;
            this.labelTele.Text = "电话号码";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(46, 323);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(29, 12);
            this.labelPosition.TabIndex = 14;
            this.labelPosition.Text = "职位";
            // 
            // textBoxRegisterName
            // 
            this.textBoxRegisterName.Location = new System.Drawing.Point(141, 216);
            this.textBoxRegisterName.Name = "textBoxRegisterName";
            this.textBoxRegisterName.Size = new System.Drawing.Size(123, 21);
            this.textBoxRegisterName.TabIndex = 15;
            // 
            // textBoxRegisterTele
            // 
            this.textBoxRegisterTele.Location = new System.Drawing.Point(141, 282);
            this.textBoxRegisterTele.Name = "textBoxRegisterTele";
            this.textBoxRegisterTele.Size = new System.Drawing.Size(123, 21);
            this.textBoxRegisterTele.TabIndex = 17;
            // 
            // textBoxRegisterPosition
            // 
            this.textBoxRegisterPosition.Location = new System.Drawing.Point(141, 320);
            this.textBoxRegisterPosition.Name = "textBoxRegisterPosition";
            this.textBoxRegisterPosition.Size = new System.Drawing.Size(123, 21);
            this.textBoxRegisterPosition.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "请填写注册信息，带‘*’的项目为必填项目！";
            // 
            // comboBoxRegisterSex
            // 
            this.comboBoxRegisterSex.FormattingEnabled = true;
            this.comboBoxRegisterSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxRegisterSex.Location = new System.Drawing.Point(141, 248);
            this.comboBoxRegisterSex.Name = "comboBoxRegisterSex";
            this.comboBoxRegisterSex.Size = new System.Drawing.Size(121, 20);
            this.comboBoxRegisterSex.TabIndex = 16;
            // 
            // comboBoxRegisterPrivilege
            // 
            this.comboBoxRegisterPrivilege.FormattingEnabled = true;
            this.comboBoxRegisterPrivilege.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBoxRegisterPrivilege.Location = new System.Drawing.Point(141, 178);
            this.comboBoxRegisterPrivilege.Name = "comboBoxRegisterPrivilege";
            this.comboBoxRegisterPrivilege.Size = new System.Drawing.Size(121, 20);
            this.comboBoxRegisterPrivilege.TabIndex = 10;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 419);
            this.Controls.Add(this.comboBoxRegisterPrivilege);
            this.Controls.Add(this.comboBoxRegisterSex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegisterPosition);
            this.Controls.Add(this.textBoxRegisterTele);
            this.Controls.Add(this.textBoxRegisterName);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelTele);
            this.Controls.Add(this.labelUserSex);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelPrivilege);
            this.Controls.Add(this.textBoxRegisterPwd2);
            this.Controls.Add(this.labelRegisterUserPwd2);
            this.Controls.Add(this.buttonCheckUserName);
            this.Controls.Add(this.textBoxRegisterPwd1);
            this.Controls.Add(this.textBoxRegisterRegisteredName);
            this.Controls.Add(this.labelRegisterUserName);
            this.Controls.Add(this.labelRegisterUserPwd1);
            this.Controls.Add(this.buttonRegisterOK);
            this.Controls.Add(this.buttonRegisterCancel);
            this.Name = "Register";
            this.Text = "注册新用户";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegisterCancel;
        private System.Windows.Forms.Button buttonRegisterOK;
        private System.Windows.Forms.Label labelRegisterUserPwd1;
        private System.Windows.Forms.Label labelRegisterUserName;
        private System.Windows.Forms.TextBox textBoxRegisterRegisteredName;
        private System.Windows.Forms.TextBox textBoxRegisterPwd1;
        private System.Windows.Forms.Button buttonCheckUserName;
        private System.Windows.Forms.Label labelRegisterUserPwd2;
        private System.Windows.Forms.TextBox textBoxRegisterPwd2;
        private System.Windows.Forms.Label labelPrivilege;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserSex;
        private System.Windows.Forms.Label labelTele;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxRegisterName;
        private System.Windows.Forms.TextBox textBoxRegisterTele;
        private System.Windows.Forms.TextBox textBoxRegisterPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxRegisterSex;
        private System.Windows.Forms.ComboBox comboBoxRegisterPrivilege;
    }
}