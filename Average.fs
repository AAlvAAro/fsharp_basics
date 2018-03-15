module Average

let average(list) = 
    let mutable sum = 0 
    let mutable n = 0
    
    for e in list do
        sum <- sum + e
        n <- n + 1
   
    sum / n 

