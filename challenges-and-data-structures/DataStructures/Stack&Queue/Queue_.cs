using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Stack_Queue
{
    public class Queue_
    {
        node rear=null;
        node front =  null;
        public bool enqueue(int data) {

            node newNode = new node(data);
            if (rear == null)
                front = rear = newNode;
            else { 
            
                rear.next= newNode;
                rear= newNode;
            
            }
            return true;
        }

        public int dequeue() {

            if (front == null)
                return -1;
            else
            {
                front = front.next;
                if (front == null)
                { 
                    rear=null;
                    return -1;
                 
                }
                else
                    return front.data;
            }
        }

        public int peek() {

            if (front == null)
                return -1;
            else
                return front.data;
        }

        public bool isEmpty() {

            return rear == null;
        }

        public void print()
        {

            while (front != null)
            {

                Console.WriteLine(front.data);
                front = front.next;
            }

        }
    }
}
