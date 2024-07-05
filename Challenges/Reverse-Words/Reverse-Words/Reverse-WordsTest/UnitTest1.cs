using Reverse_Words;


namespace Reverse_WordsTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string input = "csharp is programming language";
            string expectedOutput = "language programming is csharp";
            string actualOutput= Program.ReverseWords(input);

            Assert.Equal(actualOutput, expectedOutput);
        }

        [Fact]
        public void Test2()
        {
            string input = "Reverse the words in this sentence";
            string expectedOutput = "sentence this in words the Reverse";
            string actualOutput = Program.ReverseWords(input);

            Assert.Equal(actualOutput, expectedOutput);
        }

        [Fact]
        public void Test3()
        {
            string input = "challenges and data structures";
            string expectedOutput = "structures data and challenges";
            string actualOutput = Program.ReverseWords(input);

            Assert.Equal(actualOutput, expectedOutput);
        }
    }
}