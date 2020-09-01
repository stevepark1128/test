using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static IList<IList<int>> Combine(int n, int k) {
            IList<IList<int>> rt = new List<IList<int>>();
            IList<int> arr = new List<int>();
            IList<int> cb = new List<int>();
            for(int i=0;i<n;i++){
                arr.Add(i+1);
            }
            //displayIntList(arr);
            GetCombo(ref rt, arr, cb, k);
            return rt;
        }

        public static void GetCombo(ref IList<IList<int>> rt, IList<int> arr,IList<int> cb, int k){
            for(int i=0;i<arr.Count;i++){
                var ct = cb.ToList();
                ct.Add(arr[i]);
                if(ct.Count == k) {
                    var lt = ct.OrderBy((x)=>x).ToList();
                    if(!IsContained(rt, lt)){
                        rt.Add(lt);
                    }
                } else {
                        //displayIntList(ct);
                    var temp = arr.Where((source, index) => source != arr[i]).ToList();
                    GetCombo(ref rt, temp, ct, k);
                } 
                
            }
        }


        // public static void GetCombo(ref IList<IList<int>> rt, IList<int> arr,IList<int> cb, int k){
        //     if(k == 0) {
        //         var lt = cb.ToList();
        //         if(!IsSortedContained(rt, lt)){
        //             rt.Add(lt);
        //         }
        //     } else {
        //         --k;
        //         for(int i=0;i<arr.Count;i++){
        //             var ct = cb.ToList();
        //             ct.Add(arr[i]);
        //             //displayIntList(ct);
        //             var temp = arr.Where((source, index) => source != arr[i]).ToList();
        //             GetCombo(ref rt, temp, ct, k);
        //         }
        //     }
        // }

    }
}