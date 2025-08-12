namespace CodingChallenges.Starter.Pangram
{
    public class PangramSolutionGrokkModified
    {
        public bool IsPangram(string sentence)
        {
            HashSet<char> pangram = new HashSet<char>();

            for (int i = 0; i < sentence.Length; i++)
            {
                //I learned that C# has char.ToLower method 
                char current = char.ToLower(sentence[i]);

                //I also learned the char.IsLetter is another method in char as well
                if (char.IsLetter(current))
                {
                    pangram.Add(current);
                }
            }
        
            //This makes sense. If there is less than 26, then we don't have one. I was really stuck with how to
            //handle special characters in C#
            return pangram.Count == 26;
        }
    }
}