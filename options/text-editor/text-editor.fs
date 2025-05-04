
: text-edit ( -- )
   total-chars set-zero
   buffer clear-buffer
   user-input
;

( runs the actual text editor )
: text-editor ( -- )
  logo
  editor-rules
  text-edit
  \ link back to main program?
;

