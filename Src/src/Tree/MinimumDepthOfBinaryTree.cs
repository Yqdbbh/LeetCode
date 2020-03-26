// 111. Minimum Depth of Binary Tree
// Given a binary tree, find its minimum depth.
// The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
// Note: A leaf is a node with no children.
// Example:
// Given binary tree [3,9,20,null,null,15,7],
//     3
//    / \
//   9  20
//     /  \
//    15   7
// return its minimum depth = 2.

using System;

namespace LeetCode{
    /// <summary>
    /// 求二叉树的最小深度，抄的答案
    /// https://leetcode.com/problems/minimum-depth-of-binary-tree/discuss/36129/C-recursion-4-lines
    /// </summary>
    public class MinimumDepthOfBinaryTree{
        public int MinDepth(TreeNode root) {
            if(root == null) 
                return 0;

            if(root.left == null) 
                return 1+MinDepth(root.right);

            if(root.right == null)
                return 1 + MinDepth(root.left);

            var left = MinDepth(root.left);
            var right = MinDepth(root.right);
            return 1 + Math.Min(left, right);
        }
    }
}