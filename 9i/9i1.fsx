///Forfatter: Bjørn Møller,Hold: 9, Opgave: 9i1
/// <summary> Herunder er funktionen Filereplace som modtager en tre strenge, filnavnet, det eftersøgte ord og erstatningen af denne</summary>
let FileReplace filename (needle: string) (replace: string) =
    let (reader: System.IO.StreamReader) =
        try
            System.IO.File.OpenText filename
        with
            _ -> failwith " forkert filnavn"
    let data = reader.ReadToEnd()
    let output = data.Replace (needle, replace)
    reader.Close()
    let (skriver: System.IO.StreamWriter) =
        System.IO.File.CreateText filename
    skriver.Write output
    skriver.Close()
  

FileReplace "test9i1.txt" "dums" "bums"
