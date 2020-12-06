using System;
using System.Collections.Generic;
using System.Text;

namespace AlgsSparseSearch {
    /*
    Sparse Search: Given a sorted array of strings that is interspersed with empty strings, write a
    method to find the location of a given string.
    EXAMPLE
    Input: ball, {"at","","", "", "","ball", "", "", "", "","car", ""}
    Output: 4
    */
    public class SparseSearch {
        public static int FindIndex(string[] arr, string elt) {
            if (arr == null || arr.Length == 0) return -1;
            return FindIndex(arr, 0, arr.Length - 1, elt);
        }

        public static int FindIndex(string[] arr, int left, int right, string elt) {
            if (left > right) return -1;
            int mid = (left + right) / 2;

            if (arr[mid] == elt) return mid;

            int i = mid+1;
            while(i<=right && string.Compare(arr[i], "") == 0) i++;
            if (i > right || string.Compare(arr[i], elt) > 0) return FindIndex(arr, left, mid - 1, elt);
            return FindIndex(arr, i, right, elt);
        }
    }
}
