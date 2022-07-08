using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_Csharp_Module_16_Practice_2.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(34, 65) == 99);
        }
        [Test]
        public void Substraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Substraction(876, 65) == 811);
        }
        [Test]
        public void Multiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Multiplication(76, 10) == 760);
            Assert.That(calculator.Multiplication(76, 0) == 0);
            Assert.That(calculator.Multiplication(0, 10) == 0);
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(88, 11) == 8);
        }
        [Test]
        public void Division_MustThrowException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(40, 0));
        }

    }
}
