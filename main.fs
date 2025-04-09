include ./text-editor/text-editor.fs
include ./options/primitives.fs


: introduce-dotty ( -- )
  page
  ." Hi, I'm Dotty!" cr cr
  ." I started life as a 3D printer, but now I've found my true calling as a pen plotter. Whether it's geometric patterns, block letters, or custom designs, I'm here to bring your ideas to life on paper. Just send me your design, and watch as I dance across the page!"
;

: plotter-options ( -- )
    cr cr
    ." [1] 🟥 🟦 🟩	Shapes & Patterns" cr
    ." [2] A B C	Single Character" cr
    ." [3] HELLO      	Word" cr
    ." [4] ABC XYZ 	Sentence" cr
    ." [5] 🤖   	About Dotty" cr
    ." [6] 🔌  	Power Down" cr
;

: take-input ( -- )
  cr
  ." Ready to draw! What's your pick? 
  key dup emit
;

: determine-option ( -- )
  plotter-options
  begin
    take-input  ( get and echo user input )   
    case
      [char] 1 of shapes false endof
      [char] 2 of character false endof
      [char] 3 of single-word false endof  
      [char] 4 of text-editor false endof
      [char] 5 of about-dotty false endof
      [char] 6 of true endof
      dup cr ." Invalid option, try again." cr drop false swap
    endcase
  until
;

: main ( -- )
  introduce-dotty
  determine-option
;