#include <stdlib.h>
//#include <stdio.h>
#include "sys.h"
#include "delay.h"
#include "usart.h"
#include "led.h"
#include "adc.h"
#include "beep.h"
#include "timer.h"
#include "exti.h"

//ALIENTEK 探索者STM32F407开发板 实验1
//跑马灯实验
//技术支持：www.openedv.com
//广州市星翼电子科技有限公司

u32 EXTI_UP = 0;
void PortWirte(u8 code1, u32 code2, int len)
{
    u8 pw[10] = {0xFF};
    pw[1] = code1;
    if (len == 4)
    {
        for (int i = 0; i < len; i++)
        {
            pw[i + 2] = (u8)(code2 >> (4 * (3 - i)));
        }
    }
    else
        pw[2] = (u8)code2;
    ModBusCRC16(pw, len, 1);
    for (int t = 0; t < 5; t++)
    {
        USART1->DR = pw[t];
        while ((USART1->SR & 0X40) == 0)
            ; //等待发送结束
    }
    printf("/r/n");
}
u32 Get_Time()
{
    u32 time = 0;
    for (int i = 0; i < 4; i++)
    {
        time = (u8)(time << 4 * i) + USART_RX_BUF[i + 2];
    }
    return time;
}
u32 Get_LED_Beep(void)
{
    u32 LB = 0;
    LB = LED0;
    LB = (LB << 4) + LED1;
    LB = (LB << 4) + BEEP;
    return LB;
}
void BeepSet(u32 time)
{
    TIM3->CR1 = 0x00; //使能定时器3
    TIM3->CNT = 0;
    if (time >> 16)
    {
        TIM3->ARR = 0xffff - 1; //设定计数器自动重装值
    }
    else
        TIM3->ARR = (u16)time - 1; //设定计数器自动重装值
    BEEP = 1;
    TIM3->CR1 |= 0x01; //使能定时器3
}
u16 ADC_get(u16 time)
{

    u16 adcx = Get_Adc_Average(ADC_CH5, time);
    return adcx;
}
void ADC_set(u8 cycle)
{
    ADC1->CR2 |= 0 << 0;             //关闭AD转换器
    ADC1->SMPR2 |= cycle << (3 * 5); //通道5  480个周期,提高采样时间可以提高精确度
    ADC1->CR2 |= 1 << 0;             //开启AD转换器
}
int main(void)
{
    Stm32_Clock_Init(336, 8, 2, 7); //设置时钟,168Mhz
    delay_init(168);                //初始化延时函数
    uart_init(84, 115200);          //串口初始化为115200
    LED_Init();                     //初始化LED时钟
    BEEP_Init();
    Adc_Init();
    EXTIX_Init();
    TIM3_Int_Init(5000 - 1, 8400 - 1);
    TIM4_Int_Init(5000 - 1, 8400 - 1);
    TIM5_Int_Init(5000 - 1, 8400 - 1);
    while (1)
    {
    }
}
void sss(void)
{
    // if (USART_RX_STA & 0x8000)
    // {
    //     u8 len = USART_RX_STA & 0x3fff; //得到此次接收到的数据长度
    //                                     //        printf("\r\n您发送的消息为 ");
    //     for (u8 t = 0; t < len; t++)
    //     {
    //         USART1->DR = USART_RX_BUF[t];
    //         while ((USART1->SR & 0X40) == 0)
    //             ; //等待发送结束
    //     }
    //     //		printf("\r\n");
    // }
    if (USART_RX_BUF[0] == 0xfe)
    {
        switch (USART_RX_BUF[1])
        {
        case 0x00:

            switch (USART_RX_BUF[2])
            {
            case 0x00:
                TIM4->CR1 = 0x00; //清除使能定时器3
                LED0 = 1;
                break;
            case 0x01:
                TIM4->CR1 = 0x00; //清除使能定时器3
                LED0 = 0;
                break;
            case 0x10:
                TIM5->CR1 = 0x00; //清除使能定时器3
                LED1 = 1;
                break;
            case 0x11:
                TIM5->CR1 = 0x00; //清除使能定时器3
                LED1 = 0;
                break;
            default:
                break;
            }
            break;
        case 0x01:
            switch (USART_RX_BUF[2])
            {
            case 0:
                TIM3->CR1 = 0x00; //清除使能定时器3
                BEEP = 0;
                break;
            case 1:
                TIM3->CR1 = 0x00; //清除使能定时器3
                BEEP = 1;
                break;
            default:
                //                    TIM3->CR1 |= 1 << 0;
                break;
            }
            break;
        case 0x02:
            switch (USART_RX_BUF[2])
            {
            case 0x00:
                TIM4->CR1 = 0x00; //清除使能定时器3
                TIM5->CR1 = 0x00; //清除使能定时器3
                break;
            case 0x01:
                TIM4->CR1 |= 0x01;
                TIM5->CR1 = 0x00; //清除使能定时器3
                break;
            case 0x10:
                TIM4->CR1 = 0x00; //清除使能定时器3
                TIM5->CR1 |= 0x01;
                break;
            case 0x11:
                TIM4->CR1 |= 0x01;
                TIM5->CR1 |= 0x01;
                break;
            default:
                break;
            }
            LED1 = 1;
            LED0 = 1;
            break;
        case 0x03:
            switch (USART_RX_BUF[2])
            {
            case 0x00:
                PortWirte(0x00, Get_LED_Beep(), 4);
                break;
            case 0x01:
                PortWirte(0x01, EXTI_UP, 4);
                break;
            }
            break;
        case 0x04:
            BeepSet(Get_Time());
            break;

        default:

            break;
        }
        // USART_RX_BUF[4] = 0;
    }
    USART_RX_STA = 0;
    //			USART_RX_BUF;
}
//void BeepS(void)
//{
//    int diff = sizeof(USART_RX_BUF) / sizeof(u32);
//    char timeB[diff - 1];

//    for (int i = 1; i < diff; ++i)
//    {
//        timeB[i - 1] = USART_RX_BUF[i];
//    }
//    u16 a = atoi(timeB);
//    BeepSet(a);
//}
