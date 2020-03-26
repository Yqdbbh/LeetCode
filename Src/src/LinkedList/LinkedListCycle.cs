// 141. Linked List Cycle Easy
// Given a linked list, determine if it has a cycle in it.

// To represent a cycle in the given linked list, we use an integer pos which represents the position (0-indexed) in the linked list where tail connects to. If pos is -1, then there is no cycle in the linked list.

// Example 1:

// Input: head = [3,2,0,-4], pos = 1
// Output: true
// Explanation: There is a cycle in the linked list, where tail connects to the second node.


// Example 2:

// Input: head = [1,2], pos = 0
// Output: true
// Explanation: There is a cycle in the linked list, where tail connects to the first node.


// Example 3:

// Input: head = [1], pos = -1
// Output: false
// Explanation: There is no cycle in the linked list.

// Follow up:

// Can you solve it using O(1) (i.e. constant) memory?

namespace LeetCode{
    public class LinkedListCycle{
        /// <summary>
        /// 检查是否有环 
        /// 方案：
        ///     1.存储已经遍历节点
        ///     2.快慢指针
        ///     3.反转链表
        /// 参考：
        ///     https://blog.csdn.net/qq_41231926/article/details/86090509
        ///     https://blog.csdn.net/qq_17550379/article/details/83866566
        ///     https://leetcode.com/problems/linked-list-cycle/discuss/44600/97.37-c-solution
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(ListNode head) {
            if(head==null || head.next==null) return false;
            ListNode fast = head;
            ListNode slow = head;
            while(fast.next!=null){
                fast = fast.next.next; 
                if(fast==null)
                    return false;
                slow = slow.next;
                if(slow==fast)
                    return true;
            }
            return false;
        }
    }
}
