using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static void SortColors(int[] nums) {
            nums = MergeSort(nums);
            displayInyArr(nums);
        }
        public static int[] MergeSort(int[] nums){
            if(nums.Length > 1){
                int median = nums.Length % 2 == 0 ? nums.Length / 2 : (nums.Length / 2) + 1;
                var n1 = MergeSort(nums.Where((source, index)=> index <= median -1).ToArray());
                //displayInyArr(n1);
                var n2 = MergeSort(nums.Where((source, index)=> index >= median).ToArray());
                //displayInyArr(n2);
                return Merge(n1, n2);
            }
            return nums;      
        }
        public static int[] Merge(int[] n1, int[] n2){
            IList<int> rt = new List<int>();
            do{
                if(n1[0] > n2[0]){
                    rt.Add(n2[0]);
                    n2=n2.Where((source, index)=> index > 0).ToArray();
                } else {
                    rt.Add(n1[0]);
                    n1=n1.Where((source, index)=> index > 0).ToArray();
                }
            }while(n1.Length > 0 && n2.Length > 0);
            
            for(int i=0; i<n1.Length;i++){
                rt.Add(n1[i]);
            }
            for(int i=0; i<n2.Length;i++){
                rt.Add(n2[i]);
            }
            return rt.ToArray();
        }
    }
}
