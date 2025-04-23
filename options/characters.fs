
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
: space 32 emit ;
: newline 10 emit ;

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
      32 of space endof
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
    loop
    cr
  then
;