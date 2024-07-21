namespace HOMEWORK22._07
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calculator = new Calculator();
            double result = calculator.Cos(0);
            Assert.Equal(1, result, 5); // cos(0) должен быть равен 1

            result = calculator.Cos(Math.PI / 2);
            Assert.Equal(0, result, 5); // cos(π/2) должен быть равен 0
        }

        [Fact]
        public void Test2()
        {
            var calculator = new Calculator();
            double result = calculator.Sin(0);
            Assert.Equal(0, result, 5); // sin(0) должен быть равен 0

            result = calculator.Sin(Math.PI / 2);
            Assert.Equal(1, result, 5); // sin(π/2) должен быть равен 1
        }
    }
    
}
