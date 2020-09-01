using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static int[][] Merge(int[][] intervals) {
            var size = intervals.Length;
            if(size <= 1) {
                return intervals;
            }
            int i = 0;
            int j = i+1;
            do{
                if(IsIntersact(intervals[i], intervals[j])){
                    intervals[i] = MergeInterSact(intervals[i], intervals[j]);
                    intervals = intervals.Where((source, index) => index != j).ToArray();
                    j=i+1;
                }else{
                    j++;
                    if(j > intervals.Length - 1){
                        i++;
                        j=i+1;
                    }
                }
            
            }while(i < intervals.Length-1);
            
            return intervals;
        }
        // public static int[][] Merge(int[][] intervals) {
        //     var rt = new List<int[]>();
        //     var size = intervals.Length;
        //     if(size == 1) {
        //          rt.Add(intervals[0]);
        //     }
        //     if(size == 2) {
        //         if(IsIntersact(intervals[0], intervals[1])){
        //              rt.Add(MergeInterSact(intervals[0], intervals[1]));
        //         }
        //         else{
        //             rt.Add(intervals[0]);
        //             rt.Add(intervals[1]);
        //         }
        //     }
        //     if(size > 2){
        //         var int1 = intervals.Where((source, index) => index <= (size / 2)).ToArray();
        //         var int2 = intervals.Where((source, index) => index > (size / 2)).ToArray();
        //         Merge(rt, int1);
        //         Merge(rt, int2);
        //         if(rt.Count == 2){
        //             var rt2 = new List<int[]>();
        //             if(IsIntersact(rt[0], rt[1])){
                        
        //              rt2.Add(MergeInterSact(rt[0], rt[1]));
        //             }
        //             else{
        //                 rt2.Add(rt[0]);
        //                 rt2.Add(rt[1]);
        //             }
        //             rt = rt2;
        //         }
        //     }
        //     return rt.ToArray();
        // }

        public static void Merge(List<int[]> rt,int[][] intervals) {
            var size = intervals.Length;
            if(size == 1) {
                rt.Add(intervals[0]);
            }
            if(size == 2) {
                if(IsIntersact(intervals[0], intervals[1])){
                    rt.Add(MergeInterSact(intervals[0], intervals[1]));
                }
                else{
                    rt.Add(intervals[0]);
                    rt.Add(intervals[1]);
                }
            }
            if(size > 2){
                var int1 = intervals.Where((source, index) => index <= (size / 2)).ToArray();
                var int2 = intervals.Where((source, index) => index > (size / 2)).ToArray();
                Merge(rt, int1);
                Merge(rt, int2);
            }
        }

        public static int[] MergeInterSact(int[] a, int[] b){
            int[] rt = new int[2];
            if(b[0] <= a[0] && b[1] >= a[1]){
                Console.WriteLine("1");
                return b;
            } 
            if(a[0] <= b[0] && a[1] >= b[1]) {
                Console.WriteLine("2");
                return a;
            }
            if(a[1] >= b[0] && a[0] < b[0]){
                Console.WriteLine("3");
                rt[0] = a[0];
                rt[1] = b[1];
                return rt;
            } 
            if(b[1] >= a[0] && b[0] < a[0]){
                Console.WriteLine("4");
                rt[0] = b[0];
                rt[1] = a[1];
                return rt;
            } 
            return rt;
        }
        
        public static bool IsIntersact(int[] a, int[] b){
            if(a[1] < b[0] && a[0] < b[1]) return false;
            if(a[0] > b[1] && a[1] > b[0]) return false;
            return true;
        }
    }
}
