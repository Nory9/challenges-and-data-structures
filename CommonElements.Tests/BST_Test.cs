using challenges_and_data_structures.DataStructures.Tree_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class BST_Test
    {
        [Fact]
        public void InsertTest() {

            BinarySearchTree tree = new BinarySearchTree(10);
            TNode n= tree.Insert(1);
            Assert.NotNull(n);

        
        }

         [Fact]
        public void DeleteTest() {

            BinarySearchTree tree = new BinarySearchTree(10);
            tree.Insert(7);
            tree.Insert(1);
            TNode n = tree.remove(1);
            Assert.NotNull(n);

        
        }
         [Fact]
        public void ContainsTest() {

            BinarySearchTree tree = new BinarySearchTree(10);
            tree.Insert(7);
            tree.Insert(1);
            bool res= tree.Contains(1);
            Assert.True(res);

        
        }

    }
}
