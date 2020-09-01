using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int LengthOfLastWord(string s) {
            var sts = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if(sts.Length == 0) return 0;
            return sts[sts.Length - 1].Length; 
        } 
    }
}