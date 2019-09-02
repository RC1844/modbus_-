#include "timer.h"
#include "led.h"
#include "beep.h"
#include "modbus.h"
//////////////////////////////////////////////////////////////////////////////////
//������ֻ��ѧϰʹ�ã�δ��������ɣ��������������κ���;
//ALIENTEK NANO STM32������
//ͨ�ö�ʱ�� ��������
//����ԭ��@ALIENTEK
//������̳:www.openedv.com
//�޸�����:2018/3/27
//�汾��V1.0
//��Ȩ���У�����ؾ���
//Copyright(C) ������������ӿƼ����޹�˾ 2018-2028
//All rights reserved
//////////////////////////////////////////////////////////////////////////////////


//ͨ�ö�ʱ���жϳ�ʼ��
//����ʱ��ѡ��ΪAPB1��2������APB1Ϊ36M
//arr���Զ���װֵ��
//psc��ʱ��Ԥ��Ƶ��
//����ʹ�õ��Ƕ�ʱ��2!
void TIM2_Init(u16 arr,u16 psc)
{
    RCC->APB1ENR|=1<<0;	//TIM2ʱ��ʹ��
    TIM2->ARR=arr;  	//�趨�������Զ���װֵ
    TIM2->PSC=psc;  	//Ԥ��Ƶ������
    TIM2->DIER|=1<<0;   //��������ж�
//    TIM2->CR1|=0x01;    //ʹ�ܶ�ʱ��2
    MY_NVIC_Init(2,1,TIM2_IRQn,2);//��ռ0�������ȼ�3����2
}
//����ʹ�õ��Ƕ�ʱ��3!
void TIM3_Init(u16 arr,u16 psc)
{
    RCC->APB1ENR|=1<<1;	//TIM3ʱ��ʹ��
    TIM3->ARR=arr;  	//�趨�������Զ���װֵ
    TIM3->PSC=psc;  	//Ԥ��Ƶ������
    TIM3->DIER|=1<<0;   //��������ж�
//    TIM3->CR1|=0x01;    //ʹ�ܶ�ʱ��3
    MY_NVIC_Init(2,2,TIM3_IRQn,2);//��ռ0�������ȼ�3����2
}

//����ʹ�õ��Ƕ�ʱ��4!
void TIM4_Init(u16 arr,u16 psc)
{
    RCC->APB1ENR|=1<<2;	//TIM4ʱ��ʹ��
    TIM4->ARR=arr;  	//�趨�������Զ���װֵ
    TIM4->PSC=psc;  	//Ԥ��Ƶ������
    TIM4->DIER|=1<<0;   //��������ж�
//    TIM4->CR1|=0x01;    //ʹ�ܶ�ʱ��3
    MY_NVIC_Init(2,3,TIM4_IRQn,2);//��ռ0�������ȼ�3����2
}
//��ʱ��2�жϷ�����
void TIM2_IRQHandler(void) //TIM2�ж�
{
    if(TIM2->SR&0X0001)//����ж�
    {
        LED0=!LED0;
    }
    TIM2->SR&=~(1<<0);//����жϱ�־λ
}
//��ʱ��3�жϷ�����
void TIM3_IRQHandler(void) //TIM3�ж�
{
    if(TIM3->SR&0X0001)//����ж�
    {
        LED1=!LED1;
    }
    TIM3->SR&=~(1<<0);//����жϱ�־λ
}

//��ʱ��4�жϷ�����
void TIM4_IRQHandler(void) //TIM4�ж�
{
    if(TIM4->SR&0X0001) { //����ж�
        BEEP = 1;
        PortWirte(0x00, Get_LED_Beep(), 2);
    }
    TIM4->SR&=~(1<<0);//����жϱ�־λ
    TIM4->CR1=0x00;    //ʹ�ܶ�ʱ��3
}












