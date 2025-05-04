: horizontal-line ( len-- )
  pen-down
  rel-x
  pen-up
;

: vertical-line ( len-- )
  pen-down
  rel-y
  pen-up
;

( stem - used for: B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, T, U )
: stem ( -- )
  15 rel-y
;

: stem-reverse ( -- )
  -15 rel-y
;

( used for: A, Y )
: leg ( -- )
  12 rel-y
;

: leg-reverse ( -- )
  -12 rel-y
;

( used for: S, R, P, G )
: half-stem ( -- )
  8 rel-y
;

: half-stem-reverse ( -- )
  -8 rel-y
;

: arm ( -- )
  10 rel-x
;

: arm-reverse ( -- )
  -10 rel-x
;

: half-arm ( -- )
  5 rel-x
;

: half-arm-reverse ( -- )
  -5 rel-x
;
