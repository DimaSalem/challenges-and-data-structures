using Common_Elements;

namespace CommonElementsTest
{
    public class UnitTest1
    {
        [Fact]
        public void commonElementsCase1()
        {
            int[] actualCommonElements= Program.CommonElements(new int []{ 1, 2, 3, 0},new int []{ 2, 3, 4, 9});
            int[] expectedCommonElements = new int[] { 2, 3 };

            Assert.Equal(actualCommonElements, expectedCommonElements);
        }

        [Fact]
        public void commonElementsCase2()
        {
            int[] actualCommonElements = Program.CommonElements(new int[] { 79, 8, 15 }, new int[] { 23, 79, 8 });
            int[] expectedCommonElements = new int[] { 79, 8 };

            Assert.Equal(actualCommonElements, expectedCommonElements);
        }
    }
}