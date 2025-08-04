namespace KataPractice.FIzzBuzz;

public class FizzBuzzSolver
{
    public string Run(int number)
    {
        if (number is < 1 or > 100)
            return "#";

        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        
        if (number % 3 == 0)
        {
            return "Fizz";
        }

        if (number % 5 == 0)
        {
            return "Buzz";
        }
        
        return number.ToString();
    }
}