minim3(A, B, C, Min) :-
    Min1 is min(A, B),
    Min is min(Min1, C).
