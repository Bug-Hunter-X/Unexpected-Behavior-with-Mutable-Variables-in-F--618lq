# Unexpected Behavior with Mutable Variables in F#

This example demonstrates a common pitfall in F# when working with mutable variables.  Due to F#'s default pass-by-reference behavior for mutable values, modifying a variable within a function unexpectedly modifies the original variable outside the function.

The `bug.fs` file contains code exhibiting this issue. The `bugSolution.fs` file presents a solution using immutability to avoid this problem.

This repository serves as a concise illustration and solution for this specific issue.