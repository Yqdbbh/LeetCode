// 203. Remove Linked List elements     ___Easy
// Remove all elements from a linked list of integers that have value val.

// Example:

// Input:  6->2->6->3->4->5->6, val = 6
// Output: 6->2->3->4->5

namespace LeetCode{

    public class RemoveLinkedListElements{

        /// <summary>
        /// 链表的删除操作
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ListNode RemoveElements(ListNode head, int val) {
            var pre = head; // 前一个节点
            var pointer = head; // 当前节点
            while(pointer!=null){
                if(head.val==val){   // 删除[6,6,6,1,2] 6 这样的数据
                    pre = pointer = head = head.next;
                    continue;
                }
                if(pointer.val==val){  // 匹配，删除当前节点，
                    pre.next = pointer.next; // 当前节点的前驱只指向当前节点的后继
                }else{
                    pre = pointer;
                }
                pointer = pointer.next; // 移动指针
            }
            return head;
        }
    }
}