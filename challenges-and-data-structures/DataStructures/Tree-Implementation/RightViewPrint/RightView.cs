using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Tree_Implementation
{
    public  class RightView : BinarySearchTree
    {

        public RightView(int value) : base(value)
        {
        }

        public List<int> FindRight() {
            List<int> RightNodes = new List<int>();
            FindRight(ref RightNodes ,root, 0);
            return RightNodes;
        }

        public void FindRight(ref List<int> RightNodes,TNode root, int level) {

            if (root == null)
                return;

            if (level == RightNodes.Count)
                RightNodes.Add(root.value);

            FindRight(ref RightNodes,root.Right, level+1);
            FindRight(ref RightNodes, root.Left, level+1);


        }
    }
}
