using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int[] TwoSum(int[] nums, int target) {
            int index1 = 0;
            foreach(var num in nums){
                int index2 = index1 + 1;
                for(int i = index2; i < nums.Length; i++){
                    if(num + nums[i] == target){
                        index2 = i;
                        return new int[] {index1, index2};
                    }      
                }
                index1++;
                if(index1 == nums.Length){
                    return null;
                }
            }
            return null;
        }
    }

}
