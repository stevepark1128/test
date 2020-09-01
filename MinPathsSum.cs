using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int MinPathSum(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        IList<IList<int>> path = new List<IList<int>>();
        IList<int> rt = new List<int>();
        int cur = grid[0][0];
        rt.Add(cur);
        MinPaths(m, n, 0, 0, rt, path, grid);
        displayIntListList(path);
        return GetMinPathSum(path);
    }
    public static int GetMinPathSum(IList<IList<int>> path){
        if(path.Count==0) return 0;
        int min = path[0].Sum();
        for(int i=1;i<path.Count;i++){

            if(min > path[i].Sum()){
                min = path[i].Sum();
            }
        }
        return min;
    }
    public static void MinPaths(int m, int n, int x, int y, IList<int> rt, IList<IList<int>> path, int[][] grid){
        if(x == m-1 && y == n-1){
            path.Add(rt);
        }
        var sx = x;
        var sy = y;
        if(x<m-1) {
            var temp = rt.ToList();
            sx++;
            if(sx == m-1 && y == n-1) {
                //Console.WriteLine("-----------"+sx+":"+y);
                int cur = grid[sx][y];
                temp.Add(cur);
                path.Add(temp);
            }else{
                int cur = grid[sx][y];
                temp.Add(cur);
                MinPaths(m, n, sx, y, temp, path, grid);
            } 
            
        }
        if(y<n-1) {
            var temp = rt.ToList();
            sy++;
            if(x == m-1 && sy == n-1) {
                //Console.WriteLine("-----------"+x+":"+sy);
                int cur = grid[x][sy];
                temp.Add(cur);
                path.Add(temp);
            }else{
                int cur = grid[x][sy];
                temp.Add(cur);
                MinPaths(m, n, x, sy, temp, path, grid);
            }
        }  
    }
    }
}