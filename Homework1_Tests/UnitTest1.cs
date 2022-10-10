
using Homework1;

namespace Homework1_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSum()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(4, 5);

            var result = fraction1 + fraction2;
            Assert.Equal("13/10", result.ToString());
        }

        [Fact]
        public void TestDiff()
        {
            var fraction1 = new Fraction(10, 15);
            var fraction2 = new Fraction(10, 30);

            var result = fraction1 - fraction2;

            Assert.Equal("1/3", result.ToString());
        }

        [Fact]
        public void TestProduct()
        {
            var fraction1 = new Fraction(3, 7);
            var fraction2 = new Fraction(7, 12);

            var result = fraction1 * fraction2;
            Assert.Equal("1/4", result.ToString());
        }

        [Fact]
        public void TestDivision()
        {
            var fraction1 = new Fraction(5, 2);
            var fraction2 = new Fraction(5, 6);

            var result = fraction1 / fraction2;
            Assert.Equal("3/1", result.ToString());
        }

        [Fact]
        public void TestException()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(0, 3);

            var exception = Assert.Throws<InvalidOperationException>(() => fraction1 / fraction2);
            Assert.Equal("Denominator can't be zero.", exception.Message);
        }

        [Fact]
        public void TestValue()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(4, 1);
            var result = fraction1 * fraction2;
            Assert.Equal(2.0, result.Value);
        }
    }
}
