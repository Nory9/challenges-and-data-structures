using challenges_and_data_structures.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Stack_Queue
{
    public class Stack_
    {
         public node top = null;
        int Size = 0;
        public void push(int data)
        {
            node newNode = new node(data);
            newNode.next = top;
            top = newNode;
            Size++;
        }

        public int pop() {

            if (isEmpty())
            {
                throw new Exception("Stack is empty.");
            }

            int poppedData = top.data;
            top = top.next;
            Size--;
            return poppedData;
        }

        public bool isEmpty() { 
        
        return top == null; 
        }

        public int peek()
        {

            if(top==null)
                return -1;
            else
            {
                return top.data;
            }
            return 0;

        }

        public int Count() { 
            return Size;
        
        }

        public void print() {

            while (top != null)
            {
             
                Console.WriteLine(top.data);
                top=top.next;
            }

        }
    }
}
