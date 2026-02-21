concat_liste([], []).
concat_liste([L|T], R) :-
    concat_liste(T, R1),
    append(L, R1, R).
suma([], 0).
suma([H|T], S) :-
    suma(T, S1),
    S is S1 + H.
media_aritmetica(L, M) :-
    suma(L, S),
    length(L, N),
    N > 0,
    M is S / N.
media_concatenare(ListaDeListe, Media) :-
    concat_liste(ListaDeListe, L),
    media_aritmetica(L, Media).
