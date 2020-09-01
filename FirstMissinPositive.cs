using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int FirstMissingPositive(int[] nums) {
        
            var li = nums.ToList();
            li.Sort();
            li = li.Where(x => x > 0).ToList();
            if(li.Count == 0) return 1;
            for(int i=1;i<li.Last();i++){
                if(!li.Where(x => x == i).Any()){
                    return i;
                }
            }
            return li.Last() + 1;
        }
    }
}