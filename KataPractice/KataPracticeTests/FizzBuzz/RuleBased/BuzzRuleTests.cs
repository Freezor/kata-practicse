using JetBrains.Annotations;
using KataPractice.FIzzBuzz.RuleBased;
using Shouldly;

namespace KataPracticeTests.FizzBuzz.RuleBased;

[TestSubject(typeof(BuzzRule))]
public class BuzzRuleTests
{
    [Fact]
    public void Apply_ReturnsBuzz_WhenNumberIsDivisibleBy5()
    {
        var rule = new BuzzRule();

        var result = rule.Apply(5);

        result.ShouldBe("Buzz");
    }
}