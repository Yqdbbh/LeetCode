//88.Merge Sorted Array
//Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

//Note:

//The number of elements initialized in nums1 and nums2 are m and n respectively.
//You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
//Example:

//Input:
//nums1 = [1, 2, 3, 0, 0, 0], m = 3
//nums2 = [2, 5, 6], n = 3

//Output: [1,2,2,3,5,6]

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MergerSortedArray
    {
        public void test(int[] nums1, int m, int[] nums2, int n)
        {
            Stack<int> n1 = new Stack<int>();
            Stack<int> n2 = new Stack<int>();
            for(int i = 0; i < m; i++)
            {
                n1.Push(nums1[i]);
            }
            for(int i = 0; i < n; i++)
            {
                n2.Push(nums2[i]);
            }
            for(int i = m+n; i>0 ;)
            {
                i--;
                if (n1.Count > 0&&n2.Count>0)
                {
                    if (n1.Peek() >= n2.Peek())
                    {
                        nums1[i] = n1.Pop();
                    }
                    else
                    {
                        nums1[i] = n2.Pop();
                    }
                }else if (n1.Count > 0)
                {
                    nums1[i] = n1.Pop();
                }else if (n2.Count > 0)
                {
                    nums1[i] = n2.Pop();
                }
            }
        }
    }
}

// Answer 1 
// https://leetcode.com/problems/merge-sorted-array/discuss/275008/C-solution-beats-99
//public void Merge(int[] nums1, int m, int[] nums2, int n)
//{

//    for (var i = 0; i < nums2.Length; i++)
//        nums1[m + i] = nums2[i];

//    Array.Sort(nums1);
//}

// Answer 2  
// https://leetcode.com/problems/merge-sorted-array/discuss/29676/Clean-c-solution
//public void Merge(int[] nums1, int m, int[] nums2, int n)
//{
//    for (int i = m + n - 1, i1 = m - 1, i2 = n - 1; i > -1; i--)
//    {
//        if (i1 < 0)
//            nums1[i] = nums2[i2--];
//        else if (i2 < 0 || nums1[i1] > nums2[i2])
//            nums1[i] = nums1[i1--];
//        else
//            nums1[i] = nums2[i2--];
//    }
//}