using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms2021
{
    public static class Urlifier
    {
        // Write a method to replace all spaces in a string with `%20`
        // There are enough spaces at the end of the string to hold them

        public static string UrlifyWithHelperMethod(string original)
        {
            return original.Replace(" ", "%20");
        }

        public static string UrlifyCustom(string original)
        {
            var space = "%20";
            var splitStrings = original.Split(" ");
            for (int i = 0; i < splitStrings.Length - 1; i++)
            {
                splitStrings[i] = splitStrings[i] + space;
            }
            var result = string.Join("", splitStrings);

            return result;
        }

        public static string UrlifyWithStringBuilder(string original)
        {
            var charsToAdd = "%20";
            StringBuilder builder = new StringBuilder();
            var splitStrings = original.Split(" ");
            foreach(var str in splitStrings)
            {
                builder.Append(str + charsToAdd);
            }
            return builder.Remove(builder.Length - charsToAdd.Length, charsToAdd.Length).ToString();
        }

        public static string UrlifyWithCharArrayOnly(string original)
        {
            // Here we assume we are given a string with enough room at the end
            var charArray = original.ToCharArray();
            var charsToInsert = new[] { '%', '2', '0' };
            for (int i = 0; i < charArray.Length; i++)
            {
                if(charArray[i] == ' ')
                {
                    for(int j = charArray.Length - 3; j > i; j--)
                    {
                        charArray[j + 2] = charArray[j];
                    }
                    charArray[i] = charsToInsert[0];
                    charArray[i + 1] = charsToInsert[1];
                    charArray[i + 2] = charsToInsert[2];
                }
            }
            return string.Join("", charArray);
        }
    }
}
