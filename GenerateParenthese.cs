using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static IList<string> GenerateParenthesis(int n) {
            IList<string> rt = new List<string>();
            string[][] cb = new string[n*2][];
            for(int i =0; i< n*2; i++){
                cb[i] = new string[2] {"(", ")"};
            }
            generatePossibleCombination(rt, cb, new StringBuilder(), n*2);
            return rt;
        }
        
        public static void generatePossibleCombination(IList<string> rt, string[][] arr, StringBuilder sb, int size){
            Console.WriteLine("::::::::" + arr.Length);
            string[][] sarr1 = null;
            while(arr.Length > 0){
                
                for(int k=0; k< arr[0].Length; k++){
                    StringBuilder st = new StringBuilder(sb.ToString());
                    st.Append(arr[0][k]);
                    Console.WriteLine("+"+st.ToString());
                    sarr1 = arr.ToList().Where((source, index) => index != 0).ToArray();
                    generatePossibleCombination(rt, sarr1, st, size);
                    if(arr.Length == 1 && st.ToString().Length == size && IsValid(st.ToString())){
                        rt.Add(st.ToString());
                    }
                }
                displayArr2(arr);
                arr = sarr1;
                if(arr.Length == 1){
                    break;
                }
            } 
        }
    }
}