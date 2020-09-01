using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static IList<IList<int>> CombinationSum(int[] candidates, int target) {
            IList<IList<int>> rt = new List<IList<int>>();
            GenAllCombo(rt, candidates, target, new List<int>());
            displayIntListList(rt);
            return rt;
        }
        
        public static void GenAllCombo(IList<IList<int>> rt, int[] candidates, int target, IList<int> li){
            for(int i=0; i<candidates.Length; i++){
                var temp = new List<int>();
                for(int j=0; j<(target /candidates[i]);j++){
                    temp.AddRange(li);
                    temp.Add(candidates[i]);
                    //displayIntList(temp);
                    if(temp.Sum() < target) {
                        //var arr = candidates.Where((source, index) => index != i).ToArray();
                        GenAllCombo(rt, candidates, target, temp);
                    } else if(temp.Sum() == target) {
                        temp.Sort();
                        if(!IsContained(rt, temp)){
                            rt.Add(temp);
                        }
                        //displayIntListList(rt);
                        temp = new List<int>();
                    } else {
                        temp = new List<int>();
                    }
                    
                }
            }
        }

    }
}