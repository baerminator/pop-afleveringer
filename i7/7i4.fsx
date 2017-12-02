//Lavet af Bjørn Møller
/// <summary> min3 er en simpel hjælpefunktion, som gør funktionen leven pænere at se på da den laver to min om til min 3, hvilket kan gøres pga af loven om transativitet </summary>
let min3 (a: int) (b: int) (c: int) = min (min a b) c
/// <summary> For Det første skal der bemærkes at jeg har skrevet om på leven funktionen, for at den fungerer optimalt sammen med leven_cache. Funktionen leven_cache kontrollerer om der er et resultat i matricen og returnerer denne, ellers kører den rekursivt tilbage til næste led indtil den finder et svar. </summary>
/// <param name="a , b "> Dette er er de to strenge som skal sammenlignes </param>
/// <returns> en int , som fortæller, hvor stor forskellen er mellem to strenge </returns>
let leven_full (a: string) (b: string)  =
    let cache = Array2D.create (String.length a) (String.length b) -1
    let rec leven x y =
        match x with
        | 0 -> y
        | x when y = 0 -> x
        | x -> 
            min3 
                 ((leven_cache x (y - 1)) + 1)
                 ((leven_cache (x - 1) y) + 1)
                 (leven_cache (x - 1) (y - 1)
                  + if b.[y] = a.[x] then 0 else 1)

    and leven_cache (x: int) (y: int): int =
        let result = cache.[x,y]
        match result with
        |  -1 -> cache.[x,y] <- leven x y
                 cache.[x,y]
        | result -> result        

    leven (String.length a - 1)  (String.length b - 1)
printfn "\n%A" ( leven_full "hey Frederik" "Godkend lige min opgave")
