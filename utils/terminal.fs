
: esc[ ( -- )
  27 emit [char] [ emit
;

: go-to-position ( row col -- )
  esc[
  swap u. drop       \ Print row without space
  [char] ; emit      \ Print semicolon
  u. drop            \ Print col without space
  [char] H emit      \ Print H
;

: clear-screen-from-cursor ( -- )
  esc[ ." J"  ( clears from cursor to end of screen )
;

: clear-screen ( -- ) esc[ ." 2J" ;