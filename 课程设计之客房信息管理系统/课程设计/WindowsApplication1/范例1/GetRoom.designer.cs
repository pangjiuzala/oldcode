namespace 客房管理系统_1._0
{
    partial class GetRoom
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
            this.labelStayTime = new System.Windows.Forms.Label();
            this.labelGuestId = new System.Windows.Forms.Label();
            this.labelGuestSex = new System.Windows.Forms.Label();
            this.labelGuestName = new System.Windows.Forms.Label();
            this.textBoxGuestName = new System.Windows.Forms.TextBox();
            this.textBoxGuestId = new System.Windows.Forms.TextBox();
            this.textBoxStayTime = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxGuestSex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelStayTime
            // 
            this.labelStayTime.AutoSize = true;
            this.labelStayTime.Location = new System.Drawing.Point(64, 180);
            this.labelStayTime.Name = "labelStayTime";
            this.labelStayTime.Size = new System.Drawing.Size(101, 12);
            this.labelStayTime.TabIndex = 3;
            this.labelStayTime.Text = "预期入住时间(天)";
            // 
            // labelGuestId
            // 
            this.labelGuestId.AutoSize = true;
            this.labelGuestId.Location = new System.Drawing.Point(64, 137);
            this.labelGuestId.Name = "labelGuestId";
            this.labelGuestId.Size = new System.Drawing.Size(53, 12);
            this.labelGuestId.TabIndex = 2;
            this.labelGuestId.Text = "身份证号";
            // 
            // labelGuestSex
            // 
            this.labelGuestSex.AutoSize = true;
            this.labelGuestSex.Location = new System.Drawing.Point(64, 94);
            this.labelGuestSex.Name = "labelGuestSex";
            this.labelGuestSex.Size = new System.Drawing.Size(29, 12);
            this.labelGuestSex.TabIndex = 1;
            this.labelGuestSex.Text = "性别";
            // 
            // labelGuestName
            // 
            this.labelGuestName.AutoSize = true;
            this.labelGuestName.Location = new System.Drawing.Point(64, 51);
            this.labelGuestName.Name = "labelGuestName";
            this.labelGuestName.Size = new System.Drawing.Size(29, 12);
            this.labelGuestName.TabIndex = 0;
            this.labelGuestName.Text = "姓名";
            // 
            // textBoxGuestName
            // 
            this.textBoxGuestName.Location = new System.Drawing.Point(151, 48);
            this.textBoxGuestName.Name = "textBoxGuestName";
            this.textBoxGuestName.Size = new System.Drawing.Size(144, 21);
            this.textBoxGuestName.TabIndex = 8;
         
            // 
            // textBoxGuestId
            // 
            this.textBoxGuestId.Location = new System.Drawing.Point(151, 134);
            this.textBoxGuestId.Name = "textBoxGuestId";
            this.textBoxGuestId.Size = new System.Drawing.Size(144, 21);
            this.textBoxGuestId.TabIndex = 10;
         
            // 
            // textBoxStayTime
            // 
            this.textBoxStayTime.Location = new System.Drawing.Point(151, 209);
            this.textBoxStayTime.Name = "textBoxStayTime";
            this.textBoxStayTime.Size = new System.Drawing.Size(144, 21);
            this.textBoxStayTime.TabIndex = 11;
    
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(78, 253);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(191, 253);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBoxGuestSex
            // 
            this.comboBoxGuestSex.FormattingEnabled = true;
            this.comboBoxGuestSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxGuestSex.Location = new System.Drawing.Point(151, 91);
            this.comboBoxGuestSex.Name = "comboBoxGuestSex";
            this.comboBoxGuestSex.Size = new System.Drawing.Size(144, 20);
            this.comboBoxGuestSex.TabIndex = 14;

            // 
            // GetRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 337);
            this.Controls.Add(this.labelGuestName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelGuestSex);
            this.Controls.Add(this.comboBoxGuestSex);
            this.Controls.Add(this.labelGuestId);
            this.Controls.Add(this.textBoxGuestName);
            this.Controls.Add(this.labelStayTime);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxGuestId);
            this.Controls.Add(this.textBoxStayTime);
            this.Name = "GetRoom";
            this.Text = "入住登记";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStayTime;
        private System.Windows.Forms.Label labelGuestId;
        private System.Windows.Forms.Label labelGuestSex;
        private System.Windows.Forms.Label labelGuestName;
        private System.Windows.Forms.TextBox textBoxGuestName;
        private System.Windows.Forms.TextBox textBoxGuestId;
        private System.Windows.Forms.TextBox textBoxStayTime;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxGuestSex;

    }
}