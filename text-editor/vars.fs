create buffer 70 allot

variable total-chars
variable cursor-pos

create last-action 20 allot
S" saved" last-action place

: set-zero ( addr -- )
   0 swap !
;