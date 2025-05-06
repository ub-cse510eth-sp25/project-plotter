: init ( -- )
  enable-motors
  set-z-forward \ makes sure pen is not on glass for reset
  2 step-z-mms
  reset
  pen-up
  170 cur-y !
  -160 rel-y \ already at border
  border rel-x
;
