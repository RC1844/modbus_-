#include "timer.h"
#include "led.h"
#include "beep.h"
//////////////////////////////////////////////////////////////////////////////////
//������ֻ��ѧϰʹ�ã�δ��������ɣ��������������κ���;
//ALIENTEK STM32F407������
//��ʱ�� ��������
//����ԭ��@ALIENTEK
//������̳:www.openedv.com
//��������:2014/5/4
//�汾��V1.0
//��Ȩ���У�����ؾ���
//Copyright(C) ������������ӿƼ����޹�˾ 2014-2024
//All rights reserved
//////////////////////////////////////////////////////////////////////////////////

//��ʱ��3�жϷ������
void TIM3_IRQHandler(void)
{
	if (TIM3->SR & 0X0001) //����ж�
	{
		BEEP = 0;
	}
	TIM3->SR &= ~(1 << 0); //����жϱ�־λ
	TIM3->CR1 = 0x00;	  //���ʹ�ܶ�ʱ��3
}
//ͨ�ö�ʱ��3�жϳ�ʼ��
//����ʱ��ѡ��ΪAPB1��2������APB1Ϊ42M
//arr���Զ���װֵ��
//psc��ʱ��Ԥ��Ƶ��
//��ʱ�����ʱ����㷽��:Tout=((arr+1)*(psc+1))/Ft us.
//Ft=��ʱ������Ƶ��,��λ:Mhz
//����ʹ�õ��Ƕ�ʱ��3!
void TIM3_Int_Init(u16 arr, u16 psc)
{
	RCC->APB1ENR |= 1 << 1;			  //TIM3ʱ��ʹ��
	TIM3->ARR = arr;				  //�趨�������Զ���װֵ
	TIM3->PSC = psc;				  //Ԥ��Ƶ��
	TIM3->DIER |= 1 << 0;			  //��������ж�
	// TIM3->CR1|=0x01;    //ʹ�ܶ�ʱ��3
	MY_NVIC_Init(0, 3, TIM3_IRQn, 2); //��ռ1�������ȼ�3����2
}

void TIM4_IRQHandler(void)
{
	if (TIM4->SR & 0X0001) //����ж�
	{
		LED0 = ~LED0;
	}
	TIM4->SR &= ~(1 << 0); //����жϱ�־λ
	//	TIM4->CR1|=0x00;    //���ʹ�ܶ�ʱ��3
}

void TIM4_Int_Init(u16 arr, u16 psc)
{
	RCC->APB1ENR |= 1 << 2;			  //TIM4ʱ��ʹ��
	TIM4->ARR = arr;				  //�趨�������Զ���װֵ
	TIM4->PSC = psc;				  //Ԥ��Ƶ��
	TIM4->DIER |= 1 << 0;			  //��������ж�
									  //	TIM4->CR1|=0x01;    //ʹ�ܶ�ʱ��3
	MY_NVIC_Init(2, 3, TIM4_IRQn, 2); //��ռ1�������ȼ�3����2
}
void TIM5_IRQHandler(void)
{
	if (TIM5->SR & 0X0001) //����ж�
	{
		LED1 = ~LED1;
	}
	TIM5->SR &= ~(1 << 0); //����жϱ�־λ
	//	TIM5->CR1|=0x00;    //���ʹ�ܶ�ʱ��3
}

void TIM5_Int_Init(u16 arr, u16 psc)
{
	RCC->APB1ENR |= 1 << 3;			  //TIM5ʱ��ʹ��
	TIM5->ARR = arr;				  //�趨�������Զ���װֵ
	TIM5->PSC = psc;				  //Ԥ��Ƶ��
	TIM5->DIER |= 1 << 0;			  //��������ж�
									  //	TIM5->CR1|=0x01;    //ʹ�ܶ�ʱ��3
	MY_NVIC_Init(3, 3, TIM5_IRQn, 2); //��ռ1�������ȼ�3����2
}
//