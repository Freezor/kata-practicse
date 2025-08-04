namespace KataPractice.FIzzBuzz;

public class FizzBuzzSolver
{
    public string Run(int number)
    {
        if (number is < 1 or > 100)
            return "#";

        var result = string.Empty;
        if (number % 3 == 0)
            result += "Fizz";
        if (number % 5 == 0)
            result += "Buzz";

        return string.IsNullOrEmpty(result) ? number.ToString() : result;
    }
}