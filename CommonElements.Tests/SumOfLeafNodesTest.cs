using challenges_and_data_structures.DataStructures.Tree_Implementation.LeafSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class SumOfLeafNodesTest
    {
        [Fact]
        public void SumOfLeafNodes01() {

            LeafNodesSum s = new LeafNodesSum(10);

            s.Insert(9);
            s.Insert(12);
            s.Insert(17);
            s.Insert(23);
            s.Insert(6);
            s.Insert(8);
            s.Insert(3);
            s.Insert(15);

            string res = "49";

            var sw = new StringWriter();    
            Console.SetOut(sw);
            s.SumOfLeafNodes();
            string expectedRes= sw.ToString().Trim();

            Assert.Equal(expectedRes, res); 
        }

         [Fact]
        public void SumOfLeafNodes02() {

            LeafNodesSum s = new LeafNodesSum(10);

            s.Insert(9);
            s.Insert(12);
            s.Insert(17);
            s.Insert(23);
            s.Insert(6);
            s.Insert(8);
            s.Insert(-3);
            s.Insert(15);

            string res = "43";

            var sw = new StringWriter();    
            Console.SetOut(sw);
            s.SumOfLeafNodes();
            string expectedRes= sw.ToString().Trim();

            Assert.Equal(expectedRes, res); 
        }

    }
}
