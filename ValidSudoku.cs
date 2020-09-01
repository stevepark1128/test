using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static bool IsValidSudoku(char[][] board) {
            for(int i=0;i<board.Length; i++){
                for(int j=0;j<board[i].Length; j++){
                    var arr = board[i].Where((source, index) => index != j).ToArray();
                    if(board[i][j] != '.' && arr.Contains(board[i][j])){
                        return false;
                    }
                }
            }
            Console.WriteLine("vertical check");
            for(int i=0;i<board.Length; i++){
                List<char> v = new List<char>();
                for(int j=0;j<board[i].Length; j++){
                    if(board[j][i] != '.' && v.Contains(board[j][i])){
                        return false;
                    }
                    v.Add(board[j][i]);
                    
                }
            }
            for(int k=0;k<board.Length; k=k+3){
                for(int i=0;i<board.Length; i=i+3){
                    List<char> v = new List<char>();
                    for(int j=k;j<k+3; j++){
                        if(board[j][i] != '.' && v.Contains(board[j][i])){
                            return false;
                        }
                        v.Add(board[j][i]);
                        if(board[j][i+1] != '.' && v.Contains(board[j][i+1])){
                            return false;
                        }
                        v.Add(board[j][i+1]);
                        if(board[j][i+2] != '.' && v.Contains(board[j][i+2])){
                            return false;
                        }
                        v.Add(board[j][i+2]);
                    }
                }
            }
            return true;
        }
    }
}