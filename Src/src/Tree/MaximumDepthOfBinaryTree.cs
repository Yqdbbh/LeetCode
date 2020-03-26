
//104.Maximum Depth Of Binary Tree  
//Given a binary tree, find its maximum depth.

//The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

//Note: A leaf is a node with no children.

//Example:

//Given binary tree[3, 9, 20, null, null, 15, 7],

//    3
//   / \
//  9  20
//    /  \
//   15   7
//return its depth = 3.

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 求二叉树最大深度
    /// 2019-04-22
    /// </summary>
    class MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            return getHeigth(root.left,root.right,0,0);
        }

        /// 
        /// 遍历二叉树，如果子节点不为null,则深度+1 ,总感觉写的有问题，但测试居然通过了！
        /// 
        private int getHeigth(TreeNode left, TreeNode right, int lh, int rh)
        {
            /// 左右子树均不为空
            if (left != null && right !=null)
            {
                int l= getHeigth(left.left, left.right,lh,rh );
                int r=getHeigth(right.left, right.right, lh,rh);
                return (l >= r ? l : r)+1;
            }else if (left != null)
            {
                int l = getHeigth(left.left, left.right, lh, rh);
                return (l > rh ? l : rh)+1;
            }else if (right != null)
            {
                int r = getHeigth(right.left, right.right, lh, rh);
                return (r > lh ? r : lh)+1;
            }
            return (lh > rh ? lh : rh)+1;
        }
    }
}

/// Best Answer
/// https://leetcode.com/problems/maximum-depth-of-binary-tree/discuss/34216/Simple-solution-using-Java
/// public int maxDepth(TreeNode root)
/// {
///    if (root == null)
///    {
///        return 0;
///    }
///    return 1 + Math.max(maxDepth(root.left), maxDepth(root.right));
/// }