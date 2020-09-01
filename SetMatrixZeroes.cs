using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static void SetZeroes(int[][] matrix) {
        IList<int[]> rt = FindZeroIndeces(matrix);
        displayIntArrList(rt);
        MakeZero(matrix, rt);
        displayIntArrArr(matrix);
    }
    
    public static void MakeZero(int[][] matrix, IList<int[]> rt){
        for(int i=0;i<rt.Count;i++){
            //Verical
            for(int j=0;j<matrix.Length;j++){
                matrix[j][rt[i][1]] = 0;
            }
            //Horizontal
            for(int j=0;j<matrix[0].Length;j++){
                matrix[rt[i][0]][j] = 0;
            }
        }
    }
    
    public static IList<int[]> FindZeroIndeces(int[][] matrix){
        IList<int[]> rt = new List<int[]>();
        for(int i=0; i<matrix.Length;i++){
            for(int j=0;j<matrix[i].Length;j++){
                if(matrix[i][j] == 0){
                    int[] r = {i,j};
                    rt.Add(r);
                }
            }
        }
        return rt;
    }
    }
}