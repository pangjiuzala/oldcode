namespace WindowsApplication1
{
    partial class 客户结账
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(客户结账));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.客房信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客房管理DataSet = new WindowsApplication1.客房管理DataSet();
            this.客房信息BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.客房管理DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客房信息TableAdapter = new WindowsApplication1.客房管理DataSetTableAdapters.客房信息TableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.客户信息BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.客户信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客户信息TableAdapter = new WindowsApplication1.客房管理DataSetTableAdapters.客户信息TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.客房信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客房管理DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客房信息BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客房管理DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户信息BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(167, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "应收金额：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "打折：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "95",
            "90",
            "85",
            "80",
            "75",
            "70"});
            this.comboBox1.Location = new System.Drawing.Point(78, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("楷体_GB2312", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(251, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 20);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "结账";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "姓名：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.客房信息BindingSource, "客房价格", true));
            this.comboBox2.DataSource = this.客房信息BindingSource1;
            this.comboBox2.DisplayMember = "客房价格";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(251, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(83, 20);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "客房价格";
            // 
            // 客房信息BindingSource
            // 
            this.客房信息BindingSource.DataMember = "客房信息";
            this.客房信息BindingSource.DataSource = this.客房管理DataSet;
            // 
            // 客房管理DataSet
            // 
            this.客房管理DataSet.DataSetName = "客房管理DataSet";
            this.客房管理DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 客房信息BindingSource1
            // 
            this.客房信息BindingSource1.DataMember = "客房信息";
            this.客房信息BindingSource1.DataSource = this.客房管理DataSet;
            // 
            // 客房管理DataSetBindingSource
            // 
            this.客房管理DataSetBindingSource.DataSource = this.客房管理DataSet;
            this.客房管理DataSetBindingSource.Position = 0;
            // 
            // 客房信息TableAdapter
            // 
            this.客房信息TableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.客户信息BindingSource1, "姓名", true));
            this.comboBox3.DataSource = this.客户信息BindingSource;
            this.comboBox3.DisplayMember = "姓名";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(78, 17);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(83, 20);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.ValueMember = "姓名";
            // 
            // 客户信息BindingSource1
            // 
            this.客户信息BindingSource1.DataMember = "客户信息";
            this.客户信息BindingSource1.DataSource = this.客房管理DataSet;
            // 
            // 客户信息BindingSource
            // 
            this.客户信息BindingSource.DataMember = "客户信息";
            this.客户信息BindingSource.DataSource = this.客房管理DataSetBindingSource;
            // 
            // 客户信息TableAdapter
            // 
            this.客户信息TableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 228);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // 客户结账
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(349, 231);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "客户结账";
            this.Text = "客户结账";
            this.Load += new System.EventHandler(this.客户结账_Load);
            ((System.ComponentModel.ISupportInitialize)(this.客房信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客房管理DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客房信息BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客房管理DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户信息BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客户信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource 客房管理DataSetBindingSource;
        private 客房管理DataSet 客房管理DataSet;
        private System.Windows.Forms.BindingSource 客房信息BindingSource;
        private WindowsApplication1.客房管理DataSetTableAdapters.客房信息TableAdapter 客房信息TableAdapter;
        private System.Windows.Forms.BindingSource 客房信息BindingSource1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource 客户信息BindingSource;
        private WindowsApplication1.客房管理DataSetTableAdapters.客户信息TableAdapter 客户信息TableAdapter;
        private System.Windows.Forms.BindingSource 客户信息BindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}