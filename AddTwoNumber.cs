using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode result = new ListNode();
            ListNode current = result;
            ListNode current1 = l1;
            ListNode current2 = l2;
            int remainder = (current1.val + current2.val) % 10;
            int denominator = (current1.val + current2.val) / 10;
            current.val = remainder;
            
            while(current1.next != null || current2.next != null) {
                if(current1.next != null && current2.next != null){
                    current.next = new ListNode();
                    current = current.next;
                    current1 = current1.next;
                    current2 = current2.next;
                    current.val = (denominator + current1.val + current2.val) % 10;
                    denominator = (denominator + current1.val + current2.val) / 10;
                } 
                if(current1.next == null && current2.next != null){
                    current.next = new ListNode();
                    current = current.next;
                    current2 = current2.next;
                    current.val = (denominator + current2.val) % 10;
                    denominator = (denominator + current2.val) / 10;
                } 
                if(current1.next != null && current2.next == null){
                    current.next = new ListNode();
                    current = current.next;
                    current1 = current1.next;
                    current.val = (denominator + current1.val) % 10;
                    denominator = (denominator + current1.val) / 10;
                } 
                
            } 
            if (denominator > 0) {
                current.next = new ListNode();
                current = current.next;
                current.val = denominator;
            }
            
            return result;
        }
    }
}
