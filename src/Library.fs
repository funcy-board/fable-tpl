namespace FableApp

module Say =
    let hello name =
        printfn "Hello! %s" name

    [<EntryPoint>]
    let main args = 
        hello "Fable"
        0