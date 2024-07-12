using challenges_and_data_structures.DataStructures.LinkedList;
using System.Xml.Linq;

namespace challenges_and_data_structures
{
    public class main
    {


        public static void Main(string[] args)
        {
           linkedList linkedList = new linkedList();
            linkedList.addFirst(111);
            linkedList.addLast(2);
            linkedList.addLast(555);
            linkedList.addLast(6);
            linkedList.removeLast();
            linkedList.removeFirst();
             linkedList.Print();
            Console.WriteLine(linkedList.Includes(66));
            
        }

       
    }
}