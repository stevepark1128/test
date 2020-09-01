using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static IList<IList<int>> ThreeSum(int[] nums) {
            IList<IList<int>> llst = new List<IList<int>>();
            find3Sum(llst, nums);
            displayIntListList(llst);
            return llst;
        }
        
        public static void find3Sum(IList<IList<int>> llst,int[] nums){
            if(nums.Length < 3) return;
            //Console.WriteLine("input nums:");
            //display2(nums.ToList().Where((source, index) => index != 0).ToList());
            var sarr1 = nums.ToList().Where((source, index) => index != 0).ToArray();
            find3Sum(llst, sarr1);
            var lst = new List<int>();
            for(int i=1; i<nums.Length-1; i++){
                lst.Add(nums[0]);
                lst.Add(nums[i]);
                lst.Add(nums[i+1]);
                if(lst.Sum(x => x) == 0) {
                    //Console.WriteLine("Current list for 0 sum:");
                    //display2(lst);
                    addArray(llst, lst);
                    //Console.WriteLine("Current result list:");
                    //display(llst);    
                }
                lst = new List<int>();
                //Console.WriteLine("input nums:");
                //display2(nums.ToList().Where((source, index) => index != i).ToList());
                var sarr = nums.ToList().Where((source, index) => index != i).ToArray();
                find3Sum(llst, sarr);
            }
            
        }

        public static void addArray(IList<IList<int>> llst, IList<int> lst){
            var arr = llst.ToArray();
            bool exist = false;
            var slst = lst.ToArray();
            Array.Sort(slst);
            for(int i=0;i<arr.Length;i++){
                var sarr = arr[i].ToArray();
                Array.Sort(sarr);
                if(slst.SequenceEqual(sarr)){
                    exist = true;
                }
            }
            if(!exist){
                llst.Add(slst);
            }
            
        }
    }
}