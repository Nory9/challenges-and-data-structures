
using challenges_and_data_structures.DataStructures.Tree_Implementation.MirrorTree;
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
            MirrorTreeClass t = new MirrorTreeClass(5); //root
            t.Insert(19);
            t.Insert(3);
            t.Insert(20);
            t.Insert(1);
            t.Insert(2);
            t.Insert(4);
            t.Insert(15);
            t.Insert(16);
            t.Insert(9);
            t.Insert(10);
            t.recverseTree();
            t.Inorder();
        }
    }
}
