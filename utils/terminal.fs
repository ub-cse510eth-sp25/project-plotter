
: esc[ ( -- )
  27 emit [char] [ emit
;

: .digit ( n -- )
  [char] 0 + emit
;

: .without-space ( n -- )
  dup 10 / dup if
    .digit
  else
    drop
  then
  10 mod .digit
;

: go-to-position ( row col -- )
  esc[
  swap .without-space
  [char] ; emit
  .without-space
  [char] H emit
;

: clear-screen-from-cursor ( -- )
  esc[ ." J"  ( clears from cursor to end of screen )
;

: clear-screen ( -- ) esc[ ." 2J" ;