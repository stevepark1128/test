using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int UniquePaths(int m, int n) {
            IList<IList<int[]>> path = new List<IList<int[]>>();
            IList<int[]> rt = new List<int[]>();
            UniquePaths(m, n, 1, 1, rt, path);
            displayIntArrListList(path);
            return path.Count;        
        }

        public static void UniquePaths(int m, int n, int x, int y, IList<int[]> rt, IList<IList<int[]>> path) {
            //Console.WriteLine(x+":"+y);
            int[] init = {x, y};
            if(!IsContained(rt, init)){
                rt.Add(init);
            }
            if(x == m && y == n){
                path.Add(rt);
            }
            var sx = x;
            var sy = y;
            if(x<m) {
                var temp = rt.ToList();
                sx++;
                if(sx == m && y == n) {
                    //Console.WriteLine("-----------"+sx+":"+y);
                    int[] r = {sx, y} ;
                    if(!IsContained(temp ,r)){
                        temp.Add(r);
                    }
                    path.Add(temp);
                }else{
                    int[] r = {sx, y} ;
                    if(!IsContained(temp ,r)){
                        temp.Add(r);
                    }
                    UniquePaths(m, n, sx, y, temp, path);
                } 
                
            }
            if(y<n) {
                var temp = rt.ToList();
                sy++;
                if(x == m && sy == n) {
                    //Console.WriteLine("-----------"+x+":"+sy);
                    int[] r = {x, sy} ;
                    if(!IsContained(temp ,r)){
                        temp.Add(r);
                    }
                    path.Add(temp);
                }else{
                    int[] r = {x, sy} ;
                    if(!IsContained(temp ,r)){
                        temp.Add(r);
                    }
                    UniquePaths(m, n, x, sy, temp, path);
                }
            }  
        }
    }
}