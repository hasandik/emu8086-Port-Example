# Emu8086 Port Example
Emu8086 port usage example for academic purpose only

// Comments and variables are in Turkish

# About
EMU8086 communicates with this program through ports. EMU8086 sends data to this program. The program can read the sent data and use it as desired.
Emu8086 compares the 2 data entered in itself and sends different values to the port determined according to the big and small situations.
Emu8086 entered the BH recorder 30 degrees. The BL recorder represents the temperature of the air. If the air temperature is greater than the specified temperature (30 degrees), it will jump to the open function and send from 1 data to 100 port. The program that reads 1 data from 100 port will change the color of the button to green. If the air temperature is less than the specified temperature (30 degrees), it will jump to the closed function and send 0 data to 100 port. The program reading 0 data from 100 port will change the color of the button to red.
The red button indicates that the air conditioner is off and the green button represents the air conditioner.
# Screenshots
![klima açık](https://user-images.githubusercontent.com/59584368/76067235-1a5e1180-5fa0-11ea-9e0c-73696c721e88.JPG)
![klima kapalı](https://user-images.githubusercontent.com/59584368/76067286-2c3fb480-5fa0-11ea-927f-d7cb6a64444c.JPG)
![assembly](https://user-images.githubusercontent.com/59584368/76067347-424d7500-5fa0-11ea-82de-0b28ec918eba.JPG)
