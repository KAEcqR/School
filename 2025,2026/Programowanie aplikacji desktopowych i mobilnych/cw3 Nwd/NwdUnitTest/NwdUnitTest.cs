using NwdClassLib;

namespace NwdUnitTest
{

    public class NwdUnitTest
    {
        [Fact]
        public void Nwd_Of_48_18_Is_6()
        {
            int a = 48;
            int b = 18;
            int expectedNwd = 6;
            NwdCalculator calculator = new NwdCalculator();
            int actualNwd = calculator.CalculateNwd(a, b);
            Assert.Equal(expectedNwd, actualNwd);
        }

        [Fact]
        public void Nwd_Of_101_10_Is_1()
        {
            int a = 101;
            int b = 10;
            int expectedNwd = 1;
            NwdCalculator calculator = new NwdCalculator();
            int actualNwd = calculator.CalculateNwd(a, b);
            Assert.Equal(expectedNwd, actualNwd);
        }

        [Fact]
        public void Nwd_0f_0_5_Is_5()
        {
            int a = 0;
            int b = 5;
            int expectedNwd = 5;
            NwdCalculator calculator = new NwdCalculator();
            int actualNwd = calculator.CalculateNwd(a, b);
            Assert.Equal(expectedNwd, actualNwd);
        }

        [Fact]
        public void Nwd_0f_5_0_Is_5()
        {
            int a = 5;
            int b = 0;
            int expectedNwd = 5;
            NwdCalculator calculator = new NwdCalculator();
            int actualNwd = calculator.CalculateNwd(a, b);
            Assert.Equal(expectedNwd, actualNwd);
        }

        [Fact]
        public void Nwd_0f_negative5_7_Is_1()
        {
            int a = -5;
            int b = 7;
            int expectedNwd = 1;
            NwdCalculator calculator = new NwdCalculator();
            int actualNwd = calculator.CalculateNwd(a, b);
            Assert.Equal(expectedNwd, actualNwd);
        }

        [Fact]
        public void Nwd_0f_0_0_Is_Exception()
        {
            int a = 0;
            int b = 0;
            int expectedNwd = 1;
            NwdCalculator calculator = new NwdCalculator();
            Assert.Throws<ArgumentException>(() => calculator.CalculateNwd(a, b));
        }

        [Fact]
        public void Nwd_Iter_Of_270_192_Is_6()
        {
            int a = 270;
            int b = 192;
            int expectedNwd = 6;
            NwdCalculator calculator = new NwdCalculator();
            int actualNwd = calculator.CalculateNwdIteratively(a, b);
            Assert.Equal(expectedNwd, actualNwd);
        }
        [Fact]
        public void Nwd_Iter_Of_18_0_Is_18()
        {
            int a = 18;
            int b = 0;
            int expectedNwd = 18;
            NwdCalculator calculator = new NwdCalculator();
            int actualNwd = calculator.CalculateNwdIteratively(a, b);
            Assert.Equal(expectedNwd, actualNwd);
        }

    }
}