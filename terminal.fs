
: go-to-position ( row col -- )
  esc[ swap 0 .r [char] ; emit 0 .r [char] H emit
;

: clear-screen-from-cursor ( -- )
  esc[ ." J"  ( clears from cursor to end of screen )
;

: clear-screen ( -- ) esc[ ." 2J" ;