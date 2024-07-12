using challenges_and_data_structures.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class LinkedListTest
    {
        [Fact]
        public void TestRemoveMethod_pass() { 
        
            linkedList list = new linkedList();
            list.addFirst(1);
            list.addLast(2);
            list.addFirst(3);
           list.addLast(4);
            
            bool res=list.remove(4);
            Assert.True(res);

        }

        [Fact]
        public void TestRemoveMethod_fail()
        {

            linkedList list = new linkedList();
            list.addFirst(1);
            list.addLast(2);
            list.addFirst(3);
            list.addLast(4);

            bool res = list.remove(77);
            Assert.False(res);

        }

        [Fact]
        public void TestRemoveLast() {

            linkedList list = new linkedList();
            list.addFirst(1);
            list.addLast(2);
            list.addFirst(3);
            list.addLast(4);
            list.removeLast();

            bool res = list.removeLast();
            Assert.True(res);
        }

        [Fact]
        public void TestRemoveFirst()
        {

            linkedList list = new linkedList();
            list.addFirst(1);
            list.addLast(2);
            list.addFirst(3);
            list.addLast(4);
            list.removeFirst();

            bool res = list.removeFirst();
            Assert.True(res);
        }


        [Fact]

        public void TestPrintMethod() { 
        
            linkedList linkedList = new linkedList();
            linkedList.addFirst(1);
            linkedList.addLast(2);
            linkedList.addFirst(3);
            linkedList.addLast(4);
            linkedList.addFirst(5);

            string expectedRes = "5\r\n3\r\n1\r\n2\r\n4\r\n";

            using (var sw = new StringWriter()) { 
                Console.SetOut(sw); 

                linkedList.Print();
                
                string res=sw.ToString();

                Assert.Equal(expectedRes, res);
            
            }

        }
    }
}
