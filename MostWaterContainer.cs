using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int MaxArea(int[] height) {
            int maxA = 0;
            for(int i=0;i<height.Length-1;i++){
                for(int j=i;j<height.Length;j++){
                    var area = getArea(height[i], height[j], j -i);
                    if(maxA < area){
                        maxA = area;
                    }
                }
            } 
            return maxA;
        }
        
        public static int getArea(int p1, int p2, int distance){
            if(p1>p2){
                return distance * p2;
            } else {
                return distance * p1;
            }
        }
    }
}
