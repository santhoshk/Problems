using System;
using System.Collections.Generic;
using System.Text;

namespace Algs {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }
    /*add 2 numbers that are represented by a linked list*/
    public class AddTowNumbers {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

            ListNode res = new ListNode();
            int carry = 0;

            while (l1 != null || l2 != null) {
                int d1 = l1?.val == null ? 0 : l1.val;
                int d2 = l2?.val == null ? 0 : l2.val;
                int sum = d1 + d2 + carry;


                res.next = new ListNode();
                res = res.next;
                res.val = sum % 10;
                carry = sum / 10;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return res.next;

        }
    }
}
