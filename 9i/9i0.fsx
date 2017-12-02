/// <summary> Herunder er de tre funktioner lavet  </summary>
let safeIndexIf (arr: int array) (int: int) =
    if int <= arr.Length - 1 then
      printfn "%A"  arr.[int]
safeIndexIf [| 1;2;3|]  1

let safeIndexWith (arr: int array) (int: int) =
    try
        arr.[int]
    with
     | ex -> failwith "fejl!!!"
    
//printfn "%A" (safeIndexWith [| 1;2;3|]  4)

let safeIndexOption (arr: int array) (int: int) =
    try
        Some arr.[int]
    with
      | _ -> None
printfn "%A" (safeIndexOption [| 1;2;3|]  2)
