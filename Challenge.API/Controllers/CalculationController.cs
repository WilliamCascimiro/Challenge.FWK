using Microsoft.AspNetCore.Mvc;
using Challenge.API.DTO;
using Challenge.Service;

namespace Challenge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly CalculationService _calculationService;

        public CalculationController(CalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        [HttpGet(Name = "Calculate/{number}")]
        public IActionResult Calculate(int number)
        {
            if (number <= 0)
                return BadRequest("Por favor, informe um número inteiro positivo.");

            var calculation = _calculationService.Calculate(number);
            return Ok(new CalculationDTO(number, calculation.Item1, calculation.Item2));
        }

    }
}