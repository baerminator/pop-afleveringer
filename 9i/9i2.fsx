///Forfatter: Bjørn Møller,Hold: 9, Opgave: 9i2
/// <summary> Herunder er countLinks. Den modtager en hjemmeside, hvorefter den først laver en datastream fra Url, hvorefter den oversætter datastrømmen til en string fil og tilsidst bruges regex til at bestemme hvor mange gange udtrykket <a href forekommer. Bemærk at opgaven kun kræver <a, men jeg har valgt href da det giver et mere retvisende billede<summary>
open System.Text.RegularExpressions
let countLinks (url:string): int  =
    let url2stream url =
        let uri = System.Uri url
        let request = System.Net.WebRequest.Create uri
        let response = request.GetResponse ()
        response.GetResponseStream ()
    let readUrl url =
        let stream = url2stream url
        let reader = new System.IO.StreamReader (stream)
        reader.ReadToEnd ()
    let text = readUrl url
    Regex.Matches(text, Regex.Escape "<a href" ).Count
        
let webside = "https://www.dr.dk/" 
printfn "%A"(countLinks webside)
