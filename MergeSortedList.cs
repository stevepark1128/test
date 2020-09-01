using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace leetcode
{
    public partial class Program{
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            ListNode rt = new ListNode();
            ListNode temp = new ListNode();
            rt = temp;
            if(l1 == null && l2 == null) return null;
            if(l1 != null && l2 == null) return l1;
            if(l1 == null && l2 != null) return l2;
            do{
                if(l1.val <= l2.val){
                    temp.val = l1.val;         
                    l1 = l1.next;
                    if (l1 == null){
                        temp.next = l2;
                        break;
                    }
                }
                else{
                    temp.val = l2.val;
                    l2 = l2.next;
                    if (l2 == null){
                        temp.next = l1;
                        break;
                    }
                }
                temp.next = new ListNode();
                temp = temp.next;
            } while(l1 != null || l2 != null);
                
            return rt;
        }
    }
}
