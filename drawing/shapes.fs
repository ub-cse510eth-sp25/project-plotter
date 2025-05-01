: plot-square ( -- )
  pen-down
  15 rel-x
  stem
  -15 rel
  stem-reverse
  pen-up
  15 10 move-to-rel
  
;

: plot-triangle ( -- )
  5 rel-x
  pen-down
  -5 10 move-to-rel
  arm
  -5 -10 move-to-rel
  pen-up
  5 10 move-to-rel
;

: plot-amogus ( -- )
;

: plot-sus ( -- )
;

: plot-red ( -- )
;