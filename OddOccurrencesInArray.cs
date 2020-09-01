using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public int  OddOccurrencesInArray(int[] A) {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int oc = 0;
            for(int i=0;i<A.Length;i++){
                var temp = A.Where((source, index) => source == A[i]).ToArray();
                if (temp.Length ==1){
                    oc = A[i];
                }
            }
            return oc;
        }
    }
}