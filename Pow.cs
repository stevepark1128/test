using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static double MyPow(double x, int n) {
            double r = 1;
            if(n >= 0){
                for(int i =0; i<n; i++){
                    r = r*x;
                }
            }
            
            if(n<0){
                for(int i =0; i<Math.Abs(n); i++){
                    r = r/x;
                }
            }
            return r;
        }
    }
}