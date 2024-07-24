using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Stack_Queue
{
    public class Stack_
    {
        node top = null;
        public bool push(int data)
        {
            node newNode = new node(data);
            if (top == null) { 
            top=newNode;
            }
            else
            {
               newNode.next = top;
                top=newNode;
            }
            return true;
        }

        public int pop() {

            if (top == null)
                return -1;
            else
            {
                if (top.next == null) {
                    top = null; return -1;
                }
                node temp=top.next;
                top = temp;
                
                return temp.data;
            }

          
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

        public void print() {

            while (top != null)
            {
             
                Console.WriteLine(top.data);
                top=top.next;
            }

        }
    }
}
