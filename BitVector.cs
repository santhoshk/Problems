using System;
using System.Collections.Generic;
using System.Text;

namespace AlgsBitVector {
    public class BitVector {
        byte[] items;
        public BitVector(int size) {
            int bytesNeeded = ((size-1) >> 3) + 1;
            items = new byte[bytesNeeded];
        }

        public void Set(int value) {
            int byteNum = ((value-1) >> 3) + 1;
            int offsetInByte = value % 8;
            if(byteNum < items.Length) {
                items[byteNum] |= (byte)(1 << offsetInByte); 
            }
        }

        public bool IsSet(int value) {
            int byteNum = ((value - 1) >> 3) + 1;
            int offsetInByte = value % 8;
            if (byteNum < items.Length) {
                return (items[byteNum] & (byte)(1 << offsetInByte)) != 0;
            } else return false;
        }
    }
}
