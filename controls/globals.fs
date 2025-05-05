\ Constants for motor driver pins
7 constant DIRx \ x stepper direction
8 constant STEPx \ x stepper signal

11 constant DIRy \ y stepper direction
12 constant STEPy \ y stepper signal

17 constant DIRz \ z stepper direction
16 constant STEPz \ z stepper signal
15 constant MOT-ENA \ motor enable pins

\ Constants for end stop switch pins.
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
