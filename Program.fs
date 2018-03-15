open MathOperations
open Birthday

printfn "The sum of 34 and 122 is: %i" (addition(34, 122))
printfn "The rest of 450 and 35 is: %i" (substraction(450, 35))
printfn "The multiplication of your numbers is: %i" (multiplication(12, 6))
printfn "The result of your division is: %i" (division(200, 4))
printfn "The total that each should pay is: %i" (average[50; 100; 250; 100])

printfn "My birthday is: %s" (birthday(30, 03, 1986))