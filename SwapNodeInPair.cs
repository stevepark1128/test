using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static ListNode SwapPairs(ListNode head) {
            if(head == null || head.next==null) return head;
            var next = head.next;
            ListNode rt =  next;
            head.next = next.next;
            next.next = head;
            if(head.next != null)
            head.next = Swap(head.next, head.next.next);
            return rt;
        }

        public static ListNode Swap(ListNode head, ListNode next){
            if(head == null || head.next==null) return head;
            head.next = next.next;
            next.next = head;
            if(head.next != null)
            head.next = Swap(head.next, head.next.next);
            return next;
        }
    }
}