module Test

open Xunit
open Library

[<Fact>]
let ``Library convetrs "Banana" correctly``() =
  let expected = """I used to be Banana but now I'm "Banana"!"""
  let actual = getJsonNetJson "Banana"
  Assert.Equal(expected, actual)
