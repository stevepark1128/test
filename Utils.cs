using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static bool IsContained(IList<int[]> rt, int[] li){   
            bool contained = false;  
            bool any = false;  
            foreach(var item in rt){
                if(item.Length == li.Length){
                    for(int i=0; i< item.Length;i++){
                        if(item[i] == li[i]){
                            contained = true;
                        } 
                        else{
                            contained = false;
                            break;
                        }
                    }
                    if(contained){
                        any = true;
                    }
                }
            }
            return any;
        }
        public static bool IsContained(IList<IList<int>> rt, IList<int> li){   
            bool contained = false;  
            bool any = false;  
            foreach(var item in rt){
                if(item.Count == li.Count){
                    for(int i=0; i< item.Count;i++){
                        if(item[i] == li[i]){
                            contained = true;
                        } 
                        else{
                            contained = false;
                            break;
                        }
                    }
                    if(item.Count == 0){
                        contained = true;
                    }
                    if(contained){
                        any = true;
                    }
                }
            }
            return any;
        }
        private static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static void displayStrListList(IList<IList<string>> llst){
            var ar = llst.ToArray();
            for(int i=0; i < ar.Length; i++){
                var arr = ar[i].ToArray();
                for(int k=0; k < arr.Length; k++){
                    Console.Write(arr[k]+",");
                }
                Console.WriteLine("=========");
            }
        }

        public static void displayIntArrArr(int[][] llst){
            var ar = llst.ToArray();
            for(int i=0; i < ar.Length; i++){
                var arr = ar[i].ToArray();
                for(int k=0; k < arr.Length; k++){
                    Console.Write(arr[k]+",");
                }
                Console.WriteLine("=========");
            }
        }
        public static void displayIntListList(IList<IList<int>> llst){
            var ar = llst.ToArray();
            for(int i=0; i < ar.Length; i++){
                var arr = ar[i].ToArray();
                for(int k=0; k < arr.Length; k++){
                    Console.Write(arr[k]+",");
                }
                Console.WriteLine("=========");
            }
        }
        public static void displayIntArrListList(IList<IList<int[]>> llst){
            var ar = llst.ToArray();
            for(int j=0; j < ar.Length; j++){
                for(int i=0; i < ar[j].Count; i++){
                    var arr = ar[j][i].ToArray();
                    for(int k=0; k < arr.Length; k++){
                        Console.Write(arr[k]+",");
                    }
                    Console.WriteLine("---------");
                }
                Console.WriteLine("=========");
            }
            
        }
        public static void displayIntArrList(IList<int[]> llst){
            var ar = llst.ToArray();
            for(int i=0; i < ar.Length; i++){
                var arr = ar[i].ToArray();
                for(int k=0; k < arr.Length; k++){
                    Console.Write(arr[k]+",");
                }
                Console.WriteLine("=========");
            }
        }
        public static void displayCharList(IList<char> lst){
            var ar = lst.ToArray();
            for(int i=0; i < ar.Length; i++){
                Console.Write(ar[i]+",");
            }
            Console.WriteLine("------------");
        }
        public static void displayStrList(IList<string> lst){
            var ar = lst.ToArray();
            for(int i=0; i < ar.Length; i++){
                Console.Write(ar[i]+",");
            }
            Console.WriteLine("------str list------");
        }

        public static void displayIntList(IList<int> lst){
            var ar = lst.ToArray();
            for(int i=0; i < ar.Length; i++){
                Console.Write(ar[i]+",");
            }
            Console.WriteLine("------int lst------");
        }
        public static void displayArr2(string[][] arr){
            for(int i=0; i<arr.Length;i++){
                for(int j=0; j<arr[i].Length;j++){
                    Console.WriteLine(arr[i][j]);
                } 
                Console.WriteLine("+++++++");
            }
            
        }
        public static void displayArr(string[] arr){
            for(int j=0; j<arr.Length;j++){
                Console.WriteLine(arr[j]);
            } 
            Console.WriteLine("--------");
        }

        public static void displayStrArr(string[] arr){
            for(int j=0; j<arr.Length;j++){
                Console.WriteLine(arr[j]);
            } 
            Console.WriteLine("---str arr-----");
        }

        public static void displayInyArr(int[] arr){
            for(int j=0; j<arr.Length;j++){
                Console.WriteLine(arr[j]);
            } 
            Console.WriteLine("--------");
        }

        public static void displayCharArr(char[] arr){
            for(int j=0; j<arr.Length;j++){
                Console.WriteLine(arr[j]);
            } 
            Console.WriteLine("--------");
        }

        public static void displayListNode(ListNode l1)
        {
            if(l1 != null){
                Console.WriteLine(l1.val);
                displayListNode(l1.next); 
            }
        }
    }
}