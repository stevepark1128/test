using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int LongestValidParentheses(string s) {
            int mx=0;
            for(int i=s.Length; i>1; i--){
                var sts = getSubstr(s, i);
                for(int j=0; j < sts.Count;j++){
                    
                    if(IsValid(sts[j]) && mx < sts[j].Length){  
                        Console.WriteLine(sts[j]);
                        mx = sts[j].Length;
                    }
                }
            }
            return mx;
        }
        public static IList<string> getSubstr(string s, int n)
        {
            IList<string> st = new List<string>();
            for(int i=0; i<= s.Length - n; i++){
                StringBuilder sb = new StringBuilder("");
                for(int j=i; j<i+n; j++){
                    sb.Append(s[j]);
                    if(j == i + n -1){
                        st.Add(sb.ToString());
                    }
                }
            }
            return st;
        }
    }
}