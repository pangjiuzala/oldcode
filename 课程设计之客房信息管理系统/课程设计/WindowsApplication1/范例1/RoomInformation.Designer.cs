namespace 客房管理系统_1._0
{
    partial class RoomInformation
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加客房ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改客房信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除客房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加客房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改客房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除客房ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加客房ToolStripMenuItem1,
            this.修改客房信息ToolStripMenuItem,
            this.删除客房ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加客房ToolStripMenuItem1
            // 
            this.添加客房ToolStripMenuItem1.Name = "添加客房ToolStripMenuItem1";
            this.添加客房ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.添加客房ToolStripMenuItem1.Text = "添加客房";
            this.添加客房ToolStripMenuItem1.Click += new System.EventHandler(this.AddRoom);
            // 
            // 修改客房信息ToolStripMenuItem
            // 
            this.修改客房信息ToolStripMenuItem.Name = "修改客房信息ToolStripMenuItem";
            this.修改客房信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.修改客房信息ToolStripMenuItem.Text = "修改客房";
            this.修改客房信息ToolStripMenuItem.Click += new System.EventHandler(this.UpdateRoom);
            // 
            // 删除客房ToolStripMenuItem
            // 
            this.删除客房ToolStripMenuItem.Name = "删除客房ToolStripMenuItem";
            this.删除客房ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.删除客房ToolStripMenuItem.Text = "删除客房";
            this.删除客房ToolStripMenuItem.Click += new System.EventHandler(this.DeleteRoom);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(554, 415);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;

            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加客房ToolStripMenuItem,
            this.修改客房ToolStripMenuItem,
            this.删除客房ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 添加客房ToolStripMenuItem
            // 
            this.添加客房ToolStripMenuItem.Name = "添加客房ToolStripMenuItem";
            this.添加客房ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加客房ToolStripMenuItem.Text = "添加客房";
            this.添加客房ToolStripMenuItem.Click += new System.EventHandler(this.AddRoom);
            // 
            // 修改客房ToolStripMenuItem
            // 
            this.修改客房ToolStripMenuItem.Name = "修改客房ToolStripMenuItem";
            this.修改客房ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改客房ToolStripMenuItem.Text = "修改客房";
            this.修改客房ToolStripMenuItem.Click += new System.EventHandler(this.UpdateRoom);
            // 
            // 删除客房ToolStripMenuItem1
            // 
            this.删除客房ToolStripMenuItem1.Name = "删除客房ToolStripMenuItem1";
            this.删除客房ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.删除客房ToolStripMenuItem1.Text = "删除客房";
            this.删除客房ToolStripMenuItem1.Click += new System.EventHandler(this.DeleteRoom);
            // 
            // RoomInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 440);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RoomInformation";
            this.Text = "客房信息管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加客房ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改客房信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除客房ToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加客房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改客房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除客房ToolStripMenuItem1;
    }
}