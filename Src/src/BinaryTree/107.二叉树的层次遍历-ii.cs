/*
 * @lc app=leetcode.cn id=107 lang=csharp
 *
 * [107] 二叉树的层次遍历 II
 * 抄的，借鉴自
 * https://leetcode-cn.com/problems/binary-tree-level-order-traversal-ii/solution/san-chong-shi-xian-tu-jie-107er-cha-shu-de-ceng-ci/
 */
 using System.Collections.Generic;
namespace LeetCode {
    // @lc code=start
    /**
    * Definition for a binary tree node.
    * public class TreeNode {
    *     public int val;
    *     public TreeNode left;
    *     public TreeNode right;
    *     public TreeNode(int x) { val = x; }
    * }
    */
    public class Solution_107 {
        public IList<IList<int>> LevelOrderBottom(TreeNode root) {
            IList<IList<int>> result=new List<IList<int>>();
            if(root==null){
                return result;
            }
            Queue<TreeNode> queue=new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count>0){
                int length=queue.Count;
                var child=new List<int>();
                for(var i=0;i<length;i++){
                    var node=queue.Dequeue();
                    child.Add(node.val);
                    if(node.left!=null){
                        queue.Enqueue(node.left);
                    }
                    if(node.right!=null){
                        queue.Enqueue(node.right);
                    }
                }
                result.Insert(0,child);
                //result.Add(child);
            }
            return result;
        }
    }
    // @lc code=end
}


