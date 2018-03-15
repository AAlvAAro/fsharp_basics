module Birthday

// Marh 30, 1986
let birthday(day, month, year) =
    let months = ["Jan"; "Feb"; "Mar"; "Apr"; "May"; "Jun";
                 "Jul"; "Aug"; "Sep"; "Oct"; "Nov"; "Dec";]
    let month_text = List.nth months (month - 1)
    sprintf "%s %i, %i" month_text day year