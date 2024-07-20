using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.LinkedList
{
    public class linkedList
    {
        private Node Head;
        private int size;
        public linkedList() {
            this.size = 0;
            this.Head = null;
        }

        public bool Empty {
            get { return this.size == 0; }
        }

        public int Size{
            get { return this.size;}
        }
        // 0    1    2     3
        // 1 -> 2 -> 5 -> 8
        // head
        public bool addFirst(int num) { 
            Node newNode= new Node();
         //   newNode.Data = num;
            newNode.Next = Head;
            Head = newNode;
            return true;
        }

        public bool addLast(int num) {

            Node newNode = new Node();
            newNode.Data = num;

            if (Head == null)
                Head = newNode;
            else
            {
                Node current = Head;
                while (current.Next != null)
                    current = current.Next;

                current.Next = newNode;
               // current.Next.Data = num;
            }
            size++;
            return true;
        }

        public bool remove(int num) {
            Node current= Head;
            if (current.Data == num)
            {
                 Head=current.Next;
                Head.Next=current.Next.Next;
                return true;
            }
            while(current.Data!=num&&current.Next.Next!=null)
                current = current.Next; 

            if(current.Next==null)
                return false;   

            current.Next=current.Next.Next; 
            return true;
        }

        public bool removeFirst() { 

            Node current=Head;
            if (Head == null)
                return false;
            else {
                Head=current.Next;
                current.Next = current.Next.Next;
            return true ;
            }
        }

        public bool removeLast() {

            Node current = Head;
            if (Head == null) return false;
            else
            {
                while (current.Next.Next != null)
                    current = current.Next;
                current.Next = null;
                return true;

            }
        }

        //5 -> 20 -> 20 -> 10 -> 5 -> 10 -> Null
        //                 c   in
        // 111   2   555  6   6   6   
        public bool removeDuplicates() {

            Node current = Head;
            while (current != null) {
                Node index = current.Next;
                Node prev = current;
                while (index != null) {
                    if (current.Data == index.Data)
                    {
                        prev.Next = index.Next;
                    }
                    else { 
                    prev=index;
                    }
                 index = index.Next;
                }
             
            current = current.Next;
            }
            return true; 
        
        }

        public void Print() { 
            Node current= Head;
            while (current != null) { 
            Console.WriteLine(current.Data);
                current = current.Next; 
            }
        }

        public bool Includes(int num) {
            Node current=Head;

            if (current.Data == num) { 
            return true;    
            }
           
            while(current.Data!=num&&current.Next!=null)
                current = current.Next;
            if (current.Data == num)
                return true;

            return false;

        }
        // 10 20 30    l1
        // 5  15 25 35  l2
        public void MergeSorted(linkedList l1,linkedList l2) {

            if (l1.Head == null)
            {
                l1.Head = l2.Head;
                return;
            }
            else if (l2.Head == null)
            {
                return;
            }

            Node dummy = new Node(); // Dummy node
            Node tail = dummy;
            Node current1 = l1.Head;
            Node current2 = l2.Head;

            while (current1 != null && current2 != null)
            {
                if (current1.Data < current2.Data)
                {
                    tail.Next = current1;
                    current1 = current1.Next;
                }
                else
                {
                    tail.Next = current2;
                    current2 = current2.Next;
                }
                tail = tail.Next;
            }

            if (current1 != null)
            {
                tail.Next = current1;
            }
            else
            {
                tail.Next = current2;
            }

            l1.Head = dummy.Next;
        }


        public void printList()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}
