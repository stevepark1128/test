using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public IList<IList<int>> Subsets(int[] nums) {
            IList<IList<int>> rt = new List<IList<int>>();
            var emp = new List<int>();
            rt.Add(emp);
            Subsets(rt, nums);
            return rt;
        }
        public void Subsets(IList<IList<int>> rt, IList<int> nums) {
            if(nums.Count > 0 && !rt.Any(x=>x.Equals(nums))) rt.Add(nums);
            for(int i=0;i<nums.Count;i++){
                var temp = nums.Where((src, idx) => idx != i).ToList();
                Subsets(rt, temp);
            }
        }
    }
}