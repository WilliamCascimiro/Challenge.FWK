namespace Challenge.Service;
public class CalculationService
{
    public (IEnumerable<int>, IEnumerable<int>) Calculate(int number)
    {
        var divisors = GetDivisors(number);
        var primes = GetPrimes(divisors);

        return (divisors, primes);
    }

    #region Methods

    public IEnumerable<int> GetDivisors(int number)
    {
        return Enumerable.Range(1, number)
                .Where(x => number % x == 0);
    }

    public IEnumerable<int> GetPrimes(IEnumerable<int> numbers)
    {
        return numbers.Where(x => IsPrime(x));
    }

    public bool IsPrime(int number)
    {
        if (number == 1)
            return false;

        int numberDivisors = Enumerable.Range(1, number)
                                .Count(x => (number % x == 0) && (x != number) && (x != 1));

        return numberDivisors == 0 ? true : false;
    }

    #endregion Methods

}

