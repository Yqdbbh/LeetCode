// 112. Path Sum
// Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.

// Note: A leaf is a node with no children.

// Example:

// Given the below binary tree and sum = 22,

//       5
//      / \
//     4   8
//    /   / \
//   11  13  4
//  /  \      \
// 7    2      1
// return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.

namespace LeetCode{
    /// <summary>
    /// 判断二叉树是否包含一条从根到叶子节点的路径，使得路径上各节点的和等于给定值
    /// </summary>
    public class PathSum{
        /// <summary>
        /// 前序遍历二叉树，计算路径上的和
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool HasPathSum(TreeNode root, int sum) {
            if(root==null) return false;
            if(root.left==null&& root.right==null){
                return sum == root.val;
            }
            sum -= root.val;
            //if(sum<0) return false;
            bool left=false, right=false;
            if(root.left!=null){
                left=HasPathSum(root.left, sum);
                if(left) return true;
            }
            if(root.right!=null){
                right=HasPathSum(root.right, sum);
                if(right) return true;
            }
            return left||right;
        }
    }
}