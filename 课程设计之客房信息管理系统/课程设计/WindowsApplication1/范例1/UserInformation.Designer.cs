namespace 客房管理系统_1._0
{
    partial class UserInformation
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
            this.components = new System.ComponentModel.Container();
            this.listViewUserInformation = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewUserInformation
            // 
            this.listViewUserInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUserInformation.Location = new System.Drawing.Point(0, 0);
            this.listViewUserInformation.Name = "listViewUserInformation";
            this.listViewUserInformation.Size = new System.Drawing.Size(558, 334);
            this.listViewUserInformation.TabIndex = 0;
            this.listViewUserInformation.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改用户信息ToolStripMenuItem,
            this.删除用户信息ToolStripMenuItem,
            this.toolStripSeparator1,
            this.刷新ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 76);
            // 
            // 修改用户信息ToolStripMenuItem
            // 
            this.修改用户信息ToolStripMenuItem.Name = "修改用户信息ToolStripMenuItem";
            this.修改用户信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改用户信息ToolStripMenuItem.Text = "修改用户信息";
            this.修改用户信息ToolStripMenuItem.Click += new System.EventHandler(this.修改用户信息ToolStripMenuItem_Click);
            // 
            // 删除用户信息ToolStripMenuItem
            // 
            this.删除用户信息ToolStripMenuItem.Name = "删除用户信息ToolStripMenuItem";
            this.删除用户信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除用户信息ToolStripMenuItem.Text = "删除用户信息";
            this.删除用户信息ToolStripMenuItem.Click += new System.EventHandler(this.删除用户信息ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 334);
            this.Controls.Add(this.listViewUserInformation);
            this.Name = "UserInformation";
            this.Text = "用户信息管理";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUserInformation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 修改用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
    }
}