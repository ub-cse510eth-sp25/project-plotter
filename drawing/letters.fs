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

: plot-E ( -- )
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

: plot-F ( -- )
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

: plot-H ( -- )
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

: plot-I ( -- )
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

: plot-L ( -- )
    \ assumes starting at botom left corner
    10 rel-x
    pen-down
    -10 rel-x
    15 rel-y
    pen-up
    10 rel-x
    \ finishes at the top right corner
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

: plot-T ( -- )
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
