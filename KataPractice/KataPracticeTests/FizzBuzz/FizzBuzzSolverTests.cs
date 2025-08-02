using KataPractice.FIzzBuzz;
using Shouldly;

namespace KataPracticeTests.FizzBuzz;

public class FizzBuzzSolverTests
{
    [Fact]
    public void ReturnsNumberAsString()
    {
        new FizzBuzzSolver().Run(1).ShouldBe("1");
    }
    
}