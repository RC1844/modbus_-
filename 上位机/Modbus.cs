using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 上位机
{
    partial class MainFrom
    {
        /// <summary>
        /// 状态更新
        /// </summary>
        private void Modbus(ref byte[] indata, int len)
        {
            ModBusCRC(ref indata, len);
            if (indata[0] == 0x59)
            {
                Pic_LED0.Image = ImageList.Images[1];
                switch (indata[1])
                {
                    case 0x00:
                        Pic_BEEP.Image = ImageList.Images[indata[3]];
                        switch (indata[2])
                        {
                            case 0x00:
                                Pic_LED1.Image = ImageList.Images[0];
                                Pic_LED0.Image = ImageList.Images[0];
                                break;
                            case 0x01:
                                Pic_LED1.Image = ImageList.Images[0];
                                Pic_LED0.Image = ImageList.Images[1];
                                break;
                            case 0x10:
                                Pic_LED1.Image = ImageList.Images[1];
                                Pic_LED0.Image = ImageList.Images[0];
                                break;
                            case 0x11:
                                Pic_LED1.Image = ImageList.Images[1];
                                Pic_LED0.Image = ImageList.Images[1];
                                break;
                            default:
                                break;
                        }
                        break;
                    case 0x01:
                        textBox1.Text = (Get_Data(ref indata, 2, 5)).ToString();
                        break;
                    case 0xa0:
                        ADC_Chart(Get_Data(ref indata, 2, 3));
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// 串口数据发送
        /// </summary>
        /// <param name="code">代码指令</param>
        /// <param name="data">数据</param>
        /// <param name="len">数据长度(字节) 默认为1</param>
        private void PortWrite(byte code, uint data, int len = 1)
        {
            if (serialPort.IsOpen)
            {
                byte[] pw = new byte[10];
                pw[0] = 0xff;
                pw[1] = code;
                for (int i = 0; i < len; i++)
                {
                    pw[i + 2] = (byte)(data >> (8 * (len - 1 - i)));
                }
                ModBusCRC16(ref pw, len + 1, true);
                serialPort.Write(pw, 0, len + 6);
            }
        }
        /// <summary>
        /// 数据校验
        /// </summary>
        /// <param name="cmd">需校验的数据数组</param>
        /// <param name="len">数据位长度</param>
        /// <param name="set">true设置校验码，false检查校验码</param>
        private void ModBusCRC16(ref byte[] cmd, int len, bool set)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            ushort i, j, tmp, CRC16;
            CRC16 = 0xFFFF;             //CRC寄存器初始值
            for (i = 1; i < len + 1; i++)
            {
                CRC16 ^= cmd[i];
                for (j = 0; j < 8; j++)
                {
                    tmp = (ushort)(CRC16 & 0x0001);
                    CRC16 >>= 1;
                    if (tmp == 1)
                    {
                        CRC16 ^= 0xA001;    //异或多项式
                    }
                }
            }
            if (set)
            {
                cmd[i++] = (byte)(CRC16 & 0x00FF);
                cmd[i++] = (byte)((CRC16 & 0xFF00) >> 8);
                cmd[i++] = 0x0d;
                cmd[i++] = 0x0a;
            }
            else
            {
                if (cmd[i++] == (byte)(CRC16 & 0x00FF))
                {
                    if (cmd[i++] == (byte)((CRC16 & 0xFF00) >> 8)) cmd[0] -= 1;
                    else cmd[0] = 0;
                }
                else cmd[0] = 0;
            }
        }

        /// <summary>
        /// RCR校验
        /// </summary>
        /// <param name="cmd">校验数据</param>
        /// <param name="len">数据长度</param>
        private void ModBusCRC(ref byte[] cmd, int len)
        {
            if (cmd[0] == 0x5a && cmd[1] == 0x5a)
            {
                int suma = 0;
                for (int i = 2; i < 11; i++)
                {
                    suma += cmd[i] & 0x0f;
                }
                if (suma == cmd[11])
                {
                    cmd[0] -= 1;
                }
                else
                {
                    cmd[0] = 0;
                }
            }
        }

        /// <summary>
        /// 接收数据显示
        /// </summary>
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Delay(1);
            try
            {
                int len = serialPort.BytesToRead;
                byte[] indata = new byte[len];
                serialPort.Read(indata, 0, len);
                serialPort.DiscardInBuffer();
                string temp = "";
                foreach (var item in indata)
                {
                    temp += string.Format("0x{0:X2} ", item);
                }
                textBox2.AppendText(temp + "\r\n");
                Modbus(ref indata, len);
            }
            catch /*(Exception error)*/
            {
                //MessageBox.Show(error.Message);
            }
        }
        /// <summary>
        /// ADC图表更新
        /// </summary>
        private List<int> ADC_Data = new List<int> { 0, 0, 0, 0, 0, 0 };
        private void ADC_Chart(int Data)
        {
            if (ADC_Data.Count >= 7)
            {
                ADC_Data.RemoveAt(0);
            }
            ADC_Data.Add(Data);
            int len = ADC_Data.Count;
            Chart_ADC.Series[0].Points.Clear();
            for (int i = 0; i < len; i++)
            {
                Chart_ADC.Series[0].Points.AddY(ADC_Data[i]);
            }
        }
        /// <summary>
        /// 解包数据
        /// </summary>
        /// <param name="cmd">数据帧</param>
        /// <param name="on">数据起始位置</param>
        /// <param name="to">数据结束位置</param>
        /// <returns></returns>
        private int Get_Data(ref byte[] cmd, byte on, byte to)
        {
            int data = 0;
            int len = to - on + 1;
            for (int i = 0; i < len; i++)
            {
                data += cmd[on + i] << (8 * (len - i - 1));
            }
            return data;
        }
        /// <summary>
        /// 延时
        /// </summary>
        /// <param name="milliSecond">延时时间S</param>
        public void Delay(int milliSecond = 2)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
        }
    }
}
