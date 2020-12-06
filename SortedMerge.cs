using System;
using System.Collections.Generic;
using System.Text;

namespace AlgsSortedMerge {
    /*
     Sorted Merge: You are given two sorted arrays, A and B, where A has a large enough buffer at the
     end to hold B. Write a method to merge B into A in sorted order
    */
    public class SortedMerge {
        public static void Merge(int[] A, int[] B, int lastA, int lastB) {
            int indexMerged = lastA + lastB + 1;

            int indexA = lastA;
            int indexB = lastB;
            while (indexA >= 0 && indexB >= 0) {
                if (A[indexA] >= B[indexB]) {
                    A[indexMerged] = A[indexA];
                    indexA--;
                } else {
                    A[indexMerged] = B[indexB];
                    indexB--;
                }
            }

            while(indexB >= 0) {
                A[indexMerged] = B[indexB];
                indexB--;
            }
        }
    }
}
