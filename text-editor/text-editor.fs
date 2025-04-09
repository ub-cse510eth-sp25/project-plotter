include io.fs
include vars.fs

: text-edit ( -- )
   total-chars set-zero
   cursor-pos set-zero
   buffer clear-buffer
   user-input
;

( runs the actual text editor )
: text-editor ( -- )
  logo
  editor-rules
  text-edit
;