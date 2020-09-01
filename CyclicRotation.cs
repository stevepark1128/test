using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public int[] RotateArray(int[] A, int K) {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var left = A.Where((source, index) => index < Math.Abs(A.Length-K)).ToArray();
            var right = A.Where((source, index) => index >= Math.Abs(A.Length-K)).ToArray();
            int[] narr = new int[A.Length];
            for(int i=0;i<right.Length;i++){
                A[i] = right[i];
            }
            for(int i=0;i<left.Length;i++){
                A[i+K] = left[i];
            }
            return A;
        }
    }
}