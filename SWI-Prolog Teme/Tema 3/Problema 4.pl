par(X) :-
    0 is X mod 2.
impar(X) :-
    1 is X mod 2.

concat_liste([], []).
concat_liste([L|T], R) :-
    concat_liste(T, R1),
    append(L, R1, R).

nr_pare([], 0).
nr_pare([H|T], N) :-
    par(H),
    nr_pare(T, N1),
    N is N1 + 1.
nr_pare([H|T], N) :-
    impar(H),
    nr_pare(T, N).

nr_impare([], 0).
nr_impare([H|T], N) :-
    impar(H),
    nr_impare(T, N1),
    N is N1 + 1.
nr_impare([H|T], N) :-
    par(H),
    nr_impare(T, N).

nr_pare_impare_concatenare(ListaDeListe, NrPare, NrImpare) :-
    concat_liste(ListaDeListe, L),
    nr_pare(L, NrPare),
    nr_impare(L, NrImpare).
