let rec floatfrac2 ( x: float) :int list =
    let q = floor x
    let invR = 1. /(x-q)
    if  x-q =0.   then
        [(int( q))]
    elif invR - floor(invR) > 0.99999999999 then
         int (q) :: floatfrac2 (ceil invR)
    else
        int  (q) :: (floatfrac2 invR)
let rec frac2cfrac (t:int) (n:int) : int list =
    let q = t / n
    let r = t % n
    if r = 0 then
        [q]
    else
        q :: (frac2cfrac n r)
let rec cfrac2float (lst: int list) :float  =
   if
       lst.Length = 1 then float (lst.Head)
   else
       float (lst.Head) + 1. / (cfrac2float (lst.Tail))
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



/// Her testes funktionen 'cfrac2frac'
/// Vi tester 'cfrac2frac' ved simpelt basistilfælde
printfn "er cfrac2frac ved [3;4;12;4] 3) = (649, 200) :  %A" ((cfrac2frac [3;4;12;4] 3) =  (649, 200) )
/// Vi tester 'cfrac2frac' ved to identiske tal
printfn "er cfrac2frac ved (19,19) =  0.7853981634 :  %A" ((cfrac2frac [4;4;12;12] 3)=  (2513, 592)  )
/// Vi tester 'cfrac2frac' ved forskellige tal 
printfn "er cfrac2frac ved (375,15) = 1.53081764 :  %A" ((cfrac2frac [3;4;12;4] 3) =  375. 15. )
/// Vi tester 'cfrac2frac' ved fejl
printfn "er cfrac2frac ved (375,15) = 1 :  %A" ((cfrac2frac [3;4;12;4] 3) = 1. )