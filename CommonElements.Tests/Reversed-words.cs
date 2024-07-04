using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class Class1
    {
        [Fact]
        public void TestCase1() {
            string test_word = "Reverse the words in this sentence";

            string expected_output = "sentence this in words the Reverse";

            string output= challenges_and_data_structures.ReverseWords.Reverse_Words(test_word);

            Assert.Equal(expected_output, output);
        }

        [Fact]
        public void TestCase2()
        {
            string test_word = "csharp is programming language";

            string expected_output = "language programming is csharp";

            string output = challenges_and_data_structures.ReverseWords.Reverse_Words(test_word);

            Assert.Equal(expected_output, output);
        }

        [Fact]
        public void TestCase3()
        {
            string test_word = "challenges and data structures";

            string expected_output = "structures data and challenges";

            string output = challenges_and_data_structures.ReverseWords.Reverse_Words(test_word);

            Assert.Equal(expected_output, output);
        }
    }
}
