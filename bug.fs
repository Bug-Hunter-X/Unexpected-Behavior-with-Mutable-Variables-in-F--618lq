let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20

//In F#, mutable variables are passed by reference by default. So, when we pass x and y to swap function, the original x and y variables will be modified inside the function. Therefore, the print statement will print 20 20 instead of 10 20.