\ Assumptions:
\ 1. clockwise is forwards
\ 2. counter-clockwise is backwards
\ 3. DIR outputting high cause cw direction, and low the opposite

10 constant DIRx \ GPIO 10
11 constant STEPx \ GPIO 11
12 constant RESETx \ GPIO 12
13 constant ENABLEx \ GPIO 13
14 constant SLEEPx \ GPIO 14
\
15 constant DIRy \ GPIO 10
16 constant STEPy \ GPIO 11
17 constant RESETy \ GPIO 12
18 constant ENABLEy \ GPIO 13
19 constant SLEEPy \ GPIO 14

20 constant DIRyz \ GPIO 10
21 constant STEPz \ GPIO 11
22 constant RESETz \ GPIO 12
23 constant ENABLEz \ GPIO 13
24 constant SLEEPz \ GPIO 14
\ update w correct GPIOs^

: import-pin ( -- )
  pin import
;

: intialize-pins-x ( -- ) \ sets all pins to output state
  DIRx output-pin
  STEPx output-pin
  RESETx output-pin
  ENABLEx output-pin
  SLEEPx output-pin
;

: intialize-pins-y ( -- ) \ sets all pins to output state
  DIRy output-pin
  STEPy output-pin
  RESETy output-pin
  ENABLEy output-pin
  SLEEPy output-pin
;

: intialize-pins-z ( -- ) \ sets all pins to output state
  DIRz output-pin
  STEPz output-pin
  RESETz output-pin
  ENABLEz output-pin
  SLEEPz output-pin
;


( \\\\\\\\\\\\\\\ )


: set-x-forward ( -- )
  high DIRx pin! \ set direction pin to high
;

: set-y-forward ( -- )
  high DIRy pin! \ set direction pin to high
;

: set-z-forward ( -- )
  high DIRz pin! \ set direction pin to high
;


( \\\\\\\\\\\\\\\ )


: set-x-rev ( -- )
  low DIRx pin!
;

: set-y-rev ( -- )
  low DIRy pin!
;

: set-z-rev ( -- )
  low DIRz pin!
;


( \\\\\\\\\\\\\\\ )


: step-x ( -- )
  high STEPx pin!
  1 ms
  low STEPx pin!
  1 ms
;

: step-y ( -- )
  high STEPy pin!
  1 ms
  low STEPy pin!
  1 ms
;

: step-z ( -- )
  high STEPz pin!
  1 ms
  low STEPz pin!
  1 ms
;


( \\\\\\\\\\\\\\\ )


: step-x-mm ( -- ) \ 3 steps per mm
  3 0 DO step-x LOOP;
;

: step-y-mm ( -- ) \ 3 steps per mm
  3 0 DO step-y LOOP;
;

: step-z-mm ( -- ) \ 100 steps per mm
  100 0 DO step-z LOOP;
;


( \\\\\\\\\\\\\\\ )


: step-x-mms ( n-- )
  0 DO step-mm-x LOOP
;

: step-y-mms ( n-- )
  0 DO step-mm-y LOOP ;

: step-z-mms ( n-- )
  0 DO step-mm-z LOOP ;
