using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Stack_Queue.ReverseStackUsingQueue
{
    public class StackWithReverse : Stack_ 
    {
        public void ReverseStack() { 

            if(isEmpty()||top.next==null)
                return;
            Queue_ queue_ = new Queue_ ();

            while (!isEmpty()) {
                queue_.enqueue(pop());
            }
            while (!queue_.isEmpty()) {
                push(queue_.dequeue());

                    }
           
        }
     
    }
}
