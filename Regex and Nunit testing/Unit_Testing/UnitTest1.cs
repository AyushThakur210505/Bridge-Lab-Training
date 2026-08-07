using Unit_Test_Examples;
using UnitTesting;

namespace Unit_Testing
{
    public class Tests
    {
        //private Calculator calc;

        //[SetUp]
        //public void Setup()
        //{
        //    calc = new Calculator();
        //}

        //[TestCase(5, 3, 4, 12)]
        //[TestCase(10, 20, 5, 35)]
        //[TestCase(-5, 5, 5, 5)]
        //public void Add_Test(int a, int b, int c ,int expected)
        //{
        //    Assert.That(calc.Add(a, b, c), Is.EqualTo(expected));
        //}

        //[TestCase(5, 3, 2)]
        //[TestCase(10, 5, 5)]
        //public void Subtract_Test(int a, int b, int expected)
        //{
        //    Assert.That(calc.Subtract(a, b), Is.EqualTo(expected));
        //}

        //[TestCase(5, 3, 15)]
        //[TestCase(4, 2, 8)]
        //public void Multiply_Test(int a, int b, int expected)
        //{
        //    Assert.That(calc.Multiply(a, b), Is.EqualTo(expected));
        //}

        //[TestCase(6, 3, 2)]
        //[TestCase(20, 5, 4)]
        //public void Divide_Test(int a, int b, int expected)
        //{
        //    Assert.That(calc.Divide(a, b), Is.EqualTo(expected));
        //}

        //[Test]
        //public void Divide_By_Zero_Test()
        //{
        //    Assert.That(() => calc.Divide(5, 0),
        //        Throws.TypeOf<DivideByZeroException>());
        //}




        public class PrimeNoTests
        {
            private PrimeNo prime;

            [SetUp]
            public void Setup()
            {
                prime = new PrimeNo();
            }

            [TestCase(2, true)]
            [TestCase(3, true)]
            [TestCase(4, false)]
            [TestCase(5, true)]
            public void IsPrime_Test(int number, bool expected)
            {
                Assert.That(prime.IsPrime(number), Is.EqualTo(expected));
            }
        }
    }
}