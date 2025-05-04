\ Control Sequence Introducer (CSI): signals a control command is starting and not normal text

\ 27[
: esc[ ( -- )
  27 emit [char] [ emit
;

\ takes a digit and emits the characater version. adds ascii val for 0 (48?) to 'n' and emits it
: .digit ( n -- )
  [char] 0 + emit
;

\ handles two digit numbers and emits them without spaces
: .without-space ( n -- )
  dup 10 / dup if
    .digit
  else
    drop
  then
  10 mod .digit
;

\ CSI '27[row;colH' tells the terminal where to place the cursor
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