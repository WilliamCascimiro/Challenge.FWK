namespace Service;
public class CalculationService
{
    public void Start()
    {
        int informedNumber;
        while (true)
        {
            Console.WriteLine("Informe um número:");
            if (int.TryParse(Console.ReadLine(), out informedNumber) && informedNumber > 0)
                break;
            Console.WriteLine("Por favor, informe um número inteiro positivo");
        }

        var divisors = GetDivisors(informedNumber);
        var primes = GetPrimes(divisors);

        Console.WriteLine(@"Número de Entrada: " + String.Join(", ", informedNumber));
        Console.WriteLine(@"Número Divisores: " + String.Join(", ", divisors));
        Console.WriteLine(@"Divisores Primos: " + String.Join(", ", primes));
    }

    #region Methods

    public IEnumerable<int> GetDivisors(int number)
    {
        return Enumerable.Range(1, number)
                .Where(x => number % x == 0)
                .ToList();
    }

    public IEnumerable<int> GetPrimes(IEnumerable<int> numbers)
    {
        return numbers.Where(x => IsPrime(x)).ToList();
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

