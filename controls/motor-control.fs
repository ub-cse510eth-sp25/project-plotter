\ Assumptions:
\ 1. clockwise is forwards
\ 2. counter-clockwise is backwards
\ 3. DIR outputting high cause cw direction, and low the opposite

7 constant DIRx \ GPIO 7
8 constant STEPx \ GPIO 8

11 constant DIRy \ GPIO 11
12 constant STEPy \ GPIO 12


17 constant DIRz \ GPIO 17
16 constant STEPz \ GPIO 16

\ update w correct GPIOs^

: import-pin ( -- )
  pin import
;

import-pin

: intialize-pins-x ( -- ) \ sets all pins to output state
  DIRx output-pin
  STEPx output-pin
;

: intialize-pins-y ( -- ) \ sets all pins to output state
  DIRy output-pin
  STEPy output-pin
;

: intialize-pins-z ( -- ) \ sets all pins to output state
  DIRz output-pin
  STEPz output-pin
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
  2 ms
  low STEPx pin!
  2 ms
;

: step-y ( -- )
  high STEPy pin!
  2 ms
  low STEPy pin!
  2 ms
;

: step-z ( -- )
  high STEPz pin!
  1 ms
  low STEPz pin!
  1 ms
;


( \\\\\\\\\\\\\\\ )


: step-x-mm ( -- )
  3 0 DO step-x LOOP
;

: step-y-mm ( -- ) \ 3 steps per mm
  3 0 DO step-y LOOP
;

: step-z-mm ( -- ) \ 100 steps per mm
  100 0 DO step-z LOOP
;


( \\\\\\\\\\\\\\\ )


: step-x-mms ( n-- )
  0 DO step-x-mm LOOP
;

: step-y-mms ( n-- )
  0 DO step-y-mm LOOP
;

: step-z-mms ( n-- )
  0 DO step-z-mm LOOP
;
