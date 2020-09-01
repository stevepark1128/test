using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int MaxSubArray(int[] nums) {
            int max = 0;
            for(int i=1;i <= nums.Length;i++){
                var rt = substr(nums, i);
                displayIntListList(rt);
                for(int j=0; j<rt.Count;j++){
                    if(i==1 && j==0) max = rt[j].Sum();
                    if(rt[j].Sum() > max){
                        max = rt[j].Sum();
                    }
                }
            }
            return max;
        }
        public static IList<IList<int>> substr(int[] nums, int size){
            IList<IList<int>> rt = new List<IList<int>>();
            for(int i=0;i<=nums.Length - size;i++){
                List<int> lt = new List<int>();
                for(int j=0;j<size;j++){
                    lt.Add(nums[i+j]);
                }
                rt.Add(lt);
            }
            return rt;
        }
    }
}