/*
 * @lc app=leetcode.cn id=225 lang=csharp
 *
 * [225] 用队列实现栈
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
// @lc code=start
namespace LeetCode{
    
    public class MyStack { // FILO

        /** Initialize your data structure here. */
        Queue<int> _queue; // FIFO
        public MyStack() {
            _queue=new Queue<int>();
        }
        
        /** Push element x onto stack. */
        public void Push(int x) {
            _queue.Enqueue(x);
        }
        
        /** Removes the element on top of the stack and returns that element. */
        public int Pop() {
            if(_queue.Count==0){
                throw new Exception("栈为空");
            }
            // 取最后一条数据
            var tmp=_queue.Last();
            var ienum=_queue.Take(_queue.Count-1);
            _queue=new Queue<int>(ienum);
            return tmp;
        }
        
        /** Get the top element. */
        public int Top() {
            return _queue.Last();
        }
        
        /** Returns whether the stack is empty. */
        public bool Empty() {
            return _queue.Count==0;
        }
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

