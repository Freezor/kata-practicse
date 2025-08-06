namespace KataPractice.FIzzBuzz.RuleBased;

public class FizzRule
{
    private const int    Divisor     = 3;
    private const string Replacement = "Fizz";

    public string Apply(int number)
    {
        return number % Divisor == 0 ? Replacement : string.Empty;
    }
}