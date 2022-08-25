
using FakeCode;

namespace TestFakeCode
{
    public class Tests
    {
       
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSuma()
        {
            int op1 = 1;
            int op2 = 2;
            

            Calculadora calculadora = new();

            var result = calculadora.Suma(op1, op2);
            Assert.That(result, Is.EqualTo(3));
           
        }

        [Test]
        public void TestResta()
        {
            int op1 = 1;
            int op2 = 2;
            

            Calculadora calculadora = new();

            var resul2 = calculadora.Resta(op1, op2);
            Assert.That(resul2, Is.EqualTo(-1));
        }
    }
}