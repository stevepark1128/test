using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int ThreeSumClosest(int[] nums, int target) {
            int result = target;
            int min = 0;
            for(int i=0;i<nums.Length-2;i++){
                for(int j=i+1; j<nums.Length-1;j++){
                    for(int k=j+1; k<nums.Length;k++){
                        var sum = nums[i]+nums[j]+nums[k];
                        Console.WriteLine(nums[i]+","+nums[j]+","+nums[k]);
                        var diff = Math.Abs(sum - target);
                        if(i==0 && j==1  && k==2) {
                            Console.WriteLine(min+ ":"+ diff+":"+sum);
                            min = diff;
                            result = sum;
                        } else {
                            Console.WriteLine(min+ ":"+ diff+":"+sum);
                            if(min > diff  ){
                                min = diff;
                                result = sum;
                            }
                        }
                    } 
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}