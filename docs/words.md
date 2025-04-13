# Word List

## Motor Control
`step-forward ( n -- )`
Move `n` steps forward (1.8 degrees)

`step-backward ( n -- )`
Move `n` steps backward (1.8 degrees)

`step-cm ( -- )`
Move 1 cm

`step-cms ( n -- )`
Move `n` cms (if negative it steps backwards, if positive it steps forwards)

`set-cw ( -- )`
Set direction to clockwise

`set-ccw ( -- )`
Set direction to counterclockwise

## Axis Primitives

`at-stop? ( axis -- bool )`  
Is a stop hit in the `axis` position?

`current-pos ( axis -- n )`  
Returns the current position of the given `axis`.

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

`lift-pen ( -- )`  
Lifts the pen up.

`lower-pen ( -- )`  
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
