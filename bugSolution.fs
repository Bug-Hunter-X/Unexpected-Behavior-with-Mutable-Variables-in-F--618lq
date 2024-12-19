let x = 10
let y = 20

let swap x y =
    let temp = x
    let y = y
    (y, temp)

let (x, y) = swap x y
printf "%d %d" x y //This will print 10 20

//Instead of using mutable variables, we can make the swap function return a tuple of x and y. This ensures that the original x and y variables are not modified.