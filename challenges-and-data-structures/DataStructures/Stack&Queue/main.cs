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
            DeleteMiddleElementC stack = new DeleteMiddleElementC();
            stack.push(7);
            stack.push(14);
            stack.push(3);
            stack.push(8);
            stack.push(5);
            stack.DeleteMiddleE();
            stack.push(2);
            stack.push(9);
            stack.push(11);
            stack.DeleteMiddleE();
            stack.print();
        }
    }
}
