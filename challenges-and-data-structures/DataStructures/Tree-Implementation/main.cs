
using challenges_and_data_structures.DataStructures.Tree_Implementation.LeafSum;
using challenges_and_data_structures.DataStructures.Tree_Implementation.MirrorTree;
using challenges_and_data_structures.DataStructures.Tree_Implementation.SecondMaxValue;
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
            LeafNodesSum s = new LeafNodesSum(10);
            s.Insert(9);
            s.Insert(12);
            s.Insert(17);
            s.Insert(23);
            s.Insert(6);
            s.Insert(8);
            s.Insert(3);
            s.Insert(15);
            s.SumOfLeafNodes();

      //    Console.WriteLine(t);

        }
    }
}
