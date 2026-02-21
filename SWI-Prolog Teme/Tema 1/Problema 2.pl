e1(X, Y, E) :-
    X > 2,
    Y > 1,
    E is X + Y - 1.

e1(X, Y, E) :-
    E is 2*X - Y + 1.

e2(X, Y, Z, T, E) :-
    X > 2,
    Y > 2,
    Z > 1,
    T > 1,
    E is X + Y + Z + T.

e2(X, Y, Z, T, E) :-
    X > 2,
    Y > 2,
    Z < -1,
    T < -1,
    E is 2*X + Y - Z - T.

e2(X, Y, Z, T, E) :-
    E is X - Y + T.
