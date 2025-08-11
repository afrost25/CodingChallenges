# Pangram

Determine if the sentence contains every letter in the alphabet

## Initial Approach
My initial thought is to create a hashset again and determine if there are 26 keys in the set corresponding to each
character in the alphabet. The tricky part will be to filter out special characters.

I wanted to do something with regex or some ASCII manipulation, but I do not know this on top of my head...
I will try another approach. Maybe initialize a dictionary or hashtable where each character maps out to an entry
with a counter. We will need to iterate through the counter at the end though to ensure there is at least one of each 
character.

I feel there is a better solution, but this solution has complexities of:

**Space** O(1)

**Time** O(n)

## Grokk Solutions
I learned about the various character functions in C#, this would've come in handy when I was working through that 
problem originally. The 26 character check makes sense, and I was wanting to do something similar, but I didn't know of 
a clean way to handle the special characters.