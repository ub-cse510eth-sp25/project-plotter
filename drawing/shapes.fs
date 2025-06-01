: tilt-down-r
  1 1 move-to-rel
;

: tilt-down-l
  -1 1 move-to-rel
;

: tilt-up-l
  -1 -1 move-to-rel
;

: tilt-up-r
  1 -1 move-to-rel
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
  -2 rel-x
  pen-up \ end of pack
  -7 rel-y
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
  pen-up \ move to end
  9 rel-y
  9 rel-x
;

: tilt-down-r
  2 2 move-to-rel
;

: tilt-down-l
  -2 2 move-to-rel
;

: tilt-up-l
  -2 -2 move-to-rel
;

: tilt-up-r
  2 -2 move-to-rel
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
  -4 rel-x
  pen-up \ end of pack
  -14 rel-y
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
  pen-up \ move to end
  18 rel-y
  18 rel-x
;

: plot-sus ( -- )
  plot-amogus next-char
  plot-amogus next-char
  plot-amogus next-char
  plot-amogus next-char
  plot-amogus
;

: plot-very-sus ( -- )
  plot-amogus-big next-char stem-reverse
  plot-amogus-big next-char stem-reverse
  plot-amogus-big next-char stem-reverse
  plot-amogus-big next-char stem-reverse
  plot-amogus-big
;

\ UB logo
: badge-outline ( -- )
  pen-down
  100 rel-y
  50 40 move-to-rel
  50 -40 move-to-rel
  -100 rel-y
  -100 rel-x ( at top left corner ) 
  pen-up
;

: letter-u ( -- )
  pen-down
  20 rel-x
  10 rel-y
  -5 rel-x
  20 rel-y
  10 rel-x
  -20 rel-y
  -5 rel-x
  -10 rel-y
  20 rel-x
  10 rel-y
  -5 rel-x
  30 rel-y
  -30 rel-x
  -30 rel-y
  -5 rel-x
  -10 rel-y
  pen-up
;

: letter-b ( -- )
  pen-down
  35 rel-x
  5 5 move-to-rel
  10 rel-y
  -5 5 move-to-rel
  5 5 move-to-rel
  10 rel-y
  -5 5 move-to-rel
  -35 rel-x
  -10 rel-y
  5 rel-x
  -20 rel-y
  -5 rel-x
  -10 rel-y ( outline done )
  pen-up
  15 5 move-to-rel
  pen-down
  10 rel-x
  10 rel-y
  -10 rel-x
  -10 rel-y
  pen-up
  20 rel-y
  pen-down
  10 rel-x
  10 rel-y
  -10 rel-x
  -10 rel-y
  pen-up
  15 35 move-to-rel
;

: ub-year ( -- )
  plot-1 next-char
  plot-8 next-char
  plot-4 next-char
  plot-6 next-char 
;

: ub-full-name ( -- )
  plot-u next-char
  plot-n next-char
  plot-i next-char
  plot-v next-char
  plot-e next-char
  plot-r next-char
  plot-s next-char
  plot-i next-char
  plot-t next-char
  plot-y next-char
  carriage-return new-line
  plot-a next-char
  plot-t next-char
  plot-space next-char
  plot-b next-char
  plot-u next-char
  plot-f next-char
  plot-f next-char
  plot-a next-char
  plot-l next-char
  plot-o next-char
  
;

: scale ( val -- valscaledby5 )
  5 *
;

: ethans-head ( -- )
  2 scale rel-x
  pen-down
  12 scale rel-x ( long horiz line )
  2 scale 2 scale move-to-rel
  19 scale rel-y ( long vert line )
  -2 scale 2 scale move-to-rel
  -12 scale rel-x ( long horiz line )
  -2 scale -2 scale move-to-rel
  -19 scale rel-y
  2 scale -2 scale move-to-rel
  pen-up
  ( end position is at start of long horiz line )
;

: ethans-hair ( -- )
  pen-down
  3 scale rel-x
  -3 scale rel-y
  1 scale rel-x
  1 scale rel-y
  8 scale rel-x
  -1 scale rel-y
  1 scale rel-x
  3 scale rel-y
  3 scale rel-x
;

: ethans-ears ( -- )
  ( pen is already down, draw outer )
  4 scale rel-x
  7 scale rel-y
  -4 scale rel-x
  pen-up
  ( move and draw inner )
  -6 scale rel-y
  1 scale rel-x
  pen-down
  2 scale rel-x
  5 scale rel-y
  pen-up
  -1 scale rel-x
  pen-down
  -2 scale rel-y
  pen-up ( move to left side of head )
  -4 scale rel-y
  -18 scale rel-x
  pen-down ( draw right ear )
  -4 scale rel-x
  7 scale rel-y
  4 scale rel-x
  pen-up
  ( move and draw inner ear )
  -6 scale rel-y
  -1 scale rel-x
  pen-down
  -2 scale rel-x
  5 scale rel-y
  pen-up
  1 scale rel-x
  pen-down
  -2 scale rel-y
  pen-up
;

: ethans-glasses ( -- )
  ( draw left glasses )
  pen-down
  5 scale rel-x
  4 scale rel-y
  -5 scale rel-x
  -4 scale rel-y
  pen-up ( glasses done, draw reflection )
  2 scale 1 scale move-to-rel
  pen-down
  2 scale rel-y
  pen-up
  1 scale rel-x
  pen-down
  -1 scale rel-y
  pen-up
  2 scale rel-x
  ( draw bridge of glasses )
  pen-down
  4 scale rel-x
  pen-up
  -2 scale rel-y
  ( draw right glasses )
  pen-down
  5 scale rel-x
  4 scale rel-y
  -5 scale rel-x
  -4 scale rel-y
  pen-up ( glasses done, draw reflection )
  2 scale 1 scale move-to-rel
  pen-down
  2 scale rel-y
  pen-up
  1 scale rel-x
  pen-down
  -1 scale rel-y
  pen-up ( at top of smaller glare on right glasses )
;

: ethans-nose ( -- )
  pen-down
  -2 scale rel-x
  -4 scale rel-y
  pen-up
  -2 scale rel-x
  pen-down
  4 scale rel-y
  -2 scale rel-x
  pen-up ( at bot left of nose )
;

: ethans-beard ( -- )
  ( draw beard and left go tee )
  pen-down
  3 scale 3 scale move-to-rel
  -2 scale rel-y
  3 scale rel-x
  pen-up
  ( move to and draw go tee start )
  3 scale rel-y
  pen-down
  1 scale rel-x
  -1 scale rel-y
  2 scale rel-x
  1 scale rel-y
  1 scale rel-x
  pen-up
  ( move to and draw beard )
  -3 scale rel-y
  pen-down
  3 scale rel-x
  2 scale rel-y
  3 scale -3 scale move-to-rel
  pen-up ( at top right of beard )
;

: ethans-mouth ( -- )
  pen-down
  1 scale rel-y
  -8 scale rel-x
  -1 scale rel-y
  8 scale rel-x
  pen-up
;

: draw-ethan ( -- )
  7 scale rel-x
  ethans-head
  -2 scale rel-x 5 scale rel-y
  ethans-hair
  ethans-ears
  -2 scale rel-y 3 scale rel-x 
  ethans-glasses
  -2 scale rel-x 3 scale rel-y
  ethans-nose
  -5 scale 1 scale move-to-rel
  ethans-beard
  -4 scale 2 scale move-to-rel ( top right of mouth)
  ethans-mouth
  init ( done !)
;
