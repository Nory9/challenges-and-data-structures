using challenges_and_data_structures.DataStructures.Stack_Queue;
using challenges_and_data_structures.DataStructures.Stack_Queue.ReverseStackUsingQueue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class StackWithReverseclass
    {
        [Fact]
        public void StackReverseTest01() { 
            StackWithReverse stack=new StackWithReverse();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);

            stack.ReverseStack();

            string expectedRes = "1\r\n2\r\n3\r\n4\r\n5\r\n";
            using (var sw =new  StringWriter()) { 
               
                Console.SetOut(sw);
                stack.print();               
                string res= sw.ToString();
                Assert.Equal(expectedRes, res); 
            }

        }
        
        [Fact]
        public void StackReverseTest02() { 
            StackWithReverse stack=new StackWithReverse();
            stack.push(1);

            stack.ReverseStack();

            string expectedRes = "1\r\n";
            using (var sw =new  StringWriter()) { 
               
                Console.SetOut(sw);
                stack.print();               
                string res= sw.ToString();
                Assert.Equal(expectedRes, res); 
            }

        }
        
        [Fact]
        public void StackReverseTest03() { 
            StackWithReverse stack=new StackWithReverse();

            stack.ReverseStack();

            string expectedRes = "";
            using (var sw =new  StringWriter()) { 
               
                Console.SetOut(sw);
                stack.print();               
                string res= sw.ToString();
                Assert.Equal(expectedRes, res); 
            }

        }
    }
}
