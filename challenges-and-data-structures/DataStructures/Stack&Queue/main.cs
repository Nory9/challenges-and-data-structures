using challenges_and_data_structures.DataStructures.Stack_Queue.ReverseStackUsingQueue;
using challenges_and_data_structures.DataStructures.Stack_Queue.DeleteMiddleElement;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Stack_Queue
{
    public class main
    {
        public static void Main(string[] args)
        {
            
            MinStack stack = new MinStack();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
           // stack.print();
            Console.WriteLine( stack.GetMin());

        }
    }
}
