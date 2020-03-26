// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
// An input string is valid if:

// 1.Open brackets must be closed by the same type of brackets.
// 2.Open brackets must be closed in the correct order.
// Note that an empty string is also considered valid.

// Example 1:

// Input: "()"
// Output: true
// Example 2:

// Input: "()[]{}"
// Output: true
// Example 3:

// Input: "(]"
// Output: false
// Example 4:

// Input: "([)]"
// Output: false
// Example 5:

// Input: "{[]}"
// Output: true
using System;
using System.Collections;
namespace LeetCode{
    class ValidParentheses{
        public bool test(string s){
            //if(string.IsNullOrWhiteSpace(s)) return false;
            if(s.Length%2==1) return false;
            Stack stack=new Stack();
            foreach(var c in s){
                if(getSign(c))
                    stack.Push(c);
                else{
                    if(stack.Count==0) return false;
                    if((char)stack.Peek()==ChangeChar(c))
                        stack.Pop();
                    else
                        return false;
                }
            }
            return stack.Count==0;
        }
        public bool getSign(char c){
            switch(c){
                case '{':
                case '[':
                case '(':
                    return true;
                case '}':
                case ']':
                case ')':
                    return false;
            }
            return true;
        }
        public char ChangeChar(char c){
            switch(c){
                case ']':
                    return '[';
                case '}':
                    return '{';
                case ')':
                    return '(';
            }
            return c;
        }
    }
}

// 太慢了
// Runtime: 92 ms, faster than 24.25% of C# online submissions for Valid Parentheses.
// Memory Usage: 19.9 MB, less than 68.28% of C# online submissions for Valid Parentheses.