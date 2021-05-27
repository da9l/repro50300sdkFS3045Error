open System
open FSharp.Data


type Sample = XmlProvider<Schema="Sample.xsd",
                          ResolutionFolder=__SOURCE_DIRECTORY__>
// type Camt053 = XmlProvider<Schema           = "camt.053.001.02.xsd", 
// ResolutionFolder = srcDir>


// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    0 // return an integer exit code