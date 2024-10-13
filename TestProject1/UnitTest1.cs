using laba1.integral.classes;
namespace laba1.integral
{
    [TestClass]
    public class TestTrapCalculator
    {
        [TestMethod]
        public void TestMethod1()
        {
            double lower = 1;
            double upper = 100;
            int count = 100000000;
            Func<double, double> func = x => (2 * x) - Math.Log(2 * x) + 234;
            double expected = 32734.861;

            Icalculator calcualtor = new TrapCalculator();
            double actual = calcualtor.Calculate(lower, upper, count, func);

            Assert.AreEqual(expected, actual, 0.01);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            double lower = 1;
            double upper = 100;
            int count = -100000000;
            Func<double, double> func = x => (2 * x) - Math.Log(2 * x) + 234;
            double expected = 32734.861;

            Icalculator calcualtor = new TrapCalculator();
            double actual = calcualtor.Calculate(lower, upper, count, func);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double lower = 1;
            double upper = 100;
            int count = 100000000;
            Func<double, double> func = x => (2 * x) - Math.Log(2 * x) + 234;
            double expected = 32734.861;

            Icalculator calcualtor = new SimpsonCalculator();
            double actual = calcualtor.Calculate(lower, upper, count, func);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod4()
        {
            double lower = 1;
            double upper = 100;
            int count = -100000000;
            Func<double, double> func = x => (2 * x) - Math.Log(2 * x) + 234;
            double expected = 32734.861;

            Icalculator calcualtor = new SimpsonCalculator();
            double actual = calcualtor.Calculate(lower, upper, count, func);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod5()
        {
            double lower = 1;
            double upper = 100;
            int count = 999999;
            Func<double, double> func = x => (2 * x) - Math.Log(2 * x) + 234;
            double expected = 32734.861;

            Icalculator calculator = new SimpsonCalculator();
            double actual = calculator.Calculate(lower, upper, count, func);
        }
    }
}