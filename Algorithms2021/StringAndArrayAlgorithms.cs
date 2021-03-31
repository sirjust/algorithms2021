using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms2021
{
    public static class StringAndArrayAlgorithms
    {
        public static bool CheckPermutationUsingLinq(string original, string input)
        {
            var sortedOriginal = string.Concat(original.OrderBy(c => c));
            var sortedInput = string.Concat(input.OrderBy(c => c));
            return sortedOriginal == sortedInput;
        }

        public static bool CheckPermutation(string original, string input)
        {
            if (original.Length != input.Length) return false;
            return Sort(original.ToCharArray()).SequenceEqual(Sort(input.ToCharArray()));
        }

        private static char[] Sort(char[] array)
        {
            for(int lastUnsortedIndex = array.Length -1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            {
                int largest = 0;
                for(int i = 1; i <= lastUnsortedIndex; i++)
                {
                    if(array[i] > array[largest])
                    {
                        largest = i;
                    }
                }
                Swap(array, largest, lastUnsortedIndex);
            }
            return array;
        }

        private static char[] Swap(char[] array, int i, int j)
        {
            if (i == j) return array;
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            return array;
        }
    }
}
