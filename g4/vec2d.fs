//Implementeringsfilen

// Denne fil implementerer den givne signatur fil vec2d.fsi 
module vec2d
let len (a,b) =sqrt(a ** 2. + b ** 2.)
let ang (a,b) = atan2 a b
let scale (x:float) (a,b) =( x * a , x * b )
let add (a:float,b:float) (c:float,d:float) = (a + c, b + d)
let dot (a:float,b:float) (c:float,d:float) = a * c + b * d
// Der kan bemærkes at funktionerne add , dot og scale bliver nødt til at type bestemmes
// da fsharp egen type genkendelse gør dem til int, hvilket ikke er tilfældet for de to funktioner
// len og ang , hvilket er fordi at der eksisterer variable eller funktioner som kun fungerer
// for floats i disse 
