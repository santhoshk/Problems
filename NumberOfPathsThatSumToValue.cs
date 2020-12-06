using System;
using System.Collections.Generic;
using System.Text;

namespace Algs {
    /*In a binary tree, Count the number of paths from parent to downwards that
     sum to a given value.*/
    public class Node {
        public int Value;
        public Node Left;
        public Node Right;
    }
    public class NumberOfPathsThatSumToValue {
        static Dictionary<int, int> prefixSums = new Dictionary<int, int>();

        public static int PathCount(Node rootNode, int targetSum) {
            return PathCount(rootNode, targetSum, 0);
        }

        public static int PathCount(Node root, int targetSum, int sumSoFar) {

            if (root == null) return 0;

            int rootCount = 0;
            if (sumSoFar + root.Value == targetSum) {
                rootCount = 1;
            }

            int prefixNeeded = sumSoFar - targetSum;
            int nonRootCount = 0;
            if (!prefixSums.ContainsKey(prefixNeeded)) {
                prefixSums[prefixNeeded] = 0;
            }
            nonRootCount = prefixSums[prefixNeeded];
            prefixSums[sumSoFar + root.Value]++;

            var lCount = PathCount(root.Left, targetSum, sumSoFar + root.Value);
            var rCount = PathCount(root.Right, targetSum, sumSoFar + root.Value);

            prefixSums[sumSoFar + root.Value]--;

            return lCount + rCount + rootCount + nonRootCount;
        }
    }
}
