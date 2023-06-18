using Lab03_Challenge;

namespace TestChallenge2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int size = 4;
            int [] arr = { 4, 8, 15, 16 };
            int result = Program.Randoms(size,arr);
            Assert.Equal(10, result);
        }
        [Fact]
        public void Test2()
        {
            int size = 4;
            int[] arr = { 0, 0, 0, 0 };
            int result = Program.Randoms(size, arr);
            Assert.Equal(0, result);
        }
        [Fact]
        public void Test3()
        {
            int size = 5;
            int[] arr = { 1, 2, 3, 4,10 };
            int result = Program.Randoms(size, arr);
            Assert.Equal(4, result);
        }
    }
}