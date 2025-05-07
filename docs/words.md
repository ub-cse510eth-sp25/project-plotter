# Word List

## Motor Control
`import-pin ( -- )`
Import pin module

`initialize-pins-x ( -- )`
set relevant x-axis GPIO pins to output state

`initialize-pins-y ( -- )`
set relevant y-axis GPIO pins to output state

`initialize-pins-z ( -- )`
set relevant z-axis GPIO pins to output state

`set-x-forward ( -- )`
set DIRx pin to high

`set-y-forward ( -- )`
set DIRy pin to high

`set-z-forward ( -- )`
set DIRz pin to high

`set-x-backward ( -- )`
set DIRx pin to low

`set-y-backward ( -- )`
set DIRy pin to low

`set-z-backward ( -- )`
set DIRz pin to low

`step-x ( -- )`
Move x gear a step (1.8 degrees)

`step-y ( -- )`
Move y gear a step (1.8 degrees)

`step-z ( -- )`
Move z gear a step (1.8 degrees)

`step-x-mm ( -- )`
Move 1 mm in x-axis 

`step-y-mm ( -- )`
Move 1 mm in y-axis

`step-z-mm ( -- )`
Move 1 mm in z-axis 

`step-x-mms ( n -- )`
Move `n` mms in x-axis

`step-y-mms ( n -- )`
Move `n` mms in y-axis

`step-z-mms ( n -- )`
Move `n` mms in z-axis

## Positioning

`nStop ( axis -- pin )`  
Returns the pin constant given the axis (also a constant.)

`initialize-nSTOPs ( -- )`
Initializes end stop pins and sets them to pull up pins.

`at-stop? ( axis -- bool )`  
Is a stop hit in the `axis` position?

`x-to-home ( -- )`
Moves x postion to origin.

`y-to-home ( -- )`
Moves y postion to origin.

`z-to-home ( -- )`
Moves z postion to origin.

`reset-axis ( axis -- )`  
Moves the axis motor to its reset position.  
Sequence:  
- Move toward stop  
- Hit stop  
- Move away from stop  
- Move toward stop again  
- Hit stop (done)

`reset ( -- )`  
Returns system to home/start position.  
Written using `reset-axis`.

`init ( -- )`  
Initializes system by enabling motors, homing, and moving pen to start position (accounting for borders).

## Absolute Positioning

`abs-x ( n -- )`  
Moves to absolute X position.

`abs-y ( n -- )`  
Moves to absolute Y position.

`abs-z ( n -- )`  
Moves to absolute Z position.

`move-to-abs ( x y -- )`  
Moves to absolute X, Y coordinates.  
Written using `abs-x` and `abs-y`.

## Relative Positioning

`rel-x ( n -- )`  
Moves by `n` units relative to the current X position.  
Implemented as: `x current-position n + abs-x`

`rel-y ( n -- )`  
Moves by `n` units relative to the current Y position.  
Implemented as: `y current-position n + abs-y`

`rel-z ( n -- )`  
Moves by `n` units relative to the current Z position.  
Implemented as: `z current-position n + abs-z`

`move-to-rel ( x y -- )`  
Moves to relative X,Y coordinates.  
Written using `rel-x` and `rel-y`.

## Pen Control

`pen-up ( -- )`  
Lifts the pen up.

`pen-down ( -- )`  
Lowers the pen down.

## Spacing

`next-char ( -- )`  
Moves the pen to the starting position for the next character (top-left corner of the character space).

`carriage-return ( -- )`
Moves pen left to the starting position of the line.

`new-line ( -- )`
Moves pen down to the starting position of a new line.

## Lines

`horizontal-line ( len -- )`  
Draws a horizontal line from left to right.  
Implemented as: `pen-down len rel-x pen-up`

`vertical-line ( len -- )`  
Draws a vertical line from top to bottom.  
Implemented as: `pen-down len rel-y pen-up`

`stem ( -- )`
Draws a stem.

`stem-reverse ( -- )`
Draws a stem in reverse.

`leg ( -- )`
Draws a leg.

`leg-reverse ( -- )`
Draws a leg in reverse.

`half-stem ( -- )`
Draws half a stem.

`half-stem-reverse ( -- )`
Draws half a stem in reverse.

`arm ( -- )`
Draws an arm.

`arm-reverse ( -- )`
Draws an arm in reverse.

`half-arm ( -- )`
Draws half an arm.

`half-arm-reverse ( -- )`
Draws half an arm in reverse.

## Terminal

`esc[ ( -- )`
Emits an ANSI escape sequence starter (ASCII 27 followed by '[') which tells the terminal that a control command is coming.

`.digit ( n -- )`
Converts a single digit number (0-9) to its ASCII character and emits it to the terminal.

`.without-space ( n -- )`
Formats and emits a number as text without adding spaces, essential for ANSI sequences which need tight formatting.

`go-to-position ( row col -- )`
Places the cursor at the specified row and column.

`clear-screen-from cursor ( -- )`
Clears all characters from the screen from after the cursor position.

`clear-screen ( -- )`
Clears all characters from the screen.

## Text-Editor

`text-edit ( -- )`
Initiales the variables used for managing the text buffer. Additionally, fills the buffer with spaces and begins taking user input.

`text-editor ( -- )`
Displays the logo for the text editor and editor rules, then begins running the editor program.

## Text-Editor (I/O)

`set-zero ( addr -- )`
This word places zero at the provided memory address.

`logo ( -- )`
Displays the logo of the text editor.

`editor-rules ( -- )`
Displays the accepted keys used while using the editor.

`clear-buffer ( addr -- )`
Given an adress, writed spaces to the first 70 cells. Adittionally, sets the buffer variables to zero.

`clear-chars-from-buffer ( addr -- )`
Given an adress, writed spaces to the first 70 cells.

`draw-buffer ( addr -- )`
Given an adress, draws the contents of the buffer. The bound is the variable total-chars.

`word-count ( -- )`
Displays the remaining amount of valid characters.

`valid-char? ( char -- flag )`
Takes a character and places a flag telling if the consumed character was valid (A_Z, a-z, 0-9, '.', ' ').

`empty-the-stack ( -- )`
Removes all values from the stack.
**Note: this is a patch for the filter function**

`filter-buffer ( -- )`
Scans the editor buffer for invalid characters and removes them.

`user-input ( -- )`
Takes user input until the buffer is full. This allows for 70 valid characters and uses ACCEPT to take input. After each iteration, the word also filters the buffer.

## Programs

`shape-dialogue ( -- )`
Displays Dotty's response to the shape selection.

`shape-options ( -- )`
Displays the options for possible chapes to draw.

`shape-input ( -- )`
Prompts the user for input and captures and echoes a single keypress.

`determine-shape ( -- )`
Creates a menu loop that processes user selections 1-3, executing different drawing features and exiting only when option 3 is chosen.

`shapes ( -- )`
Entry point of the shapes program that displays Dotty's response to the shape selection and starts the option selection process.

`char-dialogue ( -- )`
Displays Dotty's response to the sharacter selection.

`char-input ( -- )`
Prompts the user for input and captures and echoes a single keypress.

`determine-char ( -- )`
Creates a loop that processes user input. It notifies uers of invalid input and breaks once the scape key is hit.

`character ( -- )`
Entry point of the single character program that displays Dotty's response to the character selection and starts the loop for user input.

`about-dotty ( -- )`
Displays a section about the hardware specifications for the repurposed 3D-printer.

## Drawing (Shapes and Characters)

`plot-square ( -- )`
Draws a square.

`plot-triangle ( -- )`
Draws a triangle.

`to-upper ( char -- uppercase-char )`
Takes an alpha character and produces the uppercase version of it. Otherwise, it leave s the character on the stack.

`plot-*`
Plots an uppercase character or number. The prototype of these words (defined above) emit the character for testing purposes.

`plot-period`
Plots a period.

`plot-hyphen`
Plots a hyphen.

`plot-space`
"Plots" a space.

`draw-char (char -- )`
Takes a character and plots it if it is valid. If not, the plotter does nothing.

`plot-buffer ( -- )`
Plots all characters in a buffer.

## Drawing (Art and UB Logos)

`plot-amogus ( -- )`
Plots a 10x15 mm Among Us Crewmate.

`plot-amogus-big ( -- )`
Plots a 20x30 mm Among Us Crewmate.

## Main Program

`introduce-dotty ( -- )`
Displays text introducing the plotter/3D-printer character.

`plotter-options ( -- )`
Displays the possible "program" options for the plotter (shapes, single character, buffer, about page, exit, etc.).

`take-input ( -- )`
Prompts the user for input and captures and echoes a single keypress.

`exit-program ( -- )`
Returns the user to the main menu by displaying the introduction and showing the plotter options.

`determine-option ( -- )`
Creates a menu loop that processes user selections 1-5, executing different drawing features and exiting only when option 5 is chosen.

`main ( -- )`
Entry point of the program that displays the introduction and starts the option selection process. This links to all other functionality.
