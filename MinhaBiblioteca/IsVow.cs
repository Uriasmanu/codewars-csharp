using System;
using System.Collections.Generic;

namespace MinhaBiblioteca
{
    public class Kata
    {
        public static object[] IsVow(object[] arr)
        {
            var vowelMap = new Dictionary<int, string>
        {
            { 'a', "a" },
            { 'e', "e" },
            { 'i', "i" },
            { 'o', "o" },
            { 'u', "u" }
        };

            object[] result = new object[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int num = Convert.ToInt32(arr[i]);

                if (vowelMap.ContainsKey(num))
                {
                    result[i] = vowelMap[num];
                }
                else
                {
                    result[i] = arr[i];
                }
            }

            return result;
        }
    }
}