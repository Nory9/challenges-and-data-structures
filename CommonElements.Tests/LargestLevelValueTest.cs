using challenges_and_data_structures.DataStructures.Tree_Implementation.LargestValueAtEachLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class LargestLevelValueTest
    {

        [Fact]
        public void LargestLevelTest() {

            LargestLevelValue tree = new LargestLevelValue(10);
            tree.Insert(13);
            tree.Insert(4);
            tree.Insert(3);
            tree.Insert(5);

            
            
            var result = tree.FindLargestValuesAtEachLevel();

            
            var expected = new List<int> { 10, 13, 5 };
            Assert.Equal(expected, result);


        }
    }
}
