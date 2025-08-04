namespace KataPractice.FIzzBuzz;

public class FizzBuzzSolver
{
    public string Run(int number)
    {
        if (number is < 1 or > 100)
            return "#";
 
        return (number % 3, number % 5) switch
        {
            (0, 0) => "FizzBuzz",
            (0, _) => "Fizz",
            (_, 0) => "Buzz",
            _ => number.ToString(),
        };
    }
}