using JetBrains.Annotations;
using KataPractice.FIzzBuzz.RuleBased;

namespace KataPracticeTests.FizzBuzz.RuleBased;

[TestSubject(typeof(BuzzRule))]
public class BuzzRuleTests
{
    [Fact]
    public void Apply_ReturnsBuzz_WhenNumberIsDivisibleBy5()
    {
        var rule = new FizzRule();

        var result = rule.Apply(5);

        Assert.Equal("Buzz", result);
    }
}