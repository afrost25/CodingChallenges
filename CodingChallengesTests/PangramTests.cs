using CodingChallenges.Starter.Palindrome;

namespace CodingChallengesTests;

public class PangramTests
{
    
    [Test]
    public void DetectsPalindromeCorrectly()
    {
        string palidrome = "Eevee";
        bool isPalindrome = PalindromeSolutionOriginal.IsPalindrome(palidrome);
        Assert.That(isPalindrome, Is.True);
    }

    [Test]
    public void DetectsNonPalidromeCorrectly()
    {
        string palidrome = "HelloWorld";
        bool isPalindrome = PalindromeSolutionOriginal.IsPalindrome(palidrome);
        Assert.That(isPalindrome, Is.False);
    }

    [Test]
    public void DetectsEmptyStringCorrectly()
    {
        string palidrome = "";
        bool isPalindrome = PalindromeSolutionOriginal.IsPalindrome(palidrome);
        Assert.That(isPalindrome, Is.True);
    }

    [Test]
    public void DetectsPalindromeWithSpecialCharactersCorrectly()
    {
        string palidrome = "I Am, Ma i";
        bool isPalindrome = PalindromeSolutionOriginal.IsPalindrome(palidrome);
        Assert.That(isPalindrome, Is.True);
    }
}