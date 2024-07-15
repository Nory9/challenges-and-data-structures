using challenges_and_data_structures.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class RemoveDuplicatesTests
    {

        //        Input: 5 -> 20 -> 20 -> 10 -> 5 -> 10 -> Null
        //After Removing Duplicates: 5 -> 20 -> 10 -> Null

        //Input: 1 -> 2 -> 3 -> 2 -> 4 -> 3 -> Null
        //After Removing Duplicates: 1 -> 2 -> 3 -> 4 -> Null

        //Input: 7 -> 7 -> 7 -> 7 -> Null
        //After Removing Duplicates: 7 -> Null

        [Fact]

        public void Test1() {

            linkedList linkedList = new linkedList();
            linkedList.addFirst(5);
            linkedList.addFirst(20);
            linkedList.addFirst(20);
            linkedList.addFirst(10);
            linkedList.addFirst(5);
            linkedList.addFirst(10);
            linkedList.removeDuplicates();


            string expectedRes = "10\r\n5\r\n20\r\n";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                linkedList.Print();

                string res = sw.ToString();

                Assert.Equal(expectedRes, res);

            } }

        [Fact]
        public void Test2()
        {

            linkedList linkedList = new linkedList();
            linkedList.addFirst(7);
            linkedList.addFirst(7);
            linkedList.addFirst(7);
            linkedList.addFirst(7);

            linkedList.removeDuplicates();


            string expectedRes = "7\r\n";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                linkedList.Print();

                string res = sw.ToString();

                Assert.Equal(expectedRes, res);

            }
        }

                [Fact]
                public void Test3() { 
                   
                   linkedList linkedList = new linkedList();
                   linkedList.addFirst(1);
                   linkedList.addFirst(2);
                   linkedList.addFirst(3);
                   linkedList.addFirst(2);
                   linkedList.addFirst(4);
                   linkedList.addFirst(3);
                   linkedList.removeDuplicates();
                   
                   
                    string expectedRes = "3\r\n4\r\n2\r\n1\r\n";
                   
                    using (var sw = new StringWriter())
                    {
                        Console.SetOut(sw);
                   
                        linkedList.Print();
                   
                        string res = sw.ToString();
                   
                        Assert.Equal(expectedRes, res);
                   
                    }
                   
        }
    }
}
