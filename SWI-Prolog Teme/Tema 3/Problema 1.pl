suma([], 0).
suma([H|T], S) :-
    suma(T, S1),
    S is S1 + H.
ma(L, M) :-
    suma(L, S),
    length(L, N),
    N > 0,
    M is S / N.

