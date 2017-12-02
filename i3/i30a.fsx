// I denne fil besvarer jeg opgave 3i.0
// her løses opgave 3i.0a
(
let sum n = (
 let mutable i = 1
 let mutable total = 0 
 while i <= n do
    total <- total + i
    i <- i + 1 
 total)
printfn "sum med n = %i  giver  %A" 3  (sum 3)
)
// her løses opgave 3i.0b
(
let smartsum n = (n*(n+1)/2 )
printfn "smartsum med n = %i giver  %A" 3  (smartsum 3) 
)

//her løses opgave 3i.0c

(
let sum n = (
 let mutable i = 1
 let mutable total = 0 
 while i <= n do
    total <- total + i
    i <- i + 1 
 total)

let smartsum n = (n*(n+1)/2 )
printfn "smartsum med n = %i giver  %A" 3  (smartsum 3) 

for n = 0 to 10 do
    printfn "%5i %5i %5i" n (sum n) (smartsum n)
    
)

//Her løses opgave 3i.0d
(
let sum n = (
 let mutable i = 1
 let mutable total = 0 
 while i <= n do
    total <- total + i
    i <- i + 1 
 total)

let smartsum n = (n*(n+1)/2 )
printfn "smartsum med n = %i giver  %A" 3  (smartsum 3) 

for n = 0 to 66500 do
    printfn "%5i %5i %5i" n (sum n) (smartsum n)
//svaret er altså n =  46340 
)
// Den bedste måde at øge n på er at få funktionen til at modtage floats således:
(
let sum (n: float) = (
 let mutable i = 1. 
 let mutable total = 0.  
 while i <= n do
    total <- total + i
    i <- i + 1.
 total)

let smartsum (n: float) = (n*(n+1.)/2. )
printfn "smartsum med n = %f giver  %A" 3.  (smartsum 3.) 

for n = 0 to 10   do
    let y = float(n)
    printfn "%5f %5f %5f" y (sum y) (smartsum y)
)

