using KataPractice.FIzzBuzz;
using Shouldly;

namespace KataPracticeTests.FizzBuzz;

public class FizzBuzzSolverTests
{
    [Fact]
    public void Run_ReturnsNumberAsString()
    {
        new FizzBuzzSolver().Run(1).ShouldBe("1");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(short.MinValue)]
    public void Run_ReturnsHashtag_WhenNumberIsSmallerThanOne(int number)
    {
        new FizzBuzzSolver().Run(number).ShouldBe("#");
    }

    [Theory]
    [InlineData(101)]
    [InlineData(200)]
    [InlineData(short.MaxValue)]
    public void Run_ReturnsHashtag_WhenNumberIsBiggerThan100(int number)
    {
        new FizzBuzzSolver().Run(number).ShouldBe("#");
    }

}