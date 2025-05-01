5 constant CHARSPACE
15 constant CHARHEIGHT
5 constant LINESPACE

: next-char ( -- )
    CHARSPACE rel-x
    0 CHARHEIGHT - rel-y
;

: carriage-return ( -- )
    border abs-y
;

: new-line ( -- )
    LINESPACE rel-y
    CHARHEIGHT rel-y \ we always end at start position of next-char, so moving it down
;