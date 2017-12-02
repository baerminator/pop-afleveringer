//Lavet af Bjørn Møller
/// <summary> min3 er en simpel hjælpefunktion, som gør funktionen leven pænere at se på da den laver to min om til min 3, hvilket kan gøres pga af loven om transativitet </summary>
let min3 (a: int)  (b: int)  (c: int) = min (min a b ) c
/// <summary> Herunder laves funktionen leven, denne funktion undersøger forskellen mellem to strenge. Dette gøres ved at for hver rekursion ligger der en værdi på 1 til medmindre den ene streng er tom. Det eneste tilfælde hvor der ikke ligges noget til, er i de situationer hvor de to karakterer er identisk, hvilket bestemmes med en indikator funktion </summary>
/// <param name="a , b "> Dette er er de to strenge som skal sammenlignes </param>
/// <returns> en int , som fortæller, hvor stor forskellen er mellem to strenge </returns>

let rec leven (a: string) (b: string) = 
    match a with
        | string when a = "" -> String.length b
        | string when b = "" -> String.length a
        | string when a = b -> 0
        | string -> 
            let bn = b.[0 .. String.length b - 2]
            let an = a.[0 .. String.length a - 2]
            min3 
                 (leven a bn + 1)
                 (leven an b + 1)
                 (leven an bn + if b.[(String.length b - 1)] = a.[(String.length a - 1)] then 0 else 1)
             
            

printfn "%A" (leven "dangerous house" "danger horse")
