5 constant CHARSPACE
15 constant CHARHEIGHT
5 constant LINESPACE

: next-char ( -- )
    set-x-forward
    CHARSPACE step-x-mms
    set-y-backward
    CHARHEIGHT step-y-mms
;

: carriage-return ( -- )
    X reset-axis
;

: new-line ( -- )
    set-y-forward
    LINESPACE step-y-mms
;