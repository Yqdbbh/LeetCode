// 28.Implement strStr().

// Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

// Example 1:

// Input: haystack = "hello", needle = "ll"
// Output: 2
// Example 2:

// Input: haystack = "aaaaa", needle = "bba"
// Output: -1
// Clarification:

// What should we return when needle is an empty string? This is a great question to ask during an interview.

// For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().
using System;
namespace LeetCode
{
    class ImplementstrStr{
        public int test(string haystack, string needle) {
            if(String.IsNullOrEmpty(needle)) return 0;
            int j=0;
            for( int i=0;i<haystack.Length;i++){
                if(haystack.Length-i<needle.Length)
                    return -1;
                for( j=0;j<needle.Length;j++){
                    if(haystack[i+j]!=needle[j]){
                        break;
                    }
                }
                if(j==needle.Length){
                    return i;
                }
            }
            return -1;
        }
    }
}
// Runtime: 72 ms, faster than 99.91% of C# online submissions for Implement strStr().
// Memory Usage: 20.2 MB, less than 76.81% of C# online submissions for Implement strStr().