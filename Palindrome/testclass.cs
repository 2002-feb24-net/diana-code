using Xunit;
using palindrome;

public class testclass
{
    [Fact]
    public void PassingPalindromeTest()
    {
        Palindrome palindrome2 = new Palindrome();
        Assert.Equal(true, palindrome2.MakePalindrome("kayak"));

    }
}