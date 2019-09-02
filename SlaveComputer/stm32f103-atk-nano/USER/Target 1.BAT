SET PATH=D:\Program Files (x86)\Keil\ARM\ARMCC\Bin;C:\Program Files (x86)\Common Files\Intel\Shared Libraries\redist\intel64\compiler;C:\WINDOWS\system32;C:\WINDOWS;C:\WINDOWS\System32\Wbem;C:\WINDOWS\System32\WindowsPowerShell\v1.0\;C:\WINDOWS\System32\OpenSSH\;C:\Program Files\NVIDIA Corporation\NVIDIA NvDLISR;C:\Program Files (x86)\NVIDIA Corporation\PhysX\Common;D:\Android\Java\java-1.8.0-openjdk-1.8.0.212-3\bin;D:\Android\Java\java-1.8.0-openjdk-1.8.0.212-3\jre\bin;D:\Program Files\Git\cmd;C:\Program Files\dotnet\;C:\WINDOWS\system32;C:\WINDOWS;C:\WINDOWS\System32\Wbem;C:\WINDOWS\System32\WindowsPowerShell\v1.0\;C:\WINDOWS\System32\OpenSSH\;D:\Program Files (x86)\qemu;D:\Program Files (x86)\GNU Tools ARM Embedded\8 2018-q4-major\bin;C:\Users\Administrator\AppData\Local\Microsoft\WindowsApps;C:\Users\Administrator\AppData\Local\Programs\Microsoft VS Code\bin;D:\Program Files (x86)\Microsoft VS Code\bin;
SET ARMCC5_ASMOPT=--diag_suppress=9931
SET ARMCC5_CCOPT=--diag_suppress=9931
SET ARMCC5_LINKOPT=--diag_suppress=9931
SET CPU_TYPE=STM32F103RB
SET CPU_VENDOR=STMicroelectronics
SET UV2_TARGET=Target 1
SET CPU_CLOCK=0x00B71B00
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmAsm" --Via "..\obj\startup_stm32f10x_md._ia"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmCC" --Via "..\obj\main.__i"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmCC" --Via "..\obj\led.__i"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmCC" --Via "..\obj\adc.__i"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmCC" --Via "..\obj\beep.__i"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmCC" --Via "..\obj\exti.__i"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmCC" --Via "..\obj\timer.__i"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmCC" --Via "..\obj\key.__i"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmCC" --Via "..\obj\modbus.__i"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmCC" --Via "..\obj\delay.__i"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmCC" --Via "..\obj\sys.__i"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmCC" --Via "..\obj\usart.__i"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\ArmLink" --Via "..\OBJ\USART.lnp"
"D:\Program Files (x86)\Keil\ARM\ARMCC\Bin\fromelf.exe" "..\OBJ\USART.axf" --i32combined --output "..\OBJ\USART.hex"
