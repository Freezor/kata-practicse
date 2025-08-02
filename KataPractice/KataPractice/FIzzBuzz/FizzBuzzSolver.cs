namespace KataPractice.FIzzBuzz;

public class FizzBuzzSolver
{
    public string Run(int number)
    {
        return number < 1 ? "#" : number.ToString();
    }
}