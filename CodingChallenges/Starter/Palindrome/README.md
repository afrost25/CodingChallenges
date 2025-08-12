# Palindrome
Given a sentence, determine if the sentence is a palindrome excluding special characters and ignoring case.

# Initial Approach
The problem looks like another two pointer problem, so I created a left pointer set it to zero and a right pointer
and set it to the length of the sentence minus one. 

Afterwards, I iterated through the string such that the left pointer moved left one and the right pointer moved right
by one as well. We continuously check if the left and right pointer overlap and we skip over non-alphanumeric
characters. We compare the two characters that left and right land on within the string. If they are the same, continue
otherwise we return early with the value of false.

**Space**: O(1)
**Time**: O(n)


# Actual Solution
The solution given was similar to my approach.