using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static IList<int> FindSubstring(string s, string[] words) {
            StringBuilder sb = new StringBuilder("");
            IList<int> rt = new List<int>();
            for(int i=0;i<words.Length; i++){
                sb = new StringBuilder(words[i]);
                var newWords = words.Where((source, index) => index != i).ToArray();
                //displayArr(newWords);
                if(newWords.Length == 0){
                    IList<int> indexes = IndexOfAll(s, sb.ToString());
                    //Console.WriteLine(sb.ToString() + index);
                    //display2(indexes);
                    for(int j=0; j < indexes.Count(); j++){
                        if(!rt.Contains(indexes[j]))
                            rt.Add(indexes[j]);
                    }
                }else{
                    FindIndices(s, newWords, sb, rt);
                }
            }
            return rt;
        }
        public static void FindIndices(string s, string[] words, StringBuilder sb, IList<int> rt){
            var temp = new StringBuilder(sb.ToString());
            for(int i=0;i<words.Length; i++){           
                //Console.WriteLine(temp.ToString()+"***********");
                sb = new StringBuilder("");
                sb.Append(temp);
                sb.Append(words[i]);
                //Console.WriteLine(sb.ToString()+"!!!!!!!!!!!");
                var newWords = words.Where((source, index) => index != i).ToArray();
                //displayArr(newWords);
                if(newWords.Length == 0){
                    IList<int> indexes = IndexOfAll(s, sb.ToString());
                    //Console.WriteLine(sb.ToString() + index);
                    //display2(indexes);
                    for(int j=0; j < indexes.Count(); j++){
                        if(!rt.Contains(indexes[j]))
                            rt.Add(indexes[j]);
                    }
                }else{
                    //Console.WriteLine(temp.ToString());
                    FindIndices(s, newWords, sb, rt);
                }
                
            }
        }

        public static IList<int> IndexOfAll(string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                return new List<int>();
            List<int> indexes = new List<int>();
            for (int index = 0;; index ++) {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
    }
}