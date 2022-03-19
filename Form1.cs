using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _100test
{
    public partial class Form1 : Form
    {
        SerialPort sp = null;
        bool isOpen = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmabout f = new frmabout();
            f.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSerialPortSet    f= new frmSerialPortSet();
            if(f.ShowDialog()==DialogResult.OK)
            {
                sp = new SerialPort();
                string s = f.getCOMBaudrate;
                try 
                {                 
                    sp.BaudRate = Convert.ToInt32(s);
                    sp.PortName = f.getCOMPortNum; 
                }
                catch (Exception ex)
                { 
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("串口号不能为空");
                }            
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsmOpenSerial_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {

                try
                {

                    sp.Open();
                    isOpen = true;
                    this.BeginInvoke(new EventHandler(delegate
                    {
                        this.tsmOpenSerial.Text = "关闭串口";
                    }));

                }
                catch (Exception)
                {
                    isOpen = false;
                    MessageBox.Show("串口无效或已被占用", "错误提示");
                }
            }
            else if (isOpen == true)
            {

                try
                {

                     sp.Close();//关闭端口
                     isOpen = false;
                     this.BeginInvoke(new EventHandler(delegate
                     {
                         tsmOpenSerial.Text = "打开串口";
                     }));
                }
                catch (Exception)
                {
                    MessageBox.Show("关闭串口时发生错误", "错误提示");
                }
            }
        }
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs eg)
        {


            byte[] ReDatas = new byte[sp.BytesToRead];
            sp.Read(ReDatas, 0, ReDatas.Length);//读取数据
            //this.AddData(ReDatas);//输出数据
        }
    }
    
}
