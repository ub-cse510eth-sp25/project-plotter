include ./utils/terminal.fs
include ./options/text-editor/vars.fs
include ./options/writing/characters.fs
include ./options/text-editor/io.fs
include ./options/text-editor/text-editor.fs
include ./options/writing/programs.fs

: introduce-dotty ( -- )
  page
  ." Hi, I'm Dotty!" cr cr
  ." I started life as a 3D printer, but now I've found my true calling as a pen plotter. Whether it's geometric patterns, block letters, or custom designs, I'm here to bring your ideas to life on paper."
;

: plotter-options ( -- )
    cr cr
    ." [1] 🔄		Reset Plotter Position" cr
    ." [2] 🟥 🟦 🟩	Shapes & Patterns" cr
    ." [3] A B C	Single Character" cr
    ." [4] ABC XYZ 	Sentence" cr
    ." [5] 🤖   	About Dotty" cr
    ." [6] 🔌  	Power Down" cr
;

: take-input ( -- )
  cr
  ." Ready to draw! What's your pick? 
  key dup emit
;

: exit-program ( -- )
  introduce-dotty
  plotter-options
;

: determine-option ( -- )
  plotter-options
  begin
    13 0 go-to-position 
    take-input
    case
      [char] 1 of wait-for-init exit-program false endof
      [char] 2 of shapes exit-program false endof
      [char] 3 of character exit-program false endof  
      [char] 4 of text-editor exit-program false endof
      [char] 5 of about-dotty exit-program false endof
      [char] 6 of true endof
      dup cr ." Invalid option, try again." cr drop false swap
    endcase
  until
  page
;

: main ( -- )
  introduce-dotty
  determine-option
;