using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static string IntToRoman(int num) {
            StringBuilder roman = new StringBuilder("");
            Dictionary<string, int> romans = new Dictionary<string,int>();
            romans["I"] = 1;
            romans["IV"] = 4;
            romans["V"] = 5;
            romans["IX"] = 9;
            romans["X"] = 10;
            romans["XL"] = 40;
            romans["L"] = 50;
            romans["XC"] = 90;
            romans["C"] = 100;
            romans["CD"] = 400;
            romans["D"] = 500;
            romans["CM"] = 900;
            romans["M"] = 1000;
            
            IntToSubRoman(roman, num, romans);
            Console.WriteLine(roman.ToString());
            return roman.ToString();
            
        }

        public static void IntToSubRoman(StringBuilder roman, int num, Dictionary<string, int> romans){
            int min = romans.Where(x=>x.Value <= num).LastOrDefault().Value;
            int val = 0;
            if(min == 0) return;
            for(int i = 0; i < num/min; i++)
            {
                val += min;
                roman.Append(romans.First(x=>x.Value == min).Key);
            }
            if(min == 1  || num%min == 0){
                return;
            }
            IntToSubRoman(roman, num - val, romans);
        }
    }
}
