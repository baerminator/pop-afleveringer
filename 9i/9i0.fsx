///Forfatter: Bjørn Møller,Hold: 9, Opgave: 9i0
/// <summary> Herunder er safeindexif lavet med tilhørende test af om denne fungerer med fejl og uden fejl  </summary>
let safeIndexIf (arr: int array) (int: int) =
    if int <= arr.Length - 1 then
        arr.[int]
    else
        System.Int32.MaxValue

printfn "vi tester om SafeIndexif virker uden fejl : %A og med fejl: %A "
 (safeIndexIf [| 1;2;3|]  1) (safeIndexIf [| 1;2;3|]  4) 
/// <summary> Herunder er safeindexOption lavet med tilhørende test af om denne fungerer med fejl og uden fejl  </summary>
let safeIndexOption (arr: int array) (int: int) =
    try
        Some arr.[int]
    with
      | _ -> None
printfn "vi tester om SafeIndexif virker uden fejl : %A og med fejl: %A "
 (safeIndexOption [| 1;2;3|]  1) (safeIndexOption [| 1;2;3|]  4) 

/// <summary> Herunder er safeindexWith lavet med tilhørende test af om denne fungerer med fejl og uden fejl  </summary>
let safeIndexWith (arr: int array) (int: int) =
    try
        arr.[int]
    with
     | ex -> failwith "fejl!!!"
    
printfn "vi tester om SafeIndexif virker uden fejl: %A "
 (safeIndexWith [| 1;2;3|]  1) 
printfn "vi tester om SafeIndexif virker med fejl: %A "
 (safeIndexWith [| 1;2;3|]  4)

