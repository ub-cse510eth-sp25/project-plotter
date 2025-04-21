( define constants for the number of steps per mm on each axis )
3 constant x-steps-per-mm
3 constant y-steps-per-mm
100 constant z-steps-per-mm

( create global variables to maintain the current position of the pen between words )
variable cur-x
variable cur-y
variable cur-z

: abs-x ( n -- )
    dup ( n n -- )
    
    \ get the current x position
    cur-x @
    
    \ compute the movement needed
    - ( n n cur-x -- n movement )
    dup 0 < if
	set-x-rev
    else
	set-x-forward
    then
    abs
    x-steps-per-mm *
    
    \ move to the new location 
    0 do
	step-x
    loop
    
    \ store the new x location 
    cur-x !
;


: abs-y ( n -- )
    dup ( n n -- )
    
    \ get the current y position
    cur-y @
    
    \ compute the movement needed
    - ( n n cur-y -- n movement )
    dup 0 < if
	set-y-rev
    else
	set-y-forward
    then
    abs
    y-steps-per-mm *
    
    \ move to the new location 
    0 do
	step-y
    loop
    
    \ store the new y location 
    cur-y !
;


: abs-z ( n -- )
    dup ( n n -- )
    
    \ get the current z position
    cur-z @
    
    \ compute the movement needed
    - ( n n cur-z -- n movement )
    dup 0 < if
	set-z-rev
    else
	set-z-forward
    then
    abs
    z-steps-per-mm *
    
    \ move to the new location 
    0 do
	step-z
    loop
    
    \ store the new z location 
    cur-z !
;

: move-to-abs ( x y -- )
    dup cur-y @ ( x y y cur-y )
    \ if there is no y movement, this is the same as move x
    = if ( x y )
	drop ( x )
	move-to-abs-x ( )
	exit
    then ( x y )
    swap ( y x )
    dup cur-x @ ( y x x cur-x )
    \ if there is no x movement, this is the same as move y
    = if ( y x )
	drop ( y )
	move-to-abs-y ( )
	exit
    then ( y x )
    2dup ( y x y x )
    \ set the x direction
    cur-x @ > if
	set-x-forward
    else
	set-x-rev
    then
    \ set the y direction
    cur-y @ > if
	set-y-forward
    else
	set-y-rev
    then
    2dup ( y x y x )
    abs swap abs swap ( y x y x )
    x-steps-per-mm * ( y x y x-steps )
    swap
    y-steps-per-mm * ( y x x-steps y-steps )
    \ determine which axis we should compute against
    2dup ( y x x-steps y-steps x-steps y-steps )
    > if
	\ there are more x-steps than y-steps
	\ for every x-step, compute its y val
	1 .
    else
	\ there are more y-steps than x-steps
	\ for every y-step, compute its x val
	2 .
    then 
;

: rel-x ( n -- )
    cur-x @ + abs-x
;

: rel-y ( n -- )
    cur-y @ + abs-y
;

: rel-z ( n -- )
    cur-z @ + abs-z
;

: move-to-rel ( x y -- )
    cur-y @ +
    swap
    cur-x @ +
    swap
    move-to-abs
;
    