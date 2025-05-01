
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
  ." A-Z, a-z, 0-9, '.' and ' '. Hit [ESCAPE] to exit this program."
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

: determine-char ( -- )
  begin
    7 0 go-to-position 
    char-input
    dup 27 = if        \ check if esc was pressed
      drop
      cr ." Exiting..." cr
      true
    else
      dup valid-char? if
        8 0 go-to-position
        clear-screen-from-cursor
        draw-char
        true
      else
        cr ." Invalid option, try again." cr
        drop
        false
      then
    then
  until
;

: character ( -- )
  char-dialogue
  determine-char
;

( ////////////// )
( dotty blurb )
: about-dotty cr ." Hi, I'm Dotty! A Pen Plotter built around a Raspberry Pi Pico 2, and programmed in the forth programming language!" cr
	      ." I started life as a Lulzbot Mini 3D Printer, but after many years of disuse, 'the ethan blanton experience' revived me into what you see now!" cr
	      ." In addition to the pico 2, I am also comprised of three stepper motor drivers, a 5 volt regulator, and a lot of 22awg wire wrap (nick will say this was a mistake, but i disagree.)" cr cr
	      ." And now with that out of the way, it has been nice to met you! happy plotting! "
;
