using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int LengthOfLongestSubstring(string s) {
            int maxL = 0;
            
            if(s.Length == 1 || (s.Length > 0 && s.Trim() == "")) return 1;
            
            for(int i=0; i<s.Length-1; i++){
                StringBuilder substring = new StringBuilder(s[i].ToString());
                for(int j=i+1; j < s.Length; j++){
                    if(!substring.ToString().Contains(s[j].ToString())) {
                        substring.Append(s[j].ToString());
                    } else {
                        break;
                    }
                }
                Console.WriteLine(substring.ToString());
                if(substring.ToString().Length > maxL){
                    maxL = substring.ToString().Length;
                    Console.WriteLine(maxL);
                }
            }
            return maxL;
        }
    }
}