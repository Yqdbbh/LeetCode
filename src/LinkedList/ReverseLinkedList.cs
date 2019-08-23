// 206. Reverse Linked list          Easy
// Reverse a singly linked list.

// Example:

// Input: 1->2->3->4->5->NULL
// Output: 5->4->3->2->1->NULL
// Follow up:

// A linked list can be reversed either iteratively or recursively. Could you implement both?

namespace LeetCode{

    /// <summary>
    ///  反转单链表：还是看的答案
    ///     https://leetcode-cn.com/articles/reverse-linked-list/
    /// </summary>
    public class ReverseLinkedList {

        /// <summary>
        /// -->A-->B-->C-->D-->
        /// 1. 假如当前节点为B,此时pre为A
        /// 2. BNext=B.next=C;保存到下一个节点的引用 
        /// 3. B.next=pre;  变成 -->A<-->B  C-->   
        ///     断开了B-->C，类推，A-->B在上一次也是断掉的  应为 -->A<--B  C-->D--> ，
        ///     pre初始为null,此时链表应该为  <--A<--B   C-->D-->
        /// 4. 下一次该建立B<--C 的连接，则 改变指针，pre=B;
        /// 5. 当前节点改为C,重复1-5
        /// 
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head) {
            ListNode pre = null;
            ListNode curr = head;
            ListNode currNext ;
            while(curr!=null){
                currNext = curr.next; // 保存当前节点的后继
                curr.next = pre; // 反转：将当前节点的后继改为当前节点的前驱
                pre = curr; // 重置前一个节点指针
                curr = currNext; // 移动至下一个节点
            }
            return pre;
        }
    }
}