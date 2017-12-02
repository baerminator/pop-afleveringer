// Her løses 4i.2
//A) Den efterspurgte pseudokode ses nedenfor
let polyLen (n:int) =
 let j = float n
 let (theta0:float) = 0.0
 let (theta:float)  = (2.0 * System.Math.PI)/j
 let punkt0 =vec2d.scale -1. (System.Math.Cos(theta0),System.Math.Sin(theta0))
 let punkt1 = (System.Math.Cos(theta),System.Math.Sin(theta))
 let afstand = vec2d.add punkt0 punkt1
 let len =   vec2d.len afstand
 let heleafstand = len* j
 heleafstand
// Vi har i ovenstående udnyttet, at der i en cirkel er lige lang afstand mellem hver punkt,
// hvilket gør, at man kan  finde den samlede længde ved at finde
// længden mellem to vilkårlige punkter og gange med antal punkter altså n 

for i = 0 to 10 do
 let  j = i * 10
 printfn "\n n = %4i ->  %A  hvor  radius 1 cirkel = %A , \n forskel er %A  " j (polyLen j) (System.Math.PI*2.) ((polyLen j)-(System.Math.PI*2.))
 printfn "--------------------------------"
// B) Vi kan fra ovenstående kode se, at når n -> uendelig går forskellen -> 0.
// Dette giver intuativt mening, da når antallet af punkter bliver uendeligt mange vil
// punkterne tilsidst fylde hele cirklens omkreds.
// Altså er hypotesen at når n -> uendelig går polylen -> pi * 2 
