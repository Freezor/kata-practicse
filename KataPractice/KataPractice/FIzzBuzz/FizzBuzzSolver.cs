namespace KataPractice.FIzzBuzz;

public class FizzBuzzSolver
{
    public string Run(int number)
    {
        return number is < 1 or > 100? "#" : number.ToString();
    }
}