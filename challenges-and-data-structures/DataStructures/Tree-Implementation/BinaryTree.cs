using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Tree_Implementation
{
    public class BinaryTree : BinarySearchTree
    {

        public BinaryTree(int value) : base(value) { }

        // left root right
        public void Inorder()
        {
            Inorder(root);
        }
        public void Inorder(TNode node) {
            if (node == null) return;
            Inorder(node.Left);
            Console.WriteLine(node.value);
            Inorder(node.Right);
        }

        public void Preorder()
        {
            Preorder(root);
        }
        // root left right
        public void Preorder(TNode node) {
            if (node == null) return;
            Console.WriteLine(node.value);
            Preorder(node.Left);
            Preorder(node.Right);
        }
        public void Postorder()
        {
            Postorder(root);
        }
        // left right root
        public void Postorder(TNode node) {
            if (node == null) return;
            Postorder(node.Left);
            Postorder(node.Right); 
            Console.WriteLine(node.value);
        }

    }
}
