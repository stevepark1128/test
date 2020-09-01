using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static bool IsPalindrome(int x) {
            var substring = x.ToString();
            if(substring.Length == 1) return true;
            if(substring.Length % 2 == 0){
                if(substring.Substring(0, substring.Length/2) ==
                ReverseString(substring.Substring(substring.Length/2, substring.Length/2)))
                    return true;
            } else {
                if(substring.Substring(0, substring.Length/2) ==
                ReverseString(substring.Substring(substring.Length/2+1, substring.Length/2)))
                return true;
            }
            return false;
        }
    }
}