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
    ( this is more complicated than the word
    list suggests due to needing to move on
    a diagonal path )
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
    