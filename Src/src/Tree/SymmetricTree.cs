/// 101.SymmetricTree
// Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).

//For example, this binary tree [1,2,2,3,4,4,3] is symmetric:

//    1
//   / \
//  2   2
// / \ / \
//3  4 4  3
//But the following[1, 2, 2, null, 3, null, 3] is not:
//    1
//   / \
//  2   2
//   \   \
//   3    3
//Note:
//Bonus points if you could solve it both recursively and iteratively.

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            return InorderTraversal (root)== ReInorderTraversal(root);
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

        /// <summary>
        /// 逆中序遍历 RDL
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public string ReInorderTraversal(TreeNode tree)
        {
            if (tree == null) return "";
            string res = "";
            if (tree.right != null)
            {
                res += ReInorderTraversal(tree.right);
            }
            res += ",";
            res += tree.val + ",";
            if (tree.left != null)
            {
                res += ReInorderTraversal(tree.left);
            }
            res += ",";
            return res;
        }
    }
}
// Same To 100 

// Batter answer
// https://leetcode.com/problems/symmetric-tree/discuss/276123/C-Straight-forward-and-easy-to-understand-92ms-beat-100
//public bool IsSymmetric(TreeNode root)
//{
//    if (root == null) return true;

//    return checkSym(root.left, root.right);
//}

//private bool checkSym(TreeNode root1, TreeNode root2)
//{
//    if (root1 == null && root2 == null) return true;

//    if (root1 == null || root2 == null) return false;

//    if (root1.val != root2.val) return false;

//    return checkSym(root1.left, root2.right) & checkSym(root1.right, root2.left);
//}