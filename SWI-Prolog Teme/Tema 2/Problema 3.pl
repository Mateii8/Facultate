l1(X, Y, Z, T, [X,Y,Z,T]).
l2(X, Y, Z, T, [[X,Y],[Z,T]]).
l3(X, Y, Z, T, [[X,Y,Z],[Y,Z,T]]).
diff([], _, []).
diff([H|T], L, R) :-
    member(H, L),
    diff(T, L, R).
diff([H|T], L, [H|R]) :-
    \+ member(H, L),
    diff(T, L, R).
e2(X, Y, Z, T, E) :-
    l1(X,Y,Z,T,L1),
    l2(X,Y,Z,T,L2),
    l3(X,Y,Z,T,L3),
    append(L1, L2, Temp),
    diff(Temp, L3, E).
