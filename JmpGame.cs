using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static bool CanJump(int[] nums) {
            if(nums.Length == 1) return true;                       
            var jump = nums[0];
            return CanJump(nums, jump);
        }

        public static bool CanJump(int[] nums, int jump){
            for(int i=jump;i>0;i--) {
                Console.WriteLine(jump);
                if(i >= nums.Length-1) return true;
                CanJump(nums, i);
                do {
                    var cur = nums[jump-1];
                    if(cur == 0) return false;
                    var newjump = jump + cur;
                    CanJump(nums, newjump);
                } while(jump < nums.Length); 
            }
            if(jump == 0) return false;
            return false;
        }
    }

}