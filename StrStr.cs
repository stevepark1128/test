using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int StrStr(string haystack, string needle) {
            if(haystack.Length==0 && needle.Length==0) return 0;
            if(haystack.Length < needle.Length) return -1;
            int rt = -1;
            for(int i=0; i<haystack.Length - needle.Length+1;i++){
                rt = i;
                for(int j=0;j<needle.Length;j++){
                    if(haystack[i+j] == needle[j]){
                        rt = i;
                    } else {
                        rt = -1;
                        break;
                    }
                }
                if(rt > -1){
                    return rt;
                }
            }
            return rt;
        }
    }
}