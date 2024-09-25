using challenges_and_data_structures.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class RotateLinkedListTest
    {
        [Fact]
        public void RotateLinkedListTest_01() { 

            linkedList linkedList = new linkedList();
            linkedList.addLast(1);
            linkedList.addLast(2);
            linkedList.addLast(3);
            linkedList.addLast(4);
            linkedList.addLast(5);
            linkedList.addLast(6);

            linkedList.RotateLinkedList(2);

            string result = "3\r\n4\r\n5\r\n6\r\n1\r\n2\r\n";
            var sw = new StringWriter();
            Console.SetOut(sw);
            linkedList.Print();
            string expectedRes = sw.ToString();

            Assert.Equal(expectedRes, result);
        }

        [Fact]
        public void RotateLinkedListTest_02()
        {

            linkedList linkedList = new linkedList();
            linkedList.addLast(1);
            linkedList.addLast(2);
            linkedList.addLast(3);
            linkedList.addLast(4);
            linkedList.addLast(5);
            linkedList.addLast(6);

            linkedList.RotateLinkedList(0);

            string result = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n";
            var sw = new StringWriter();
            Console.SetOut(sw);
            linkedList.Print();
            string expectedRes = sw.ToString();

            Assert.Equal(expectedRes, result);
        }

        [Fact]
        public void RotateLinkedListTest_03()
        {

            linkedList linkedList = new linkedList();
            linkedList.addLast(1);
            linkedList.addLast(2);
            linkedList.addLast(3);
            linkedList.addLast(4);
            linkedList.addLast(5);
            linkedList.addLast(6);

            linkedList.RotateLinkedList(10);

            string result = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n";
            var sw = new StringWriter();
            Console.SetOut(sw);
            linkedList.Print();
            string expectedRes = sw.ToString();

            Assert.Equal(expectedRes, result);
        }
    }
}
