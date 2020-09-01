using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static string LongestCommonPrefix(string[] strs) {
            if(strs.Length == 0) return "";
            StringBuilder rst = new StringBuilder("");
            var isPrefix = true;
            string st=strs[0];
            for(int j=1; j< strs.Length;j++){
                if(st.Length > strs[j].Length) st = strs[j];    
            }
            for(int i=0; i< st.Length; i++){
                for(int j=0; j< strs.Length;j++){
                    if(st[i] != strs[j][i]) {
                        isPrefix = false;
                    }
                }
                if(isPrefix){
                    rst.Append(st[i].ToString());
                }   
            }
            return rst.ToString();
        }
    }
}