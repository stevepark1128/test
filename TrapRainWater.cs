using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int Trap(int[] height) {
            int tr = 0;
            for(int i=0;i<height.Length;i++){
                Console.WriteLine(":"+i);
                var arr = height.Where((source, index) => index > i).ToArray();
                //displayInyArr(arr);
                if(arr.Where(x => x >= height[i]).Any()){
                    for(int j=i+1;j<height.Length;j++){
                        if(height[i] > height[j]){
                            tr += (height[i] - height[j]);
                            Console.WriteLine("--"+tr + ":" + i +","+j);
                        } else {
                            i=j-1;
                            //Console.WriteLine(":"+i);
                            break;
                        }
                    }
                } else {
                    break;
                }
            }
            height = height.Reverse().ToArray();
            for(int i=0;i<height.Length;i++){
                Console.WriteLine(":"+i);
                var arr = height.Where((source, index) => index > i).ToArray();
                //displayInyArr(arr);
                if(arr.Where(x => x > height[i]).Any()){
                    for(int j=i+1;j<height.Length;j++){
                        if(height[i] > height[j]){
                            tr += (height[i] - height[j]);
                            Console.WriteLine("--"+tr + ":" + i +","+j);
                        } else {
                            i=j-1;
                            //Console.WriteLine(":"+i);
                            break;
                        }
                    }
                } else {
                    break;
                }
            }
            return tr;
        }
    }
}