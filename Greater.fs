module Greater

let greater(list) =
    let mutable bigger = 0
    let mutable n = 0
    
    for e in list do
        if e > bigger
        then bigger <- e
      
    bigger