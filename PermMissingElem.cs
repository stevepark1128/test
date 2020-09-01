using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int PermMissingElem(int[] A){
            int rt = 0;
            var sa = A.ToList();
            
            if(A.Length == 1) return A[0]+1;
            for(int i=sa.Min();i<=sa.Max();i++){
                var temp = A.Where((source,index) => source == i).ToArray();
                if(temp.Length == 0){
                    rt = i;
                }
            }

            return rt;
        }
    }
}