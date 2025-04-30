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
  -5 rel-y
  arm
  pen-up
;

: plot-2 ( -- )
  pen-down
  arm
  half-stem
  arm-reverse
  half stem
  arm
  pen-up
;

: plot-3 ( -- )
  pen-down
  arm
  stem
  arm-reverse
  arm
  half-stem-reverse
  arm-reverse
  arm
  half-stem
  pen-up
;

: plot-4 ( -- )
  pen-down
  half-stem
  arm
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
  half-stem
  arm
  half-stem
;

: plot-9 ( -- )
  10 15 move-to-rel
  pen-down
  stem-reverse
  arm-reverse
  half-stem
  arm
  half-stem
  pen-up
;
