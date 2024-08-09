
using challenges_and_data_structures.DataStructures.Stack_Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class MinStackTest
    {
        [Fact]
        public void MiniStack_test01() { 

           MinStack minStack = new MinStack();

            minStack.push(1);
            minStack.push(2);
            minStack.push(3);
            minStack.push(4);
            minStack.push(5);
            minStack.push(6);

            int expectedRes=minStack.GetMin();
            int res = 1;
            Assert.Equal(expectedRes, res); 
        }
         [Fact]
        public void MiniStack_test02() { 

           MinStack minStack = new MinStack();

            minStack.push(7);
            minStack.push(20);
            minStack.push(3);
            minStack.GetMin();
            minStack.pop();

            int expectedRes=minStack.GetMin();
            int res = 7;
            Assert.Equal(expectedRes, res); 
        }

    }
}
