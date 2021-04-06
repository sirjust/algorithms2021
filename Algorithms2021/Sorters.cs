using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms2021
{
    public static class Sorters
    {
        public static void MergeSort(int[] array, int start, int end)
        {
            if (end - start < 2) return;

            // partition the sections
            int mid = (start + end) / 2;
            MergeSort(array, start, mid);
            MergeSort(array, mid, end);

            // merge them
            Merge(array, start, mid, end);
        }

        public static void Merge(int[] array, int start, int mid, int end)
        {
            if (array[mid - 1] <= array[mid]) return;

            int i = start;
            int j = mid;
            int tempIndex = 0;

            int[] temp = new int[end - start];
            while (i < mid && j < end)
            {
                // the tempIndex is incremented, and whichever value it takes
                temp[tempIndex++] = array[i] <= array[j] ? array[i++] : array[j++];

            }
            Array.Copy(array, i, array, start + tempIndex, mid - i);
            Array.Copy(temp, 0, array, start, tempIndex);
        }
    }
}
