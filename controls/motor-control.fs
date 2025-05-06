\ Assumptions:
\ 1. clockwise is forwards
\ 2. counter-clockwise is backwards
\ 3. DIR outputting high cause cw direction, and low the opposite

: import-pin ( -- )
  pin import
;

import-pin

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


: set-x-backward ( -- )
  low DIRx pin!
;

: set-y-backward ( -- )
  low DIRy pin!
;

: set-z-backward ( -- )
  low DIRz pin!
;

: initialize-enable-pins ( -- )
  MOT-ENA output-pin
  low MOT-ENA pin!
;

: intialize-pins-x ( -- ) \ sets all pins to output state
  DIRx output-pin
  STEPx output-pin
  set-x-forward
;

: intialize-pins-y ( -- ) \ sets all pins to output state
  DIRy output-pin
  STEPy output-pin
  set-y-forward
;

: intialize-pins-z ( -- ) \ sets all pins to output state
  DIRz output-pin
  STEPz output-pin
  set-z-forward
;

initialize-enable-pins
intialize-pins-x
intialize-pins-y
intialize-pins-z


( \\\\\\\\\\\\\\\ )


: enable-motors ( -- )
  low MOT-ENA pin!
;

: disable-motors ( -- )
  high MOT-ENA pin!
;

disable-motors

: step-x ( -- )
  low STEPx pin!
  1 ms
  high STEPx pin!
  1 ms
  high STEPx pin!
  1 ms
;

: step-y ( -- )
  low STEPy pin!
  1 ms
  high STEPy pin!
  1 ms
  low STEPy pin!
  1 ms
;

: step-z ( -- )
  low STEPz pin!
  1 ms
  high STEPz pin!
  1 ms
  low STEPz pin!
  1 ms
;


( \\\\\\\\\\\\\\\ )


: step-x-mm ( -- )
  x-steps-per-mm 0 DO step-x LOOP
;

: step-y-mm ( -- ) \ 3 steps per mm
  y-steps-per-mm 0 DO step-y LOOP
;

: step-z-mm ( -- ) \ 100 steps per mm
  z-steps-per-mm 0 DO step-z LOOP
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
