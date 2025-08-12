namespace CodingChallenges.Starter.Duplicate;
public class ContainsDuplicateSolutionOriginal
{
    public static bool ContainsDuplicate(int[] nums) {
        HashSet<int> hashNums = new HashSet<int>();

        foreach(int num in nums)
        {
            if(hashNums.Contains(num))
            {
                return true;
            }

            hashNums.Add(num);
        }

        return false;
    }
}

