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
    }
}
