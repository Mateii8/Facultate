par(X) :-
    0 is X mod 2.
impar(X) :-
    1 is X mod 2.

suma_pare([], 0).
suma_pare([H|T], S) :-
    par(H),
    suma_pare(T, S1),
    S is S1 + H.
suma_pare([H|T], S) :-
    impar(H),
    suma_pare(T, S).

suma_impare([], 0).
suma_impare([H|T], S) :-
    impar(H),
    suma_impare(T, S1),
    S is S1 + H.
suma_impare([H|T], S) :-
    par(H),
    suma_impare(T, S).
