: init ( -- )
  pen-up \ make sure pen is not drawing
  reset
  pen-up
  170 cur-y !
  -160 rel-y \ already at border
  border rel-x
;