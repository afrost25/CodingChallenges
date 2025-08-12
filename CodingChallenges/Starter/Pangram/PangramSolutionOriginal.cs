namespace CodingChallenges.Starter.Pangram
{
    public class PangramSolutionOriginal {
        // Function to check if given sentence is pangram
        public bool IsPangram(string sentence) {
    
            Dictionary<string, int> pangrams = new Dictionary<string, int>()
            { 
                {"A", 0 }, {"B", 0 }, {"C", 0 }, {"D", 0 }, {"E", 0 }, {"F", 0 }, {"G", 0 }, {"H", 0 },
                {"I", 0 }, {"J", 0 }, {"K", 0 }, {"L", 0 }, {"M", 0 }, {"N", 0 }, {"O", 0 }, {"P", 0 },
                {"Q", 0 }, {"R", 0 }, {"S", 0 }, {"T", 0 }, {"U", 0 }, {"V", 0 }, {"W", 0 }, {"X", 0 }, 
                {"Y", 0 }, {"Z", 0 },
            };

            foreach(char c in sentence.ToCharArray())
            {
                string upperChar = c.ToString().ToUpper();
      
                if(pangrams.ContainsKey(upperChar))
                {
                    pangrams[upperChar] += 1;
                }
            }

            foreach(var entry in pangrams)
            {
                if(entry.Value == 0)
                    return false;
            }

            return true;
        }
    } 
}

