e1(X, Y, E) :-
    X > 2,
    Y > 1,
    E is X + Y - 1.

e1(X, Y, E) :-
    E is 2*X - Y + 1.

e3(X, Y, E) :-
    Max is max(X, Y),
    Min is min(X, Y),
    e1(X, Y, E1),
    E is Max - Min + E1.
max3(X, Y, Z, Max) :-
    Max1 is max(X, Y),
    Max is max(Max1, Z).

min3(X, Y, Z, Min) :-
    Min1 is min(X, Y),
    Min is min(Min1, Z).

media(X, Y, M) :-
    M is (X + Y) / 2.

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

e4(X, Y, Z, T, E) :-
    max3(X, Y, Z, Max),
    min3(Y, Z, T, Min),
    media(X, Y, Med),
    e2(X, Y, Z, T, E2),
    E is Max - Min + Med - E2.


