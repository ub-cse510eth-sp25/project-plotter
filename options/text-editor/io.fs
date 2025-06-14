
: logo ( -- )
  page
  cr
  ." +-+-+-+-+-+-+" cr
  ." |E|D|I|T|O|R|" cr
  ." +-+-+-+-+-+-+" cr
;

: editor-rules ( -- )
  cr ." ╓────────────────────────────────────────────────────────╖"
  cr ." ║ Instructions:                                          ║"
  cr ." ║ - L/R arrow keys to navigate.	                         ║"
  cr ." ║ - ENTER to save or give exit prompt.                   ║"
  cr ." ║ - Valid chararcters are (A-Z, a-z, 0-9, '.' and ' ').  ║"
  cr ." ╙────────────────────────────────────────────────────────╜"
  cr cr ." Buffer: " cr
;

: clear-buffer ( addr -- )
  70 0 do 
    32 over i + c!
  loop
  drop
  total-chars set-zero
;

: clear-chars-from-buffer ( addr -- )
  70 0 do 
    32 over i + c!
  loop
  drop
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
  ." Remaining valid characetrs: " 70 total-chars @ - . cr
;

: valid-char? ( char -- flag )
  dup 
  dup [CHAR] a >= over [CHAR] z <= and

  swap dup [CHAR] A >= over [CHAR] Z <= and
  rot or

  swap dup [CHAR] 0 >= over [CHAR] 9 <= and
  rot or  

  swap dup [CHAR] . = 
  rot or

  swap dup [CHAR] - =
  rot or

  swap dup BL = 
  rot or

  swap drop
;

: empty-the-stack ( -- ) depth 0 ?do drop loop ;

: filter-buffer ( -- )
  \ clear the temp buffer
  temp-buffer clear-chars-from-buffer
  
  \ update tracking vars
  0 shifts !
  0 index !
  
  \ process buffer (take valid chars, leave the others)
  total-chars @ 0 ?do
    buffer i + c@ dup valid-char? invert if
      drop
      1 shifts +!
    else
      \ copy valid chars to temp
      temp-buffer index @ + c!
      1 index +!
    then
  loop
  
  \ update total chars to include only valid chars
  total-chars @ shifts @ - total-chars !
  
  \ wipe main buffer
  buffer clear-chars-from-buffer
  
  \ copy temp back to main buffer
  total-chars @ 0 ?do
    temp-buffer i + c@ buffer i + c!
  loop

  empty-the-stack
;

: user-input ( -- )
  \ place cursor at the beginning of the buffer
  14 0 go-to-position

  begin  
    \ position cursor at end of buffer for editing
    14 total-chars @ 1 + go-to-position
    
    \ read input, preserving existing content
    buffer total-chars @ + 70 total-chars @ - accept
    total-chars @ + total-chars !

    \ filter the buffer
    filter-buffer
    
    \ display updated buffer content
    14 0 go-to-position
    clear-screen-from-cursor
    buffer total-chars @ type
    
    \ position cursor at end of buffer again
    14 total-chars @ 1 + go-to-position
    
    \ show word count
    16 0 go-to-position
    word-count
    
    \ ask user if they are done
    ." Done? (y/[any key]): "
    key dup emit
    [CHAR] y = 
  until

  \ ask user if they want to plot buffer
  cr ." Plot this buffer? (y/[any key]): "
  key dup emit
  [CHAR] y = if
    plot-buffer
    carriage-return new-line
  then
;
