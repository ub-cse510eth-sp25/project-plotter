: load-gpio ( -- ) gpio import ; \ loads GPIO module
: load-timer ( -- ) timer import ; \ loads timer module


10 constant DIR \ GPIO 10 - update w/ correct GPIO
11 constant STEP \ GPIO 11 - update w/ correct GPIO
1 constant CW \ clockwise
0 constant CCW \ counterclockwise


\ enables DIR and STEP as output
: intialize-gpios ( -- ) \ depending on the bits I may be overwriting
  1 DIR bit GPIO_OE_SET !
  1 STEP bit GPIO_OE_SET !
;

: set-cw ( -- )
  1 DIR bit GPIO_OUT_SET ! ;

: set-ccw ( -- )
  1 DIR bit GPIO_OUT_CLR ! ;

: step-on ( -- )
  1 STEP bit GPIO_OUT_SET ! ;

: step-off ( -- )
  1 STEP bit GPIO_OUT_CLR ! ;

: step-delay ( -- ) 1000 ms ; \ change later

: step-once ( -- )
  step-on
  step-delay
  step-off
  step-delay ;

: rotate-once ( -- )
  200 0 d fao
    step-once
  loop ;
