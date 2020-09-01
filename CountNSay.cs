using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static string CountAndSay(int n) {
            if(n == 1) return "1";
            string st = "1";
            int count = 1;
            char num = new char();
            num = '1';
            StringBuilder rt = new StringBuilder("");
            for(int i=1; i<n; i++){
                for(int j=0;j<st.Length;j++){            
                    if(j!=0 && num != st[j]){
                        rt.Append((count-1).ToString());
                        rt.Append(st[j-1].ToString());
                        count = 1;   
                    }
                    if(j==st.Length -1){
                        rt.Append(count.ToString());
                        rt.Append(st[j].ToString());
                    }
                    num = st[j];
                    count++;
                }
                st = rt.ToString();
                Console.WriteLine(st);
                count = 1;
                num = new char();
                rt = new StringBuilder("");
            }
            Console.WriteLine("---" + rt.ToString());
            return st;
        }
    }
}