namespace CodingChallenges.Starter.ReverseVowels;

public class ReverseVowelSolutionOriginal
{
    static readonly string vowels = "aeiouAEIOU";

    public string reverseVowels(string s) {
        int leftPointer = 0;
        int rightPointer = s.Length - 1;

        char[] copySent = s.ToCharArray();
        
        while (leftPointer < rightPointer)
        {
            while (leftPointer < rightPointer && vowels.Contains(s[leftPointer]) == false)
            {
                leftPointer++;
            }

            while (leftPointer < rightPointer && vowels.Contains(s[rightPointer]) == false)
            {
                rightPointer--;
            }
            
            char temp = s[leftPointer];
            copySent[leftPointer] = copySent[rightPointer];
            copySent[rightPointer] = temp;

            leftPointer++;
            rightPointer--;
        }
        
        return new string(copySent);
    }
}