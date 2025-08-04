namespace KataPractice.FIzzBuzz;

public class FizzBuzzSolver
{
    public string GetFizzBuzzValue(int number)
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

    public string PrintFizzBuzzUpTo(int number)
    {
        if (number is < 1 or > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 1 and 100");
        }

        return string.Empty;
    }
}