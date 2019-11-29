# TwoSumProblem
"You're given an array of integers. Write a function that returns a pair of numbers such that they sum up to some number x.  You can assume there will be exactly 1 solution."

For the Two Sum Problem, we must search through an array for two values whose sum is equal to an arbitrary value. First, I implemented a brute-forcing function that checks every single possible pair until it finds the correct solution. On average, the time complexity is O(n^2), as is the worst case. This solution is implemented using two for loops. However, to improve this solution, a HashMap may be used.

For a more optimal solution (if not, the optimal solution) a HashMap can be used to iterate the array only once. Start by inserting the first value in the array into the hashmap, then check if the current value's complement is in the hashmap. Since the operation is O(1) time, the average time for this function is only O(n), and is O(n) in the worst case, as well.
