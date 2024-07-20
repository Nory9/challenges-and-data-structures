using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.LinkedList
{
    public class Node
    {
        private int data;
        private Node next;

        public Node()
        {
            this.data = 0;
            this.next = null;
        }


        public int Data { get; set; }
        public Node Next { get; set; }
    }
}
