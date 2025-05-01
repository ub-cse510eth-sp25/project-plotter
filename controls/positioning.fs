\ Assumptions:
\ 1. pin module was imported
\ 2. nSTOP is an active-low input pin, so when it is low, it is active

\ Constants for axes (used in positioning only)
101 constant X
102 constant Y
103 constant Z

: nStop ( axis -- pin )
  case
    X of nSTOPx endof
    Y of nSTOPy endof
    Z of nSTOPz endof
  endcase
;


( \\\\\\\\\\\\\\\ )


\ : current-pos ( axis -- n )
\   case
\     x of cur-x @ endof
\     y of cur-y @ endof
\     z of cur-z @ endof
\   endcase
\ ;


( \\\\\\\\\\\\\\\ )


\ set nSTOP pins to input
: initialize-nSTOPs ( -- )
  nSTOPx input-pin
  nSTOPx pull-up-pin
  nSTOPy input-pin
  nSTOPy pull-up-pin
  nSTOPz input-pin
  nSTOPz pull-up-pin
;

initialize-nSTOPs

( \\\\\\\\\\\\\\\ )


: at-stop? ( axis -- bool ) \ returns true or -1 if stop is triggered
  nStop pin@ 0=
;


( \\\\\\\\\\\\\\\ )


: x-to-home ( -- ) \ ! This works
  set-x-backward
  BEGIN
    X at-stop? not
    WHILE step-x
    REPEAT
;

: y-to-home ( -- )
  set-y-forward
  \ set-y-backward
  BEGIN
    Y at-stop? not
    WHILE step-y
    REPEAT
;

: z-to-home ( -- )
  set-z-backward \ ! This works
  BEGIN
    Z at-stop? not
    WHILE step-z
    REPEAT
;

( \\\\\\\\\\\\\\\ )



: reset-axis ( axis -- )
  case
    X of
      x-to-home
      set-x-forward \ ! This works
      5 step-x-mms
      x-to-home
      0 cur-x !
    endof

    Y of
      y-to-home
      set-y-backward
      \ set-y-forward
      5 step-y-mms
      y-to-home
      0 cur-y !
    endof

    Z of
      z-to-home
      set-z-forward \ ! This works
      5 step-z-mms
      z-to-home
      0 cur-z !
    endof
  endcase
;


( \\\\\\\\\\\\\\\ )


: reset ( -- )
  X reset-axis
  Y reset-axis
  Z reset-axis
;