using Xunit;
using challenges_and_data_structures;

namespace CommonElements.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] a1 = { 79, 8, 15 };
            int[] a2 = { 23, 79, 8 };
            int[] expectedOutput = { 79, 8 };
            int[] a3 = challenges_and_data_structures.Program.CommonElements(a1, a2);

            Assert.Equal(expectedOutput,a3);

        }

        [Fact]
        public void Test2()
        {
            int[] a1 = { 1, 2, 3, 0};
            int[] a2 = { 2, 3, 4, 9 };
            int[] expectedOutput = { 2, 3 };
            int[] a3 = challenges_and_data_structures.Program.CommonElements(a1, a2);

            Assert.Equal(expectedOutput, a3);

        }
    }
}