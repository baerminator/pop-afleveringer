
type weekday = Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday


let numberToDay (x: int )  =
    match x with
        | 1 -> Some Monday
        | 2 -> Some Tuesday
        | 3 -> Some Wednesday
        | 4 -> Some Thursday
        | 5 -> Some Friday
        | 6 -> Some Saturday
        | 7 -> Some Sunday
        | _ -> None
for i = 1 to 8 do
    printfn "\n%A" (numberToDay i)

