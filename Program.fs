open System
let timeNow () = DateTime.Now.ToLongTimeString()

printfn $"The time now is %s{timeNow()}"