using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static string GetPermutation(int n, int k) {
            IList<IList<int>> rt = new List<IList<int>>();
            int[] nums = new int[n];
            for(int i=1;i<=n;i++){
                nums[i-1] = i;
            }
            displayInyArr(nums);
            for(int i=0; i<nums.Length; i++){
                var lt = new List<int>();
                lt.Add(nums[i]);
                var arr = nums.Where((source, index) => index != i).ToArray();
                if(arr.Length > 0){
                    Permute(arr, lt, rt);
                } else {
                    rt.Add(lt);
                }
            }
            return ConvertIntListToString(rt[k-1]);
        }

        public static string ConvertIntListToString(IList<int> lst){
                var ar = lst.ToArray();
                StringBuilder sb = new StringBuilder("");
                for(int i=0; i < ar.Length; i++){
                    sb.Append(ar[i]);
                }
                return sb.ToString();
            }

        }
}