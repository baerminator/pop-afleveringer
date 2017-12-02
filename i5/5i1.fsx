/// <summary> Her laves 5i.1. Denne koder tager en liste af integers. Den bruger derefter funktionen list.Collect til at have samme funktion som concat har </summary>
/// <returns> Denne funktion returnerer en liste med alle værdier fra den givne listes  </returns>
/// <param name="n"> Dette er den givne, som er defineret som en liste af integers </param>
let concat n:int  list  =
 List.collect ( fun x -> x) n
let a = [[3;3;1;];[3;3;1] ;[7;8;9]]
printfn "%A" (concat a)
