using challenges_and_data_structures.DataStructures.LinkedList;
using System.Xml.Linq;

namespace challenges_and_data_structures
{
    public class main
    {


        public static void Main(string[] args)
        {
           linkedList linkedList = new linkedList();
            linkedList.addFirst(20);
            linkedList.addLast(20);
            linkedList.addLast(20);
            linkedList.addLast(10);
            linkedList.addLast(5);
            linkedList.addLast(10);     
            linkedList.removeDuplicates();  
          //  linkedList.removeLast();
           // linkedList.removeFirst();
             linkedList.Print();
            Console.WriteLine(linkedList.Includes(66));
            
        }

       
    }
}