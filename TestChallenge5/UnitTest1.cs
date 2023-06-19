using Lab03_Challenge;

namespace TestChallenge5
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()

        {
            int[] num = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };

            int result = Program.MaxNumber(num);

            Assert.Equal(555, result);
        }
        [Fact]
        public void Test2()

        {
            int[] num = { -1,-2,-5,-7 };

            int result = Program.MaxNumber(num);

            Assert.Equal(-1, result);
        }
        [Fact]
        public void Test3()

        {
            int[] num = { 2, 2, 2, 2 };

            int result = Program.MaxNumber(num);

            Assert.Equal(2, result);
        }
    }
}