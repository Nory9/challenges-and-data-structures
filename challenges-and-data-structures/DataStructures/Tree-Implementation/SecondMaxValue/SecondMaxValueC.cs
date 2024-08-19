using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Tree_Implementation.SecondMaxValue
{
    public class SecondMaxValueC : BinaryTree
    {
        public SecondMaxValueC(int value) : base(value)
        {
        }

        public void SecondMax() {
            int c = 0;
          SecondMax(root, ref c);
        }

        public void SecondMax(TNode node, ref int c) {
           
            if (node == null || c >= 2)
                return ;

            SecondMax(node.Right,ref c );
            c++;

            if (c == 2) {
                Console.WriteLine(node.value);
                return ;
            }

            SecondMax(node.Left,ref c ); 

        }
    }
}
