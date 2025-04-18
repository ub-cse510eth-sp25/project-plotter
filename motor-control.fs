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


: set-cw-x ( -- )
  high DIRx pin! \ set direction pin to high
;

: set-cw-y ( -- )
  high DIRy pin! \ set direction pin to high
;

: set-cw-z ( -- )
  high DIRz pin! \ set direction pin to high
;


( \\\\\\\\\\\\\\\ )


: set-ccw-x ( -- )
  low DIRx pin!
;

: set-ccw-y ( -- )
  low DIRy pin!
;

: set-ccw-z ( -- )
  low DIRz pin!
;


( \\\\\\\\\\\\\\\ )


: step-x ( -- )
  STEPx toggle-pin
  1 ms
  STEPx toggle-pin
  1 ms
;

: step-y ( -- )
  STEPy toggle-pin
  1 ms
  STEPy toggle-pin
  1 ms
;

: step-z ( -- )
  STEPz toggle-pin
  1 ms
  STEPz toggle-pin
  1 ms
;


( \\\\\\\\\\\\\\\ )


: step-forward-x ( -- )
  set-cw-x
  step-x
;

: step-forward-y ( -- )
  set-cw-y
  step-y
;

: step-forward-z ( -- )
  set-cw-z
  step-z
;


( \\\\\\\\\\\\\\\ )


: step-backward-x ( -- )
  set-ccw-x
  step-x
;

: step-backward-y ( -- )
  set-ccw-y
  step-y
;

: step-backward-z ( -- )
  set-ccw-z
  step-z
;


( \\\\\\\\\\\\\\\ )


: step-mm-x ( -- ) \ 3 steps per mm
  3 0 DO step-x LOOP;
;

: step-mm-y ( -- ) \ 3 steps per mm
  3 0 DO step-y LOOP;
;

: step-mm-z ( -- ) \ 100 steps per mm
  100 0 DO step-z LOOP;
;


( \\\\\\\\\\\\\\\ )


: step-mms-x ( n-- )
  0 DO step-mm-x LOOP
;

: step-mms-y ( n-- )
  0 DO step-mm-y LOOP ;

: step-mms-z ( n-- )
  0 DO step-mm-z LOOP ;
