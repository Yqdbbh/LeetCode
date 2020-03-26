//100.Same Tree
//Given two binary trees, write a function to check if they are the same or not.

//Two binary trees are considered the same if they are structurally identical and the nodes have the same value.

//Example 1:

//Input:     1         1
//          / \       / \
//         2   3     2   3

//        [1,2,3], [1,2,3]

//Output: true
//Example 2:

//Input:     1         1
//          /           \
//         2             2

//        [1,2], [1,null,2]

//Output: false
//Example 3:

//Input:     1         1
//          / \       / \
//         2   1     1   2

//        [1,2,1], [1,1,2]

//Output: false

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            string pDLR = PreorderTraversal(p);
            string pLDR = InorderTraversal(p);
            string qDLR = PreorderTraversal(q);
            string qLDR = InorderTraversal(q);
            Console.WriteLine("pLDR：" + pLDR);
            Console.WriteLine("qLDR：" + qLDR);
            Console.WriteLine("pDLR：" + pDLR);
            Console.WriteLine("qDLR：" + qDLR);
            return pDLR == qDLR && pLDR == qLDR;
        }

        /// <summary>
        /// 二叉树前序遍历 DLR
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public string PreorderTraversal(TreeNode tree)
        {
            if (tree == null) return "";
            string res = ""+tree.val+",";
            if (tree.left != null)
            {
                res+=PreorderTraversal(tree.left);
            }
            res += ",";
            if (tree.right != null)
            {
                res += PreorderTraversal(tree.right);
            }
            res += ",";
            return res;
        }
        
        /// <summary>
        /// 中序遍历 LDR
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public string InorderTraversal(TreeNode tree)
        {
            if (tree == null) return "";
            string res = "";
            if (tree.left != null)
            {
                res += InorderTraversal(tree.left);
            }
            res += ",";
            res += tree.val+",";
            if (tree.right != null)
            {
                res += InorderTraversal(tree.right);
            }
            res += ",";
            return res;
        }
        
    }
}

/// 1 Line
/// https://leetcode.com/problems/same-tree/discuss/32766/C-recursive-1-liner
//public bool IsSameTree(TreeNode p, TreeNode q)
//{
//    return (p == null && q == null) ||
//            (p != null && q != null && p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
//}

///
/// faster
/// https://leetcode.com/problems/same-tree/discuss/131361/C-Recursive-Solution-Beats-99
//public bool IsSameTree(TreeNode p, TreeNode q)
//{
//    if (p == null && q == null) return true;
//    if (p == null) return false;
//    if (q == null) return false;

//    return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);

//}