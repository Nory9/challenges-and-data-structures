using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Tree_Implementation.MirrorTree
{
    public class MirrorTreeClass : BinaryTree
    {
        public MirrorTreeClass(int value) : base(value)
        {
        }

        public void recverseTree() {

            reverseTreee(root);
        }
        public void reverseTreee(TNode root) { 
            if(root== null)
                return;
            TNode temp= root.Left;
            root.Left=root.Right;
            root.Right=temp;

            reverseTreee(root.Left);
            reverseTreee(root.Right);
        }
    }
}
