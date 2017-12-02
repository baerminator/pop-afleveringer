//Lavet af Bjørn Møller
/// <summary> Herunder laves funktionen alle funktionerne som skal bruges til at lave en interaktiv funktion, der laver en X fractal </summary>
open ImgUtil

/// <summary> Her laves funktionen form, som bestemmer, hvad der bliver printet på bitmappet lavet i Draw funktionen. Den tegner en kasse så længe len er under 200 , ellers kalder den sig selv rekursivt 5 gange med forskellige koordinater</summary>
/// <param name="len">Dette er en integer, som bestemmer størrelsen af de tegnede firkanter </param>
/// <returns> Den returnerer en aftegning af X fractal på et bitmap </returns>

let rec form bmp len (x , y) =
    if len < 200 then setBox red (x , y) (x + len, y + len) bmp
    else let half = len / 3
         do form bmp half (x, y)
         do form bmp half (x + half * 2, y)
         do form bmp half (x, y + half * 2)
         do form bmp half (x + half * 2, y + half * 2)
         do form bmp half (x + half, y + half)

/// <summary> Draw funktionen konstruerer et bitmap ved at kalde funktionen ImgUtils.Mk med værdierne 800, hvilket er størrelsen på bitmap. Den kalder derefter funktionen form til at tegne X Fractalen  </summary>
/// <param name="x"> dette er en variabel som indeholder bitmappet </param>
/// <returns> returnerer et påtegnet bitmap </returns>
         
let rec  Draw h l state =
   let x =  (ImgUtil.mk 800 800)
   form x state (30, 30)
   x
/// <summary> funktionen react modtager et tastetryk og bruger dette til at ændre state ,hvilket reelt betyder en ændring af størrelsen på fractalen  </summary>
/// <param name="tast"> Dette er en værdi, som indeholder selve den trykke tast og vil ændre staten ved up eller ned tasten </param>
/// <returns> en ny state værdi </returns>
   
let  react state (tast : System.Windows.Forms.KeyEventArgs) =  
 if tast.KeyCode = System.Windows.Forms.Keys.Up
    then Some (state + 1)
 elif  tast.KeyCode =    System.Windows.Forms.Keys.Down
    then Some (state - 1)
 else Some (state)

/// <summary> Herunder bruges funktionen runApp, fra biblioteket ImgUtils, og bruger de forskellige funktioner til at lave det ønskede vindue med den interaktive X fractal </summary>
do runApp " 7i.2 " 800 800 Draw  react 600
