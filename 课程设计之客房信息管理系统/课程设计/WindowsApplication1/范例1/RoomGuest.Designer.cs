namespace 客房管理系统_1._0
{
    partial class RoomGuest
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelInTime = new System.Windows.Forms.Label();
            this.labelStayTime = new System.Windows.Forms.Label();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.textBoxInTime = new System.Windows.Forms.TextBox();
            this.textBoxStayTime = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "姓名";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(32, 78);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(29, 12);
            this.labelSex.TabIndex = 1;
            this.labelSex.Text = "性别";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(32, 120);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(41, 12);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "身份证";
            // 
            // labelInTime
            // 
            this.labelInTime.AutoSize = true;
            this.labelInTime.Location = new System.Drawing.Point(32, 211);
            this.labelInTime.Name = "labelInTime";
            this.labelInTime.Size = new System.Drawing.Size(53, 12);
            this.labelInTime.TabIndex = 3;
            this.labelInTime.Text = "入住时间";
            // 
            // labelStayTime
            // 
            this.labelStayTime.AutoSize = true;
            this.labelStayTime.Location = new System.Drawing.Point(32, 257);
            this.labelStayTime.Name = "labelStayTime";
            this.labelStayTime.Size = new System.Drawing.Size(77, 12);
            this.labelStayTime.TabIndex = 4;
            this.labelStayTime.Text = "预期居住时间";
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Location = new System.Drawing.Point(32, 170);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(53, 12);
            this.labelDeposit.TabIndex = 5;
            this.labelDeposit.Text = "已交押金";
            // 
            // textBoxSex
            // 
            this.textBoxSex.Location = new System.Drawing.Point(146, 75);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.ReadOnly = true;
            this.textBoxSex.Size = new System.Drawing.Size(100, 21);
            this.textBoxSex.TabIndex = 6;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(146, 117);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 21);
            this.textBoxID.TabIndex = 7;
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Location = new System.Drawing.Point(146, 167);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.ReadOnly = true;
            this.textBoxDeposit.Size = new System.Drawing.Size(100, 21);
            this.textBoxDeposit.TabIndex = 8;
            // 
            // textBoxInTime
            // 
            this.textBoxInTime.Location = new System.Drawing.Point(146, 208);
            this.textBoxInTime.Name = "textBoxInTime";
            this.textBoxInTime.ReadOnly = true;
            this.textBoxInTime.Size = new System.Drawing.Size(100, 21);
            this.textBoxInTime.TabIndex = 9;
            // 
            // textBoxStayTime
            // 
            this.textBoxStayTime.Location = new System.Drawing.Point(146, 248);
            this.textBoxStayTime.Name = "textBoxStayTime";
            this.textBoxStayTime.ReadOnly = true;
            this.textBoxStayTime.Size = new System.Drawing.Size(100, 21);
            this.textBoxStayTime.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(146, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "续住";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoomGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxStayTime);
            this.Controls.Add(this.textBoxInTime);
            this.Controls.Add(this.textBoxDeposit);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxSex);
            this.Controls.Add(this.labelDeposit);
            this.Controls.Add(this.labelStayTime);
            this.Controls.Add(this.labelInTime);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelName);
            this.Name = "RoomGuest";
            this.Text = "RoomGuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelInTime;
        private System.Windows.Forms.Label labelStayTime;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.TextBox textBoxInTime;
        private System.Windows.Forms.TextBox textBoxStayTime;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button1;
    }
}