using challenges_and_data_structures.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Stack_Queue
{
    public class Queue_
    {
        node rear;
      public  node front;
        public Queue_()
        {
            front = rear = null;
        }
        public void enqueue(int data) {

            node newNode = new node(data);

            if (isEmpty())
            {
                front = rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
        }

        public int dequeue() {

            if (isEmpty())
            {
                throw new Exception("Queue is empty.");
            }

            int dequeuedData = front.data;
            front = front.next;

            if (front == null)
            {
                rear = null;
            }

            return dequeuedData;
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
