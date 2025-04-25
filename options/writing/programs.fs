
( this will include the programs for doing each option )

( ////////////// )
( shapes )

: shape-dialogue ( -- )
  page
  cr ." Dotty: Ah yes, I love shapes. These are are what I have been practicing..." 
;
: shape-options ( -- )
    cr cr
    ." [1] Square" cr
    ." [2] Triangle" cr
    ." [3] Exit" cr
;

: shape-input ( -- )
  cr
  ." Which would you like me to create? " 
  key dup emit
;

: plot-square ( -- )
  cr ." SQUARE"
;

: plot-triangle ( -- )
  cr ." TRIANGLE"
;

: determine-shape ( -- )
  shape-options
  begin
    7 0 go-to-position 
    shape-input
    case
      [char] 1 of clear-screen-from-cursor plot-square false endof
      [char] 2 of clear-screen-from-cursor plot-triangle false endof
      [char] 3 of true endof
      dup cr ." Invalid option, try again." cr drop false swap
    endcase
  until
;

: shapes ( -- )
  shape-dialogue
  determine-shape
;

( ////////////// )
( single characters )

: char-dialogue ( -- )
  page
  cr ." Dotty: Oh so you want to start slow? I'll show you a single character, but it has to be one that I know. Remember valid characters are the following:" cr
  ." A-Z, a-z, '.' and ' '"
  cr
;

: char-input ( -- )
  cr
  ." Choose your character: " 
  key dup emit
;

( not in use right now )
: empty-the-stack ( -- )
  begin
    depth 0> while
      drop
  repeat
;

: determine-char ( -- )
  begin
    7 0 go-to-position 
    char-input
    dup valid-char? if
      .s
      8 0 go-to-position
      clear-screen-from-cursor
      draw-char
      true
    else
      cr ." Invalid option, try again." cr drop
      drop
      false
    then
  until
  drop
;

: character ( -- )
  char-dialogue
  determine-char
;

( ////////////// )
( dotty blurb )
: about-dotty cr ." this will be the blurb about her specs" ;