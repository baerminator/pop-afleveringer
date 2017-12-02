
module vec2d
val len     : float -> float -> float

val ang     : float -> float -> float

val scale   : float -> float -> float -> float

val add     : float -> float -> float -> float -> float * float 

val dot : float -> float -> float -> float -> float                 
/// som en general regel vil kode med en tuple af to værdier ligne en to afskilde værdier meget,
/// da en tuple essientielt set er en samling af værdier. Det vil sige at i koden for Len, Ang, Scale, og Dot, skal man bare 
/// ændre tuplerne med to floats om til to floats, såaledes: fra float*float til float -> float. Der er dog et problem med funktionen 
/// add og det er, at en funktion kan ikke have mere en 1 output, derfor giver omskrivningen fra tuple til floats ikke mening.
