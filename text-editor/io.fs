
: logo ( -- )
  page
  cr
  ." +-+-+-+-+-+-+" cr
  ." |E|D|I|T|O|R|" cr
  ." +-+-+-+-+-+-+" cr
;

: editor-rules ( -- )
  cr ." ╓───────────────────────────────────────╖"
  cr ." ║ Instructions:                         ║"
  cr ." ║ - L/R arrow keys to navigate.	        ║"
  cr ." ║ - ENTER to save or give exit prompt.  ║"
  cr ." ╙───────────────────────────────────────╜"
  cr cr ." Buffer: " cr
;

: clear-buffer ( addr -- )
  70 0 do 
    32 over i + c!
  loop
  drop
  cursor-pos set-zero
  total-chars set-zero
;

: draw-buffer ( addr -- )
  cr
  70 0 do 
    dup i + c@ emit
  loop
  drop
  cr
;

: word-count ( -- )
  ." Remaining characetrs: " 69 total-chars @ - . cr
  ." Last action: " last-action count type cr
;

: valid-char? ( char -- flag )
  dup 
  dup [CHAR] a >= over [CHAR] z <= and

  swap dup [CHAR] A >= over [CHAR] Z <= and
  rot or

  swap dup [CHAR] . = 
  rot or

  swap dup BL = 
  rot or

  swap drop
;

: add-char ( c addr -- )
  total-chars @ 69 < if
    swap over cursor-pos @ + c!
    1 cursor-pos +!
    1 total-chars +!
    drop
  else
    2drop
  then
;

: go-to-position ( row col -- )
  esc[ swap 0 .r [char] ; emit 0 .r [char] H emit
;

: clear-screen-from-cursor ( -- )
  esc[ ." J"  \ Clears from cursor to end of screen
;

: user-input ( -- )
  begin
    \ Display current buffer content
    14 0 go-to-position
    clear-screen-from-cursor
    buffer total-chars @ type
    
    \ Position cursor back at beginning of line for editing
    14 total-chars @ 1 + go-to-position
    
    \ Read input, preserving existing content
    buffer total-chars @ + 70 total-chars @ - accept
    total-chars @ + total-chars !
    
    \ Show word count
    16 0 go-to-position
    word-count
    
    \ Ask if done
    ." Done? (y/[any key]): "
    key dup emit
    [CHAR] y = 
  until
;