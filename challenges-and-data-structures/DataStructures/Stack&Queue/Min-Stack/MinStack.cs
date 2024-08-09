using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Stack_Queue
{
    public class MinStack :Stack_
    {
        public int GetMin() {

            if (isEmpty())
                return -1;
            Stack_ stack_=new Stack_();
            int mini = int.MaxValue;
            while (!isEmpty()) {

                stack_.push(pop());
                if(stack_.peek()<mini)
                    mini = stack_.peek();
            }

            while (!stack_.isEmpty()) {
                push(stack_.pop());
            }

            return mini;
        
        }
    }
}
