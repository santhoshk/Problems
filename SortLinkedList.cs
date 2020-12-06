using System;
using System.Collections.Generic;
using System.Text;

namespace AlgsSortLinkedList {
    public class Node {
        public int Value;
        public Node Next;
    }
    public static class SortLinkedList {

        public static Tuple<Node, Node, Node, Node> Split(Node root) {
            int len = 0;
            Node n = root;
            while(n != null) {
                len++; n = n.Next;
            }

            Node head1, tail1, head2, tail2;
            head1 = root;
            int i = 0;
            n = root;
            while (i++ < len / 2) {
                n = n.Next;
            }
            return null;
        }
        public static Tuple<Node, Node> Merge(Node l1, Node l2) {
            Node head = new Node();
            Node curr = head;

            while (l1 != null && l2 != null) {
                if (l1.Value <= l2.Value) {
                    curr.Next = l1;
                    l1 = l1.Next;
                } else {
                    curr.Next = l2;
                    l2 = l2.Next;
                }
                curr = curr.Next;
            }

            if (l1 == null) {
                while (l2 != null) {
                    curr.Next = l2;
                    curr = curr.Next;
                    l2 = l2.Next;
                }
            }
            if (l2 == null) {
                while (l1 != null) {
                    curr.Next = l2;
                    curr = curr.Next;
                    l1 = l1.Next;
                }
            }
            return new Tuple<Node, Node>(head.Next, curr);
        }
    }
}
