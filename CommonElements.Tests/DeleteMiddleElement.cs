using challenges_and_data_structures.DataStructures.Stack_Queue;
using challenges_and_data_structures.DataStructures.Stack_Queue.DeleteMiddleElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class DeleteMiddleElement
    {
        [Fact]
        public void DeleteMiddleElementTest_01() {

            DeleteMiddleElementC stack = new DeleteMiddleElementC();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);

            stack.DeleteMiddleE();

            string expectedRes = "5\r\n4\r\n2\r\n1\r\n";
            using (var sw = new StringWriter()) { 
            
               Console.SetOut(sw);

                stack.print();
                string actualRes = sw.ToString();
                Assert.Equal(actualRes, expectedRes);
            }
        }
        
        [Fact]
        public void DeleteMiddleElementTest_02() {

            DeleteMiddleElementC stack = new DeleteMiddleElementC();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);

            stack.DeleteMiddleE();

            string expectedRes = "4\r\n3\r\n1\r\n";
            using (var sw = new StringWriter()) { 
            
               Console.SetOut(sw);

                stack.print();
                string actualRes = sw.ToString();
                Assert.Equal(actualRes, expectedRes);
            }
        }
    }
}
