//83.RemoveDuplicatesfromSortedList
//Given a sorted linked list, delete all duplicates such that each element appear only once.

//Example 1:

//Input: 1->1->2
//Output: 1->2
//Example 2:

//Input: 1->1->2->3->3
//Output: 1->2->3
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class RemoveDuplicatesfromSortedList
    {
        //1，1，1
        public ListNode DeleteDuplicates(ListNode head)
        {
            //if (head == null) return null;
            ListNode result = head;
            while (head!=null&&head.next!=null)
            {
                if (head.next.val == head.val)
                    head.next = head.next.next;
                else
                    head = head.next;
            }
            return result ;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
    
}
