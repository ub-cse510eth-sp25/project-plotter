: plot-A ( -- )
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

: plot-M ( -- )
  15 rel-y
  pen-down
  stem-reverse
  5 3 move-to-rel
  5 -3 move-to-rel
  stem
  pen-up
  ( move to top right )
;

: plot-N ( -- )
  15 rel-y
  pen-down
  reverse-stem
  10 15 move-to-rel
  reverse-stem
  pen-up
  ( move to top right )
;

: plot-V ( -- )
  pen-down
  5 15 move-to-rel
  5 -15 move-to rel
  pen-up
  ( move to top right )
;

: plot-W ( -- )
  pen-down
  stem
  5 -3 move-to-rel
  5 3 move-to-rel
  reverse-stem
  ( move to top right )
;

: plot-X ( -- )
  pen-down
  10 15 move-to-rel
  pen-up
  -10 rel-x
  pen-down
  10 -15 move-to-rel
  pen-up
  ( move to top right )
;

: plot-Y ( -- )
  pen-down
  5 3 move-to-rel
  leg
  leg-reverse
  5 -3 move-to-rel
  pen-up
  ( move to top right )
;

: plot-Z ( -- )
  pen-down
  10 rel-x
  -10 15 move-to-rel
  10 rel-x
  pen-up
  ( move to top right )
;
