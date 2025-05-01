# Word List

## Motor Control
`import-pin ( -- )`
Import pin module

`initialize-pins-x ( -- )`
set relevant x-axis GPIO pins to output state

`initialize-pins-y ( -- )`
set relevant y-axis GPIO pins to output state

`initialize-pins-z ( -- )`
set relevant z-axis GPIO pins to output state

`set-x-forward ( -- )`
set DIRx pin to high

`set-y-forward ( -- )`
set DIRy pin to high

`set-z-forward ( -- )`
set DIRz pin to high

`set-x-backward ( -- )`
set DIRx pin to low

`set-y-backward ( -- )`
set DIRy pin to low

`set-z-backward ( -- )`
set DIRz pin to low

`step-x ( -- )`
Move x gear a step (1.8 degrees)

`step-y ( -- )`
Move y gear a step (1.8 degrees)

`step-z ( -- )`
Move z gear a step (1.8 degrees)

`step-x-mm ( -- )`
Move 1 mm in x-axis 

`step-y-mm ( -- )`
Move 1 mm in y-axis

`step-z-mm ( -- )`
Move 1 mm in z-axis 

`step-x-mms ( n -- )`
Move `n` mms in x-axis

`step-y-mms ( n -- )`
Move `n` mms in y-axis

`step-z-mms ( n -- )`
Move `n` mms in z-axis

## Axis Primitives

`nStop? ( axis -- pin )`  
Returns the pin constant given the axis (also a constant.)

`at-stop? ( axis -- bool )`  
Is a stop hit in the `axis` position?

<!-- `current-pos ( axis -- n )`  <!--! Currently not in use
Returns the current position of the given `axis`. -->

`x-to-home ( -- )`
Moves x postion to origin.

`y-to-home ( -- )`
Moves y postion to origin.

`z-to-home ( -- )`
Moves z postion to origin.

`reset-axis ( axis -- )`  
Moves the axis motor to its reset position.  
Sequence:  
- Move toward stop  
- Hit stop  
- Move away from stop  
- Move toward stop again  
- Hit stop (done)

`reset ( -- )`  
Returns system to home/start position.  
Written using `reset-axis`.

## Absolute Positioning

`abs-x ( n -- )`  
Moves to absolute X position.

`abs-y ( n -- )`  
Moves to absolute Y position.

`abs-z ( n -- )`  
Moves to absolute Z position.

`move-to-abs ( x y -- )`  
Moves to absolute X, Y coordinates.  
Written using `abs-x` and `abs-y`.

## Relative Positioning

`rel-x ( n -- )`  
Moves by `n` units relative to the current X position.  
Implemented as: `x current-position n + abs-x`

`rel-y ( n -- )`  
Moves by `n` units relative to the current Y position.  
Implemented as: `y current-position n + abs-y`

`rel-z ( n -- )`  
Moves by `n` units relative to the current Z position.  
Implemented as: `z current-position n + abs-z`

`move-to-rel ( x y -- )`  
Moves to relative X,Y coordinates.  
Written using `rel-x` and `rel-y`.

## Pen Control

`pen-up ( -- )`  
Lifts the pen up.

`pen-down ( -- )`  
Lowers the pen down.

## Spacing

`next-char ( -- )`  
Moves the pen to the starting position for the next character (top-left corner of the character space).

## Lines

`horizontal-line ( len -- )`  
Draws a horizontal line from left to right.  
Implemented as: `pen-down len rel-x pen-up`

`vertical-line ( len -- )`  
Draws a vertical line from top to bottom.  
Implemented as: `pen-down len rel-y pen-up`

`stem ( -- )`
Draws a stem

`stem-reverse ( -- )`
Draws a stem in reverse

`leg ( -- )`
Draws a leg

`leg-reverse ( -- )`
Draws a leg in reverse

`half-stem ( -- )`
Draws half a stem

`half-stem-reverse ( -- )`
Draws half a stem in reverse

`arm ( -- )`
Draws an arm

`arm-reverse ( -- )`
Draws an arm in reverse

`half-arm ( -- )`
Draws half an arm

`half-arm-reverse ( -- )`
Draws half an arm in reverse

## Characters

`plot-A ( -- )` ... `plot-Z ( -- )`
Plots the specified character

`plot-0 ( -- )` ... `plot-9 ( -- )`
Plots the specified number

`plot-period ( -- )`
Plots a period

`plot-space ( -- )`
Plots a space
