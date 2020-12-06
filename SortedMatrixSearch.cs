using System;
using System.Collections.Generic;
using System.Text;

namespace AlgsSortedMatrixSearch {
    /*
     * Sorted Matrix Search: Given an M x N matrix in which each row and each column is sorted in
    ascending order, write a method to find an element
     * */
    public class SortedMatrixSearch {

        public static Tuple<int, int> Find(int[,] arr, int elt) {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            int r = 0;
            int c = cols - 1;
            while (r < rows && r >= 0 && c < cols && c >= 0) {
                if (arr[r, c] == elt) return new Tuple<int, int>(r, c);

                if (arr[r, c] > elt) c--;
                else r++;
            }

            return new Tuple<int, int>(-1, -1);
        }

        public static Tuple<int, int> FindBinary(int[,] arr, int elt) {
            int rows = arr.GetLength(0)-1;
            int cols = arr.GetLength(1)-1;

            return FindBinary(arr, 0, 0, rows - 1, cols - 1, elt);
        }

        public static Tuple<int, int> FindBinary(int[,] arr, int topRow, int topCol, int bottomRow, int bottomCol, int elt) {

            if (topRow >= bottomRow || topRow < 0 || topRow > arr.GetLength(1)-1 || bottomRow < 0 || bottomRow > arr.GetLength(1)-1
                || topCol >= bottomCol || topCol < 0 || topCol > arr.GetLength(0) - 1 || bottomCol < 0 || bottomCol > arr.GetLength(0) - 1)
                return new Tuple<int, int>(-1, -1);

            int midRow = (topRow + bottomRow) / 2;
            int midCol = (topCol + bottomCol) / 2;

            if (arr[midRow, midCol] == elt) return new Tuple<int, int>(midRow, midCol);

            Tuple<int, int> find;
            if (elt < arr[midRow, midCol]) {
                find = FindBinary(arr, topRow, topCol, midRow, midCol, elt);
                if (find.Item1 != -1) return find;
            } else if (midRow+1 <= bottomRow && midCol+1 <= bottomCol && elt >= arr[midRow+1, midCol+1]){
                find = FindBinary(arr, midRow+1, midCol+1, bottomRow, bottomCol, elt);
                if (find.Item1 != -1) return find;
            }

            find = FindBinary(arr, topRow, midCol + 1, midRow, bottomCol, elt);
            if (find.Item1 != -1) return find;

            find = FindBinary(arr, midRow+1, topCol, bottomRow, midCol, elt);
            if (find.Item1 != -1) return find;

            return new Tuple<int, int>(-1, -1);
        }
    }
}
