using Lab03_Challenge;

namespace TestChallenge9
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string word = "Hello Word";
            string[] arr = { "Hello: 5", "Word: 4" };
            string[] result = Program.NumberWords(word);
           
            Assert.Equal(arr, result);
        }
        [Fact]
        public void Test2()
        {
            string word = "Hello friend samer";
            string[] arr = { "Hello: 5", "friend: 6","samer: 5"};
            string[] result = Program.NumberWords(word);

            Assert.Equal(arr, result);
        }
    }
}