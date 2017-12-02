/// <summary> Herunder laves funktionen frac2cfrac, som tager to integers som repræsenterer tæller og nævner og returnerer en int liste som repræsenterer en fortsat brøk </summary>
///<example>
/// Følgende kode:
/// <code>
/// printfn "%A" (frac2cfrac 649 200)
/// </code>
/// vil printe <c>[3; 4; 12; 4]</c> ud til terminalen.
/// </example>
/// <param name="t">en integer, som repræsenterer tælleren i brøken </param>
/// <param name="n">en integer, som repræsenterer nævneren i brøken</param>
/// <returns> En int liste som udgør den fortsatte brøk </returns>


let rec frac2cfrac (t:int) (n:int) : int list =
    let q = t / n
    let r = t % n
    if r = 0 then
        [q]
    else
        q :: (frac2cfrac n r)
printfn "%A" (frac2cfrac 649 200)




