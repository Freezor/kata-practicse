namespace KataPractice.FIzzBuzz.RuleBased;

public class BuzzRule : IRule
{
    private const int    Divisor     = 5;
    private const string Replacement = "Buzz";

    public string Apply(int number)
    {
        return number % Divisor == 0 ? Replacement : string.Empty;
    }
}