: plot-c ( -- )
  10 rel-x
  pen-down
  arm-reverse
  stem
  arm-reverse
  pen-up
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

: plot-o ( -- )
  10 15 move-to-rel
  pen-down
  arm-reverse
  stem-reverse
  arm
  stem
  pen-up
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