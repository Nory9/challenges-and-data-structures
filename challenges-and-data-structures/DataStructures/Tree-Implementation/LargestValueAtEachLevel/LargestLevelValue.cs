using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Tree_Implementation.LargestValueAtEachLevel
{
    public class LargestLevelValue : BinaryTree
    {
        public LargestLevelValue(int value) : base(value)
        {
        }

        public List<int> FindLargestValuesAtEachLevel()
        {
            List<int> largestValues = new List<int>();
            if (root == null)
                return largestValues;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxAtLevel = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    TNode currentNode = queue.Dequeue();
                    if (currentNode.value > maxAtLevel)
                        maxAtLevel = currentNode.value;

                    if (currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);

                    if (currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);
                }

                largestValues.Add(maxAtLevel);
            }

            return largestValues;
        }
    }
}
