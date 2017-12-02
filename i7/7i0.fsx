//Lavet af Bjørn Møller
/// <summary> Herunder laves funktionen merge, lavet på en form som indeholder pattern matching </summary>
/// <param name="listx">Dette er en liste modtaget fra enten merge eller mergesort funktionen , som sættes sammen med listen Listy, som har samme egenskaber </param>
/// <returns> en sammenkoblet liste lavet af listy og listx i sorteret rækkefølge </returns>
let rec merge listx listy =
    match listx with
        | [] -> listy
        | x::xs -> match listy with
                       | [] -> listx
                       | y::ys ->
                           match x with
                               | x when (x < y) -> x :: merge xs (y::ys)
                               | x -> y :: merge (x::xs) ys
