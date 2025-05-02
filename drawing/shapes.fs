: tilt-down-r
  1 1 move-to-rel
;

: tilt-down-l
  -1 1 move-to-rel
;

: tilt-up-l
  1 -1 move-to-rel
;

: tilt-up-r
  1 1 move-to-rel
;

: plot-amogus ( -- )
  4 rel-y
  pen-down \ start of window
  tilt-up-r
  4 rel-x
  tilt-down-r
  1 rel-y
  tilt-down-l
  -4 rel-x
  tilt-up-l
  -1 rel-y
  pen-up \ end of window
  tilt-up-r
  7 rel-x
  pen-down \ start of pack
  2 rel-x
  7 rel-y
  -2 rel-y
  pen-up \ end of pack
  -4 rel-y
  -7 rel-x
  pen-down \ start of body
  -2 rel-y
  tilt-up-r
  5 rel-x
  tilt-down-r
  14 rel-y
  -3 rel-x
  -5 rel-y
  -1 rel-x
  5 rel-y
  -3 rel-x
  -9 rel-y
  pen-up
;

: tilt-down-r
  2 2 move-to-rel
;

: tilt-down-l
  -2 2 move-to-rel
;

: tilt-up-l
  2 -2 move-to-rel
;

: tilt-up-r
  2 2 move-to-rel
;

: plot-amogus-big ( -- )
  8 rel-y
  pen-down \ start of window
  tilt-up-r
  8 rel-x
  tilt-down-r
  2 rel-y
  tilt-down-l
  -8 rel-x
  tilt-up-l
  -2 rel-y
  pen-up \ end of window
  tilt-up-r
  14 rel-x
  pen-down \ start of pack
  4 rel-x
  14 rel-y
  -4 rel-y
  pen-up \ end of pack
  -8 rel-y
  -14 rel-x
  pen-down \ start of body
  -4 rel-y
  tilt-up-r
  10 rel-x
  tilt-down-r
  28 rel-y
  -6 rel-x
  -10 rel-y
  -2 rel-x
  10 rel-y
  -6 rel-x
  -18 rel-y
  pen-up
;

: plot-sus ( -- )
  plot-amogus next-char
  plot-amogus next-char
  plot-amogus next-char
  plot-amogus next-char
  plot-amogus next-char
  plot-amogus next-char
;

: plot-very-sus ( -- )
  plot-amogus-big next-char stem-reverse
  plot-amogus-big next-char stem-reverse
  plot-amogus-big next-char stem-reverse
  plot-amogus-big next-char stem-reverse
  plot-amogus-big next-char stem-reverse
;