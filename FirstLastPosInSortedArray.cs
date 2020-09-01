using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public int[] SearchRange(int[] nums, int target) {
            int f = -1;
            int l = -1;
            for(int i=0; i< nums.Length; i++){
                if(nums[i] == target){
                    if(f == -1){
                        f = i;
                        l = i;
                    }else {
                        l = i;
                    }                    
                }
            }
            int[] rt = {-1,-1};
            rt[0] = f;
            rt[1] = l;
            return rt;
        }
    }
}