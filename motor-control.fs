\ Assumptions:
\ 1. clockwise is forwards
\ 2. counter-clockwise is backwards
\ 3. DIR outputting high cause cw direction, and low the opposite

10 constant DIR \ GPIO 10
11 constant STEP \ GPIO 11
12 constant RESET \ GPIO 12
13 constant ENABLE \ GPIO 13
14 constant SLEEP \ GPIO 14
\ update w correct GPIOs^

: import-pin ( -- )
  pin import
;

: intialize-pins ( -- ) \ sets all pins to output state
  DIR output-pin
  STEP output-pin
  RESET output-pin
  ENABLE output-pin
  SLEEP output-pin
;

: set-cw ( -- )
  high DIR pin! \ set direction pin to high
;

: set-ccw ( -- )
  low DIR pin!
;

: step ( -- )
  STEP toggle-pin
  STEP toggle-pin
;

: step-forward ( -- )
  set-cw
  step
;

: step-backward ( -- )
  set-ccw
  step
;

: step-cm ( -- )
  \ 1. need circumference of the gear -? C = pi * 2 * radius | pi * diameter (in cms)
  \ 2. need steps per revolution
  \ 3. x = {1} / {2}
  \ x 0 do step LOOP
;

: step-cms ( n-- )
  0 DO step-cm LOOP ;
