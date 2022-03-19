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
    public partial class frmSerialPortSet : Form
    {
        public frmSerialPortSet()
        {
            InitializeComponent();
        }

        private void btnCheckCom_Click(object sender, EventArgs e)
        {

            bool comExistence = false;
            cbxCOMPort.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                    comExistence = true;
                }

                catch (Exception)
                {
                    continue;
                }
            }
            if (comExistence)
            {
                cbxCOMPort.SelectedIndex = 0;
            }
            else
            {
                cbxCOMPort.ResetText();//若未检测到串口，则清除显示的串口号
                MessageBox.Show("没有找到可用串口！", "错误提示！");
            }
        }

        public frmSerialPortSet(string COMPortNum,string COMBaudrate) : this()
        {
            cbxCOMPort.Text = COMPortNum;
            cbxBaudRate.Text = COMBaudrate;
        }

        public string getCOMPortNum
        {
            get { return cbxCOMPort.Text.Trim(); }
        }
        public string getCOMBaudrate
        {
            get { return cbxBaudRate.Text.Trim(); }
        }
    }
    

}
