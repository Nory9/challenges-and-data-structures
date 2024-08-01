using challenges_and_data_structures.DataStructures.Stack_Queue.ReverseStackUsingQueue;
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
            StackWithReverse stack_ = new StackWithReverse();
            stack_.push(7);
            stack_.push(2);
            stack_.push(3);
            stack_.push(4);
            stack_.push(5);
            stack_.ReverseStack();
            stack_.print();
        }
    }
}
