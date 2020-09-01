using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static ListNode RotateRight(ListNode head, long k) {
            var total = totalCount(head);
            if(total == 0) return head;
            if(total == 1) return head;
            if(total < k){
            k = k%total; 
            }
            Rotate(ref head, total, k , 1);
            return head;
            
        }
        public static void Rotate(ref ListNode head, int total, long k, int count){
            if(count <= k){
                var cur = head;
                
                ListNode found = null;
                for(int i=1;i<=(total-1);i++){
                    //Console.WriteLine("-----"+cur.val);
                    if(i == (total-1)){
                        found = cur.next;
                        //Console.WriteLine(found.val);
                        cur.next = null;
                    }
                    else {
                        cur=cur.next;
                    }
                }
                //Console.WriteLine("========="+found.val);
                var second = found;
                second.next = head;
                head = found;
                //displayListNode(head);
                //Console.WriteLine("+++++++++++++"+count);
                Rotate(ref head, total, k, ++count);
            } 
        }
        
        public static int totalCount(ListNode head){
            if(head == null) return 0;
            var cur = head;
            int count=0;
            do{
                cur = cur.next;
                count++;
            }while(cur != null);
            
            return count;
        }
    }
}