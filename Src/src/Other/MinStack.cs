// 155. Min Stack     Easy
// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

// push(x) -- Push element x onto stack.
// pop() -- Removes the element on top of the stack.
// top() -- Get the top element.
// getMin() -- Retrieve the minimum element in the stack.


// Example:

// MinStack minStack = new MinStack();
// minStack.push(-2);
// minStack.push(0);
// minStack.push(-3);
// minStack.getMin();   --> Returns -3.
// minStack.pop();
// minStack.top();      --> Returns 0.
// minStack.getMin();   --> Returns -2.
using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode{
    public class MinStack {
        /// <summary>
        /// 数据
        /// </summary>
        private List<int> data;
        /// <summary>
        /// 最小值数组，也可以存下标
        /// </summary>
        private List<int> minValues;
        /// <summary>
        /// 栈顶指针
        /// </summary>
        private int top;
        /// <summary>
        /// 最小值
        /// </summary>
        private int min;
        /** initialize your data structure here. */
        public MinStack() {
            top = -1;
            data = new List<int>();
            minValues = new List<int>();
            min = int.MaxValue;
        }
        
        public void Push(int x) {
            data.Add(x);
            top++;
            if(x<=min||top<0){ // 插入值比最小值小   
                min = x;
                minValues.Add(x);
            }
            //sortIndex.Insert()
        }
        
        public void Pop() {
            if(top<0)
                return;
            if(data[top]==minValues[minValues.Count-1])
                minValues.RemoveAt(minValues.Count - 1);
            data.RemoveAt(top);
            top--;
        }
        
        public int Top() {
            if(top<0) return int.MinValue;
            return data[top]; 
        }
        
        public int GetMin() {
            if(top<0) return int.MinValue;
            return minValues[minValues.Count - 1];
        }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */

}
//["MinStack","push","push","push","top","pop","getMin","pop","getMin","pop","push","top","getMin","push","top","getMin","pop","getMin"]
//[[],[2147483646],[2147483646],[2147483647],[],[],[],[],[],[],[2147483647],[],[],[-2147483648],[],[],[],[]]