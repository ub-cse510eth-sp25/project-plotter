
( prototype for other ufn. is redefined later )
: valid-char? ( -- ) ;

( takes char and return uppercase version )
: to-upper ( char -- uppercase-char )
  dup [CHAR] a >= over [CHAR] z <= and if
    [CHAR] a - [CHAR] A +
  then
;

(  draw single characters )
: plot-a 65 emit ;
: plot-b 66 emit ;
: plot-c 67 emit ;
: plot-d 68 emit ;
: plot-e 69 emit ;
: plot-f 70 emit ;
: plot-g 71 emit ;
: plot-h 72 emit ;
: plot-i 73 emit ;
: plot-j 74 emit ;
: plot-k 75 emit ;
: plot-l 76 emit ;
: plot-m 77 emit ;
: plot-n 78 emit ;
: plot-o 79 emit ;
: plot-p 80 emit ;
: plot-q 81 emit ;
: plot-r 82 emit ;
: plot-s 83 emit ;
: plot-t 84 emit ;
: plot-u 85 emit ;
: plot-v 86 emit ;
: plot-w 87 emit ;
: plot-x 88 emit ;
: plot-y 89 emit ;
: plot-z 90 emit ;
: plot-0 48 emit ;
: plot-1 49 emit ;
: plot-2 50 emit ;
: plot-3 51 emit ;
: plot-4 52 emit ;
: plot-5 53 emit ;
: plot-6 54 emit ;
: plot-7 55 emit ;
: plot-8 56 emit ;
: plot-9 57 emit ;
: plot-period 46 emit ;
: plot-space 32 emit ;

: plot-a ( -- )
  stem
  pen-down
  leg-reverse
  5 -3 move-to-rel
  5 3 move-to-rel
  leg
  pen-up
  leg-reverse
  2 rel-y
  pen-down
  arm-reverse
  pen-up
  -2 rel-y
  ( move to bot right )
  leg
  arm

;

: plot-b ( -- )
  stem
  pen-down
  stem-reverse
  half-arm
  5 3 move-to-rel
  -5 4 move-to-rel
  half-arm-reverse
  half-arm
  5 4 move-to-rel
  -5 4 move-to-rel
  half-arm-reverse
  pen-up
  ( move to bot right )
  arm
;

: plot-c ( -- )
  arm
  pen-down
  arm-reverse
  stem
  arm
  pen-up
  ( at bot right )
;

: plot-d ( -- )
  stem
  pen-down
  stem-reverse
  4 rel-x
  6 3 move-to-rel
  9 rel-y
  -6 3 move-to-rel
  -4 rel-x
  pen-up
  ( move to bot right )
  arm
;

: plot-e ( -- )
  arm
  pen-down
  arm-reverse
  stem
  arm
  pen-up
  arm-reverse
  half-stem-reverse
  pen-down
  8 rel-x
  pen-up
  ( move to bot right )
  2 rel-x
  half-stem
;

: plot-f ( -- )
  arm
  pen-down
  arm-reverse
  stem
  pen-up
  -7 rel-y
  pen-down
  arm
  pen-up
  ( move to bot right )
  half-stem
;

: plot-g ( -- )
  arm
  pen-down
  arm-reverse
  stem
  arm
  half-stem-reverse
  half-arm-reverse
  pen-up
  ( move to bot right )
  half-arm
  half-stem
;

: plot-h ( -- )
  pen-down
  stem
  pen-up
  half-stem-reverse
  pen-down
  arm
  pen-up
  -7 rel-y
  pen-down
  stem
  pen-up
  ( at bot right )
;

: plot-i ( -- )
  pen-down
  arm
  pen-up
  half-arm-reverse
  pen-down
  stem
  pen-up
  half-arm-reverse
  pen-down
  arm
  pen-up
  ( at bot right )
;

: plot-j ( -- )
  arm
  pen-down
  stem
  half-arm-reverse
  -5 -4 move-to-rel
  pen-up
  ( move to bot right )
  5 4 move-to-rel
  half-arm
;

: plot-k ( -- )
  pen-down
  stem
  pen-up
  arm
  pen-down
  -10 -8 move-to-rel
  10 7  move-to-rel
  pen-up
  ( move to bot right )
  stem
;

: plot-l ( -- )
    pen-down
    stem
    arm
    pen-up
    ( move to bot right )
;

: plot-m ( -- )
  stem
  pen-down
  stem-reverse
  5 3 move-to-rel
  5 -3 move-to-rel
  stem
  pen-up
  ( at bot right )
;

: plot-n ( -- )
  stem
  pen-down
  stem-reverse
  10 15 move-to-rel
  stem-reverse
  pen-up
  ( move to bot right )
  stem
;

: plot-o ( -- )
  10 15 move-to-rel
  pen-down
  arm-reverse
  stem-reverse
  arm
  stem
  pen-up
  ( at bot right )
;

: plot-p ( -- )
  stem
  pen-down
  stem-reverse
  arm
  6 rel-y
  arm-reverse
  pen-up
  ( move to bot right )
  arm
  9 rel-y
;

: plot-q ( -- )
  arm
  pen-down
  arm-reverse
  stem
  3 rel-x
  7 -5 move-to-rel
  pen-up
  -7 rel-x
  pen-down
  7 5 move-to-rel
  pen-up
  ( at bot right )
;

: plot-r ( -- )
  stem
  pen-down
  stem-reverse
  arm
  6 rel-y
  arm-reverse
  10 9 move-to-rel
  pen-up ( at bottom right )
;

: plot-s ( -- )
  arm
  pen-down
  arm-reverse
  half-stem
  arm
  half-stem
  arm-reverse
  pen-up
  ( move to bot right )
  arm
;

: plot-t ( -- )
  pen-down
  arm
  pen-up
  half-arm-reverse
  pen-down
  stem
  pen-up
  ( move to bot right )
  half-arm
;

: plot-u ( -- )
  pen-down
  stem
  arm
  stem-reverse
  pen-up
  ( move to bot right )
  stem
;

: plot-v ( -- )
  pen-down
  5 15 move-to-rel
  5 -15 move-to-rel
  pen-up
  ( move to bot right )
  stem
;

: plot-w ( -- )
  pen-down
  stem
  5 -3 move-to-rel
  5 3 move-to-rel
  stem-reverse
  pen-up
  ( move to bot right )
  stem
;

: plot-x ( -- )
  pen-down
  10 15 move-to-rel
  pen-up
  arm-reverse
  pen-down
  10 -15 move-to-rel
  pen-up
  ( move to bot right )
  stem
;

: plot-y ( -- )
  pen-down
  5 3 move-to-rel
  5 -3 move-to-rel
  pen-up
  -5 3 move-to-rel
  leg
  pen-up
  ( move to bot right )
  half-arm
;

: plot-z ( -- )
  pen-down
  arm
  -10 15 move-to-rel
  arm
  pen-up
  ( move to top right )
;

( 0 1 2 3 4 5 6 7 8 9 )
: plot-0 ( -- )
  pen-down
  stem
  arm
  stem-reverse
  arm-reverse
  10 15 move-to-rel
  pen-up
;

: plot-1 ( -- )
  3 rel-y
  pen-down
  3 -3 move-to-rel
  stem
  pen-up
  -5 rel-x
  pen-down
  arm
  pen-up
;

: plot-2 ( -- )
  pen-down
  arm
  half-stem
  arm-reverse
  half-stem
  arm
  pen-up
;

: plot-3 ( -- )
  pen-down
  arm
  stem
  arm-reverse
  pen-up
  half-stem-reverse
  pen-down
  arm
  pen-up
  half-stem
;

: plot-4 ( -- )
  pen-down
  half-stem
  arm
  pen-up
  half-stem-reverse
  stem
  pen-up
;

: plot-5 ( -- )
  plot-s
;

: plot-6 ( -- )
  pen-down
  stem
  arm
  half-stem-reverse
  arm-reverse
  arm
  half-stem
  pen-up
;

: plot-7 ( -- )
  pen-down
  arm
  stem
  pen-up
;

: plot-8 ( -- )
  pen-down
  stem
  arm
  stem-reverse
  arm-reverse
  pen-up
  half-stem
  pen-down
  arm
  pen-up
  half-stem
;

: plot-9 ( -- )
  10 15 move-to-rel
  pen-down
  stem-reverse
  arm-reverse
  half-stem
  arm
  pen-up
  half-stem
;

: plot-period ( -- )
  stem
  half-arm
  pen-down
  pen-up
  half-arm
;

: plot-space ( -- )
  stem
  arm
;

( take a char and draw its representation)
: draw-char ( char -- )
  dup valid-char? if 
    to-upper
    case
      [CHAR] A of plot-a endof
      [CHAR] B of plot-b endof
      [CHAR] C of plot-c endof
      [CHAR] D of plot-d endof
      [CHAR] E of plot-e endof
      [CHAR] F of plot-f endof
      [CHAR] G of plot-g endof
      [CHAR] H of plot-h endof
      [CHAR] I of plot-i endof
      [CHAR] J of plot-j endof
      [CHAR] K of plot-k endof
      [CHAR] L of plot-l endof
      [CHAR] M of plot-m endof
      [CHAR] N of plot-n endof
      [CHAR] O of plot-o endof
      [CHAR] P of plot-p endof
      [CHAR] Q of plot-q endof
      [CHAR] R of plot-r endof
      [CHAR] S of plot-s endof
      [CHAR] T of plot-t endof
      [CHAR] U of plot-u endof
      [CHAR] V of plot-v endof
      [CHAR] W of plot-w endof
      [CHAR] X of plot-x endof
      [CHAR] Y of plot-y endof
      [CHAR] Z of plot-z endof
      [CHAR] 0 of plot-0 endof
      [CHAR] 1 of plot-1 endof
      [CHAR] 2 of plot-2 endof
      [CHAR] 3 of plot-3 endof
      [CHAR] 4 of plot-4 endof
      [CHAR] 5 of plot-5 endof
      [CHAR] 6 of plot-6 endof
      [CHAR] 7 of plot-7 endof
      [CHAR] 8 of plot-8 endof
      [CHAR] 9 of plot-9 endof
      [CHAR] . of plot-period endof
      32 of plot-space endof
      drop
    endcase
  else
    drop  ( drop invalid characters )
  then
;

: plot-buffer ( -- )
  total-chars @ 0= if
     cr
     ." buffer empty"
     drop
  else
    cr
    total-chars @ 0 do
      buffer i + c@ draw-char
      next-char
      i 1+ 8 mod 0= if carriage-return new-line then
    loop
    cr
  then
;
