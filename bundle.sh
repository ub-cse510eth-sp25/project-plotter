#!/bin/bash

# currently in the root directory
# output file which will be cat-ted to the device
OUTPUT="bundle.fs"

echo "\ Zeptoforth bundle created on $(date)" > $OUTPUT
echo "" >> $OUTPUT

# globals.fs
echo "\ -- globals --------" >> $OUTPUT
cat controls/globals.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# motor-control.fs
echo "\ -- motor-control --------" >> $OUTPUT
cat controls/motor-control.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# positioning.fs
echo "\ -- positioning --------" >> $OUTPUT
cat controls/positioning.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# coordinates.fs
echo "\ -- coordinates --------" >> $OUTPUT
cat controls/coordinates.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# pen-control.fs
echo "\ -- pen-control --------" >> $OUTPUT
cat controls/pen-control.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# initialize.fs
echo "\ -- initialize --------" >> $OUTPUT
cat controls/initialize.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# lines.fs
echo "\ -- lines --------" >> $OUTPUT
cat drawing/lines.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# spacing.fs
echo "\ -- spacing --------" >> $OUTPUT
cat drawing/spacing.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# terminal.fs
echo "\ -- terminal utilities --------" >> $OUTPUT
cat utils/terminal.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# vars.fs
echo "\ -- variables --------" >> $OUTPUT
cat options/text-editor/vars.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# characters.fs
echo "\ -- writing files --------" >> $OUTPUT
cat options/writing/characters.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# shapes.fs
echo "\ -- shapes --------" >> $OUTPUT
cat drawing/shapes.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# io.fs
echo "\ -- I/O --------" >> $OUTPUT
cat options/text-editor/io.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# editor.fs
echo "\ -- text editor --------" >> $OUTPUT
cat options/text-editor/text-editor.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# programs.fs
echo "\ -- variables --------" >> $OUTPUT
cat options/writing/programs.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT

# main.fs
echo "\ -- main program --------" >> $OUTPUT
cat main.fs | grep -v "include" >> $OUTPUT
echo "" >> $OUTPUT
