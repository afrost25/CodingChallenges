using CodingChallenges.Starter.Duplicate;

namespace CodingChallengesTests;

public class Tests
{

    [Test]
    public void CorrectlyDetectsDuplicates()
    {
        int[] dupArr = { 1, 2, 3, 4, 6, 1 };
        bool hasDup = ContainsDuplicateSolutionOriginal.ContainsDuplicate(dupArr);
        Assert.That(hasDup, Is.True);
    }

    [Test]
    public void CorrectlyDeterminesNoDuplicates()
    {
        int[] dupArr = { 1, 2, 3, 4, 6 };
        bool hasDup = ContainsDuplicateSolutionOriginal.ContainsDuplicate(dupArr);
        Assert.That(hasDup, Is.False);
    }

    [Test]
    public void CorrectlyDetermineNoDuplicatesEmptyArray()
    {
        int[] dupArr = new int[0];
        bool hasDup = ContainsDuplicateSolutionOriginal.ContainsDuplicate(dupArr);
        Assert.That(hasDup, Is.False);
    }
}