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

    [Fact]
    public void Run_ReturnsHashtag_WhenNumberIsSmallerThanOne()
    {
        new FizzBuzzSolver().Run(-1).ShouldBe("#");
    }

}