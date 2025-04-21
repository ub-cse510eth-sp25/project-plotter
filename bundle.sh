#!/bin/bash

# currently in the root directory
# output file which will be cat-ted to the device
OUTPUT="bundle.fs"

echo "\ Zeptoforth bundle created on $(date)" > $OUTPUT
echo "" >> $OUTPUT

# text-editor
if [ -d "text-editor" ];
then
    echo "\ -- text-editor files --------" >> $OUTPUT
    cat text-editor/vars.fs >> $OUTPUT
    cat text-editor/io.fs | grep -v "include" >> $OUTPUT
    cat text-editor/text-editor.fs | grep -v "include" >> $OUTPUT
    echo "" >> $OUTPUT
fi

# options files (shapes, character, words, etc)
# hardcoded, needs to be updated when more development happens
if [ -d "options" ];
then
    echo "\ -- options files -------- " >> $OUTPUT
    cat options/programs.fs >> $OUTPUT
fi

# driver file
echo "\ -- driver/main file --------" >> $OUTPUT
cat main.fs | grep -v "include">> $OUTPUT
