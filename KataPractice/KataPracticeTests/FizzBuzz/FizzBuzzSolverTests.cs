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

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(90)]
    [InlineData(33)]
    public void Run_ReturnsFizz_ForMultiplesOfThree(int number)
    {
        new FizzBuzzSolver().Run(number).ShouldBe("Fizz");
    }
    
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    [InlineData(25)]
    [InlineData(50)]
    [InlineData(95)]
    public void Run_ReturnsBuzz_ForMultiplesOfFive(int number)
    {
        new FizzBuzzSolver().Run(number).ShouldBe("Buzz");
    }
    
}