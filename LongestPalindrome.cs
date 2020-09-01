using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static string LongestPalindrome(string s) {
            string maxSt = "";
            for(int i = 0; i < s.Length; i++)
            {
                StringBuilder substring = new StringBuilder("");
                for(int j = i; j<s.Length; j++){
                    substring.Append(s[j].ToString());
                    // Console.WriteLine("input:" + substring);
                    string newSt = maxPalindrome2(substring.ToString());
                    // Console.WriteLine(newSt);
                    if(newSt != "" && newSt.Length > maxSt.Length){
                        maxSt = newSt;
                    }
                }
            }
            Console.WriteLine(maxSt);
            return maxSt;
            
        }
        private static string maxPalindrome(string substring){
            if(substring.Length == 1) return substring;
            if(substring.Length % 2 == 0){
                for(int i = 0; i < substring.Length / 2 ; i++){
                    if(substring[i] != substring[(substring.Length - 1) - i]){
                        return "";
                    }
                }
            } else {
                for(int i = 0; i < (substring.Length -1) / 2 ; i++){
                    if(substring[i] != substring[(substring.Length - 1) - i]){
                        return "";
                    }
                }
            }
            return substring;
        }
        private static string maxPalindrome2(string substring){
            if(substring.Length == 1) return substring;
            if(substring.Length % 2 == 0){
                if(substring.Substring(0, substring.Length/2) ==
                    ReverseString(substring.Substring(substring.Length/2, substring.Length/2)))
                    return substring;
            } else {
                if(substring.Substring(0, substring.Length/2) ==
                    ReverseString(substring.Substring(substring.Length/2+1, substring.Length/2)))
                    return substring;
            }
            return "";
        }
    }
}


