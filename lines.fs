: horizontal-line ( len-- )
  lower-pen
  rel-x
  lift-pen
;

: vertical-line ( len-- )
  lower-pen
  rel-y
  lift-pen
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
