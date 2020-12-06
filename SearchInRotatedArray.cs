using System;
using System.Collections.Generic;
using System.Text;

namespace AlgsSearchInRotatedArray {
    public class SearchInRotatedArray {
        public static int Search(int[] arr, int elt) {
            if (arr == null || arr.Length == 0) return -1;
            return Search(arr, 0, arr.Length-1, elt);
        }

        public static int Search(int[] arr, int left, int right, int elt) {
            if (left > right) return -1;

            int mid = left + (right - left) / 2;
            if (arr[mid] == elt) return mid;

            // decide which way to probe further
            if(mid+1 <= right && arr[mid+1] <= arr[right]) {
                if (arr[mid + 1] <= elt && elt <= arr[right])
                    return Search(arr, mid + 1, right, elt);
                else
                    return Search(arr, left, mid - 1, elt);
            } else {
                if (left <= mid-1 && arr[left] <= elt && elt <= arr[mid-1])
                    return Search(arr, left, mid-1, elt);
                else
                    return Search(arr, mid+1, right, elt);
            }
        }
    }
}
