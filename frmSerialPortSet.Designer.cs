namespace _100test
{
    partial class frmSerialPortSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckCom = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // btnCheckCom
            // 
            this.btnCheckCom.Location = new System.Drawing.Point(41, 111);
            this.btnCheckCom.Name = "btnCheckCom";
            this.btnCheckCom.Size = new System.Drawing.Size(157, 23);
            this.btnCheckCom.TabIndex = 4;
            this.btnCheckCom.Text = "搜索可用串口";
            this.btnCheckCom.UseVisualStyleBackColor = true;
            this.btnCheckCom.Click += new System.EventHandler(this.btnCheckCom_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(41, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "确认";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.FormattingEnabled = true;
            this.cbxCOMPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.cbxCOMPort.Location = new System.Drawing.Point(86, 28);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(112, 20);
            this.cbxCOMPort.TabIndex = 6;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "921600",
            "115200",
            "9600",
            "4800",
            "2400",
            "1200",
            "960",
            "480"});
            this.cbxBaudRate.Location = new System.Drawing.Point(86, 65);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(112, 20);
            this.cbxBaudRate.TabIndex = 7;
            this.cbxBaudRate.Text = "115200";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(41, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSerialPortSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxBaudRate);
            this.Controls.Add(this.cbxCOMPort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCheckCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSerialPortSet";
            this.Text = "串口设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckCom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Button button1;
    }
}