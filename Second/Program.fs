open System

open Exam2_2122
open Checker

let checkboard (size : int) = ""

let map2 (f : 'a -> 'b -> 'c) (list1 : List<'a>) (list2 : List<'b>) : Option<List<'c>> = None

let flatten (nestedList :  List<NestedListElement<'a>>) : List<'a> = []

let minBy (projection : 'a -> 'b) (list : List<'a>) : Option<'b> = None

let mapGraph (f : 'a -> 'a1) (graph: Graph<'a,'b>) : Graph<'a1,'b> = Graph.Create([])
    



[<EntryPoint>]
let main argv =
   try
     let testedExercises =
       {
         Exercise1 = checkboard
         Exercise2 = map2
         Exercise3 = flatten
         Exercise4 = minBy
         Exercise5 = mapGraph
       }
     printfn "%s" (validate testedExercises)
     0
   with
   | CheckerException msg -> 
       printfn "%s" msg
       1
   | :? Exception as e ->
       printfn "EXCEPTION: %s \nSTACK TRACE: %s" e.Message e.StackTrace
       1