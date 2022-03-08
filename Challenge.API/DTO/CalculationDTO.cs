namespace Challenge.API.DTO
{
    public class CalculationDTO
    {
        public CalculationDTO(int informedNumbers, IEnumerable<int> divisors, IEnumerable<int> primes)
        {
            InformedNumbers = informedNumbers;
            Divisors = divisors;
            Primes = primes;
        }

        public int InformedNumbers { get; private set; }
        public IEnumerable<int> Divisors { get; private set; }
        public IEnumerable<int> Primes { get; private set; }
    }
}
