using Challenge.Service;

var calculationService = new CalculationService();

int informedNumber;
while (true)
{
    Console.WriteLine("Informe um número:");
    if (int.TryParse(Console.ReadLine(), out informedNumber) && informedNumber > 0)
        break;
    Console.WriteLine("Por favor, informe um número inteiro positivo");
}

var divisors = calculationService.GetDivisors(informedNumber);
var primes = calculationService.GetPrimes(divisors);

Console.WriteLine(@"Número de Entrada: " + String.Join(", ", informedNumber));
Console.WriteLine(@"Número Divisores: " + String.Join(", ", divisors));
Console.WriteLine(@"Divisores Primos: " + String.Join(", ", primes));
