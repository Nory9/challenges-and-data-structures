
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Tree_Implementation
{
    public class BinarySearchTree
    {
        public TNode root { get; set; }
        public BinarySearchTree(int value) {

            root = new TNode(value);
        }

        public TNode Insert(int value) {

            return Insert(root, value);
        }


        public TNode Insert(TNode node, int value) {

            if(node==null)
                return new TNode(value);
            if (value < node.value)
            {
                if (node.Left == null)
                    node.Left =new TNode(value);
                else
                    Insert(node.Left, value);

            }
            else { 
                if(node.Right==null)
                    node.Right=new TNode(value);
                else
                    Insert(node.Right, value);
        
            }
            return node;
        }

        public bool Contains(int value) {
           return  Contains(root, value);
        
        }
        public bool Contains(TNode node, int value) {
            if (node == null)
                return false;
            if (node.value == value)
                return  true;

            bool left_res = Contains(node.Left, value);
            bool right_res = Contains(node.Right, value);

            return left_res || right_res;

        
        }


        public TNode remove(int value) {

          return Remove(root, value);
        }

        public TNode Remove(TNode node, int value)
        {
            if (node == null) return null;

            if (value < node.value)
            {
                node.Left = Remove(node.Left, value);
            }
            else if (value > node.value)
            {
                node.Right = Remove(node.Right, value);
            }
            else
            {
                // Node to be deleted is found

                // Case 1: Node has no children (leaf node)
                if (node.Left == null && node.Right == null)
                {
                    return null;
                }
                // Case 2: Node has only one child
                if (node.Left == null)
                {
                    return node.Right;
                }
                if (node.Right == null)
                {
                    return node.Left;
                }
                // Case 3: Node has two children
                TNode minNode = findMin(node.Right); // Find the in-order successor
                node.value = minNode.value; // Replace the value with the in-order successor's value
                node.Right = Remove(node.Right, minNode.value); // Remove the in-order successor
            }
            return node;
        }



        public TNode findMin(TNode node) {

            while (node.Left != null) { 
                node = node.Left;
            }
            return node;
        }
    }
}
