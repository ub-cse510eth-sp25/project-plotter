
( this will include the programs for doing each option )

( ////////////// )
( plotter psoition )
: wait-for-init ( -- )
  page
  ." Plotter is resetting its position. Please wait one moment..." cr
  init
;

( ////////////// )
( shapes )

: shape-dialogue ( -- )
  page
  cr ." Dotty: Ah yes, I love shapes. These are are what I have been practicing..." 
;
: shape-options ( -- )
    cr cr
    ." [1] Square" cr
    \ ." [2] Triangle" cr
    ." [2] Amogus (Crewmate)" cr
    ." [3] Amogus (Crewmate) Big" cr
    ." [4] UB Logo 1" cr
    ." [5] UB Logo 2" cr
    ." [6] Exit" cr
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

: plot-square ( -- )
  pen-down
  15 rel-x
  stem
  -15 rel-x
  stem-reverse
  pen-up
  15 15 move-to-rel
;

: plot-triangle ( -- )
  5 rel-x
  pen-down
  -5 10 move-to-rel
  arm
  -5 -10 move-to-rel
  pen-up
  5 10 move-to-rel
;

: ub-logo ( -- )
  badge-outline
  20 rel-y
  8 rel-x
  letter-U
  44 rel-x
  letter-b
  60 rel-y
  reset-x
  30 rel-x
  ub-year
  0 abs-z
  150 abs-y
;

: ub-logo2 ( -- )
  letter-u
  25 rel-x
  20 rel-y
  letter-b
  45 rel-y
  X reset-axis
  ub-full-name
  0 abs-z
  150 abs-y
;

: determine-shape ( -- )
  shape-options
  begin
    11 0 go-to-position 
    shape-input
    case
      [char] 1 of clear-screen-from-cursor plot-square false endof
      \ [char] 2 of clear-screen-from-cursor plot-triangle false endof
      [char] 2 of clear-screen-from-cursor plot-amogus false endof
      [char] 3 of clear-screen-from-cursor plot-amogus-big false endof
      [char] 4 of clear-screen-from-cursor init ub-logo false endof
      [char] 5 of clear-screen-from-cursor init ub-logo2 false endof
      [char] 6 of true endof
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
  ." A-Z, a-z, 0-9, '.' and ' '. Hit [ESCAPE] to exit this program. You are constrained to 10 characters per line."
  cr
;

: char-input ( -- )
  cr
  ." Choose your character: " 
  key dup emit
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
        draw-char next-char
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
: about-dotty ( -- )
  	      page
	      cr ." Hi, I'm Dotty! A Pen Plotter built around a Raspberry Pi Pico 2, and programmed in the forth programming language!" cr
	      ." I started life as a Lulzbot Mini 3D Printer, but after many years of disuse, 'the ethan blanton experience' revived me into what you see now!" cr
	      ." In addition to the pico 2, I am also comprised of three stepper motor drivers, a 5 volt regulator, and a lot of 22awg wire wrap (nick will say this was a mistake, but i disagree.)" cr cr
	      ." And now with that out of the way, it has been nice to met you! happy plotting! "
	      cr cr ." Hit [any key] when you are done reading.
	      key drop   
;

( wipe glass plate)
: clear-plate ( -- )
  pen-up
  page
  disable-motors
  cr ." Please clean off the glass plate now, then [any key] to re initialize and continue..." cr
  key drop
  1000 ms
  enable-motors
  wait-for-init
;
