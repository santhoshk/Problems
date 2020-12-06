using System;
using System.Collections.Generic;
using System.Text;

namespace AlgsSortedSearchNoSize {
    /*
     You are given an array-like data structure Listy which lacks a size
    method. It does, however, have an elementAt ( i) method that returns the element at index i in
    0( 1) time. If i is beyond the bounds of the data structure, it returns -1. (For this reason, the data
    structure only supports positive integers.) Given a Listy which contains sorted, positive integers,
    find the index at which an element x occurs. If x occurs multiple times, you may return any index
     */

    public class Listy {
        // Returns the element at index. If index is beyond bounds, returns -1.
        public int ElementAt(int index) { return 0; }
    }

    public class SortedSearchNoSize {
        public static int FindIndex(Listy listy, int x) {
            int left = 0;
            int right = 1;
            while(listy.ElementAt(right) != -1) {
                right = right * 2;
            }
            return FindIndex(listy, left, right, x);
        }

        public static int FindIndex(Listy listy, int left, int right, int x) {
            if (left > right) return -1;
            int mid = (left + right) / 2;
            if (listy.ElementAt(mid) == x) return mid;
            if (listy.ElementAt(mid) == -1 || listy.ElementAt(mid) > x)
                return FindIndex(listy, left, mid - 1, x);
            return FindIndex(listy, mid + 1, right, x);
        }

        public static int FindIndexIterative(Listy listy, int left, int right, int x) {
            while(left <= right) {
                int mid = (left + right) / 2;
                if (listy.ElementAt(mid) == x) return mid;
                if (listy.ElementAt(mid) == -1 || listy.ElementAt(mid) > x) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
