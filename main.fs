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
    ." [1] 🟥 🟦 🟩	Shapes & Patterns" cr
    ." [2] A B C	Single Character" cr
    ." [3] ABC XYZ 	Sentence" cr
    ." [4] 🤖   	About Dotty" cr
    ." [5] 🔌  	Power Down" cr
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
    12 0 go-to-position 
    take-input
    case
      [char] 1 of shapes exit-program false endof
      [char] 2 of character exit-program false endof  
      [char] 3 of text-editor exit-program false endof
      [char] 4 of about-dotty exit-program false endof
      [char] 5 of true endof
      dup cr ." Invalid option, try again." cr drop false swap
    endcase
  until
  page
;

: main ( -- )
  introduce-dotty
  determine-option
;