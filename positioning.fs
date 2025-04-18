\ Assumptions:
\ 1. pin module was imported
\ 2. nSTOP is an active-low input pin, so when it is low, it is active
\ 3. 

101 constant x \TODO: move these to an initialization script?
102 constant y
103 constant z

1 constant nSTOPx \TODO: update with correct pin #s;
2 constant nSTOPy
3 constant nSTOPz

variable xpos
variable ypos
variable zpos

: nStop ( axis -- pin )
  case
    x of nSTOPx endof
    y of nSTOPy endof
    z of nSTOPz endof
  endcase
;


( \\\\\\\\\\\\\\\ )


: current-pos ( axis -- n )
  case
    x of xpos @ endof
    y of ypos @ endof
    z of zpos @ endof
  endcase
;


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
  BEGIN
    x at-stop?
    WHILE step-backward-x \TODO: change forward or backward, not sure where the stops are
    REPEAT
  0 xpos !
;

: y-to-home ( -- )
  BEGIN
    y at-stop?
    WHILE step-backward-y
    REPEAT
  0 ypos !
;

: z-to-home ( -- )
  BEGIN
    z at-stop?
    WHILE step-backward-z
    REPEAT
  0 zpos !
;

( \\\\\\\\\\\\\\\ )



: reset-axis ( axis -- )
  case
    x of
      x-to-home
      5 step-mms-x \TODO: is this in the right direction?
      x-to-home
    endof

    y of
      y-to-home
      5 step-mms-y
      y-to-home
    endof

    z of
      z-to-home
      5 step-mms-z
      z-to-home
    endof
  endcase
;


( \\\\\\\\\\\\\\\ )


: reset ( -- )
  x reset-axis
  y reset-axis
  z reset-axis
;