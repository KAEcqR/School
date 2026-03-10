namespace NwdUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void If_Even_Modulo_0()
        {
            int nuber = 12;
            Assert.Equal(0, nuber % 2);
        }

        [Fact]
        public void If_Times_positive_negative_is_negative()
        {
            int a = 5;
            int b = -3;

            int result = a * b;
            Assert.True(result < 0);
        }
    }
}
