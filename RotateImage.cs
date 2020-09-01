using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        //00,02,22,20 =>20,00,02,22
        //01,12,21,10 =>10,01,12,21

        //00,03,33,30
        //01,13,32,20
        //02,23,31,10
        public static void Rotate(int[][] matrix) {
            int n = matrix.Length - 1;
                IList<int> temp = new List<int>();
                temp.Add(matrix[n][0]);
                temp.Add(matrix[0][0]);
                temp.Add(matrix[0][n]);
                temp.Add(matrix[n][n]);
                matrix[0][0] = temp[0];
                matrix[0][n] = temp[1];
                matrix[n][n] = temp[2];
                matrix[n][0] = temp[3];
                for(int i=1;i<n;i++){
                    temp = new List<int>();
                    temp.Add(matrix[n-i][0]);
                    temp.Add(matrix[0][i]);
                    temp.Add(matrix[i][n]);
                    temp.Add(matrix[n][n-i]);
                    matrix[0][i] = temp[0];
                    matrix[i][n] = temp[1];
                    matrix[n][n-i] = temp[2];
                    matrix[n-i][0] = temp[3];
                }
            if(n >= 3){
                Rotate(matrix, n-1, 1);
            }
        }
        
        public static void Rotate(int[][] matrix, int size, int start){
            int n = size - 1;
            IList<int> temp = new List<int>();
            temp.Add(matrix[start+ n][start]);
            temp.Add(matrix[start][start]);
            temp.Add(matrix[start][start + n]);
            temp.Add(matrix[start + n][start + n]);
            matrix[start][start] = temp[0];
            matrix[start][start+n] = temp[1];
            matrix[start+n][start+n] = temp[2];
            matrix[start+n][start] = temp[3];
            for(int i=1;i<n;i++){
                temp = new List<int>();
                temp.Add(matrix[start + n-i][start]);
                temp.Add(matrix[start][start + i]);
                temp.Add(matrix[start + i][start + n]);
                temp.Add(matrix[start+ n][start + n-i]);
                matrix[start][start + i] = temp[0];
                matrix[start + i][start + n] = temp[1];
                matrix[start + n][start + n-i] = temp[2];
                matrix[start + n-i][start] = temp[3];
            }
            if(n >= 3){
                Rotate(matrix, n-1, start + 1);
            }
        }
    }
}