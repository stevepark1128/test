using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public int Search(int[] nums, int target) {
        for(int i=0; i<nums.Length; i++){
            if(nums[i] == target){
                return i;
            }
        }
        return -1;
    }
    }
}