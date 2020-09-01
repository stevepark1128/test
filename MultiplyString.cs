using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static string Multiply(string num1, string num2) {
            if(num1 =="0" || num2=="0") return "0";
            StringBuilder rt = new StringBuilder("");
            for(int i=0;i<num1.Length;i++){
                StringBuilder sb = new StringBuilder("");
                var tc = 0;
                for(int j=num2.Length-1;j >= 0;j--){
                    var mt = int.Parse(num1[i].ToString()) * int.Parse(num2[j].ToString()) + tc;
                    var ms = mt.ToString();
                    Console.WriteLine(num1[i] +"X"+ num2[j]);
                    tc=0;
                    var temp = sb.ToString();
                    Console.WriteLine(ms);
                    sb = new StringBuilder("");
                    if(ms.Length == 2){
                        tc = int.Parse(ms.ToString()[0].ToString()); 
                        if(j==0){
                            sb.Append(tc.ToString());
                        }
                    } 
                    sb.Append(ms[ms.Length-1]);
                    sb.Append(temp);
                    
                    Console.WriteLine("1:"+sb);
                }
                Console.WriteLine("="+rt);
                Console.WriteLine(":"+sb);
                var ic = 0;
                for(int k=sb.Length-1; k >= 0;k--){
                    if(rt.Length == 0){
                        rt = sb;
                        break;
                    }
                    if(k == sb.Length-1){
                        rt.Append(sb[k].ToString());
                    } else {    
                        var temp = int.Parse(rt[rt.Length - 1 - (sb.Length -1 - k)].ToString()) + int.Parse(sb[k].ToString()) + ic;
                        Console.WriteLine(rt[rt.Length - 1 - (sb.Length -1 - k)]+"+"+sb[k] +"+"+ic );
                        if(temp.ToString().Length == 2){
                            ic = int.Parse(temp.ToString()[0].ToString());
                            rt[rt.Length - 1 - (sb.Length -1 - k)] = temp.ToString()[1];
                            if(k==0 && rt.Length == sb.Length){
                                var tp = rt.ToString();
                                rt = new StringBuilder(ic.ToString());
                                rt.Append(tp);
                                ic=0;
                            }
                        } else {
                            ic = 0;
                            rt[rt.Length - 1 - (sb.Length -1 - k)] = temp.ToString()[0];
                        }
                        Console.WriteLine("=="+rt);
                        Console.WriteLine("::"+sb);
                        if(k==0 && rt.Length > sb.Length){
                            var top = int.Parse(rt[rt.Length - 1 - (sb.Length)].ToString()) + ic;
                            Console.WriteLine(rt[rt.Length - 1 - (sb.Length)].ToString());
                            Console.WriteLine(ic);
                            
                            if(top.ToString().Length == 2){
                                rt[rt.Length - 1 - (sb.Length)] = top.ToString()[1];
                                Console.WriteLine(rt.Length - 1 - (sb.Length + 1));
                                ic = int.Parse(top.ToString()[0].ToString());
                                if(rt.Length - 1 - (sb.Length + 1) < 0 && ic > 0){
                                    var tp2 = rt.ToString();
                                    Console.WriteLine(tp2 +":"+ ic);
                                    rt = new StringBuilder(ic.ToString());
                                    rt.Append(tp2);
                                    ic=0;
                                }
                                for(int l= rt.Length - 1 - (sb.Length + 1); l >= 0; l--){
                                    var tp = int.Parse(rt[l].ToString()) + ic;
                                    Console.WriteLine(rt[l].ToString());
                                    if(tp.ToString().Length == 2){
                                        ic = int.Parse(tp.ToString()[0].ToString());
                                        rt[l] = tp.ToString()[1];
                                        if(l == 0 && ic > 0){
                                            var tp2 = rt.ToString();
                                            Console.WriteLine(tp2 +":"+ ic);
                                            rt = new StringBuilder(ic.ToString());
                                            rt.Append(tp2);
                                            ic=0;
                                        }
                                    } else {
                                        rt[l] = tp.ToString()[0];
                                        break;
                                        ic = 0;
                                    }
                                }
                                
                                //var tp = rt.ToString();
                                //rt = new StringBuilder(top.ToString()[0].ToString());
                                //rt.Append(tp);

                            } else {
                                rt[rt.Length - 1 - (sb.Length)] = top.ToString()[0];
                            }
                        }
                    }
                }
            }
            return rt.ToString();
        }
    }
}