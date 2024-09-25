using challenges_and_data_structures.DataStructures.LinkedList;
using System.Collections.Generic;
using System.Xml.Linq;

namespace challenges_and_data_structures
{
    public class main
    {


        public static void Main(string[] args)
        {
            linkedList l1 = new linkedList();
            l1.addLast(1);
            l1.addLast(2);
            l1.addLast(3);
            l1.addLast(4);
            l1.addLast(5);
            l1.addLast(6);
            l1.RotateLinkedList(2);
            l1.printList();

        }


    }
}