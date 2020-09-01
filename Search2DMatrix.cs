using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static bool SearchMatrix(int[][] matrix, int target) {
            return FindTrgetIndeces(matrix, target);
            
        }
        public static bool FindTrgetIndeces(int[][] matrix, int target){
            for(int i=0; i<matrix.Length;i++){
                for(int j=0;j<matrix[i].Length;j++){
                    if(matrix[i][j] == target){
                        return true;
                    }
                }
            }
            return false;
        }
    }
}