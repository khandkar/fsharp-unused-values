namespace Foo

module Main = begin
    let unusedNumber =
        1

    let unusedFunction unusedParameter =
        "UNUSED"

    [<EntryPoint>]
    let main _ =
        printfn "Hi"
        0
end
