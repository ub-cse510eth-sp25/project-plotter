\ Assumptions:
\ 1. pin module was imported
\ 2. nSTOP is an active-low input pin, so when it is low, it is active

101 constant x \TODO: move these to an initialization script?
102 constant y
103 constant z

1 constant nSTOPx \TODO: update with correct pin #s
2 constant nSTOPy
3 constant nSTOPz

\ defined in coordinates.fs \TODO: move to initialization script?
\ variable cur-x
\ variable cur-y
\ variable cur-z

: nStop ( axis -- pin )
  case
    x of nSTOPx endof
    y of nSTOPy endof
    z of nSTOPz endof
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
  nSTOPy input-pin
  nSTOPz input-pin
;


( \\\\\\\\\\\\\\\ )


: at-stop? ( axis -- bool ) \ returns true or -1 if stop is triggered
  nStop pin@ 0=
;


( \\\\\\\\\\\\\\\ )


: x-to-home ( -- )
  set-x-backward
  BEGIN
    x at-stop? not
    WHILE step-x \TODO: change forward or backward, not sure where the stops are
    REPEAT
;

: y-to-home ( -- )
  set-y-backward
  BEGIN
    y at-stop? not
    WHILE step-y
    REPEAT
;

: z-to-home ( -- )
  set-z-backward
  BEGIN
    z at-stop? not
    WHILE step-z
    REPEAT
;

( \\\\\\\\\\\\\\\ )



: reset-axis ( axis -- )
  case
    x of
      x-to-home
      set-x-forward
      5 step-x-mms
      x-to-home
      0 cur-x !
    endof

    y of
      y-to-home
      set-y-forward
      5 step-y-mms
      y-to-home
      0 cur-y !
    endof

    z of
      z-to-home
      set-z-forward
      5 step-z-mms
      z-to-home
      0 cur-z !
    endof
  endcase
;


( \\\\\\\\\\\\\\\ )


: reset ( -- )
  x reset-axis
  y reset-axis
  z reset-axis
;