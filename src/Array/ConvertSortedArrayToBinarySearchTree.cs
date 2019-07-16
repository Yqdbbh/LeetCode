// 108. Convert Sorted Array to Binary Search Tree
// Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
// For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.

// Example:
// Given the sorted array: [-10,-3,0,5,9],
// One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:
//       0
//      / \
//    -3   9
//    /   /
//  -10  5

using System;
namespace LeetCode{
    /// <summary>
    /// 有序数组转B树
    /// </summary>
    public class ConvertSortedArrayToBinarySerachTree{

        /// <summary>
        /// 有序数组转B树
        /// </summary>
        /// <param name="nums">数组</param>
        /// <returns>转换后的根节点</returns>
        public TreeNode SortedArrayToBST(int[] nums)
        {
            int length = nums.Length;
            if(length==0) return null;
            TreeNode node = new TreeNode(nums[length / 2]);
            if (length > 2){
                int[] leftSub = new int[length / 2];
                int[] rightSub = new int[length / 2-(length + 1) % 2];
                Array.Copy(nums, leftSub, leftSub.Length);
                node.left = SortedArrayToBST(leftSub);
                Array.ConstrainedCopy(nums, length / 2+1, rightSub, 0, rightSub.Length);
                node.right = SortedArrayToBST(rightSub);
            }else if(length==2){
                node.left = new TreeNode(nums[0]);
            }
            return node;
        } // End SortedArrayToBST 效率有一点慢 120ms  24.8MB 进行了大量数组复制操作，开辟了太多数组空间，浪费内存
        
        /// <summary>
        /// 更优解  
        /// 来自：https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/discuss/35377/Recursive-C-Solution-Beats-92
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public TreeNode SortedArrayToBST2(int[] nums) {
            if(nums.Length == 0) return null;
            return SortedArrayToBSTHelper(nums,0, nums.Length-1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums">原始数组</param>
        /// <param name="low">最小下标</param>
        /// <param name="high">最大下标</param>
        /// <returns></returns>
        private TreeNode SortedArrayToBSTHelper(int[] nums, int low, int high){
            int mid = (low + high)/2;
            TreeNode node = new TreeNode(nums[mid]);
            if( low < mid)
            {
                node.left = SortedArrayToBSTHelper(nums,low,mid-1);
            }
            if(mid < high)
            {
                node.right = SortedArrayToBSTHelper(nums,mid+1,high);
            }
            return node;
        }

    } 
}