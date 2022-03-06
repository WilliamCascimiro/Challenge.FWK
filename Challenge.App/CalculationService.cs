namespace Desafio;
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
    }    
}

