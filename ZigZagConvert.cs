using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static string Convert(string s, int numRows) {
            if(numRows == 1) return s;
            string[,] arr = new string[numRows, s.Length];
            int k=0;
            int j=0;
            for(int i=0;i<s.Length;i++){
                if(j == 0 || j%(numRows-1) == 0)
                {
                    Console.WriteLine(k%numRows+","+j);
                    arr[k%numRows, j] = s[i].ToString();
                    Console.WriteLine("F: "+arr[k%numRows, j].ToString());
                    k++;
                    if(k == numRows){
                        k = 0;
                        j++;
                    }
                } else {
                    if(j<numRows){
                        Console.WriteLine(numRows-1-j%numRows+","+j);
                        arr[numRows-1-j%numRows, j] = s[i].ToString();
                        Console.WriteLine("-S: "+arr[numRows-1-j%numRows, j].ToString()); 
                        k++; 
                        if(numRows-1-j%numRows == 1)
                        {
                            k=0;
                        } 
                        j++; 
                    } else {
                        Console.WriteLine(numRows-1-j%(numRows-1)+","+j);
                        arr[numRows-1-j%(numRows-1), j] = s[i].ToString();
                        Console.WriteLine("-S: "+arr[numRows-1-j%(numRows-1), j].ToString()); 
                        k++; 
                        if(numRows-1-j%(numRows-1) == 1)
                        {
                            k=0;
                        } 
                        j++;
                    }            
                }    
            }
            StringBuilder newS = new StringBuilder("");
            foreach(var item in arr){
                newS.Append(item);
            }

            Console.WriteLine(newS.ToString());
            return newS.ToString();
        }
    }
}