open System

open Library

[<EntryPoint>]
let main argv =
    printfn "Nice command line arguments! Here is what JSON.NET has to say about them:"

    argv
    |> Array.map getJsonNetJson
    |> Array.iter (printfn "%s")

    0
