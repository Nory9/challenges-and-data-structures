
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
            RightView tree = new RightView(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(-1);
            tree.Insert(1);

            List<int> res= tree.FindRight();
            foreach(int i in res)
                Console.WriteLine(i);


            //    Console.WriteLine(t);

        }
    }
}
