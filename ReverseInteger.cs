using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int Reverse(int x) {
            int result;
            string s = x.ToString();
            StringBuilder newS = new StringBuilder("");
            if(x < 0){
                newS.Append("-");
                for(int i = s.Length - 1; i > 0 ; i--){
                    newS.Append(s[i].ToString());
                }
            } else{
                for(int i = s.Length - 1; i >= 0 ; i--){
                    newS.Append(s[i].ToString());
                }
            }
            
            int.TryParse(newS.ToString(), out result);
            Console.WriteLine(result);
            return result; 
        }
    }
}
