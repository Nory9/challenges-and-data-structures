using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Stack_Queue.DeleteMiddleElement
{
    public class DeleteMiddleElementC :Stack_
    {

        public void DeleteMiddleE() {
            int n = Count()/2;

            Stack_ stack_ = new Stack_ ();

            for (int i = 0; i < n; i++) {

               stack_.push(pop());
            }
            pop();
            while (!stack_.isEmpty()) {

                push(stack_.pop());
            }
        }
    }
}
