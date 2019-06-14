module SudokuGenerator

// Learn more about F# at http://fsharp.org
    open System
    open System.Threading

    module Board =
        let gridSideLength = 3
        let grid =
            Array2D.zeroCreate<int> gridSideLength gridSideLength

        grid.[1,1] <- 1

    module Search =
        open Board

        let searchColForDigit digit col =
            let columnRange = grid.[0..gridSideLength - 1, col]
            columnRange |> Array.exists (fun cell -> cell = digit)

        let searchRowForDigit digit row =
            let rowRange = grid.[row, 0..gridSideLength - 1]
            rowRange |> Array.exists (fun cell -> cell = digit)


    [<EntryPoint>]
    let main argv =
        open SudokuGenerator

        printfn "%A" grid

        let exists = searchColForDigit 1 1


        printfn "%A" exists

        0