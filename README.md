# F# Mutable Variable Swap Bug

This example demonstrates an unexpected behavior when working with mutable variables in F#. The `swap` function intends to swap the values of two mutable variables, but it modifies the original variables directly due to pass-by-reference semantics.

## Bug

The bug lies in the `swap` function.  Because `x` and `y` are passed by reference, the function's internal modifications directly affect the variables outside the function's scope.

## Solution

The solution involves creating copies of the input values within the `swap` function to avoid modifying the original variables.