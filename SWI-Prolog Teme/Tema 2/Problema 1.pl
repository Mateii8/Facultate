b(0,-1).
b(1,2).
 b(N, Bn) :-
    N >= 2,
    N1 is N - 1,
    N2 is N - 2,
    b(N1, Bn1),
    b(N2, Bn2),
    Bn is Bn1 - 2 * Bn2.
