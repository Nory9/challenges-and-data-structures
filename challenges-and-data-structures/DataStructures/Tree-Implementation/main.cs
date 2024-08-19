
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
            SecondMaxValueC max = new SecondMaxValueC(10);

            max.Insert(30);
            max.Insert(1);
            max.Insert(28);
            max.Insert(4);
            max.Insert(17);
            max.Insert(5);

          max.SecondMax();
      //    Console.WriteLine(t);

        }
    }
}
