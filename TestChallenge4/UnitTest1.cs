using Lab03_Challenge;

namespace TestChallenge4
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()

        {
            int[] num = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };

            int result = Program.FindDublicated(num);

            Assert.Equal(1, result);
        }
        [Fact]
        public void Test2()

        {
            int[] num = { 2, 2,2,2 };

            int result = Program.FindDublicated(num);

            Assert.Equal(2, result);
        }
        [Fact]
        public void Test3()

        {
            int[] num = { 5, 2, 3, 4 };

            int result = Program.FindDublicated(num);

            Assert.Equal(5, result);
        }
        [Fact]
        public void Test4()

        {
            int[] num = { 6, 6,6,3, 3,3, 4 };

            int result = Program.FindDublicated(num);

            Assert.Equal(6, result);
        }
    }
}