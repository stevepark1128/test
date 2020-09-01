using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static bool IsValid(string s) {
            Dictionary<char, char> brackets = new Dictionary<char, char>();
            brackets['('] = ')';
            brackets['['] = ']';
            brackets['{'] = '}';
            if(s.Length == 0) return true;
            if(s.Length % 2 != 0) return false;
            
            List<char> sb = new List<char>();
            for(int i=0; i < s.Length; i++){
                var op = brackets.Where(b => b.Key == s[i]).Select(x=>x);
                if(op.Count() > 0){
                    sb.Add(op.Last().Key);
                    //display4(sb);
                } else {
                    if(sb.Count() < 1) return false;
                    if(s[i] == brackets[sb.Last()]){
                        sb.RemoveAt(sb.Count() - 1);
                        //display4(sb);
                    } else {
                        return false;
                    }
                }
            }
            
            return sb.Count() > 0 ? false : true;
        }
    }
}