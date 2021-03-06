#r "img_util.dll"

type point = int * int
type colour = int * int * int

type figure =
    | Circle of point * int *  colour
    | Rectangle of point * point * colour
    | Mix of figure * figure
    | Triangle of point * point * point * colour

// Herfra laves opgave 8g1, hvis primære opgave er blot at definere selve figuren:
let gray = ImgUtil.fromRgb (128,128,128)

let circ = Circle ((70,20), 10 , ( (255,255,0)))
let rectangle = Rectangle ( ( 20 , 70 ), ( 80 , 120 ),  (255,0,0) )
let triangle = Triangle (( 15 , 80 ), ( 45 , 30 ), ( 85 , 70 ),  (0,0,255) )
let figure = Mix (Mix ( circ , rectangle ) , triangle)    
  
// Herfra laves opgave 8g2,
let triarea2ekstra (fig: figure) =
    match fig with
        | Triangle ((x1,y1),(x2,y2),(x3,y3),col) ->
            Some (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) 
        | _ -> None
// Den ovenstående er teknisk set forkert, da den kun modtager figuren. NedenStående er korrekt

let triarea2 (x1,y1) (x2,y2) (x3,y3) = abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2))
printfn "%A" (triarea2( 15 , 80 ) ( 45 , 30 ) ( 85 , 70 ))
printfn "%A" (triarea2( 90 , 90 ) ( 45 , 30 ) ( 85 , 70 ))
printfn "%A" (triarea2( 15 , 80 ) ( 90 , 90 ) ( 85 , 70 ))
printfn "%A" (triarea2( 15 , 80 ) ( 45 , 30 ) ( 90 , 90 ))
// herunder laves opgave 8g3
let rec colourAt (x,y) figure =
    match figure with
        | Circle ((cx,cy),r,col) ->
            if (x-cx)*(x- cx )+( y - cy )*( y - cy ) <= r*r
// uses Pythagoras ' formular to determine
// distance to center
            then Some col else None
        | Rectangle (( x0 , y0 ) , ( x1 , y1 ) , col ) ->
            if x0 <= x && x <= x1 && y0 <= y && y <= y1
// within corners
            then Some col else None
        | Triangle ((x1,y1),(x2,y2),(x3,y3),col) ->
            if triarea2 (x1,y1) (x2,y2) (x3,y3) = triarea2 (x,y) (x2,y2) (x3,y3) + (triarea2 (x1,y1) (x,y) (x3,y3)) + (triarea2 (x1,y1) (x2,y2) (x,y))
            then Some col else None
        | Mix ( f1 , f2 ) ->
            match ( colourAt (x , y ) f1 , colourAt (x , y ) f2 ) with
                | ( None , c ) -> c // no overlap
                | (c , None ) -> c // no overlap
                | ( Some ( r1 , g1 , b1 ) , Some ( r2 , g2 , b2 ) ) ->
// average color
                    Some (( r1 + r2 ) /2 , ( g1 + g2 ) /2 , ( b1 + b2 ) /2)





let makePicture (navn: string) (figurform: figure)  (x, y) =
    let bitmap = ImgUtil.mk  x y // her laves der selve canvas
    for i = 0 to x - 1 do
        for j = 0 to y - 1 do
            match (colourAt (i,j) figurform) with
             | Some farve  ->  ImgUtil.setPixel (ImgUtil.fromRgb farve ) ( i,j) bitmap
             | None -> ImgUtil.setPixel gray ( i,j) bitmap
    do ImgUtil.toPngFile navn bitmap  // laves laves canvas om til et bitmap

do makePicture  "fisk" figure   (100, 150)

let falseCol (x:colour): bool =
    let (c1 , c2 , c3) = x
    if  c1 > 255 || c1 < 0
     || c2 > 255 || c2 < 0
     || c3 > 255 || c3 < 0 then true else false

let rec  checkfigure ( figur: figure ): bool =
    match figur with
        | Circle ((cx,cy),r,col) ->
            if r < 0 || falseCol col then false else true
        | Rectangle (( x0,y0),(x1,y1),col) ->
            if x1 <= x0 || y1 <= y0 || falseCol col  then false else true
        | Triangle ((x1,y1),(x2,y2),(x3,y3),col) ->
            if falseCol col then false else true
        | Mix (f1,f2) ->
            if checkfigure f1 && checkfigure f2 then true else false
do printfn "\n%A"  (checkfigure figure)

let min3 a b c = min a ( min b c )
let max3 a b c = max a ( max b c )
let rec boundingbox (fig: figure): point*point =
    match fig with
    | Circle (( cx, cy), r, col) -> ((cx - r , cy - r) , (cx + r, cy + r))  
    | Rectangle ((x0 , y0) , (x1, y1), col) -> ((x0 , y0) , (x1, y1))
    | Triangle ((x1,y1),(x2,y2),(x3,y3),col) ->
      ((min3 x1 x2 x3 , min3 y1 y2 y3) , (max3 x1 x2 x3 , max3 y1 y2 y3)) 
    | Mix (f1,f2) ->
     let  ((x0 , y0) , (x1, y1)) = ( boundingbox f1)
     let  ((nx0 ,ny0) , (nx1, ny1)) = (boundingbox f2)
     ((min x0 nx0, min y0 ny0) , (max x1 nx1, max y1  ny1))

printfn "%A" (boundingbox figure)
do makePicture  "navn" figure  (snd(boundingbox figure)) 
