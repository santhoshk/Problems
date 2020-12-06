using System;
using System.Collections.Generic;
using System.Text;

namespace Algs {
    public class QSort {


        public static void Sort(int[] arr) {
            if (arr == null || arr.Length <= 1) return;
            Sort(arr, 0, arr.Length - 1);
        }

        public static void Sort(int[] arr, int left, int right) {
            if (left >= right) return;
            int idx = Partition(arr, left, right);
            Sort(arr, left, idx - 1);
            Sort(arr, idx+1, right);
        }

        public static int Partition(int[] arr, int left, int right) {
            int pivot = left;
            for(int i=left+1; i<=right; i++) {
                 if(arr[i] < arr[pivot] && i > pivot + 1) {
                    Swap(arr, i, pivot);
                    pivot++;
                    Swap(arr, i, pivot);
                } else if (arr[i] < arr[pivot]) {
                    Swap(arr, i, pivot);
                    pivot++;
                }
            }
            return pivot;
        }

        public static void Swap(int[] arr, int i, int j) {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
