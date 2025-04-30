
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
: plot-period 46 emit ;
: plot-space 32 emit ;

: plot-a ( -- )
  15 rel-y
  pen-down
  leg-reverse
  5 -3 move-to-rel
  5 3 move-to-rel
  leg
  leg-reverse
  -10 rel-x
  pen-up
  ( move to top right )
;

: plot-b ( -- )
  15 rel-y
  pen-down
  stem-reverse
  5 rel-x
  ( curves )
  5 3.5 move-to-rel
  -5 3.5 move-to-rel
  -5 rel-x
  5 rel-x
  ( curves )
  5 3.5 move-to-rel
  -5 3.5 move-to-rel
  -5 rel-x
  ( we are at the left edge)
  pen-up
  10 rel-x ( at bottom right )
;

: plot-c ( -- )
  10 rel-x
  pen-down
  arm-reverse
  stem
  arm-reverse
  pen-up
;

: plot-d ( -- )
  15 rel-y
  pen-down
  stem-reverse
  4 rel-x
  6 2.5 move-to-rel
  10 rel-y
  -6 2.5 move-to-rel
  -4 rel-x
  ( we are at the left edge)
  pen-up
  10 rel-x ( at bottom right )
;

: plot-e ( -- )
    \ assumes starting at botom left corner
    10 rel-x
    pen-down
    -10 rel-x
    15 rel-y
    10 rel-x
    pen-up
    -10 -7 move-to-rel
    pen-down
    8 rel-x
    pen-up
    7 2 move-to-rel
    \ finishes at the top right corner
;

: plot-f ( -- )
    \ assumes starting at botom left corner
    pen-down
    15 rel-y
    10 rel-x
    pen-up
    -10 -7 move-to-rel
    pen-down
    8 rel-x
    pen-up
    7 2 move-to-rel
    \ finishes at the top right corner
;

: plot-g ( -- )
  10 rel-x
  pen-down
  arm-reverse
  stem
  arm
  half-stem-reverse
  half-arm-reverse
  pen-up
  half-arm
  half-stem
;

: plot-h ( -- )
    \ assumes starting at botom left corner
    pen-down
    15 rel-y
    pen-up
    -7 rel-y
    pen-down
    10 rel-x
    pen-up
    -8 rel-y
    pen-down
    15 rel-y
    pen-up
    \ finishes at the top right corner
;

: plot-i ( -- )
    \ assumes starting at botom left corner
    pen-down
    10 rel-x
    pen-up
    -5 rel-x
    pen-down
    15 rel-y
    pen-up
    -5 rel-x
    pen-down
    10 rel-x
    pen-up
    \ finishes at the top right corner
;

: plot-j ( -- )
  10 rel-x
  pen-down
  stem
  half-arm-reverse
  -5 -3.5 move-to-rel
  pen-up
  5 3.5 move-to-rel
  half-arm
;

: plot-k ( -- )
  15 rel-y
  stem-reverse
  7.5 rel-y
  10 -7.5 move-to-rel
  -10 7.5 move-to-rel
  10 7.5 move-to-rel
  pen-up ( already at bottom right )
;

: plot-l ( -- )
    \ assumes starting at botom left corner
    10 rel-x
    pen-down
    -10 rel-x
    15 rel-y
    pen-up
    10 rel-x
    \ finishes at the top right corner
;

: plot-m ( -- )
  15 rel-y
  pen-down
  stem-reverse
  5 3 move-to-rel
  5 -3 move-to-rel
  stem
  pen-up
  ( move to top right )
;

: plot-n ( -- )
  15 rel-y
  pen-down
  reverse-stem
  10 15 move-to-rel
  reverse-stem
  pen-up
  ( move to top right )
;

: plot-o ( -- )
  10 15 move-to-rel
  pen-down
  arm-reverse
  stem-reverse
  arm
  stem
  pen-up
;

: plot-p ( -- )
  15 rel-y
  pen-down
  stem-reverse
  10 rel-x
  6 rel-y
  -10 rel-x
  pen-up
  10 rel-x
  9 rel-y ( at bottom right )
;

: plot-q ( -- )
  10 rel-x
  pen-down
  arm-reverse
  leg
  3 rel-x
  7 -5 move-to-rel
  pen-up
  -7 rel-x
  pen-down
  7 5 move-to-rel
  pen-up
;

: plot-r ( -- )
  15 rel-y
  pen-down
  stem-reverse
  10 rel-x
  6 rel-y
  -10 rel-x
  10 9 move-to-rel
  pen-up ( at bottom right )
;

: plot-s ( -- )
  10 rel-x
  arm-reverse
  half-stem
  arm
  half-stem
  arm-reverse
  pen-up
  10 rel-x
;

: plot-t ( -- )
    \ assumes starting at botom left corner
    5 rel-x
    pen-down
    15 rel-y
    pen-up
    -5 rel-x
    pen-down
    10 rel-x
    pen-up
    \ finishes at the top right corner
;

: plot-u ( -- )
  pen-down
  15 rel-y
  10 rel-x
  stem-reverse
  pen-up
  15 rel-y ( at bottom right )
;

: plot-v ( -- )
  pen-down
  5 15 move-to-rel
  5 -15 move-to rel
  pen-up
  ( move to top right )
;

: plot-w ( -- )
  pen-down
  stem
  5 -3 move-to-rel
  5 3 move-to-rel
  reverse-stem
  ( move to top right )
;

: plot-x ( -- )
  pen-down
  10 15 move-to-rel
  pen-up
  -10 rel-x
  pen-down
  10 -15 move-to-rel
  pen-up
  ( move to top right )
;

: plot-y ( -- )
  pen-down
  5 3 move-to-rel
  leg
  leg-reverse
  5 -3 move-to-rel
  pen-up
  ( move to top right )
;

: plot-z ( -- )
  pen-down
  10 rel-x
  -10 15 move-to-rel
  10 rel-x
  pen-up
  ( move to top right )
;

: plot-period ( -- )
  15 rel-y
  5 rel-x
  pen-down
  pen-up
  5 rel-x
;

: plot-space ( -- )
  15 rel-y
  10 rel-x
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
      i 1+ 7 mod 0= if new-line then
    loop
    cr
  then
;