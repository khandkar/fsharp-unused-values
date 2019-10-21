namespace Foo

module Main = begin
    let private unusedNumberPrivate =
        1

    let unusedNumber =
        1

    let unusedFunction unusedParameter =
        "UNUSED"

    [<EntryPoint>]
    let main _ =
        printfn "Hi"
        0
end
