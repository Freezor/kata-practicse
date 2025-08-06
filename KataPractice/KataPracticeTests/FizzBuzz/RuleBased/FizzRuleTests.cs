using JetBrains.Annotations;
using KataPractice.FIzzBuzz.RuleBased;
using Shouldly;

namespace KataPracticeTests.FizzBuzz.RuleBased;

[TestSubject(typeof(FizzRule))]
public class FizzRuleTests
{
    [Fact]
    public void Apply_ReturnsFizz_WhenNumberIsDivisibleBy3()
    {
        var rule = new FizzRule();

        var result = rule.Apply(3);

        result.ShouldBe("Fizz");
    }

    [Fact]
    public void Apply_ReturnsEmpty_WhenNumberIsNotDivisibleBy3()
    {
        var rule = new FizzRule();

        var result = rule.Apply(4);

        result.ShouldBeEmpty();
    }
}