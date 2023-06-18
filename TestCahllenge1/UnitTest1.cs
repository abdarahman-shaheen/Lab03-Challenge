using Lab03_Challenge;

namespace TestCahllenge1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string num= "1 2 3";

            int result = Program.Multiplication(num);

            Assert.Equal(6, result);
        }
        [Fact]
        public void Test2()
        {
            string num = "1 2";

            int result = Program.Multiplication(num);

            Assert.Equal(0, result);
        }
        [Fact]
        public void Test3()
        {
            string num = "a 1 2";

            int result = Program.Multiplication(num);

            Assert.Equal(2, result);
        }
        [Fact]
        public void Test4()
        {
            string num = "1 -1 2";

            int result = Program.Multiplication(num);

            Assert.Equal(-2, result);
        }
        [Fact]
        public void Test5()
        {
            string num = "1 3 2 5 6";

            int result = Program.Multiplication(num);

            Assert.Equal(6, result);
        }
    }
}