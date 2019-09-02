#include "modbus.h"
#include "delay.h"
#include "usart.h"
#include "led.h"
#include "adc.h"
#include "beep.h"
#include "timer.h"
#include "exti.h"

u32 EXTI_UP = 0;
u8 time=1;
void PortWirte(u8 code, u16 data, int len) {
    u8 pw[10] = {0xFF};
    pw[1] = code;
    for (int i = 0; i < len; i++) {
        pw[i + 2] = (u8)(data >> (8 * (len-1 - i)));
    }
    ModBusCRC16(pw, len+1, 1);
    for (int t = 0; t < len+6; t++) {
        USART1->DR = pw[t];
        while ((USART1->SR & 0X40) == 0); //等待发送结束
    }
}
u16 Get_Data(u8 on,u8 to) {
    u16 time = 0;
    u8 len=to-on+1;
    for (int i = 0; i < len; i++) {
        time += USART_RX_BUF[i + on]<<(8*(len-1-i));
    }
    return time;
}
u16 Get_LED_Beep(void) {
    u16 LB = 0;
    LB = LED1;
    LB = (LB << 4) + LED0;
    LB = (LB << 8) + BEEP;
    return LB;
}
void Beep_Set(u16 time) {
    TIM4->CR1 = 0x00; //清除定时器4使能
    TIM4->CNT = 0;
    TIM4->ARR = time - 1; //设定计数器自动重装值
    BEEP = 0;
    TIM4->CR1 |= 0x01; //使能定时器3
}

void ADC_set(u8 cycle) {
    ADC1->CR2 |= 0 << 0;             //关闭AD转换器
    ADC1->SMPR2 |= cycle << (3 * ADC_CH9); //通道5  480个周期,提高采样时间可以提高精确度
    ADC1->CR2 |= 1 << 0;             //开启AD转换器
}
void ModBusCRC16(u8 *cmd, int len, char set) {
    u16 i, j, tmp, CRC16;
    CRC16 = 0xFFFF; //CRC寄存器初始值
    for (i = 1; i < len + 1; i++) {
        CRC16 ^= cmd[i];
        for (j = 0; j < 8; j++) {
            tmp = (u16)(CRC16 & 0x0001);
            CRC16 >>= 1;
            if (tmp == 1) {
                CRC16 ^= 0xA001; //异或多项式
            }
        }
    }
    if (set) {
        cmd[i++] = (u8)(CRC16 & 0x00FF);
        cmd[i++] = (u8)((CRC16 & 0xFF00) >> 8);
    }
    else {
        if (cmd[i++] == (u8)(CRC16 & 0x00FF)) {
            if (cmd[i++] == (u8)((CRC16 & 0xFF00) >> 8))
                cmd[0] -= 1;
            else cmd[0] = 0;
        }
        else cmd[0] = 0;
    }
}

void Modbus(void) {
    ModBusCRC16(USART_RX_BUF, (USART_RX_STA & 0x3fff) - 3, 0);
    if (USART_RX_BUF[0] == 0xfe) {
        switch (USART_RX_BUF[1]) {
        case 0x00:
            switch (USART_RX_BUF[2])
            {
            case 0x00:
                TIM2->CR1 = 0x00; //清除使能定时器2
                LED0 = 1;
                break;
            case 0x01:
                TIM2->CR1 = 0x00; //清除使能定时器2
                LED0 = 0;
                break;
            case 0x10:
                TIM3->CR1 = 0x00; //清除使能定时器3
                LED1 = 1;
                break;
            case 0x11:
                TIM3->CR1 = 0x00; //清除使能定时器3
                LED1 = 0;
                break;
            }
            PortWirte(0x00, Get_LED_Beep(), 2);
            break;
        case 0x01:
            switch (USART_RX_BUF[2])
            {
            case 0:
                TIM4->CR1 = 0x00; //清除使能定时器3
                BEEP = 1;
                break;
            case 1:
                TIM4->CR1 = 0x00; //清除使能定时器3
                Beep_Set(2000);
                break;
            }
            PortWirte(0x00, Get_LED_Beep(), 2);
            break;
        case 0x02:
            switch (USART_RX_BUF[2])
            {
            case 0x00:
                TIM2->CR1 = 0x00; //清除使能定时器3
                TIM3->CR1 = 0x00; //清除使能定时器3
                break;
            case 0x01:
                TIM2->CR1 |= 0x01;
                TIM3->CR1 = 0x00; //清除使能定时器3
                break;
            case 0x10:
                TIM2->CR1 = 0x00; //清除使能定时器3
                TIM3->CR1 |= 0x01;
                break;
            case 0x11:
                TIM2->CR1 |= 0x01;
                TIM3->CR1 |= 0x01;
                break;
            }
            LED1 = 1;
            LED0 = 1;
            break;
        case 0x03:
            switch (USART_RX_BUF[2])
            {
            case 0x00:
                PortWirte(0x00, Get_LED_Beep(), 2);
                break;
            case 0x01:
                PortWirte(0x01, EXTI_UP, 4);
                break;
            }
            break;
        case 0x04:
            Beep_Set(Get_Data(2,3));
            PortWirte(0x00, Get_LED_Beep(), 2);
            break;
        case 0xa0:
            PortWirte(0xa0,Get_Adc_Average(ADC_CH9,time),2);
            break;
        case 0xa1:
            ADC_set(USART_RX_BUF[2]);
            time=Get_Data(4,5);
            PortWirte(0xa0,Get_Adc_Average(ADC_CH9,time),2);
            break;
        default:
            break;
        }
    }
    USART_RX_STA = 0;
}
