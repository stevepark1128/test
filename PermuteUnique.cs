using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public IList<IList<int>> PermuteUnique(int[] nums) {
            IList<IList<int>> rt = new List<IList<int>>();
            for(int i=0; i<nums.Length; i++){
                var lt = new List<int>();
                lt.Add(nums[i]);
                var arr = nums.Where((source, index) => index != i).ToArray();
                if(arr.Length > 0){
                    PermuteUnique(arr, lt, rt);
                } else {
                    rt.Add(lt);
                }
            }
            return rt;
        }
        public static void PermuteUnique(int[] nums, IList<int> lt, IList<IList<int>> rt) {
            for(int i=0; i<nums.Length; i++){
                var temp = new List<int>();
                temp.AddRange(lt);
                temp.Add(nums[i]);
                var arr = nums.Where((source, index) => index != i).ToArray();
                if(arr.Length > 0){
                    PermuteUnique(arr, temp, rt);
                } else {
                    if(!IsContained(rt, temp)){
                        rt.Add(temp);
                    }
                }
            }
        }
    }
}