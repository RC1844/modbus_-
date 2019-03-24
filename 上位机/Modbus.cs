using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 上位机
{
    partial class MainFrom
    {
        private List<int> ADC_Data= new List<int>{0,0,0,0,0,0 };
        private void ADC_Chart(int Data)
        {
            if (ADC_Data.Count>=7)
            {
                ADC_Data.RemoveAt(0);
            }
            ADC_Data.Add(Data);
            int len = ADC_Data.Count;
            Chart_ABC.Series[0].Points.Clear();
            for (int i = 0; i < len; i++)
            {
                Chart_ABC.Series[0].Points.AddY( ADC_Data[i]);
            }
        }
        private void Modbus(ref byte[] indata,int len)
        {
            ModBusCRC16(ref indata, len - 5, false);
            if (indata[0] == 0xfe)
            {
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
                        textBox1.Text = (Get_Data(ref indata,2,5)).ToString() ;
                        break;
                    case 0xa0:
                        ADC_Chart(Get_Data(ref indata,2,3));
                        break;
                    default:

                        break;
                }
            }
        }
        private int Get_Data(ref byte[] cmd,byte on,byte to)
        {
            int data = 0;
            int len = to - on + 1;
            for (int i = 0; i < len; i++)
            {
                data += cmd[on + i] << (8 * (len - i-1));
            }
            return data;
        }
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
                    if (cmd[i++] == (byte)((CRC16 & 0xFF00) >> 8))
                    {
                        cmd[0] -= 1;
                    }
                    else
                    {
                        cmd[0] = 0;
                    }
                }
                else
                {
                    cmd[0] = 0;
                }
            }
        }
        public void Delay(int milliSecond=2)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
        }
    }
}
