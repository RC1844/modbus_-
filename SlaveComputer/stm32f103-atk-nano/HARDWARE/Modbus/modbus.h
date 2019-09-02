#ifndef __MODBUS_H
#define __MODBUS_H
#include "sys.h"

void PortWirte(u8 code, u16 data, int len);
u16 Get_Data(u8 on,u8 to);
u16 Get_LED_Beep(void);
void Beep_Set(u16 time);
void ModBusCRC16(u8 *cmd, int len, char set);
void Modbus(void);
#endif
