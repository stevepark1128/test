using System;
using System.Text;
using System.Collections.Generic;
namespace leetcode
{
    public partial class Program{
        public string SimplifyPath(string path) {
            var stack= new Stack<string>();
            var paths = path.Split('/');
            foreach(var item in paths){
                if(item == ".."){
                    if(stack.Count > 0) stack.Pop();
                }else if(item == "."){

                } else if(!string.IsNullOrWhiteSpace(item)) {
                    stack.Push(item);
                }
            }
            string sb = "/";
            if(stack.Count > 0){
                sb = sb + stack.Pop();
                while(stack.Count > 0){
                    sb = "/" + stack.Pop() + sb;
                };
            }
            return sb;
        }
    }
}