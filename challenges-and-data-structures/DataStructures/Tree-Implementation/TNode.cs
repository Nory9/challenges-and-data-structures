using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Tree_Implementation
{
    public class TNode
    {
        public int value { get; set; }
        public TNode Left { get; set; }
        public TNode Right { get; set; }
        public TNode(int value=0) { 
       
            this.value = value;
            Left = null;
            Right = null;
        }

    }
}
