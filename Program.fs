open System
open Humanizer

let timeNow () = DateTime.Now.ToLongTimeString()

let currentWeek () = Globalization.ISOWeek.GetWeekOfYear(DateTime.Now).ToWords()

let currentMonth () =DateTime.Now.Month.ToWords()

let currentYear () = DateTime.Now.Year.ToWords()

let currentDay () = DateTime.Now.Day.ToWords()

printfn $"The time now is %s{timeNow()}."

printfn $"We are in the day %s{currentDay()} of the month %s{currentMonth()} of the year %s{currentYear()}."

printfn $">> %s{DateTime.Now.ToOrdinalWords()}"

printfn "Cheers."
