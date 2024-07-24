using challenges_and_data_structures.DataStructures.Stack_Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class StackAndQueue
    {
        [Fact]
        public void StackPushMethod_Test()
        {
            Stack_ stack =new Stack_ ();
            stack.push (1);

            int expectedRes = 1;

            Assert.Equal(expectedRes, stack.peek());


        }

        [Fact]
        public void StackPopMethod_Test()
        {
            Stack_ stack = new Stack_();
            stack.push(1);
            stack.push(2);
            stack.push(4);
            stack.pop();
            int expectedRes = 2;

            Assert.Equal(expectedRes, stack.peek());
        }

        [Fact]

        public void StackisEmptyMethod_Test01() {

            Stack_ stack = new Stack_();
            stack.push(1);
            stack.push(2);
            stack.push(4);

            Assert.False(stack.isEmpty());

        }

        [Fact]

        public void StackisEmptyMethod_Test02()
        {

            Stack_ stack = new Stack_();
            stack.push(1);
            stack.push(2);
            stack.push(4);
            stack.pop();
            stack.pop();
            stack.pop();
            Assert.True(stack.isEmpty());

        }
    }
}
