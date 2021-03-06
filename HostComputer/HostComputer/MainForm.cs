﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace HostComputer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ///初始设置
            CheckForIllegalCrossThreadCalls = false;
            ComboBox_Click(comboBox, e: null);
            comboBox1.SelectedIndex = 6;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 7;
            //serialPort.Encoding = Encoding.GetEncoding("GB2312");
        }

        /// <summary>
        /// 扫描串口
        /// </summary>
        private void ComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox.Items.Clear();
                string[] arr = SerialPort.GetPortNames();
                foreach (var item in arr)
                {
                    comboBox.Items.Add(item);
                }
                comboBox.SelectedIndex = 0;
            }
            catch
            {
            }
        }
        /// <summary>
        /// 链接/断开串口
        /// </summary>
        private void But_Port_Link_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                But_Port_Link.Text = "打开串口";
                But_Port_Link.ImageKey = "OFF.png";
            }
            else
            {
                try
                {
                    serialPort.PortName = (string)comboBox.SelectedItem;
                    serialPort.BaudRate = Convert.ToInt32(comboBox1.SelectedItem);
                    serialPort.StopBits = (StopBits)comboBox2.SelectedIndex + 1;
                    serialPort.DataBits = Convert.ToInt32(comboBox3.SelectedItem);
                    serialPort.Parity = (Parity)comboBox4.SelectedIndex;
                    serialPort.Open();
                    But_Port_Link.Text = "关闭串口";
                    But_Port_Link.ImageKey = "ON.png";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        /// <summary>
        /// Button 功能并合
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            if (name == But_LED0_ON.Name)
            {
                PortWrite(0x00, 0x01);
            }
            else if (name == But_LED0_OFF.Name)
            {
                PortWrite(0x00, 0x00);
            }
            else if (name == But_LED1_ON.Name)
            {
                PortWrite(0x00, 0x11);
            }
            else if (name == But_LED1_OFF.Name)
            {
                PortWrite(0x00, 0x10);
            }
            else if (name == But_BEEP_ON.Name)
            {
                PortWrite(0x01, 0x01);
            }
            else if (name == But_BEEP_OFF.Name)

            {
                PortWrite(0x01, 0x00);
            }
            else if (name == But_BEEP_Delay.Name)
            {
                PortWrite(0x04, Convert.ToUInt16(BEEP_ms.Text), 2);
            }
            else
            {
                ;
            }
        }
        /// <summary>
        /// LED闪烁
        /// </summary>
        private void But_LEDFlsh_Click(object sender, EventArgs e)
        {
            uint temp = 0x00;
            if (Check_LED0.Checked)
            {
                temp += 0x01;
            }
            if (Check_LED1.Checked)
            {
                temp += 0x10;
            }
            PortWrite(0x02, temp);
        }
        /// <summary>
        /// 状态咨询
        /// </summary>
        private void But_Scan_Click(object sender, EventArgs e)
        {
            PortWrite(0x03, 0x01);
            Delay(3);
            PortWrite(0x03, 0x00);
        }
        /// <summary>
        /// 自定义内容发送
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(textBox3.Text + "\r\n");
            }
        }
        /// <summary>
        /// 咨询ADC的值
        /// </summary>
        private void But_ADC_Click(object sender, EventArgs e)
        {
            PortWrite(0xa0, 0x00);
        }
        /// <summary>
        /// 修改ADC采集方式
        /// </summary>
        private void But_ADC_Change_Click(object sender, EventArgs e)
        {
            uint data = (uint)comboBox5.SelectedIndex << 8 * 3;
            data += Convert.ToUInt16(textBox4.Text);
            PortWrite(0xa1, data, 4);
        }
        /// <summary>
        /// 实时更新控制
        /// </summary>
        private void But_Timer_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                if (Timer1.Enabled)
                {
                    Timer1.Enabled = false;
                    But_Timer.Text = "开启实时更新";
                    But_Timer.ImageKey = "OFF.png";
                }
                else
                {
                    Timer1.Interval = Convert.ToInt32(textBox5.Text);
                    Timer1.Enabled = true;
                    But_Timer.Text = "关闭实时更新";
                    But_Timer.ImageKey = "ON.png";
                }
            }
        }
        /// <summary>
        /// 实时更新的方法
        /// </summary>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            PortWrite(0x03, 0x01);
            Delay(3);
            PortWrite(0x03, 0x00);
            Delay(3);
            PortWrite(0xa0, 0x00);
        }
        /// <summary>
        /// 解除限制
        /// </summary>
        private void Menu_Debug_Click(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            textBox4.Enabled = true;
            But_ADC_Change.Enabled = true;
        }
        /// <summary>
        /// 重启应用
        /// </summary>
        private void Menu_Sign_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
