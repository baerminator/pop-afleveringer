///White-box testing
printfn "\n Her starter whitebox testen"

/// Her testes funktionen 'len'
/// Vi tester 'len' ved et simpelt basistilfælde
printfn "er len (1,1) = sqrt(2): %A" (vec2d.len (1.,1.) = sqrt(2.))
/// Vi tester 'len' ved to identiske tal
printfn "er len (5,5) = sqrt(50): %A" (vec2d.len (5.,5.) = sqrt(50.))
/// Vi tester 'len' ved forskellige tal
printfn "er len (10,5) = sqrt(125): %A" (vec2d.len (10.,5.) = sqrt(125.))
/// Vi tester 'len' ved fejl
printfn "er len (10,5) = sqrt(125): %A" (vec2d.len (10.,5.) = 10.)


/// Her testes funktionen 'ang'
/// Vi tester 'ang' ved simpelt basistilfælde
printfn "er ang ved (1,1) =  0.7853981634 :  %A" (vec2d.ang (1.,1.) = atan2 1. 1. )
/// Vi tester 'ang' ved to identiske tal
printfn "er ang ved (19,19) =  0.7853981634 :  %A" (vec2d.ang (19.,19.) = atan2 19. 19.  )
/// Vi tester 'ang' ved forskellige tal 
printfn "er ang ved (375,15) = 1.53081764 :  %A" (vec2d.ang (375.,15.) = atan2 375. 15. )
/// Vi tester 'ang' ved fejl
printfn "er ang ved (375,15) = 1 :  %A" (vec2d.ang (375.,15.) = 1. )


/// Her testes funktionen 'scale'
/// Vi tester 'scale' basistilfælde
printfn "er scale ved 6 (1,1) = ( 6 ,6) :  %A"  (vec2d.scale 6. (1.,1.) = (6.,6.))
/// Vi tester 'scale' ved to identiske tal
printfn "er scale ved 10 (3,3) = (30 ,30) :  %A"  (vec2d.scale 10. (3.,3.) = (30.,30.))
/// Vi tester 'scale' ved to forskellige tal
printfn "er scale ved 10 (15,23) = ( 150 ,230) :  %A"  (vec2d.scale 10. (15.,23.) = (150.,230.))
/// Vi tester 'scale' ved fejl
printfn "er scale ved 10 (10,10) = ( 150 ,230) :  %A"  (vec2d.scale 10. (10.,10.) = (150.,230.))

/// Her testes funktionen 'add'
/// Vi tester 'add' ved basiseksempel                                              
printfn "er add ved(2,2) (3,3) = (5,5):  %A" (vec2d.add (2.,2.) (3.,3.)= (5. , 5.))
/// Vi tester 'add' ved identiske tupler
printfn "er add ved(3,3) (3,3) = (6,6):  %A" (vec2d.add (3.,3.) (3.,3.)= (6. , 6.))
/// Vi tester 'add' ved forskellige tupler
printfn "er add ved(20,21) (15,16) = (35,37):  %A" (vec2d.add (20.,21.) (15.,16.)= (35. , 37.))
/// Vi tester 'add' ved fejl
printfn "er add ved(20,21) (15,16) = (10,10):  %A" (vec2d.add (20.,21.) (15.,16.)= (10. , 10.))

/// Her testes funktionen 'dot' 
/// Vi tester 'dot' ved basistilfælde
printfn "er dot ved (2,2) og (3,3) = 12: %A" (vec2d.dot (2.,2.) (3.,3.)= 12.)
/// Vi tester 'dot' ved identiske tupler
printfn "er dot ved (2,2) og (2,2) = 8: %A" (vec2d.dot (2.,2.) (2.,2.)= 8.)
/// Vi tester 'dot' ved forskellige tupler
printfn "er dot ved (1,2) og (3,4) = 11: %A" (vec2d.dot (1.,2.) (3.,4.)= 11.)
/// Vi tester 'dot' ved fejl
printfn "er dot ved (2,2) og (3,3) =  5: %A" (vec2d.dot (2.,2.) (3.,3.) = 5.)
