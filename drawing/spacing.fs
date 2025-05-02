5 constant CHARSPACE
15 constant CHARHEIGHT
5 constant LINESPACE

: next-char ( -- )
    CHARSPACE rel-x
    0 CHARHEIGHT - rel-y
;

: init-bell ( -- )
  BELL output-pin
;

init-bell

: ring ( -- )
  high BELL pin!
  2 ms
  low BELL pin!
;

: carriage-return ( -- )
    border abs-x
    ring
;

: new-line ( -- )
    LINESPACE rel-y
    CHARHEIGHT rel-y \ we always end at start position of next-char, so moving it down
;
