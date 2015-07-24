namespace 客房管理系统_1._0
{
    partial class AddRoom
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
            this.labelRoomName = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelRoomDayCount = new System.Windows.Forms.Label();
            this.labelRoomDeposit = new System.Windows.Forms.Label();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.textBoxRoomDayCount = new System.Windows.Forms.TextBox();
            this.textBoxRoomDeposit = new System.Windows.Forms.TextBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Location = new System.Drawing.Point(30, 31);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(41, 12);
            this.labelRoomName.TabIndex = 0;
            this.labelRoomName.Text = "客房名";
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Location = new System.Drawing.Point(30, 68);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(53, 12);
            this.labelRoomType.TabIndex = 1;
            this.labelRoomType.Text = "客房类型";
            // 
            // labelRoomDayCount
            // 
            this.labelRoomDayCount.AutoSize = true;
            this.labelRoomDayCount.Location = new System.Drawing.Point(30, 106);
            this.labelRoomDayCount.Name = "labelRoomDayCount";
            this.labelRoomDayCount.Size = new System.Drawing.Size(41, 12);
            this.labelRoomDayCount.TabIndex = 2;
            this.labelRoomDayCount.Text = "日消费";
            // 
            // labelRoomDeposit
            // 
            this.labelRoomDeposit.AutoSize = true;
            this.labelRoomDeposit.Location = new System.Drawing.Point(30, 142);
            this.labelRoomDeposit.Name = "labelRoomDeposit";
            this.labelRoomDeposit.Size = new System.Drawing.Size(29, 12);
            this.labelRoomDeposit.TabIndex = 3;
            this.labelRoomDeposit.Text = "押金";
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Location = new System.Drawing.Point(97, 28);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(121, 21);
            this.textBoxRoomName.TabIndex = 5;
            // 
            // textBoxRoomDayCount
            // 
            this.textBoxRoomDayCount.Location = new System.Drawing.Point(97, 103);
            this.textBoxRoomDayCount.Name = "textBoxRoomDayCount";
            this.textBoxRoomDayCount.Size = new System.Drawing.Size(121, 21);
            this.textBoxRoomDayCount.TabIndex = 7;
            // 
            // textBoxRoomDeposit
            // 
            this.textBoxRoomDeposit.Location = new System.Drawing.Point(97, 139);
            this.textBoxRoomDeposit.Name = "textBoxRoomDeposit";
            this.textBoxRoomDeposit.Size = new System.Drawing.Size(121, 21);
            this.textBoxRoomDeposit.TabIndex = 8;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "单人间",
            "双人间",
            "三人间",
            "套房"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(97, 68);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxRoomType.TabIndex = 9;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(32, 203);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(143, 203);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 264);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.textBoxRoomDeposit);
            this.Controls.Add(this.textBoxRoomDayCount);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.labelRoomDeposit);
            this.Controls.Add(this.labelRoomDayCount);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.labelRoomName);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelRoomDayCount;
        private System.Windows.Forms.Label labelRoomDeposit;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.TextBox textBoxRoomDayCount;
        private System.Windows.Forms.TextBox textBoxRoomDeposit;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}