using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenges_and_data_structures.DataStructures.Tree_Implementation;

namespace CommonElements.Tests
{
    public class RightNodesTest
    {
        [Fact]
        public void RightViewTest_01() {

            RightView tree = new RightView(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(-1);
            tree.Insert(1);
            List<int> expected = new List<int>{ 2, 3, 4, 5 };
            List<int> actual = tree.FindRight();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RightViewTest_02()
        {

            RightView tree = new RightView(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(6);
            tree.Insert(7);
            List<int> expected = new List<int> { 2, 3, 4, 5 ,6,7};
            List<int> actual = tree.FindRight();
            Assert.Equal(expected, actual);
        }

    }
}
