using challenges_and_data_structures.DataStructures.LinkedList;
using challenges_and_data_structures.DataStructures.Tree_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class BT_Test
    {
        [Fact]
        public void Inorder_Test() {

            BinaryTree tree = new BinaryTree(10);
            tree.Insert(4);
            tree.Insert(8);
            tree.Insert(16);
            tree.Insert(40);

            string expectedRes = "4\r\n8\r\n10\r\n16\r\n40";
            var sw = new StringWriter();

            Console.SetOut(sw);

                tree.Inorder();

                string res = sw.ToString().Trim();

                Assert.Equal(expectedRes, res);
        }
          [Fact]
        public void Preorder_Test() {

            BinaryTree tree = new BinaryTree(10);
            tree.Insert(4);
            tree.Insert(8);
            tree.Insert(16);
            tree.Insert(40);

            string expectedRes = "10\r\n4\r\n8\r\n16\r\n40";
            var sw = new StringWriter();

            Console.SetOut(sw);

                tree.Preorder();

                string res = sw.ToString().Trim();

                Assert.Equal(expectedRes, res);
        }

          [Fact]
        public void Postorder_Test() {

            BinaryTree tree = new BinaryTree(10);
            tree.Insert(4);
            tree.Insert(8);
            tree.Insert(16);
            tree.Insert(40);

            string expectedRes = "8\r\n4\r\n40\r\n16\r\n10";
            var sw = new StringWriter();

            Console.SetOut(sw);

                tree.Postorder();

                string res = sw.ToString().Trim();

                Assert.Equal(expectedRes, res);
        }

    }
    }

