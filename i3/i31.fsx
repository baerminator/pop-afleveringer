// Her laves opgave a
printfn "Opgave 1 "
let multable j  = (
 let mutable str = sprintf "%4s " (" ")
 for n = 1 to 10 do
  str <- str + sprintf "%4i" n 
 str <- sprintf  "%4s" str

 for n = 1 to 10 do
  str <- sprintf "%s\n %4i" str (n)
  for y = 1 to 10 do
   let k = sprintf "%4i" (n * y)
   str <- str  + k
 let b = j*46+44 
 sprintf "%s" str.[0..b]    
)
printf "%s"  (multable 9) 
printfn ""
printfn ""


// her laves opgave b
printfn "Opgave 2 "
let Loopmultable a = (
 let mutable str = sprintf "%4s "(" ")
 for n = 1 to 10 do
  str <- str + sprintf "%4i" n 
 str <- sprintf  "%4s" str

 for n = 1 to a do
  str <- sprintf "%s\n %4i" str (n)
  for y = 1 to 10 do
   let k = sprintf "%4i" (n * y)
   str <- str  + k        
 str 
)

printf "%s" ( Loopmultable 10 )
printfn ""
printfn ""
// Her laves opgave c
printfn "Opgave 3 "
let test n = (
    (Loopmultable n) = (multable n)
)
printfn "n test(n) "
for n = 1 to 10 do
 printfn "%A %A"n (test n)

printfn ""
printfn ""
// Her laves opgave d
printfn "Opgave 4 "
printf "%A" (multable 10)
printfn ""
printfn ""
printf "%s" (multable 10)
printfn "" 
