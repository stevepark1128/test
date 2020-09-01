using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            ListNode prev = new ListNode();
            ListNode cur = head;
            int count = 1;
            while(cur.next != null){
                cur = cur.next;
                count++;
            }
            int i = 1;
            int del = count - n;
            if(count == 1 && n == 1) return null;
            if(del < i) return head.next;
            cur = head;
            while(cur.next != null){
                prev = cur;
                cur = cur.next;
                if(i == del){
                    prev.next = cur.next;
                }
                i++;
            }
            return head;
        } 
    }
}