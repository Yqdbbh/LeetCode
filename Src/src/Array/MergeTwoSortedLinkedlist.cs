// Question 21:
// Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

// Example:

// Input: 1->2->4, 1->3->4
// Output: 1->1->2->3->4->4

namespace LeetCode{

    class MergeTwoSortedLinkedlist{
        public ListNode test(ListNode l1, ListNode l2) {
            if(l1==null) return l2;
            if(l2==null) return l1;
            //赋初始值
            int i=0;
            if(l1.val<=l2.val){
                i=l1.val;
                l1=l1.next;
            }else{
                i=l2.val;
                l2=l2.next;
            }
            ListNode result=new ListNode(i); //头
            ListNode pointer=result;//模拟指针，总是指向当前节点
            while(l1!=null&&l2!=null){ //取完一个序列就停止取值
                if(l1.val<=l2.val){
                    pointer.next=new ListNode(l1.val);
                    l1=l1.next;
                }else{
                    pointer.next=new ListNode(l2.val);
                    l2=l2.next;
                }
                pointer=pointer.next;
            }
            if(l1!=null){ //l1有剩余值
                pointer.next=l1; 
            }else{
                pointer.next=l2;
            }
            //ListNode l1n=l1.next;//l1的最小值
            return result;
        }
    }
}
// 2019-04-16
// Runtime: 92 ms, faster than 99.95% of C# online submissions for Merge Two Sorted Lists.
// Memory Usage: 23.7 MB, less than 44.61% of C# online submissions for Merge Two Sorted Lists.

// 
// From mrwiti. Fastest Answer
// public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
//          if(l1 == null) return l2;
//          if(l2 == null) return l1;
         
//          if(l1.val < l2.val)
//          {
//              l1.next = MergeTwoLists(l1.next,l2);
//              return l1;
//          }
         
//          l2.next =  MergeTwoLists(l1,l2.next);
//          return l2;
// }