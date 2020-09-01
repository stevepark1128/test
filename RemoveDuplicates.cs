using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace leetcode
{
    public partial class Program{
        public static int RemoveDuplicates(ref int[] nums) {
            int? cur = null;
            int newL = nums.Length;
            for(int i=0; i<nums.Length;i++){
                if(cur != nums[i]) {
                    cur = nums[i];
                } else {
                    nums = nums.Where((source, index) => index != i).ToArray();
                    displayInyArr(nums);
                    i--;
                    newL--;
                }
                
            }
            return newL;
        }
    }
}