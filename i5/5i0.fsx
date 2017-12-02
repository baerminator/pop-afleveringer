/// <summary> Her laves 5i.0a. Denne koder tager en liste af lister som indeholder integers. Den antager at tabellen er perfekt og undersøger, derefter om der er mangler for en fuld tabel </summary>
/// <remarks>Det kan bemærkes, at der måske kunne være lavet en hurtigere kode igennem en foldback mekanisme </remarks>
/// <returns> Denne funktion returnere en boolsk værdi som fortæller om tabellen opfylder de ønskede kriterier  </returns>
/// <param name="n"> Dette er den givne, som er defineret som en liste af lister </param>
/// <param name="x">Dette er parameteren, som bestemmer om der bliver returneret true eller false. Den starter med værdien true </param>
let isTable( n: int list list ) =
    let j = (n.Head.Length) 
    let k = n.Length - 1
    let mutable  x  =  true
    
    if n.[0].IsEmpty then x <- false
    for i = 0 to k do
     if( n.[i].Length <> j )
      then x <- false
    x

let a = [ [1;2;3]; [4;5;4]; [7;8;9]]
printfn "%A" (isTable a)

/// <summary> Her laves 5i.0b. Denne koder tager en liste af lister som indeholder integers. Den bruger derefter  liste funktionen .Head til at trække første element ud af hver underliste. Den bruger foldback, da det giver den eftertragtede rækkefølge </summary>
/// <remarks> Det skal bemærkes, at der bruges foldback, da funktionen :: sætter elementet foran tabellen , hvilket betyder, at en normal Fold returnerer en tabel i forkert rækkefølge </remarks>
/// <returns> Denne funktion returnerer en liste af integers  </returns>
/// <param name="n"> Dette er den givne, som er defineret som en liste af lister </param>
/// <param name="x"> Dette element bliver brugt til at indføre en tom liste' </param>

let firstColumn ( n:int list list ) =
    List.foldBack ( fun   ( n:int list) x  -> n.Head::x )  n []
printfn "%A" (firstColumn a)




/// <summary> Her laves 5i.0c. Denne koder tager en liste af lister som indeholder integers. Den bruger derefter  liste funktionen .Tail til at trække alle  pånær  første element ud af hver underliste. Den bruger foldback, da det giver den eftertragtede rækkefølge </summary>
/// <remarks> Det skal bemærkes, at der bruges foldback, da funktionen :: sætter elementet foran tabellen , hvilket betyder, at en normal Fold returnerer en tabel i forkert rækkefølge </remarks>
/// <returns> Denne funktion returnerer en liste af lister med integers  </returns>
/// <param name="n"> Dette er den givne, som er defineret som en liste af lister </param>
/// <param name="x"> Dette element bliver brugt til at indføre en tom liste' </param>

let dropFirstColumn ( n:int list list ) =
    List.foldBack (fun  (n:int list) x -> n.Tail::x ) n  []
printfn "%A" (dropFirstColumn a)


/// <summary> Her laves 5i.0d. Denne koder tager en liste af lister som indeholder integers. Den bruger derefter de to nye funktioner dropfirstcolumn og firstcolumn til at transponere matricen </summary>
/// <remarks> Det skal bemærkes, at denne kun vil fungere på en defineret matrice. Desuden bruges der list reverse til sidst for at sørge for at matricen er i rigtig rækkefølge </remarks>
/// <returns> Denne funktion returnerer den modtagne matrice, blot transponeret </returns>
/// <param name="n"> Dette er den givne, som er defineret som en liste af lister </param>
/// <param name="x"> Dette element bliver brugt til langsomt at fjerne listens elementer' </param>
/// <param name=j"> Dette element bliver brugt til at opbevare og returnere den transponerede matrice </param>
let transpose (n: int list list ) =
    let mutable x =  n
    let mutable j = []
    let laengde = ((x.Head.Length)-1)
    for i = 0 to laengde  do
        j <- (firstColumn x) ::j 
        x <- dropFirstColumn x
    List.rev j 
printfn "%A\n%A"  (transpose a) a

