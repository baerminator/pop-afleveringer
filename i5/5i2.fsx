/// <summary> Her laves 5i.2. Denne koder tager en liste af floats. Den returnerer derefter None hvis listen er tom ellers bruger den list. fold og list. length til at returnere gennemsnittet </summary>
/// <returns> Den returnerer en værdi som enten er None ellers returnerer den gennemsnittet af listens elemter som en float </returns>
/// <param name="n"> Dette er den givne, som er defineret som en liste af floats </param>
let gennemsnit( n: float list) =
     if (List.isEmpty n) then None
     else Some ( (List.fold ( fun  acc x -> acc + x) 0. n ) / float(n.Length))
let b = [ 6. ; 9. ; 3.]
let a = []
printfn "%A\n%A" (gennemsnit b) (gennemsnit a)
