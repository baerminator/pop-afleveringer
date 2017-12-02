/// <summary> Herunder laves funktionen cfrac2float, som tager en liste af fortsatte brøker og returnerer en reel værdi med alle decimaler    </summary>
///<example>
/// Følgende kode:
/// <code>
/// printfn "\n%f" (cfrac2float [3;4;12;4]) 
/// </code>
/// vil printe <c>3.245000</c> ud til terminalen.
/// </example>
/// <param name="Lst">en liste af integers som sammen udgør en fortsat brøk </param>
/// <returns> det reelle tal, i form af en float  </returns>
let rec cfrac2float (lst: int list) :float  =
   if
       lst.Length = 1 then float (lst.Head)
   else
       float (lst.Head) + 1. / (cfrac2float (lst.Tail))
printfn "\n%f" (cfrac2float [3;4;12;4])
