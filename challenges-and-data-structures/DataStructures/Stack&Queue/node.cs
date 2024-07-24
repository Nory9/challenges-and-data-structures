using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Stack_Queue
{
    public class node
    {
        public int data;
        public node next;

        public node(int data) { 
        
            this.data = data;
            this.next = null;
        
        }
    }
}
