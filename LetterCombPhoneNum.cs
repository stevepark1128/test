using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static IList<string> LetterCombinations(string digits) {
            IList<string> rt = new List<string>();
            Dictionary<string, int> nums = new Dictionary<string, int>();
                nums["a"] = 2;
                nums["b"] = 2;
                nums["c"] = 2;
                nums["d"] = 3;
                nums["e"] = 3;
                nums["f"] = 3;
                nums["g"] = 4;
                nums["h"] = 4;
                nums["i"] = 4;
                nums["j"] = 5;
                nums["k"] = 5;
                nums["l"] = 5;
                nums["m"] = 6; 
                nums["n"] = 6;
                nums["o"] = 6;
                nums["p"] = 7;
                nums["q"] = 7;
                nums["r"] = 7;
                nums["s"] = 7;
                nums["t"] = 8;
                nums["u"] = 8;
                nums["v"] = 8;
                nums["w"] = 9;
                nums["x"] = 9;
                nums["y"] = 9;
                nums["z"] = 9;
            
            string[][] arr = new string[digits.Length][];
            for(int i=0; i<digits.Length;i++){
                var num = System.Convert.ToInt32(digits[i].ToString());
                arr[i] = nums.Where(x=>x.Value == num).Select(x=>x.Key.ToString()).ToArray();
                displayArr(arr[i]);
            }
            StringBuilder sb = new StringBuilder("");
            findCombo(rt, arr, sb, arr.Length);
            Console.WriteLine("result: ");
            displayStrList(rt);
            return rt;
        }

        public static void findCombo(IList<string> rt, string[][] arr, StringBuilder sb, int size){
            Console.WriteLine("::::::::" + arr.Length);
            //int j=0;
            string[][] sarr1 = null;
            while(arr.Length > 0){
                
                for(int k=0; k< arr[0].Length; k++){
                    StringBuilder st = new StringBuilder(sb.ToString());
                    st.Append(arr[0][k]);
                    Console.WriteLine("+"+st.ToString());
                    sarr1 = arr.ToList().Where((source, index) => index != 0).ToArray();
                    findCombo(rt, sarr1, st, size);
                    if(arr.Length == 1 && st.ToString().Length == size){
                        rt.Add(st.ToString());
                    }
                }
                displayArr2(arr);
                arr = sarr1;
                if(arr.Length == 1){
                    break;
                }
                //j++;
            } 
        }
    }
}