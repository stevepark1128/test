using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int LgstJump(int N) {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            StringBuilder bst= new StringBuilder("");
            return GetLgstGap(GetBinaryString(N, bst));
        }
        
        public static string GetBinaryString(int N, StringBuilder bst) {
            int temp = N;
            do{
                var den = temp / 2;
                var rem = temp % 2;
                bst.Append(rem.ToString());
                temp = den;
            }while(temp >= 1);
            Console.WriteLine(bst.ToString());
            return bst.ToString();
        }
        public static int GetLgstGap(string st){
            int start = -1;
            int end = -1;
            int max = 0;
            for(int i=0;i<st.Length;i++){
                if(st[i] == '1'){
                    if(start < 0){
                        start = i;
                    } else if(end < 0){
                        end = i;
                        max = end - start - 1;
                        start = end;
                        end = -1;
                    }
                }
            }
            return max;
        }
    }
}