// 160. Intersection of Two Linked Lists    Easy
// Write a program to find the node at which the intersection of two singly linked lists begins.

// Example 1:
// Input: intersectVal = 8, listA = [4,1,8,4,5], listB = [5,0,1,8,4,5], skipA = 2, skipB = 3
// Output: Reference of the node with value = 8
// Input Explanation: The intersected node's value is 8 (note that this must not be 0 if the two lists intersect). From the head of A, it reads as [4,1,8,4,5]. From the head of B, it reads as [5,0,1,8,4,5]. There are 2 nodes before the intersected node in A; There are 3 nodes before the intersected node in B.

// Example 2:
// Input: intersectVal = 2, listA = [0,9,1,2,4], listB = [3,2,4], skipA = 3, skipB = 1
// Output: Reference of the node with value = 2
// Input Explanation: The intersected node's value is 2 (note that this must not be 0 if the two lists intersect). From the head of A, it reads as [0,9,1,2,4]. From the head of B, it reads as [3,2,4]. There are 3 nodes before the intersected node in A; There are 1 node before the intersected node in B.

// Example 3:
// Input: intersectVal = 0, listA = [2,6,4], listB = [1,5], skipA = 3, skipB = 2
// Output: null
// Input Explanation: From the head of A, it reads as [2,6,4]. From the head of B, it reads as [1,5]. Since the two lists do not intersect, intersectVal must be 0, while skipA and skipB can be arbitrary values.
// Explanation: The two lists do not intersect, so return null.

// Notes:

// If the two linked lists have no intersection at all, return null.
// The linked lists must retain their original structure after the function returns.
// You may assume there are no cycles anywhere in the entire linked structure.
// Your code should preferably run in O(n) time and use only O(1) memory.

using System.Collections.Generic;

namespace LeetCode{
    public class IntersectionOfTwoLinkedLists{
        /// <summary>
        /// 查找两个链表相交的第一个节点，不相交，返回null
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
            // 遍历，将数据存入hashSet，利用hashSet 去重
            if(headA==null|| headB==null) return null;
            HashSet<ListNode> allNodes = new HashSet<ListNode>();
            var indexA = headA;
            var indexB = headB;
            // 存入数据
            int numA = 0, numB = 0;
            while(indexA!=null){
                allNodes.Add(indexA);
                indexA = indexA.next;
                numA++;
            }
            while(indexB!=null){
                allNodes.Add(indexB);
                indexB = indexB.next;
                numB++;
            }
            int sum = allNodes.Count;
            int sameNum = numA + numB - sum;
            if(sameNum==0){
                return null;
            }
            indexA = headA; 
            for (var i = 0; i < numA - sameNum;i++){
                indexA = indexA.next;
            }
            return indexA;
        }

        /// <summary>
        /// 比上一个稍微快一点
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        private ListNode Fun2(ListNode headA,ListNode headB){
            // 遍历，将数据存入hashSet，利用hashSet 去重
            if(headA==null|| headB==null) return null;
            HashSet<ListNode> allNodes = new HashSet<ListNode>();
            var indexA = headA;
            var indexB = headB;
            // 存入数据
            while(indexA!=null){
                allNodes.Add(indexA);
                indexA = indexA.next;
            }
            int sum = allNodes.Count;
            while(indexB!=null){
                allNodes.Add(indexB);
                if(allNodes.Count==sum){
                    return indexB;
                }
                indexB = indexB.next;
                sum++;
            }
            return null;
        }
    }
}