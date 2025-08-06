using KataPractice.FIzzBuzz.RuleBased;

namespace KataPracticeTests.FizzBuzz.RuleBased;

public class FizzRuleTests
{
    [Fact]
    public void Apply_ReturnsFizz_WhenNumberIsDivisibleBy3()
    {
        var rule = new FizzRule();

        var result = rule.Apply(3);

        Assert.Equal("Fizz", result);
    }
    [Fact]
    public void Apply_ReturnsEmpty_WhenNumberIsNotDivisibleBy3()
    {
        var rule = new FizzRule();

        var result = rule.Apply(4);

        Assert.Equal("Fizz", result);
    }
}