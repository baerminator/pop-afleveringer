//Lavet af Bjørn Møller
// Her laves der en blackbox test af vores implementation af merge med pattern matching
let rec merge listx listy  =
    match listx with
        | [] -> listy
        | x::xs -> match listy with
                       | [] -> listx
                       | y::ys ->
                           match x with
                               | x when (x < y) ->  x :: merge xs (y::ys)
                               | x -> y :: merge (x::xs) ys
let rec msort xs =
    let sz = List.length xs
    if sz < 2 then xs
    else
        let n = sz / 2
        let ys = xs.[0..n-1]
        let zs = xs.[n..sz-1]
        in
        merge (msort ys) (msort zs)

// Vi vil undersøge 5 tilfælde:
// ved en tom liste:
printfn "\n(msort [])  returnerer %A" (msort [])
// ved en liste med 1 element
printfn "(msort [7]) returnerer %A" (msort [7])
// ved en liste med flere elementer sorteret 
printfn "(msort [3; 4; 5; 6; 7;]) returnerer %A" (msort [3; 4; 5; 6; 7;])
// ved en liste med flere elementer omvendt sorteret
printfn "(msort [7; 6; 5; 4; 3;]) returnerer %A" (msort [7; 6; 5; 4; 3;])
// ved en liste med flere elementer usorteret
printfn "(msort [5; 4; 7; 6; 3;]) returnerer %A" (msort [5; 4; 7; 6; 3;])
