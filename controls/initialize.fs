: init ( -- )
  reset
  -170 rel-y
  0 cur-y ! \ set cur y to 0 after moving it
  border rel-x
  border rel-y
;