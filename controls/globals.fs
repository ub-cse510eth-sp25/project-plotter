\ Constants for motor driver pins
7 constant DIRx \ GPIO 7
8 constant STEPx \ GPIO 8

11 constant DIRy \ GPIO 11
12 constant STEPy \ GPIO 12

17 constant DIRz \ GPIO 17
16 constant STEPz \ GPIO 16

\ Constants for end stops pins
0 constant nSTOPx
26 constant nSTOPy
22 constant nSTOPz

\ Constants for number of steps per mm on each axis
6 constant x-steps-per-mm
6 constant y-steps-per-mm
100 constant z-steps-per-mm

\ Variables for current position of pen
variable cur-x
variable cur-y
variable cur-z

\ Constants for sizing
10 constant border
170 constant canvas

\ Constant for BELL
21 constant BELL \ GPIO 21
