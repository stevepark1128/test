using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static IList<int> SpiralOrder(int[][] matrix) {
            IList<int> lt = new List<int>();
            if(matrix.Length == 0) return lt;
            int startx = 0;
            int starty = 0;
            int sizex = matrix[0].Length - startx*2;
            int sizey = matrix.Length - starty*2;
            SpiralOrder(lt, matrix, startx, starty);
            return lt;
        }
        public static void SpiralOrder(IList<int> lt, int[][] matrix, int startx, int starty) {
            Console.WriteLine("start:" + startx + "," + starty);
            if((startx > matrix[0].Length - 1) || (starty > matrix.Length - 1)) return;
            int sizex = matrix[0].Length - startx*2;
            int sizey = matrix.Length - starty*2;

            Console.WriteLine("size:" + sizex + "," + sizey);

            if(sizex <= 0 || sizey <= 0) {
                return;
            }
            if(sizex == 1 && sizey == 1) {
                lt.Add(matrix[startx][starty]);
                displayIntList(lt);
                return;
            }
            for(int i = startx; i < matrix[0].Length - startx; i++){
                lt.Add(matrix[startx][i]);
            }
            for(int i = starty + 1; i < matrix.Length - starty; i++){
                lt.Add(matrix[i][matrix[0].Length - startx -1]);
            }
            if(sizey > 1){
                for(int i = matrix[0].Length-startx-2; i >= startx; i--){
                    lt.Add(matrix[matrix.Length - starty-1][i]);
                }
            }
            if(sizex > 1){
                for(int i = matrix.Length - starty-2; i > starty; i--){
                    lt.Add(matrix[i][startx]);
                }
            }
            
            displayIntList(lt);
            SpiralOrder(lt, matrix, ++startx, ++starty);
        }
    }
}