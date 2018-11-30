﻿module Tests.Configuration.ApplySettings

open NBomber.Contracts
open NBomber.FSharp

open FsCheck
open FsCheck.Xunit

[<Property>]
let ``apply scenario settings ``(xs:int) =
    let scenario = Scenario.create("simple test", [])    
    true

    