@echo off
set avrdudePath=C:\Users\Tam\Desktop\Hshop\Hshop-Terminal\bin\Debug\tool_upload\bin\avrdude.exe
set programmer=arduino
set port=COM4
set baudrate=115200
set hexFile=C:\Users\Tam\Desktop\Hshop\HS000024_JoystickShield\firmware\Hshop_JoyStickShleld.ino_UNO.hex
"%avrdudePath%" -C "C:\Users\Tam\Desktop\Hshop\Hshop-Terminal\bin\Debug\tool_upload\etc\avrdude.conf" -v -patmega328p -c %programmer% -P %port% -b %baudrate% -D -U flash:w:"%hexFile%":i
pause
