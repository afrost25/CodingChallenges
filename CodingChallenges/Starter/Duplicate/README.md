# Duplicate Number
We are given a set of integers, we must determine if this set contains duplicate entries

## Initial Solution

I have some background experience with this, so my initial instinct was to use a hashset to determine if there was 
a duplicate since this is the most efficient way I know of to handle this type of problem.

Using the hashset solution, we have the following complexities:

**Space:** O(n) for the hashset itself

**Time:** O(n) for the loop as well


## Alternative Solution

There was another solution that was brought to my attention that was absolutely amazing. There is Floyd's Tortoise
and Hare implementation. This does however require that each element in the array is a value between 1 and n.
