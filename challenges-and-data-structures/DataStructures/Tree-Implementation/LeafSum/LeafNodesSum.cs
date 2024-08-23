using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Tree_Implementation.LeafSum
{
    public class LeafNodesSum : BinaryTree
    {
        public LeafNodesSum(int value) : base(value)
        {
        }

        public void SumOfLeafNodes() {

            int sum = 0;
            SumOfLeafNodes(root, ref sum);
            Console.WriteLine(sum);
        }
        
        public void SumOfLeafNodes(TNode root, ref int sum) {

            if (root == null)
                return;
            if (root.Right == null&& root.Left==null)
            {
                sum += root.value;
                return;
            }
           
                SumOfLeafNodes(root.Right,ref sum);
                SumOfLeafNodes(root.Left, ref sum);
        }
    }
}
