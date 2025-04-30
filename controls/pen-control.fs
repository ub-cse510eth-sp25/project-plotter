0 constant pen-down-height
2 constant pen-up-height

\ raises the pen above the paper
: pen-up ( -- )
    set-z-forward
    pen-up-height abs-z
;

\ lowers the pen to the paper
: pen-down ( -- )
    set-z-backpaward
    pen-down-height abs-z
;
