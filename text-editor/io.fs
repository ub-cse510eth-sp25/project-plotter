include vars.fs

: logo ( -- )
  cr
  ." +-+-+-+-+-+-+" cr
  ." |E|D|I|T|O|R|" cr
  ." +-+-+-+-+-+-+" cr
;

: editor-rules ( -- )
  cr
  ." 1. You may type alpha characters and a period. All text will be plotted in capital letters." cr
  ." 2. To redraw the editor, you may hit the [ENTER] key." cr
  ." 3. You are limited to 1000 characters. All extra text will be truncated." cr
  ." 4. Your may use the arrow keys and the [BACKSPACE] key to edit prior text." cr
  cr
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
  cursor-pos @ 0 do 
    dup i + c@ emit
  loop
  drop
  cr
;

: pretty-print ( addr -- )
  cr
  cursor-pos @ 0 do
    dup i + c@ emit
    i 1+ 7 mod 0= if cr then
    i 69 = if leave then
  loop
  drop
  cr
;

: word-count ( -- )
  ." Character count: " total-chars @ . ." /70" cr
;

: alpha? ( c -- flag )
;

: add-char ( c addr -- )
  cursor-pos @ 69 < if
    swap over cursor-pos @ + c!
    1 cursor-pos +!
    1 total-chars +!
    drop
  else
    2drop
    ." Buffer full!"
  then
;

: key-enter 13 ;

: key-escape 27 ;

: key-backspace 8 ;

: user-input ( -- )
  begin
    key dup key-enter = if
      ." [ENTER] was hit" cr
      buffer draw-buffer
      word-count
      drop
    else
      dup key-escape = if
        ." [ESCAPE] was hit" cr
        drop
        exit
      else
        dup emit
	buffer add-char
      then
    then
  again
;
