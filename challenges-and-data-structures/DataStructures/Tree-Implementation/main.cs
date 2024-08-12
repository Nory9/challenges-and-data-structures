
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace challenges_and_data_structures.DataStructures.Tree_Implementation
{
    public class main
    {
        static void Main(string[] args)
        {
            BinaryTree bst= new BinaryTree(10);
            bst.Insert(2);
            bst.Insert(31);
            bst.Insert(5);
            bst.Insert(12);
            bst.Insert(23);
            bst.remove(10);
            bst.Inorder();
        }
    }
}
