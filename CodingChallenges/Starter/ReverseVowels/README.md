# Reverse Vowels

Given a word, reverse all the vowels within the word and return the resulting string.

## Initial Approach
My initial approach was to use two pointers. One pointer on the lefthand side, the other pointer on the righthand side.
We move both pointers further to the left and right until we reach a vowel. Once both pointers reach a vowel, we swap 
the letters to get a result. We keep going until we overlap.

**Space:** O(n) for the CharArray copy
**Time** O(n) iterating through the array on both ends

## Solution Approach
Great news, it turns out my approach was very similar to what Grokking had proposed too, which is great.