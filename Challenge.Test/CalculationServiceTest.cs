using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Challenge.Service;

namespace Challenge.Test
{
    [TestFixture]
    public class CalculationServiceTest
    {
        private CalculationService _calculationService;
        private Dictionary<int, int[]> _dividersList;
        private Dictionary<int[], int[]> _primesList;

        [SetUp]
        public void Setup()
        {
            _calculationService = new CalculationService();

            _dividersList = new Dictionary<int, int[]>();
            _dividersList.Add(13, new int[] { 1, 13 });
            _dividersList.Add(45, new int[] { 1, 3, 5, 9, 15, 45 });
            _dividersList.Add(46, new int[] { 1, 2, 23, 46 });

            _primesList = new Dictionary<int[], int[]>();
            _primesList.Add(new int[] { 6, 8, 10, 15 }, new int[] { });
            _primesList.Add(new int[] { 1, 3, 5, 9, 15, 45 }, new int[] { 3, 5 });
            _primesList.Add(new int[] { 3 }, new int[] { 3 });
        }

        [Test]
        public void ShouldBindDividersMethodWithDivedersList()
        {
            foreach (var number in _dividersList.Keys)
            {
                Assert.AreEqual(_dividersList[number], _calculationService.GetDivisors(number));
            }
        }

        [Test]
        public void ShouldBindPrimesMethodWithPrimesList()
        {
            foreach (int[] number in _primesList.Keys)
            {
                Assert.AreEqual(_primesList[number], _calculationService.GetPrimes(number.ToList()));
            }
        }

        [TestCase(2)]
        [TestCase(31)]
        [TestCase(107)]
        [TestCase(197)]
        [TestCase(257)]
        [TestCase(281)]
        [TestCase(367)]
        [TestCase(547)]
        public void ShouldReturnTrue(int number)
        {
            Assert.AreEqual(true, _calculationService.IsPrime(number));
        }

        [TestCase(1)]
        [TestCase(32)]
        [TestCase(108)]
        [TestCase(198)]
        [TestCase(256)]
        [TestCase(282)]
        [TestCase(368)]
        [TestCase(548)]
        public void ShouldReturnFalse(int number)
        {
            Assert.AreEqual(false, _calculationService.IsPrime(number));
        }

    }
}