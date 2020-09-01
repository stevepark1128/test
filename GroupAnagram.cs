using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static IList<IList<string>> GroupAnagrams(string[] strs) {
            IList<IList<string>> rt = new List<IList<string>>(); 
            do{
                IList<string> tmp = new List<string>();
                tmp.Add(strs[0]);
                strs = strs.Where((source, index) => index != 0).ToArray();
                displayStrArr(strs);
                if(strs.Length > 0){
                    int j = 0;
                    do{
                        if(isAnagram(tmp[0], new StringBuilder(strs[j]))){
                            tmp.Add(strs[j]);
                            strs = strs.Where((source, index) => index != j).ToArray();
                            displayStrArr(strs);
                        }else{
                        j++;  
                        }
                    }while(j < strs.Length);
                }
                displayStrList(tmp);
                rt.Add(tmp);
            }while(strs.Length > 0);
            return rt;
        }
        
        public static bool isAnagram(string s1, StringBuilder s2){
            if(s1.Length != s2.Length) return false;
            for(int i=0; i<s1.Length; i++){
                var f = s2.ToString().IndexOf(s1[i]);
                if(f>-1){
                    s2.Remove(f, 1);
                }
            }
            if(s2.Length == 0){
                return true;
            }
            return false;
        }

    }
}
