using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static void NextPermutation(int[] nums) {
             int xId = 0;
            int yId = 0;
            for(int i=0; i<nums.Length-1; i++){
                if(nums[i] < nums[i+1]){
                    xId = i;
                }
            }
            for(int i=xId+1; i<nums.Length; i++){
                if(nums[xId] < nums[i]){
                    yId=i;
                }
            }
            if(xId == 0 && yId == 0){
                Array.Sort(nums);
            }
            else{
                Console.WriteLine(xId + ":" + yId);
                var temp = nums[yId];
                nums[yId] = nums[xId];
                nums[xId] = temp;
                Array.Reverse(nums, xId+1, nums.Length - xId-1);
            }
            
            displayIntList(nums);
        }
    }
}