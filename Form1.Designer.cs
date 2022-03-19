namespace _100test
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSerialPortSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpenSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.操作人员选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存储测试结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.操作人员选择ToolStripMenuItem,
            this.存储测试结果ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSerialPortSet,
            this.tsmOpenSerial});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "通信连接";
            // 
            // tsmSerialPortSet
            // 
            this.tsmSerialPortSet.Name = "tsmSerialPortSet";
            this.tsmSerialPortSet.Size = new System.Drawing.Size(180, 22);
            this.tsmSerialPortSet.Text = "串口设置";
            this.tsmSerialPortSet.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmOpenSerial
            // 
            this.tsmOpenSerial.Name = "tsmOpenSerial";
            this.tsmOpenSerial.Size = new System.Drawing.Size(180, 22);
            this.tsmOpenSerial.Text = "打开串口";
            this.tsmOpenSerial.Click += new System.EventHandler(this.tsmOpenSerial_Click);
            // 
            // 操作人员选择ToolStripMenuItem
            // 
            this.操作人员选择ToolStripMenuItem.Name = "操作人员选择ToolStripMenuItem";
            this.操作人员选择ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.操作人员选择ToolStripMenuItem.Text = "操作人员选择";
            // 
            // 存储测试结果ToolStripMenuItem
            // 
            this.存储测试结果ToolStripMenuItem.Name = "存储测试结果ToolStripMenuItem";
            this.存储测试结果ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.存储测试结果ToolStripMenuItem.Text = "存储";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.打印ToolStripMenuItem.Text = "打印";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "SWQ100测试系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 操作人员选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存储测试结果ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSerialPortSet;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenSerial;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

