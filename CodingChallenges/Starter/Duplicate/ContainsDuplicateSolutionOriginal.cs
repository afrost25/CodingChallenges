namespace GrokkingCodingInterviewSolutions.Warmup.ContainsDuplicate
{
    public class ContainsDuplicateSolutionOriginal
    {
        public bool ContainsDuplicate(int[] nums) {
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
}

