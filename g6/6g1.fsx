/// <summary> Herunder laves funktionen floatfrac2, som tager et reelt tal i form af en float og omdanner denne til en int liste som udgør en fortsat brøk </summary>
///<example>
/// Følgende kode:
/// <code>
/// printfn "%A" (floatfrac2 (3.245))
/// </code>
/// vil printe <c>[3; 4; 12; 4]</c> ud til terminalen.
/// </example>
/// <param name="x">Dette er en float, som udgår det reelle tal </param>
/// <returns> En int liste som udgør den fortsatte brøk </returns>
let rec floatfrac2 ( x: float) :int list =
    let q = floor x
    let invR = 1. /(x-q)
    if  x-q =0.   then
        [(int( q))]
    elif invR - floor(invR) > 0.99999999999 then
         int (q) :: floatfrac2 (ceil invR)
    else
        int  (q) :: (floatfrac2 invR)
        
printfn "%A" (floatfrac2 (3.245))
