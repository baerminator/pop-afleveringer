///Forfatter: Bjørn Møller,Hold: 9, Opgave: 9i1
/// <summary> Herunder er funktionen Filereplace som modtager en tre strenge, filnavnet, det eftersøgte ord og erstatningen af denne. Koden åbner først en datastrøm som kan læses, hvorefter den gemmer hele strengen. Tilsidst overskriver den filen, med en tom fil, hvor der indføres indholdet efter alle substrenge er blevet erstattet med den nye substreng. Bemærk, at man i opgave beskrivelse skulle bruge read og ikke readtoend, men jeg har valgt at bruge den anden metode, da den fylder mindre.</summary>
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
  
/// Der er vedlagt en tekst fil til afprøvning af min kode 
FileReplace "test9i1.txt" "dums" "bums"
