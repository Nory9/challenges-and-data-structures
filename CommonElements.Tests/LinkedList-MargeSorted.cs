using challenges_and_data_structures.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class LinkedList_MargeSorted
    {
        [Fact]
        public void MargeSorted_Test1() { 
        
            linkedList l1 = new linkedList();
            l1.addLast(1);
            l1.addLast(3);
            l1.addLast(5);

            linkedList l2 = new linkedList();   
            l2.addLast(2);
            l2.addLast(4);
            l2.addLast(6);

            l1.MergeSorted(l1, l2);

            string expectedRes = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n";
            using (var sw = new StringWriter()) {
                Console.SetOut(sw);
                
                l1.Print();
                
                string res=sw.ToString();

                Assert.Equal(expectedRes, res);
            }
               
        }


        //List 1: Head -> 5 -> 10 -> 15 -> Null
        //List 2: Head -> 2 -> 3 -> 20 -> Null
        //Merged List: Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null
        [Fact]

        public void MargeSorted_Test2()
        { 

            linkedList l1 = new linkedList();   
            l1.addLast(5);
            l1.addLast(10);
            l1.addLast(15);

            linkedList l2 = new linkedList();   
            l2.addLast(2);
            l2.addLast(3);    
            l2.addLast(20);

            l1.MergeSorted(l1, l2);



            string expectedRes = "2\r\n3\r\n5\r\n10\r\n15\r\n20\r\n";
            using (var sw =new StringWriter()) { 
             
                Console.SetOut(sw);

                l1.Print(); 

                string res=sw.ToString();

                Assert.Equal (expectedRes, res);    
            
            }
        
        }

        // when one list is empty
        [Fact]

        public void MargeSorted_Test3()
        {

            linkedList l1 = new linkedList();

            linkedList l2 = new linkedList();
            l2.addLast(2);
            l2.addLast(3);
            l2.addLast(20);

            l1.MergeSorted(l1, l2);



            string expectedRes = "2\r\n3\r\n20\r\n";
            using (var sw = new StringWriter())
            {

                Console.SetOut(sw);

                l1.Print();

                string res = sw.ToString();

                Assert.Equal(expectedRes, res);

            }

        }

        // when both lists are empty
        [Fact]
        public void MargeSorted_Test4()
        {

            linkedList l1 = new linkedList();

            linkedList l2 = new linkedList();
         

            l1.MergeSorted(l1, l2);



            string expectedRes = "";
            using (var sw = new StringWriter())
            {

                Console.SetOut(sw);

                l1.Print();

                string res = sw.ToString();

                Assert.Equal(expectedRes, res);

            }

        }
    }
}
