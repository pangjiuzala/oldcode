namespace 客房管理系统_1._0
{
    partial class LoadForm
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
            this.buttonLoadCancel = new System.Windows.Forms.Button();
            this.textBoxLoadUserPwd = new System.Windows.Forms.TextBox();
            this.textBoxLoadUserName = new System.Windows.Forms.TextBox();
            this.labelLoadUserPwd = new System.Windows.Forms.Label();
            this.labelLoadUserName = new System.Windows.Forms.Label();
            this.buttonLoadOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadCancel
            // 
            this.buttonLoadCancel.Location = new System.Drawing.Point(25, 142);
            this.buttonLoadCancel.Name = "buttonLoadCancel";
            this.buttonLoadCancel.Size = new System.Drawing.Size(67, 23);
            this.buttonLoadCancel.TabIndex = 3;
            this.buttonLoadCancel.Text = "重置";
            this.buttonLoadCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxLoadUserPwd
            // 
            this.textBoxLoadUserPwd.Location = new System.Drawing.Point(80, 90);
            this.textBoxLoadUserPwd.Name = "textBoxLoadUserPwd";
            this.textBoxLoadUserPwd.PasswordChar = '*';
            this.textBoxLoadUserPwd.Size = new System.Drawing.Size(100, 21);
            this.textBoxLoadUserPwd.TabIndex = 1;
            // 
            // textBoxLoadUserName
            // 
            this.textBoxLoadUserName.Location = new System.Drawing.Point(80, 31);
            this.textBoxLoadUserName.Name = "textBoxLoadUserName";
            this.textBoxLoadUserName.Size = new System.Drawing.Size(100, 21);
            this.textBoxLoadUserName.TabIndex = 0;
            // 
            // labelLoadUserPwd
            // 
            this.labelLoadUserPwd.AutoSize = true;
            this.labelLoadUserPwd.Location = new System.Drawing.Point(23, 93);
            this.labelLoadUserPwd.Name = "labelLoadUserPwd";
            this.labelLoadUserPwd.Size = new System.Drawing.Size(29, 12);
            this.labelLoadUserPwd.TabIndex = 2;
            this.labelLoadUserPwd.Text = "密码";
            // 
            // labelLoadUserName
            // 
            this.labelLoadUserName.AutoSize = true;
            this.labelLoadUserName.Location = new System.Drawing.Point(23, 34);
            this.labelLoadUserName.Name = "labelLoadUserName";
            this.labelLoadUserName.Size = new System.Drawing.Size(41, 12);
            this.labelLoadUserName.TabIndex = 5;
            this.labelLoadUserName.Text = "用户名";
            // 
            // buttonLoadOK
            // 
            this.buttonLoadOK.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoadOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLoadOK.Location = new System.Drawing.Point(113, 142);
            this.buttonLoadOK.Name = "buttonLoadOK";
            this.buttonLoadOK.Size = new System.Drawing.Size(67, 23);
            this.buttonLoadOK.TabIndex = 2;
            this.buttonLoadOK.Text = "确定";
            this.buttonLoadOK.UseVisualStyleBackColor = false;
            this.buttonLoadOK.Click += new System.EventHandler(this.buttonLoadOK_Click);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 207);
            this.Controls.Add(this.labelLoadUserName);
            this.Controls.Add(this.labelLoadUserPwd);
            this.Controls.Add(this.textBoxLoadUserName);
            this.Controls.Add(this.textBoxLoadUserPwd);
            this.Controls.Add(this.buttonLoadOK);
            this.Controls.Add(this.buttonLoadCancel);
            this.MaximumSize = new System.Drawing.Size(220, 243);
            this.MinimumSize = new System.Drawing.Size(220, 243);
            this.Name = "LoadForm";
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadCancel;
        private System.Windows.Forms.Button buttonLoadOK;
        private System.Windows.Forms.TextBox textBoxLoadUserPwd;
        private System.Windows.Forms.TextBox textBoxLoadUserName;
        private System.Windows.Forms.Label labelLoadUserPwd;
        private System.Windows.Forms.Label labelLoadUserName;
    }
}