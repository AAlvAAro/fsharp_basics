module MathOperations 

let addition(n1, n2) =
    n1 + n2

let substraction(a1, a2) =
    a1 - a2

let multiplication(a1, a2) =
    a1 * a2
    
let division(n1, n2) =
    n1 / n2
    
let average(list) = 
    let mutable sum = 0 
    let mutable n = 0
    
    for e in list do
        sum <- sum + e
        n <- n + 1   
    sum / n 