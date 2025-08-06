using KataPractice.FIzzBuzz.RuleBased;

namespace KataPracticeTests.FizzBuzz.RuleBased;

public class FizzRuleTests
{
    [Fact]
    public void Returns_Fizz_When_Number_Is_Divisible_By_3()
    {
        var rule = new FizzRule();

        var result = rule.Apply(3);

        Assert.Equal("Fizz", result);
    }
}