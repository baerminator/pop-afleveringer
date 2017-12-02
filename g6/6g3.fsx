/// <summary> Herunder laves funktionen cfrac2frac, som tager en fortsat brøk og et index , og returnerer tæller og nævner i aproximationen af det reelle tal  </summary>
///<example>
/// Følgende kode:
/// <code>
/// printfn "%A" (cfrac2frac [3;4;12;4] 3)
/// </code>
/// vil printe <c>(649, 200)</c> ud til terminalen.
/// </example>
/// <param name="i">en integer, som repræsenterer indeks tallet, bemærk f# indexerer fra nul </param>
/// <param name="lst">en liste af integers som sammen udgør en fortsat brøk </param>
/// <returns> Funktionen returnerere t_i og n_i i en tuple som (t_i, n_i). </returns>

let cfrac2frac (lst: int list) (i: int): int * int  =
   let rec tfinder (lst: int list) i  =
       if  i < 0 then 1
       elif  i = 0 then lst.[0]
       else lst.[i] * (tfinder lst (i-1) ) + (tfinder lst ( i-2))
   let rec nfinder (lst: int list)  i  =
       if i = 0 then 1
       elif i < 0 then 0
       else lst.[i] * (nfinder lst (i-1) ) + (nfinder lst ( i-2))
   ((tfinder lst i) ,( nfinder lst i))

printfn "%A" (cfrac2frac [3;4;12;4] 3)
printfn "%A" (cfrac2frac [4;4;12;12] 3)

