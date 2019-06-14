namespace Tests

open NUnit.Framework
open SudokuGenerator

[<TestClass>]
type TestClass () =

    [<SetUp>]
    member this.Setup () =
        ()

    [<Test>]
    member this.ReturnsTrueIfDigitExistsInColumn () =
        
        Assert.Pass()
