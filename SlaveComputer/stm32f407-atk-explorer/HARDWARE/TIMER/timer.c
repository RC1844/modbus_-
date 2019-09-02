#include "timer.h"
#include "led.h"
#include "beep.h"
//////////////////////////////////////////////////////////////////////////////////
//本程序只供学习使用，未经作者许可，不得用于其它任何用途
//ALIENTEK STM32F407开发板
//定时器 驱动代码
//正点原子@ALIENTEK
//技术论坛:www.openedv.com
//创建日期:2014/5/4
//版本：V1.0
//版权所有，盗版必究。
//Copyright(C) 广州市星翼电子科技有限公司 2014-2024
//All rights reserved
//////////////////////////////////////////////////////////////////////////////////

//定时器3中断服务程序
void TIM3_IRQHandler(void)
{
	if (TIM3->SR & 0X0001) //溢出中断
	{
		BEEP = 0;
	}
	TIM3->SR &= ~(1 << 0); //清除中断标志位
	TIM3->CR1 = 0x00;	  //清除使能定时器3
}
//通用定时器3中断初始化
//这里时钟选择为APB1的2倍，而APB1为42M
//arr：自动重装值。
//psc：时钟预分频数
//定时器溢出时间计算方法:Tout=((arr+1)*(psc+1))/Ft us.
//Ft=定时器工作频率,单位:Mhz
//这里使用的是定时器3!
void TIM3_Int_Init(u16 arr, u16 psc)
{
	RCC->APB1ENR |= 1 << 1;			  //TIM3时钟使能
	TIM3->ARR = arr;				  //设定计数器自动重装值
	TIM3->PSC = psc;				  //预分频器
	TIM3->DIER |= 1 << 0;			  //允许更新中断
	// TIM3->CR1|=0x01;    //使能定时器3
	MY_NVIC_Init(0, 3, TIM3_IRQn, 2); //抢占1，子优先级3，组2
}

void TIM4_IRQHandler(void)
{
	if (TIM4->SR & 0X0001) //溢出中断
	{
		LED0 = ~LED0;
	}
	TIM4->SR &= ~(1 << 0); //清除中断标志位
	//	TIM4->CR1|=0x00;    //清除使能定时器3
}

void TIM4_Int_Init(u16 arr, u16 psc)
{
	RCC->APB1ENR |= 1 << 2;			  //TIM4时钟使能
	TIM4->ARR = arr;				  //设定计数器自动重装值
	TIM4->PSC = psc;				  //预分频器
	TIM4->DIER |= 1 << 0;			  //允许更新中断
									  //	TIM4->CR1|=0x01;    //使能定时器3
	MY_NVIC_Init(2, 3, TIM4_IRQn, 2); //抢占1，子优先级3，组2
}
void TIM5_IRQHandler(void)
{
	if (TIM5->SR & 0X0001) //溢出中断
	{
		LED1 = ~LED1;
	}
	TIM5->SR &= ~(1 << 0); //清除中断标志位
	//	TIM5->CR1|=0x00;    //清除使能定时器3
}

void TIM5_Int_Init(u16 arr, u16 psc)
{
	RCC->APB1ENR |= 1 << 3;			  //TIM5时钟使能
	TIM5->ARR = arr;				  //设定计数器自动重装值
	TIM5->PSC = psc;				  //预分频器
	TIM5->DIER |= 1 << 0;			  //允许更新中断
									  //	TIM5->CR1|=0x01;    //使能定时器3
	MY_NVIC_Init(3, 3, TIM5_IRQn, 2); //抢占1，子优先级3，组2
}
//