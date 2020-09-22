/*
 * @lc app=leetcode.cn id=38 lang=csharp
 *
 * [38] 外观数列
 */
namespace LeetCode{
    // @lc code=start
    public class Solution_38 {
        public string CountAndSay(int n) {
            var str="";
            for(int i=0;i<n;i++){
                var chars=str.ToCharArray();
                int p=1;
                var prev="";
                var tmp="";
                foreach(var item in chars){
                    if(prev!=(item+"")){
                        if(prev!=""){
                            tmp+=p+prev;
                        }
                        p=1;                        
                        prev=item+"";
                    }else{
                        p++;
                    }
                }
                tmp+=p+prev;
                str=tmp;
            }
            return str;
        }
    }
    // @lc code=end
}


