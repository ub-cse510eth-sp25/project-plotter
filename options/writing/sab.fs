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

: plot-u ( -- )
  pen-down
  15 rel-y
  10 rel-x
  stem-reverse
  pen-up
  15 rel-y ( at bottom right )
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