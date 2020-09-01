using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static bool IsMatch(string s, string p) {
            if(s.Length == 0 && p.Length == 0) return true;
            if(s.Length > 0 && p.Length == 0) return false;
            string temp = s;
            Console.WriteLine(temp);
            if(p[0] == '*'){
                if(temp.Length == 0 && IsAllWild(p)) return true;
                if(temp.Length > 0 && p.Length == 1) return true;
                if(temp.Length == 0 && !IsAllWild(p)) return false;
                Console.WriteLine(temp+"***");
                //if(p[1] == '*') return IsMatch(temp.Substring(1), p.Substring(1)); 
                for(int j=0; j < temp.Length; j++){
                    if(temp[j] == p[1]){
                        if(IsMatch(temp.Substring(j), p.Substring(1))){
                            return true;
                        }
                    }
                    if(p[1] == '?'  || p[1] == '*'){
                        if(IsMatch(temp.Substring(j), p.Substring(1))){
                            return true;
                        }
                    }
                }  
                if(!temp.Contains(p[1])) return false;                    
                Console.WriteLine(temp[0]+"**");

            } else if(p[0] == '?'){
                if(temp.Length == 0) return false;
                Console.WriteLine(temp+"???");
                Console.WriteLine(temp[0]+"??");
                Console.WriteLine(p+":?");
                if(temp.Length == 1 && p.Length == 1) return true;
                if(temp.Length == 1 && !IsAllWild(p.Substring(1))) return false;
                return IsMatch(temp.Substring(1), p.Substring(1));
            } else {
                if(temp.Length == 0) return false;
                Console.WriteLine(temp+"---");
                Console.WriteLine(temp[0]+"--");
                Console.WriteLine(p[0]+"--");
                if(p[0] == temp[0]){
                    if(temp.Length == 1 && p.Length == 1) return true;
                    //Console.WriteLine(temp.Substring(1)+"----");
                    if(IsMatch(temp.Substring(1), p.Substring(1))){
                        return true;
                    }
                } else {
                    return false;
                }   
            }
            return false;
        }
        public static bool IsAllWild(string p){
            if(p.Length > 0 && p.LastOrDefault() == '?') return false;
            for(int i=0;i<p.Length;i++){
                if(p[i] == '*'){
                } else{
                    return false;
                }
            }
            return true;
        }
    }
}