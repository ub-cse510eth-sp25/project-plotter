0 constant pen-down-height
2 constant pen-up-height

\ raises the pen above the paper
: lift-pen ( -- )
    pen-up-height abs-z
;

\ lowers the pen to the paper
: lower-pen ( -- )
    pen-down-height abs-z
;