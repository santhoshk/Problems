using System;
using System.Collections.Generic;
using System.Text;

namespace Algs {
    static class RotateMatrix {
        public static void Rotate90(int[,] arr) {
            int start = 0;
            int end = arr.GetLength(0)-1;

            while(start < end) {
                for(int i = 0; i <= end - start - 1; i++) {
                    int temp = arr[start, start+i];
                    arr[start, start+i] = arr[end - i, start];
                    arr[end - i, start] = arr[end, end - i];
                    arr[end, end - i] = arr[start + i, end];
                    arr[start + i, end] = temp;
                }
                start++; end--;
            }
        }
    }
}
