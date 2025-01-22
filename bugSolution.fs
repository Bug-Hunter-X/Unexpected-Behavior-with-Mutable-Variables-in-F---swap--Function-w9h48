let x = 10
let y = 20

let swap x y =
    let temp = x
    let x = y
    let y = temp
    (x, y)

let (x', y') = swap x y
printf "%d %d" x' y'