\ Assumptions:
\ 1. clockwise is forwards
\ 2. counter-clockwise is backwards
\ 3. DIR outputting high cause cw direction, and low the opposite

7 constant DIRx \ GPIO 7
8 constant STEPx \ GPIO 8

11 constant DIRy \ GPIO 11
12 constant STEPy \ GPIO 12

17 constant DIRyz \ GPIO 17
16 constant STEPz \ GPIO 16

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
