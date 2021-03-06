﻿[<AutoOpen>]
module internal FSharpApiSearch.OptionModule

type OptionBuilder() =
  member this.Bind(x, f) = Option.bind f x
  member this.Return(x) = Some x
  member this.ReturnFrom(x) = x

let option = OptionBuilder()